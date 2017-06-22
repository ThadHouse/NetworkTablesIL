using FRC;
using FRC.NetworkTables.Core.Interop;

namespace NetworkTables
{
    /// <summary>
    /// This class contains all info for a given entry.
    /// </summary>
    public struct EntryInfo2
    {
        public NetworkTableEntry Entry { get; }
        /// <summary>Gets the Name of the entry.</summary>
        public string Name { get; }
        /// <summary>Gets the Type of the entry.</summary>
        public NtType Type { get; }
        /// <summary>Gets the Flags attached to the entry.</summary>
        public EntryFlags Flags { get; }
        /// <summary>Gets the last change time of the entry.</summary>
        public long LastChange { get; }

        public EntryInfo2(NetworkTableEntry entry, string name, NtType type, EntryFlags flags, long lastChange)
        {
            Entry = entry;
            Name = name;
            Type = type;
            Flags = flags;
            LastChange = lastChange;
        }

        public unsafe EntryInfo2(NT_EntryInfo2* entryInfo)
        {
            Entry = entryInfo->entry;
            Type = (NtType)entryInfo->type;
            Flags = (EntryFlags)entryInfo->flags;
            LastChange = (long)entryInfo->last_change;
            Name = UTF8String.ReadUTF8String(entryInfo->name.str, entryInfo->name.len);
        }
    }
}
