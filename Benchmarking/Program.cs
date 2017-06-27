using FRC.NativeLibraryUtilities;
using FRC.NetworkTables.Core.Interop;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Benchmarking
{
    class Program
    {
        [DllImport(@"libwpiutil.so")]
        //[DllImport(@"C:\Users\thadh\Documents\GitHub\ThadHouse\wpiutil-test\build\libs\wpiutil\shared\x86\wpiutil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TEST_SUM(int x, int y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int TEST_SUM_DELEGATE(int x, int y);


        static void Main(string[] args)
        {
            ILibraryLoader loader = new EmbeddedLibraryLoader();
            string path = @"C:\Users\thadh\Documents\GitHub\ThadHouse\wpiutil-test\build\libs\wpiutil\shared";
           
            if (Marshal.SizeOf<UIntPtr>() == 8)
            {
                path = Path.Combine(path, "x86-64", "wpiutil.dll");
             
            }
            else
            {
                path = Path.Combine(path, "x86", "wpiutil.dll");
            }
            path = "/home/admin/app/libwpiutil.so";
            loader.LoadLibrary(path);
            var addr = loader.GetProcAddress("TEST_SUM");

            var del = Marshal.GetDelegateForFunctionPointer<TEST_SUM_DELEGATE>(addr);

            Functions.TEST_SUMFP = addr;

            Functions.TEST_SUM(5, 5);


            Stopwatch calli = Stopwatch.StartNew();

            for (int i = 0; i < 5_000_000; i++)
            {
                var ret = Functions.TEST_SUM(i, i);
                if (ret != i + i)
                {
                    throw new Exception();
                }
            }

            calli.Stop();

            Console.WriteLine("Calli");
            Console.WriteLine(calli.ElapsedTicks / (double)Stopwatch.Frequency);

            del(5, 5);

            calli = Stopwatch.StartNew();

            for (int i = 0; i < 5_000_000; i++)
            {
                var ret = del(i, i);
                if (ret != i + i)
                {
                    throw new Exception();
                }
            }

            calli.Stop();

            Console.WriteLine("Delegate");
            Console.WriteLine(calli.ElapsedTicks / (double)Stopwatch.Frequency);

            TEST_SUM(5, 5);

            calli = Stopwatch.StartNew();

            for (int i = 0; i < 5_000_000; i++)
            {
                var ret = TEST_SUM(i, i);
                if (ret != i + i)
                {
                    throw new Exception();
                }
            }

            calli.Stop();

            Console.WriteLine("PInvoke");
            Console.WriteLine(calli.ElapsedTicks / (double)Stopwatch.Frequency);



            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}