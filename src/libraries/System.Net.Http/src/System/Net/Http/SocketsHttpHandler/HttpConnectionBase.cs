// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    internal abstract class HttpConnectionBase : IDisposable, IHttpTrace
    {
        /// <summary>Cached string for the last Date header received on this connection.</summary>
        private string? _lastDateHeaderValue;
        /// <summary>Cached string for the last Server header received on this connection.</summary>
        private string? _lastServerHeaderValue;

        /// <summary>Uses <see cref="HeaderDescriptor.GetHeaderValue"/>, but first special-cases several known headers for which we can use caching.</summary>
        public string GetResponseHeaderValueWithCaching(HeaderDescriptor descriptor, ReadOnlySpan<byte> value, Encoding? valueEncoding)
        {
            return
                descriptor.Equals(KnownHeaders.Date) ? GetOrAddCachedValue(ref _lastDateHeaderValue, descriptor, value, valueEncoding) :
                descriptor.Equals(KnownHeaders.Server) ? GetOrAddCachedValue(ref _lastServerHeaderValue, descriptor, value, valueEncoding) :
                descriptor.GetHeaderValue(value, valueEncoding);

            static string GetOrAddCachedValue([NotNull] ref string? cache, HeaderDescriptor descriptor, ReadOnlySpan<byte> value, Encoding? encoding)
            {
                string? lastValue = cache;
                if (lastValue is null || !Ascii.Equals(value, lastValue))
                {
                    cache = lastValue = descriptor.GetHeaderValue(value, encoding);
                }
                Debug.Assert(cache is not null);
                return lastValue;
            }
        }

        public abstract void Trace(string message, [CallerMemberName] string? memberName = null);

        protected void TraceConnection(Stream stream)
        {
            if (stream is SslStream sslStream)
            {
                Trace(
                    $"{this}. " +
                    $"SslProtocol:{sslStream.SslProtocol}, NegotiatedApplicationProtocol:{sslStream.NegotiatedApplicationProtocol}, " +
                    $"NegotiatedCipherSuite:{sslStream.NegotiatedCipherSuite}, CipherAlgorithm:{sslStream.CipherAlgorithm}, CipherStrength:{sslStream.CipherStrength}, " +
                    $"HashAlgorithm:{sslStream.HashAlgorithm}, HashStrength:{sslStream.HashStrength}, " +
                    $"KeyExchangeAlgorithm:{sslStream.KeyExchangeAlgorithm}, KeyExchangeStrength:{sslStream.KeyExchangeStrength}, " +
                    $"LocalCertificate:{sslStream.LocalCertificate}, RemoteCertificate:{sslStream.RemoteCertificate}");
            }
            else
            {
                Trace($"{this}");
            }
        }

        private readonly long _creationTickCount = Environment.TickCount64;

        public long GetLifetimeTicks(long nowTicks) => nowTicks - _creationTickCount;

        public abstract long GetIdleTicks(long nowTicks);

        /// <summary>Check whether a connection is still usable, or should be scavenged.</summary>
        /// <returns>True if connection can be used.</returns>
        public virtual bool CheckUsabilityOnScavenge() => true;

        internal static bool IsDigit(byte c) => (uint)(c - '0') <= '9' - '0';

        internal static int ParseStatusCode(ReadOnlySpan<byte> value)
        {
            byte status1, status2, status3;
            if (value.Length != 3 ||
                !IsDigit(status1 = value[0]) ||
                !IsDigit(status2 = value[1]) ||
                !IsDigit(status3 = value[2]))
            {
                throw new HttpRequestException(SR.Format(SR.net_http_invalid_response_status_code, System.Text.Encoding.ASCII.GetString(value)));
            }

            return 100 * (status1 - '0') + 10 * (status2 - '0') + (status3 - '0');
        }

        /// <summary>Awaits a task, ignoring any resulting exceptions.</summary>
        internal static void IgnoreExceptions(ValueTask<int> task)
        {
            // Avoid TaskScheduler.UnobservedTaskException firing for any exceptions.
            if (task.IsCompleted)
            {
                if (task.IsFaulted)
                {
                    _ = task.AsTask().Exception;
                }
            }
            else
            {
                task.AsTask().ContinueWith(static t => _ = t.Exception,
                    CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
            }
        }

        /// <summary>Awaits a task, logging any resulting exceptions (which are otherwise ignored).</summary>
        internal void LogExceptions(Task task)
        {
            if (task.IsCompleted)
            {
                if (task.IsFaulted)
                {
                    LogFaulted(this, task);
                }
            }
            else
            {
                task.ContinueWith(static (t, state) => LogFaulted((HttpConnectionBase)state!, t), this,
                    CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
            }

            static void LogFaulted(HttpConnectionBase connection, Task task)
            {
                Debug.Assert(task.IsFaulted);
                Exception? e = task.Exception!.InnerException; // Access Exception even if not tracing, to avoid TaskScheduler.UnobservedTaskException firing
                if (NetEventSource.Log.IsEnabled()) connection.Trace($"Exception from asynchronous processing: {e}");
            }
        }

        public abstract void Dispose();
    }
}
