using FRC.NetworkTables.Core.Interop;
using NetworkTables;
using System;
using System.Collections.Generic;
using System.Text;
using static FRC.NetworkTables.Core.Interop.Functions;

namespace FRC.NetworkTables.Core.Native
{
    public class NtCore
    {
        public static NT_Inst GetDefaultInstance()
        {
            return NT_GetDefaultInstance();
        }

        public static NT_Inst CreateInstance()
        {
            return NT_CreateInstance();
        }

        public static void DestroyInstance(NT_Inst inst)
        {
            NT_DestroyInstance(inst);
        }

        public static NT_Inst GetInstanceFromHandle(NT_Handle handle)
        {
            return NT_GetInstanceFromHandle(handle);
        }

        public static unsafe NT_Entry GetEntry(NT_Inst inst, string name)
        {
            CachedNativeString ns = UTF8String.CreateCachedUTF8String(name);
            return NT_GetEntry(inst, ns.Buffer, ns.Length);
        }

        public static unsafe List<NT_Entry> GetEntries(NT_Inst inst, string prefix, NT_Type types)
        {
            var ns = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr count = UIntPtr.Zero;
            var data = NT_GetEntries(inst, ns.Buffer, ns.Length, (uint)types, &count);
            List<NT_Entry> entries = new List<NT_Entry>((int)count);
            for(int i = 0; i < (int)count; i++)
            {
                entries.Add(data[i]);
            }
            NT_DisposeEntryArray(data, count);
            return entries;
        }

        public static unsafe List<NetworkTableEntry> GetEntriesManaged(NetworkTableInstance inst, string prefix, NT_Type types)
        {
            var ns = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr count = UIntPtr.Zero;
            var data = NT_GetEntries(inst.Handle, ns.Buffer, ns.Length, (uint)types, &count);
            List<NetworkTableEntry> entries = new List<NetworkTableEntry>((int)count);
            for (int i = 0; i < (int)count; i++)
            {
                entries.Add(new NetworkTableEntry(inst, data[i]));
            }
            NT_DisposeEntryArray(data, count);
            return entries;
        }

        public static unsafe string GetEntryName(NT_Entry entry)
        {
            UIntPtr len = UIntPtr.Zero;
            var data = NT_GetEntryName(entry, &len);
            string ret = UTF8String.ReadUTF8String(data, len);
            NT_FreeCharArray(data);
            return ret;
        }

        public static NT_Type GetEntryType(NT_Entry entry)
        {
            return NT_GetEntryType(entry);
        }

        public static ulong GetEntryLastChange(NT_Entry entry)
        {
            return NT_GetEntryLastChange(entry);
        }

        public static unsafe NT_ManagedValue GetEntryValue(NT_Entry entry)
        {
            NT_Value value = new NT_Value();
            NT_GetEntryValue(entry, &value);
            var ret = NT_ManagedValue.CreateManagedFromNative(&value);
            NT_DisposeValue(&value);
            return ret;
        }

        public static unsafe bool SetDefaultEntryValue(NT_Entry entry, NT_ManagedValue value)
        {
            NT_Value v = new NT_Value();
            NT_ManagedValue.CreateNativeFromManaged(value, &v);
            var ret = NT_SetDefaultEntryValue(entry, &v);
            NT_ManagedValue.DisposeCreatedNative(&v);
            return ret.Get();
        }

        public static unsafe bool SetEntryValue(NT_Entry entry, NT_ManagedValue value)
        {
            NT_Value v = new NT_Value();
            NT_ManagedValue.CreateNativeFromManaged(value, &v);
            var ret = NT_SetEntryValue(entry, &v);
            NT_ManagedValue.DisposeCreatedNative(&v);
            return ret.Get();
        }

        public static unsafe void SetEntryTypeValue(NT_Entry entry, NT_ManagedValue value)
        {
            NT_Value v = new NT_Value();
            NT_ManagedValue.CreateNativeFromManaged(value, &v);
            NT_SetEntryTypeValue(entry, &v);
            NT_ManagedValue.DisposeCreatedNative(&v);
        }

        public static void SetEntryFlags(NT_Entry entry, NT_EntryFlags flags)
        {
            NT_SetEntryFlags(entry, (uint)flags);
        }

        public static NT_EntryFlags GetEntryFlags(NT_Entry entry)
        {
            return (NT_EntryFlags)NT_GetEntryFlags(entry);
        }

        public static void DeleteEntry(NT_Entry entry)
        {
            NT_DeleteEntry(entry);
        }

        public static void DeleteAllEntries(NT_Inst inst)
        {
            NT_DeleteAllEntries(inst);
        }

        public static unsafe List<EntryInfo> GetEntryInfo(NetworkTableInstance inst, string prefix, NT_Type types)
        {
            UIntPtr count = UIntPtr.Zero;
            var ns = UTF8String.CreateCachedUTF8String(prefix);
            var data = NT_GetEntryInfo(inst.Handle, ns.Buffer, ns.Length, (uint)types, &count);
            List<EntryInfo> entries = new List<EntryInfo>((int)count);
            for (int i = 0; i < (int)count; i++)
            {
                entries.Add(new EntryInfo(inst, &data[i]));
            }
            NT_DisposeEntryInfoArray(data, count);
            return entries;
        }
    }
}
