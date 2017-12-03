using FRC;
using FRC.NetworkTables.Core.Interop;

namespace FRC.NetworkTables
{
    /// <summary>
    /// This class contains all info for a given entry.
    /// </summary>
    public struct EntryInfo
    {
        public NT_Entry EntryHandle { get; }
        /// <summary>Gets the Name of the entry.</summary>
        public string Name { get; }
        /// <summary>Gets the Type of the entry.</summary>
        public NtType Type { get; }
        /// <summary>Gets the Flags attached to the entry.</summary>
        public EntryFlags Flags { get; }
        /// <summary>Gets the last change time of the entry.</summary>
        public long LastChange { get; }

        private NetworkTableInstance m_inst;
        private NetworkTableEntry m_entry;

        /// <summary>
        /// Get the entry object
        /// </summary>
        /// <returns>Entry object</returns>
        public NetworkTableEntry GetEntry()
        {
            if (m_entry == null)
            {
                m_entry = new NetworkTableEntry(m_inst, EntryHandle);
            }
            return m_entry;
        }

        public unsafe EntryInfo(NetworkTableInstance instance, NT_EntryInfo* entryInfo)
        {
            EntryHandle = entryInfo->entry;
            Type = (NtType)entryInfo->type;
            Flags = (EntryFlags)entryInfo->flags;
            LastChange = (long)entryInfo->last_change;
            Name = UTF8String.ReadUTF8String(entryInfo->name.str, entryInfo->name.len);
            m_inst = instance;
            m_entry = null;
        }
    }
}
