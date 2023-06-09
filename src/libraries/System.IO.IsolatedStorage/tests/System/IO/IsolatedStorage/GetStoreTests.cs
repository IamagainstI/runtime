// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Reflection;
using Xunit;

namespace System.IO.IsolatedStorage
{
    public class GetStoreTests : IsoStorageTest
    {
        private static MethodInfo s_verifyScopeMethod;

        static GetStoreTests()
        {
            s_verifyScopeMethod = typeof(IsolatedStorage).GetMethod("VerifyScope", BindingFlags.NonPublic | BindingFlags.Static);
        }

        [Theory,
            MemberData(nameof(ValidScopes))
            ]
        public void InitStore_ValidScopes(IsolatedStorageScope scope)
        {
            s_verifyScopeMethod.Invoke(null, new object[] { scope });
        }

        [Theory,
            InlineData(IsolatedStorageScope.None),
            InlineData(IsolatedStorageScope.Machine | IsolatedStorageScope.Roaming),
            InlineData(IsolatedStorageScope.Machine | IsolatedStorageScope.User)
            ]
        public void InitStore_InvalidScopes(IsolatedStorageScope scope)
        {
            try
            {
                s_verifyScopeMethod.Invoke(null, new object[] { scope });
            }
            catch (TargetInvocationException e)
            {
                Assert.IsType<ArgumentException>(e.InnerException);
            }
        }

        [Fact]
        public void GetUserStoreForSite_ThrowsNotSupported()
        {
            Assert.Throws<NotSupportedException>(() => IsolatedStorageFile.GetUserStoreForSite());
        }

        [Fact]
        [SkipOnPlatform(TestPlatforms.Android | TestPlatforms.iOS | TestPlatforms.tvOS | TestPlatforms.MacCatalyst, "For mobile platforms root ends with /.isolated-storage")]
        public void GetUserStoreForApplication()
        {
            var isf = IsolatedStorageFile.GetUserStoreForApplication();
            VerifyApplicationStore(isf);
        }

        private void VerifyApplicationStore(IsolatedStorageFile isf)
        {
            string root = isf.GetUserRootDirectory();
            Assert.EndsWith(@"AppFiles" + Path.DirectorySeparatorChar, root);
            Assert.True(Directory.Exists(root), "store root folder should exist");
        }

        [Fact]
        [SkipOnPlatform(TestPlatforms.Android | TestPlatforms.iOS | TestPlatforms.tvOS | TestPlatforms.MacCatalyst, "For mobile platforms root ends with /.isolated-storage")]
        public void GetUserStoreForAssembly()
        {
            var isf = IsolatedStorageFile.GetUserStoreForAssembly();
            string root = isf.GetUserRootDirectory();
            Assert.EndsWith(@"AssemFiles" + Path.DirectorySeparatorChar, root);
            Assert.True(Directory.Exists(root), "store root folder should exist");
        }

        [Fact]
        [SkipOnPlatform(TestPlatforms.Android | TestPlatforms.iOS | TestPlatforms.tvOS | TestPlatforms.MacCatalyst, "For mobile platforms root ends with /.isolated-storage")]
        public void GetUserStoreForDomain()
        {
            var isf = IsolatedStorageFile.GetUserStoreForDomain();
            string root = isf.GetUserRootDirectory();
            Assert.EndsWith(@"Files" + Path.DirectorySeparatorChar, root);
            Assert.True(Directory.Exists(root), "store root folder should exist");
        }

        [Fact]
        public void GetStore_ThrowsPlatformNotSupported()
        {
            Assert.Throws<PlatformNotSupportedException>(() => IsolatedStorageFile.GetStore(IsolatedStorageScope.User, typeof(object)));
            Assert.Throws<PlatformNotSupportedException>(() => IsolatedStorageFile.GetStore(IsolatedStorageScope.User, typeof(object), typeof(object)));
            Assert.Throws<PlatformNotSupportedException>(() => IsolatedStorageFile.GetStore(IsolatedStorageScope.User, new object()));
            Assert.Throws<PlatformNotSupportedException>(() => IsolatedStorageFile.GetStore(IsolatedStorageScope.User, new object(), new object()));
        }

        [Fact]
        [SkipOnPlatform(TestPlatforms.Android | TestPlatforms.iOS | TestPlatforms.tvOS | TestPlatforms.MacCatalyst, "For mobile platforms root ends with /.isolated-storage")]
        public void GetStore_NullParamsAllowed()
        {
            VerifyApplicationStore(IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Application, (Type)null));
            VerifyApplicationStore(IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Application, (Type)null, (Type)null));
            VerifyApplicationStore(IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Application, (object)null));
            VerifyApplicationStore(IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Application, (object)null, (object)null));
        }

        [Fact]
        public void GetEnumerator_NoOp()
        {
            IEnumerator e = IsolatedStorageFile.GetEnumerator(IsolatedStorageScope.Assembly);
            Assert.False(e.MoveNext(), "should have no items");

            // Reset shouldn't throw
            e.Reset();
        }

        [Fact]
        public void GetEnumerator_ThrowsForCurrent()
        {
            IEnumerator e = IsolatedStorageFile.GetEnumerator(IsolatedStorageScope.Assembly);
            Assert.Throws<InvalidOperationException>(() => e.Current);
            e.MoveNext();
            Assert.Throws<InvalidOperationException>(() => e.Current);
        }
    }
}
