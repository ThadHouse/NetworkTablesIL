using System;

namespace testApps
{
    class Program
    {
        static void Main(string[] args)
        {
            FRC.NetworkTables.Core.Interop.NT_Bool val = new FRC.NetworkTables.Core.Interop.NT_Bool(false);
            Console.WriteLine(val.Get());
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
