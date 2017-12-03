using FRC.NativeLibraryUtilities;
using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using static FRC.NetworkTables.Core.Interop.Functions;

namespace FRC.NetworkTables.Core.Native
{
    public class NtCore
    {
        // ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
        internal static NativeLibraryLoader NativeLoader { get; }
        private static readonly string s_libraryLocation;
        private static readonly bool s_useCommandLineFile;
        // ReSharper restore PrivateFieldCanBeConvertedToLocalVariable
        private static readonly bool s_runFinalizer;

        static NtCore()
        { 
            EventHandler h = (o, e) =>
            {
                if (!s_runFinalizer) return;
                NativeLoader.LibraryLoader.UnloadLibrary();

                try
                {
                    if (!s_useCommandLineFile && File.Exists(s_libraryLocation))
                    {
                        File.Delete(s_libraryLocation);
                    }
                }
                catch
                {

                }
            };
            AppDomain.CurrentDomain.DomainUnload += h;
            AppDomain.CurrentDomain.ProcessExit += h;

            try
            {
                string[] commandArgs = Environment.GetCommandLineArgs();
                foreach (var commandArg in commandArgs)
                {
                    //search for a line with the prefix "-ntcore:"
                    if (commandArg.ToLower().Contains("-ntcore:"))
                    {
                        //Split line to get the library.
                        int splitLoc = commandArg.IndexOf(':');
                        string file = commandArg.Substring(splitLoc + 1);

                        //If the file exists, just return it so dlopen can load it.
                        if (File.Exists(file))
                        {
                            s_libraryLocation = file;
                            s_useCommandLineFile = true;
                        }
                    }
                }

                const string resourceRoot = "FRC.NetworkTables.Core.DesktopLibraries.Libraries.";

                NativeLoader = new NativeLibraryLoader();
                NativeLoader.AddLibraryLocation(OsType.Windows32,
                    resourceRoot + "Windows.x86.ntcore.dll");
                NativeLoader.AddLibraryLocation(OsType.Windows64,
                    resourceRoot + "Windows.amd64.ntcore.dll");
                NativeLoader.AddLibraryLocation(OsType.Linux32,
                    resourceRoot + "Linux.x86.libntcore.so");
                NativeLoader.AddLibraryLocation(OsType.Linux64,
                    resourceRoot + "Linux.amd64.libntcore.so");
                NativeLoader.AddLibraryLocation(OsType.MacOs32,
                    resourceRoot + "Mac_OS_X.x86.libntcore.dylib");
                NativeLoader.AddLibraryLocation(OsType.MacOs64,
                    resourceRoot + "Mac_OS_X.x86_64.libntcore.dylib");
                NativeLoader.AddLibraryLocation(OsType.roboRIO, "libntcore.so");

                if (s_useCommandLineFile)
                {
                    NativeLoader.LoadNativeLibrary<NtCore>(s_libraryLocation, true);
                }
                else
                {
                    NativeLoader.LoadNativeLibraryFromReflectedAssembly("FRC.NetworkTables.Core.DesktopLibraries");
                    s_libraryLocation = NativeLoader.LibraryLocation;
                }

                var type = typeof(Functions).GetTypeInfo();


                foreach (var field in type.GetFields(BindingFlags.Static | BindingFlags.Public))
                {
                    if (field.FieldType == typeof(IntPtr) && field.Name.EndsWith("FunctionPointer"))
                    {
                        field.SetValue(null, NativeLoader.LibraryLoader.GetProcAddress(field.Name.Replace("FunctionPointer", "")));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Environment.Exit(1);
            }
            s_runFinalizer = true;
        }

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
            for (int i = 0; i < (int)count; i++)
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

        public static unsafe EntryInfo? GetEntryInfoHandle(NetworkTableInstance inst, NT_Entry entry)
        {
            NT_EntryInfo info = new NT_EntryInfo();
            var ret = NT_GetEntryInfoHandle(entry, &info);
            if (!ret.Get())
            {
                NT_DisposeEntryInfo(&info);
                return null;
            }
            EntryInfo infoM = new EntryInfo(inst, &info);
            NT_DisposeEntryInfo(&info);
            return infoM;
        }

        public static NT_EntryListenerPoller CreateEntryListenerPoller(NT_Inst inst)
        {
            return NT_CreateEntryListenerPoller(inst);
        }

        public static void DestroyEntryListenerPoller(NT_EntryListenerPoller poller)
        {
            NT_DestroyEntryListenerPoller(poller);
        }

        public static unsafe void PostRpcResponse(NT_Entry entry, NT_RpcCall call, byte[] result)
        {
            fixed (byte* p = result)
            {
                UIntPtr len = (UIntPtr)result.Length;
                NT_PostRpcResponse(entry, call, p, len);
            }
        }
    }
}
