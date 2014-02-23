using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    class MacAddress
    {
        byte[] _address;

        public MacAddress(byte[] b)
        {
            if (b == null)
                throw new ArgumentNullException("b");
            if (b.Length != 8)
                throw new ArgumentOutOfRangeException("b");
            _address = new byte[b.Length];
            Array.Copy(b, _address, b.Length);
        }

        public byte[] Address { get { return _address; } }

        public override string ToString()
        {
            return Address[0].ToString("X2", System.Globalization.CultureInfo.InvariantCulture) + ":" +
                    Address[1].ToString("X2", System.Globalization.CultureInfo.InvariantCulture) + ":" +
                    Address[2].ToString("X2", System.Globalization.CultureInfo.InvariantCulture) + ":" +
                    Address[3].ToString("X2", System.Globalization.CultureInfo.InvariantCulture) + ":" +
                    Address[4].ToString("X2", System.Globalization.CultureInfo.InvariantCulture) + ":" +
                    Address[5].ToString("X2", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static List<MacAddress> GetMacAddresses()
        {
            int size = 0;
            // this chunk of code teases out the first adapter info
            int r = GetAdaptersInfo(null, ref size);
            if ((r != IPConfigConst.ERROR_SUCCESS) && (r != IPConfigConst.ERROR_BUFFER_OVERFLOW))
            {
                return null;
            }
            Byte[] buffer = new Byte[size];
            r = GetAdaptersInfo(buffer, ref size);
            if (r != IPConfigConst.ERROR_SUCCESS)
            {
                return null;
            }
            AdapterInfo Adapter = new AdapterInfo();
            ByteArray_To_IPAdapterInfo(ref Adapter, buffer, Marshal.SizeOf(Adapter));

            List<MacAddress> addresses = new List<MacAddress>();
            do
            {
                addresses.Add(new MacAddress(Adapter.Address));
                IntPtr p = Adapter.NextPointer;
                if (p != IntPtr.Zero)
                {
                    IntPtr_To_IPAdapterInfo(ref Adapter, p, Marshal.SizeOf(Adapter));
                }
                else
                {
                    break;
                }
            } while (true);
            return addresses;
        }

        // glue definitions into windows
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        private struct IPAddrString
        {
            public IntPtr NextPointer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4 * 4)]
            public String IPAddressString;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4 * 4)]
            public String IPMaskString;
            public int Context;
        }

        private class IPConfigConst
        {
            public const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;
            public const int MAX_ADAPTER_NAME_LENGTH = 256;
            public const int MAX_ADAPTER_ADDRESS_LENGTH = 8;
            public const int ERROR_BUFFER_OVERFLOW = 111;
            public const int ERROR_SUCCESS = 0;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        private struct AdapterInfo
        {
            public IntPtr NextPointer;
            public int ComboIndex;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPConfigConst.MAX_ADAPTER_NAME_LENGTH + 4)]
            public string AdapterName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = IPConfigConst.MAX_ADAPTER_DESCRIPTION_LENGTH + 4)]
            public string Description;
            public int AddressLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = IPConfigConst.MAX_ADAPTER_ADDRESS_LENGTH)]
            public Byte[] Address;
            public int Index;
            public int Type;
            public int DhcpEnabled;
            public IntPtr CurrentIPAddress;
            public IPAddrString IPAddressList;
            public IPAddrString GatewayList;
            public IPAddrString DhcpServer;
            public Boolean HaveWins;
            public IPAddrString PrimaryWinsServer;
            public IPAddrString SecondaryWinsServer;
            public int LeaseObtained;
            public int LeaseExpires;
        }
        [DllImport("Iphlpapi.dll", CharSet = CharSet.Auto)]
        private static extern int GetAdaptersInfo(Byte[] PAdapterInfoBuffer, ref int size);
        [DllImport("Kernel32.dll", EntryPoint = "CopyMemory")]
        private static extern void ByteArray_To_IPAdapterInfo(ref AdapterInfo dst, Byte[] src, int size);
        [DllImport("Kernel32.dll", EntryPoint = "CopyMemory")]
        private static extern void IntPtr_To_IPAdapterInfo(ref AdapterInfo dst, IntPtr src, int size);
    }

}
