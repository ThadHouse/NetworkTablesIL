using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace ILRewriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach(var item in args)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // On windows, Generating new DLL's
                string ilAsmPath = Path.GetFullPath(Path.Combine(args[0], "ilasm", "ilasm.exe"));
                string ilDasmPath = Path.GetFullPath(Path.Combine(args[0], "ilasm", "ildasm.exe"));
                string tempPath = Path.GetFullPath(Path.Combine(args[0], "obj", "temp"));
                string ilFilePath = Path.GetFullPath(Path.Combine(tempPath, $"{args[2]}.il"));
                string ilResFilePath = Path.GetFullPath(Path.Combine(tempPath, $"{args[2]}.res"));
                if (Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath, true);
                }
                Directory.CreateDirectory(tempPath);
                string buildPath = Path.GetFullPath(args[1]);
                string dllName = Path.GetFullPath(Path.Combine(buildPath, args[2]));
                string pdbName = dllName.Replace(".dll", ".pdb");

                string extraIlPath = Path.GetFullPath(Path.Combine(args[0], "il"));

                Console.WriteLine(ilAsmPath);
                Console.WriteLine(dllName);

                Console.WriteLine(File.Exists(ilDasmPath));

                ProcessStartInfo ilDasmInfo = new ProcessStartInfo()
                {
                    FileName = ilDasmPath,
                    Arguments = $"{dllName} /out:{ilFilePath}"
                };

                Process.Start(ilDasmInfo).WaitForExit();

                //return;

                string[] lines = File.ReadAllLines(ilFilePath);

                bool inFunctionsDecl = false;
                int bracketCount = 0;

                using (FileStream fs = File.Open(ilFilePath, FileMode.Create))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    for(int i = 0; i < lines.Length; i++)
                    //foreach (var line in lines)
                    {
                        var line = lines[i];
                        if (line.Contains(".class public abstract auto ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.Functions"))
                        {
                            inFunctionsDecl = true;
                            i++;
                            continue;
                        }
                        if (inFunctionsDecl)
                        {
                            if (line.Trim().StartsWith("{"))
                            {
                                bracketCount++;
                            }
                            if (line.Trim().StartsWith("}"))
                            {
                                bracketCount--;
                            }
                            if (bracketCount == 0)
                            {

                            }

                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                if (File.Exists(pdbName))
                {
                    File.Delete(pdbName);
                }

                if (File.Exists(dllName))
                {
                    File.Delete(dllName);
                }

                string otherIlFiles = "";
                foreach(var file in Directory.GetFiles(extraIlPath, "*.il"))
                {
                    otherIlFiles += file;
                    otherIlFiles += " ";
                }

                ProcessStartInfo ilAsmInfo = new ProcessStartInfo()
                {
                    FileName = ilAsmPath,
                    Arguments = $"/dll /optimize /quiet /output:{dllName} {ilFilePath} {otherIlFiles}",
                };

                Process.Start(ilAsmInfo).WaitForExit();


                ProcessStartInfo ilDasmInfo2 = new ProcessStartInfo()
                {
                    FileName = ilDasmPath,
                    Arguments = $"{dllName} /out:{ilFilePath}Result"
                };

                Process.Start(ilDasmInfo2).WaitForExit();

            }
            else
            {
                // Copy existing DLL's
            }
        }
    }
}
