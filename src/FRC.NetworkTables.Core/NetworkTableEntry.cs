using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace FRC.NetworkTables
{
    public class NetworkTableEntry
    {
        private NT_Entry m_handle;
        private NetworkTableInstance m_inst;

        public NetworkTableEntry(NetworkTableInstance inst, NT_Entry handle)
        {
            m_inst = inst;
            m_handle = handle;
        }
    }
}
