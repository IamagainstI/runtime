// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.NetworkInformation
{
    internal sealed class SystemIPv6InterfaceProperties : IPv6InterfaceProperties
    {
        private readonly uint _index;
        private readonly uint _mtu;
        private readonly uint[] _zoneIndices;

        internal SystemIPv6InterfaceProperties(uint index, uint mtu, uint[] zoneIndices)
        {
            _index = index;
            _mtu = mtu;
            _zoneIndices = zoneIndices;
        }

        public override int Index
        {
            get
            {
                return (int)_index;
            }
        }

        // Specifies the Maximum transmission unit in bytes. Uses GetIFEntry.
        // We cache this to be consistent across all platforms
        public override int Mtu
        {
            get
            {
                return unchecked((int)_mtu);
            }
        }

        public override long GetScopeId(ScopeLevel scopeLevel)
        {
            ArgumentOutOfRangeException.ThrowIfNegative((int)scopeLevel, nameof(scopeLevel));
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((int)scopeLevel, _zoneIndices.Length, nameof(scopeLevel));

            return _zoneIndices[(int)scopeLevel];
        }
    }
}
