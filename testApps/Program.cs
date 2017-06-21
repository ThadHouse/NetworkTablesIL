using FRC.NetworkTables.Core.Interop;
using System;
using System.Runtime.InteropServices;

namespace testApps
{
    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NT_Inst NT_GetInst();

        static void Main(string[] args)
        {
            FRC.NetworkTables.Core.Interop.NT_Bool val = new FRC.NetworkTables.Core.Interop.NT_Bool(false);

            NT_GetInst instFunc = () =>
            {
                return new NT_Inst(42);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(instFunc);
            Functions.NT_GetDefaultInstanceFunctionPointer = ptr;

            var inst = Functions.NT_GetDefaultInstance();

            Console.WriteLine(val.Get());
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
