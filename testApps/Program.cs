using FRC;
using FRC.NetworkTables.Core.Interop;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace testApps
{
    class Program
    {
        public static unsafe NT_Entry[] NT_GetEntries(NT_Inst inst, string prefix, uint types)
        {
            var nativePrefix = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr len;
            var entriesPtr = Functions.NT_GetEntries(inst, (byte*)nativePrefix.Buffer.ToPointer(), nativePrefix.Length, types, &len);
            int lenInt = (int)len;
            NT_Entry[] entries = new NT_Entry[lenInt];

            for (int i = 0; i < lenInt; i++)
            {
                Unsafe.Copy(ref entries[i], &entriesPtr[i]);
            }

            Functions.NT_DisposeEntryArray(entriesPtr, len);

            return entries;
        }

        static unsafe void Main(string[] args)
        {
            /*
            NT_GetEntriesDelegate del = (a, b, c, d, e) =>
            {
                var size = Unsafe.SizeOf<NT_Entry>();
                NT_Entry* pt = (NT_Entry*)Marshal.AllocHGlobal(size * 10).ToPointer();

                for (int i = 0; i < 10; i++)
                {
                    pt[i] = new NT_Entry(i * 5);
                }

                *e = (UIntPtr)10;

                return pt;
            };

            NT_DisposeEntryArrayDelegate dDel = (a, b) =>
            {
                Marshal.FreeHGlobal((IntPtr)a);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(del);
            Functions.NT_GetEntriesFunctionPointer = ptr;

            var dPtr = Marshal.GetFunctionPointerForDelegate(dDel);
            Functions.NT_DisposeEntryArrayFunctionPointer = dPtr;

            var entries = NT_GetEntries(new NT_Inst(1), "", 0);
            */
            /*
            NT_SetListenerOnStartDelegate del = (fP, vP) =>
            {
                fP.Invoke(vP);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(del);

            Functions.NT_SetListenerOnStartFunctionPointer = ptr;

            Functions.NT_SetListenerOnStart((vP) =>
            {
                Console.WriteLine((int)vP);
                Console.WriteLine("Hello!!!");
            }, (void*)10);
            */

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
