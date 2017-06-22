using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkTables
{
    public class NetworkTableEntry
    {
        private NT_Entry m_handle;

        public NetworkTableEntry(NT_Entry handle)
        {
            m_handle = handle;
        }

        public static implicit operator NetworkTableEntry(NT_Entry handle)
        {
            return new NetworkTableEntry(handle);
        }

        public static explicit operator NT_Entry(NetworkTableEntry entry)
        {
            return entry.m_handle;
        }
    }
}
