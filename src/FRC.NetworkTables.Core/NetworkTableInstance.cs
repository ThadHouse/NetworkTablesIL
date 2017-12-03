using FRC.NetworkTables.Core;
using FRC.NetworkTables.Core.Interop;
using FRC.NetworkTables.Core.Native;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace FRC.NetworkTables
{
    public class NetworkTableInstance : IDisposable
    {
        public static readonly int DefaultPort = 1735;

        private NT_Inst m_handle;
        private bool m_owned;

        public NetworkTableInstance(NT_Inst handle)
        {
            m_owned = false;
            m_handle = handle;
        }

        public void Dispose()
        {
            if (m_owned && m_handle.Get() != 0)
            {
                NtCore.DestroyInstance(m_handle);
                m_handle = new NT_Inst();
            }
        }

        public bool IsValid() => m_handle.Get() != 0;

        private static Lazy<NetworkTableInstance> s_defaultInstance = new Lazy<NetworkTableInstance>();

        public static NetworkTableInstance Default => s_defaultInstance.Value;

        public static NetworkTableInstance Create()
        {
            var inst = new NetworkTableInstance(NtCore.CreateInstance());
            inst.m_owned = true;
            return inst;
        }

        public NT_Inst Handle => m_handle;

        public NetworkTableEntry GetEntry(string name)
        {
            return new NetworkTableEntry(this, NtCore.GetEntry(m_handle, name));
        }

        public List<NetworkTableEntry> GetEntries(string prefix, NT_Type types)
        {
            return NtCore.GetEntriesManaged(this, prefix, types);
        }

        public List<EntryInfo> GetEntryInfo(string prefix, NT_Type types)
        {
            return NtCore.GetEntryInfo(this, prefix, types);
        }

        private readonly ConcurrentDictionary<string, NetworkTable> m_tables = new ConcurrentDictionary<string, NetworkTable>();

        public NetworkTable GetTable(string key)
        {
            string theKey;
            if (string.IsNullOrWhiteSpace(key) || key.Equals(""))
            {
                theKey = "";
            } 
            else if (key[0] == NetworkTable.PathSeparator)
            {
                theKey = key;
            }
            else
            {
                theKey = NetworkTable.PathSeparator + key;
            }

            NetworkTable table = m_tables.GetOrAdd(theKey, (s) =>
            {
                return new NetworkTable();
            });
            return table;
        }

        public void DeleteAllEntries()
        {
            NtCore.DeleteAllEntries(m_handle);
        }
    }
}
