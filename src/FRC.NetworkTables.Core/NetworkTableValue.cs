using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NetworkTables
{
    public class NetworkTableValue
    {
        public static unsafe NetworkTableValue CreateFromNative(NT_Value* native)
        {
            throw null;
        }

        public static unsafe void CreateNative(NetworkTableValue inValue, NT_Value* outValue)
        {
            throw null;
        }

        public static unsafe void DisposeNative(NT_Value* value)
        {

        }
    }
}
