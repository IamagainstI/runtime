// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Apple;
using System.Security.Cryptography.X509Certificates;

using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class AppleCrypto
    {
        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509GetRawData(
            SafeSecCertificateHandle cert,
            out SafeCFDataHandle cfDataOut,
            out int pOSStatus);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509GetSubjectSummary(
            SafeSecCertificateHandle cert,
            out SafeCFStringHandle cfSubjectSummaryOut);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509GetPublicKey(SafeSecCertificateHandle cert, out SafeSecKeyRefHandle publicKey);

        internal static X509ContentType X509GetContentType(ReadOnlySpan<byte> data)
            => X509GetContentType(ref MemoryMarshal.GetReference(data), data.Length);

        [LibraryImport(Libraries.AppleCryptoNative, EntryPoint = "AppleCryptoNative_X509GetContentType")]
        private static partial X509ContentType X509GetContentType(ref byte pbData, int cbData);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509CopyCertFromIdentity(
            SafeSecIdentityHandle identity,
            out SafeSecCertificateHandle cert);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509CopyPrivateKeyFromIdentity(
            SafeSecIdentityHandle identity,
            out SafeSecKeyRefHandle key);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509DemuxAndRetainHandle(
            IntPtr handle,
            out SafeSecCertificateHandle certHandle,
            out SafeSecIdentityHandle identityHandle);

        internal static byte[] X509GetRawData(SafeSecCertificateHandle cert)
        {
            int osStatus;
            SafeCFDataHandle data;

            int ret = AppleCryptoNative_X509GetRawData(
                cert,
                out data,
                out osStatus);

            using (data)
            {
                if (ret == 1)
                {
                    return CoreFoundation.CFGetData(data);
                }

                if (ret == 0)
                {
                    throw CreateExceptionForOSStatus(osStatus);
                }

                Debug.Fail($"Unexpected return value {ret}");
                throw new CryptographicException();
            }
        }

        internal static string? X509GetSubjectSummary(SafeSecCertificateHandle cert)
        {
            SafeCFStringHandle subjectSummary;

            int ret = AppleCryptoNative_X509GetSubjectSummary(
                cert,
                out subjectSummary);

            using (subjectSummary)
            {
                if (ret == 1)
                {
                    return CoreFoundation.CFStringToString(subjectSummary);
                }
            }

            if (ret == 0)
            {
                return null;
            }

            Debug.Fail($"Unexpected return value {ret}");
            throw new CryptographicException();
        }

        internal static SafeSecKeyRefHandle X509GetPrivateKeyFromIdentity(SafeSecIdentityHandle identity)
        {
            SafeSecKeyRefHandle key;
            int osStatus = AppleCryptoNative_X509CopyPrivateKeyFromIdentity(identity, out key);

            if (osStatus != 0)
            {
                key.Dispose();
                throw CreateExceptionForOSStatus(osStatus);
            }

            if (key.IsInvalid)
            {
                key.Dispose();
                throw new CryptographicException(SR.Cryptography_OpenInvalidHandle);
            }

            return key;
        }

        internal static SafeSecKeyRefHandle X509GetPublicKey(SafeSecCertificateHandle cert)
        {
            SafeSecKeyRefHandle publicKey;
            int ret = AppleCryptoNative_X509GetPublicKey(cert, out publicKey);

            if (ret == 1)
            {
                return publicKey;
            }

            publicKey.Dispose();

            Debug.Fail($"Unexpected return value {ret}");
            throw new CryptographicException();
        }
    }
}
