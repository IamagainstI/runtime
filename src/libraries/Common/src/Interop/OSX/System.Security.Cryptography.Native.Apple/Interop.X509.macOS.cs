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
        private static readonly SafeCreateHandle s_emptyExportString =
            CoreFoundation.CFStringCreateWithCString("");

        private static int AppleCryptoNative_X509ImportCertificate(
            ReadOnlySpan<byte> keyBlob,
            X509ContentType contentType,
            SafeCreateHandle cfPfxPassphrase,
            SafeKeychainHandle tmpKeychain,
            int exportable,
            out SafeSecCertificateHandle pCertOut,
            out SafeSecIdentityHandle pPrivateKeyOut,
            out int pOSStatus)
        {
            return AppleCryptoNative_X509ImportCertificate(
                ref MemoryMarshal.GetReference(keyBlob),
                keyBlob.Length,
                contentType,
                cfPfxPassphrase,
                tmpKeychain,
                exportable,
                out pCertOut,
                out pPrivateKeyOut,
                out pOSStatus);
        }

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509ImportCertificate(
            ref byte pbKeyBlob,
            int cbKeyBlob,
            X509ContentType contentType,
            SafeCreateHandle cfPfxPassphrase,
            SafeKeychainHandle tmpKeychain,
            int exportable,
            out SafeSecCertificateHandle pCertOut,
            out SafeSecIdentityHandle pPrivateKeyOut,
            out int pOSStatus);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509ImportCollection(
            ref byte pbKeyBlob,
            int cbKeyBlob,
            X509ContentType contentType,
            SafeCreateHandle cfPfxPassphrase,
            SafeKeychainHandle tmpKeychain,
            int exportable,
            out SafeCFArrayHandle pCollectionOut,
            out int pOSStatus);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509ExportData(
            SafeCreateHandle data,
            X509ContentType type,
            SafeCreateHandle cfExportPassphrase,
            out SafeCFDataHandle pExportOut,
            out int pOSStatus);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509CopyWithPrivateKey(
            SafeSecCertificateHandle certHandle,
            SafeSecKeyRefHandle privateKeyHandle,
            SafeKeychainHandle targetKeychain,
            out SafeSecIdentityHandle pIdentityHandleOut,
            out int pOSStatus);

        [LibraryImport(Libraries.AppleCryptoNative)]
        private static partial int AppleCryptoNative_X509MoveToKeychain(
            SafeSecCertificateHandle certHandle,
            SafeKeychainHandle targetKeychain,
            SafeSecKeyRefHandle privateKeyHandle,
            out SafeSecIdentityHandle pIdentityHandleOut,
            out int pOSStatus);

        internal static SafeSecCertificateHandle X509ImportCertificate(
            ReadOnlySpan<byte> bytes,
            X509ContentType contentType,
            SafePasswordHandle importPassword,
            SafeKeychainHandle keychain,
            bool exportable,
            out SafeSecIdentityHandle identityHandle)
        {
            SafeCreateHandle? cfPassphrase = null;
            bool releasePassword = false;

            try
            {
                if (!importPassword.IsInvalid)
                {
                    importPassword.DangerousAddRef(ref releasePassword);
                    cfPassphrase = CoreFoundation.CFStringCreateFromSpan(importPassword.DangerousGetSpan());
                }

                return X509ImportCertificate(
                    bytes,
                    contentType,
                    cfPassphrase,
                    keychain,
                    exportable,
                    out identityHandle);
            }
            finally
            {
                if (releasePassword)
                {
                    importPassword.DangerousRelease();
                }

                cfPassphrase?.Dispose();
            }
        }

        private static SafeSecCertificateHandle X509ImportCertificate(
            ReadOnlySpan<byte> bytes,
            X509ContentType contentType,
            SafeCreateHandle? importPassword,
            SafeKeychainHandle keychain,
            bool exportable,
            out SafeSecIdentityHandle identityHandle)
        {
            SafeSecCertificateHandle certHandle;
            int osStatus;

            SafeCreateHandle cfPassphrase = importPassword ?? s_nullExportString;

            int ret = AppleCryptoNative_X509ImportCertificate(
                bytes,
                contentType,
                cfPassphrase,
                keychain,
                exportable ? 1 : 0,
                out certHandle,
                out identityHandle,
                out osStatus);

            SafeTemporaryKeychainHandle.TrackItem(certHandle);
            SafeTemporaryKeychainHandle.TrackItem(identityHandle);

            if (ret == 1)
            {
                return certHandle;
            }

            certHandle.Dispose();
            identityHandle.Dispose();

            const int SeeOSStatus = 0;
            const int ImportReturnedEmpty = -2;
            const int ImportReturnedNull = -3;

            switch (ret)
            {
                case SeeOSStatus:
                    throw CreateExceptionForOSStatus(osStatus);
                case ImportReturnedNull:
                case ImportReturnedEmpty:
                    throw new CryptographicException();
                default:
                    Debug.Fail($"Unexpected return value {ret}");
                    throw new CryptographicException();
            }
        }

        internal static SafeCFArrayHandle X509ImportCollection(
            ReadOnlySpan<byte> bytes,
            X509ContentType contentType,
            SafePasswordHandle importPassword,
            SafeKeychainHandle keychain,
            bool exportable)
        {
            SafeCreateHandle cfPassphrase = s_nullExportString;
            bool releasePassword = false;

            int ret;
            SafeCFArrayHandle collectionHandle;
            int osStatus;

            try
            {
                if (!importPassword.IsInvalid)
                {
                    importPassword.DangerousAddRef(ref releasePassword);
                    IntPtr passwordHandle = importPassword.DangerousGetHandle();

                    if (passwordHandle != IntPtr.Zero)
                    {
                        cfPassphrase = CoreFoundation.CFStringCreateWithCString(passwordHandle);
                    }
                }

                ret = AppleCryptoNative_X509ImportCollection(
                    ref MemoryMarshal.GetReference(bytes),
                    bytes.Length,
                    contentType,
                    cfPassphrase,
                    keychain,
                    exportable ? 1 : 0,
                    out collectionHandle,
                    out osStatus);

                if (ret == 1)
                {
                    return collectionHandle;
                }
            }
            finally
            {
                if (releasePassword)
                {
                    importPassword.DangerousRelease();
                }

                if (cfPassphrase != s_nullExportString)
                {
                    cfPassphrase.Dispose();
                }
            }

            collectionHandle.Dispose();

            const int SeeOSStatus = 0;
            const int ImportReturnedEmpty = -2;
            const int ImportReturnedNull = -3;

            switch (ret)
            {
                case SeeOSStatus:
                    throw CreateExceptionForOSStatus(osStatus);
                case ImportReturnedNull:
                case ImportReturnedEmpty:
                    throw new CryptographicException();
                default:
                    Debug.Fail($"Unexpected return value {ret}");
                    throw new CryptographicException();
            }
        }

        internal static SafeSecIdentityHandle X509CopyWithPrivateKey(
            SafeSecCertificateHandle certHandle,
            SafeSecKeyRefHandle privateKeyHandle,
            SafeKeychainHandle targetKeychain)
        {
            SafeSecIdentityHandle identityHandle;
            int osStatus;

            int result = AppleCryptoNative_X509CopyWithPrivateKey(
                certHandle,
                privateKeyHandle,
                targetKeychain,
                out identityHandle,
                out osStatus);

            SafeTemporaryKeychainHandle.TrackItem(identityHandle);

            if (result == 1)
            {
                Debug.Assert(!identityHandle.IsInvalid);
                return identityHandle;
            }

            identityHandle.Dispose();

            if (result == 0)
            {
                throw CreateExceptionForOSStatus(osStatus);
            }

            Debug.Fail($"AppleCryptoNative_X509CopyWithPrivateKey returned {result}");
            throw new CryptographicException();
        }

        internal static SafeSecIdentityHandle? X509MoveToKeychain(
            SafeSecCertificateHandle cert,
            SafeKeychainHandle targetKeychain,
            SafeSecKeyRefHandle? privateKey)
        {
            SafeSecIdentityHandle identityHandle;
            int osStatus;
            int result;

            // Ensure the keychain is not disposed, if there is any associated one
            using (SafeKeychainHandle keychain = Interop.AppleCrypto.SecKeychainItemCopyKeychain(cert))
            {
                // AppleCryptoNative_X509MoveToKeychain can change the keychain of the input
                // certificate, so we need to reflect that change.
                SafeTemporaryKeychainHandle.UntrackItem(cert.DangerousGetHandle());

                result = AppleCryptoNative_X509MoveToKeychain(
                    cert,
                    targetKeychain,
                    privateKey ?? SafeSecKeyRefHandle.InvalidHandle,
                    out identityHandle,
                    out osStatus);

                SafeTemporaryKeychainHandle.TrackItem(cert);
                SafeTemporaryKeychainHandle.TrackItem(identityHandle);
            }

            if (result == 0)
            {
                identityHandle.Dispose();
                throw CreateExceptionForOSStatus(osStatus);
            }

            if (result != 1)
            {
                Debug.Fail($"AppleCryptoNative_X509MoveToKeychain returned {result}");
                throw new CryptographicException();
            }

            if (privateKey?.IsInvalid == false)
            {
                // If a PFX has a mismatched association between a private key and the
                // certificate public key then MoveToKeychain will write the NULL SecIdentityRef
                // (after cleaning up the temporary key).
                //
                // When that happens, just treat the import as public-only.
                if (!identityHandle.IsInvalid)
                {
                    return identityHandle;
                }
            }

            // If the cert in the PFX had no key, but it was imported with PersistKeySet (imports into
            // the default keychain) and a matching private key was already there, then an
            // identityHandle could be found. But that's not desirable, since neither Windows or Linux would
            // do that matching.
            //
            // So dispose the handle, no matter what.
            identityHandle.Dispose();
            return null;
        }

        private static byte[] X509Export(X509ContentType contentType, SafeCreateHandle cfPassphrase, IntPtr[] certHandles)
        {
            Debug.Assert(contentType == X509ContentType.Pkcs7 || contentType == X509ContentType.Pkcs12);

            using (SafeCreateHandle handlesArray = CoreFoundation.CFArrayCreate(certHandles, (UIntPtr)certHandles.Length))
            {
                SafeCFDataHandle exportData;
                int osStatus;

                int result = AppleCryptoNative_X509ExportData(
                    handlesArray,
                    contentType,
                    cfPassphrase,
                    out exportData,
                    out osStatus);

                using (exportData)
                {
                    if (result != 1)
                    {
                        if (result == 0)
                        {
                            throw CreateExceptionForOSStatus(osStatus);
                        }

                        Debug.Fail($"Unexpected result from AppleCryptoNative_X509ExportData: {result}");
                        throw new CryptographicException();
                    }

                    Debug.Assert(!exportData.IsInvalid, "Successful export yielded no data");
                    return CoreFoundation.CFGetData(exportData);
                }
            }
        }

        internal static byte[] X509ExportPkcs7(IntPtr[] certHandles)
        {
            return X509Export(X509ContentType.Pkcs7, s_nullExportString, certHandles);
        }

        internal static byte[] X509ExportPfx(IntPtr[] certHandles, SafePasswordHandle exportPassword)
        {
            SafeCreateHandle cfPassphrase = s_emptyExportString;
            bool releasePassword = false;

            try
            {
                if (!exportPassword.IsInvalid)
                {
                    exportPassword.DangerousAddRef(ref releasePassword);
                    IntPtr passwordHandle = exportPassword.DangerousGetHandle();

                    if (passwordHandle != IntPtr.Zero)
                    {
                        cfPassphrase = CoreFoundation.CFStringCreateWithCString(passwordHandle);
                    }
                }

                return X509Export(X509ContentType.Pkcs12, cfPassphrase, certHandles);
            }
            finally
            {
                if (releasePassword)
                {
                    exportPassword.DangerousRelease();
                }

                if (cfPassphrase != s_emptyExportString)
                {
                    cfPassphrase.Dispose();
                }
            }
        }

        internal static SafeSecCertificateHandle X509GetCertFromIdentity(SafeSecIdentityHandle identity)
        {
            SafeSecCertificateHandle cert;
            int osStatus = AppleCryptoNative_X509CopyCertFromIdentity(identity, out cert);

            SafeTemporaryKeychainHandle.TrackItem(cert);

            if (osStatus != 0)
            {
                cert.Dispose();
                throw CreateExceptionForOSStatus(osStatus);
            }

            if (cert.IsInvalid)
            {
                cert.Dispose();
                throw new CryptographicException(SR.Cryptography_OpenInvalidHandle);
            }

            return cert;
        }

        internal static bool X509DemuxAndRetainHandle(
            IntPtr handle,
            out SafeSecCertificateHandle certHandle,
            out SafeSecIdentityHandle identityHandle)
        {
            int result = AppleCryptoNative_X509DemuxAndRetainHandle(handle, out certHandle, out identityHandle);

            SafeTemporaryKeychainHandle.TrackItem(certHandle);
            SafeTemporaryKeychainHandle.TrackItem(identityHandle);

            switch (result)
            {
                case 1:
                    return true;
                case 0:
                    return false;
                default:
                    Debug.Fail($"AppleCryptoNative_X509DemuxAndRetainHandle returned {result}");
                    throw new CryptographicException();
            }
        }
    }
}

namespace System.Security.Cryptography.X509Certificates
{
    internal sealed class SafeSecIdentityHandle : SafeKeychainItemHandle
    {
        public SafeSecIdentityHandle()
        {
        }
    }

    internal sealed class SafeSecCertificateHandle : SafeKeychainItemHandle
    {
        public SafeSecCertificateHandle()
        {
        }
    }
}
