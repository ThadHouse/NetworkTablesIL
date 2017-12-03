using FRC.NetworkTables.Core.Interop;
using FRC.NetworkTables.Core.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace FRC.NetworkTables
{
    public struct RpcAnswer : IDisposable
    {
        public NT_Entry Entry { get; }
        public NT_RpcCall Call { get; }
        public string Name { get; }
        public string Params { get; }
        public ConnectionInfo Conn { get; }

        public RpcAnswer(NetworkTableInstance inst, NT_Entry entry, NT_RpcCall call, string name, string @params, ConnectionInfo conn)
        {
            Entry = entry;
            Call = call;
            Name = name;
            Params = @params;
            Conn = conn;
            this.inst = inst;
            this.entryObject = null;
        }

        public void Dispose()
        {
            if (Call.Get() != 0)
            {
                PostResponse(Array.Empty<byte>());
            }
        }

        public bool IsValid() => Call.Get() != 0;

        public void PostResponse(byte[] result)
        {
            NtCore.PostRpcResponse(Entry, Call, result);
        }

        private NetworkTableInstance inst;

        private NetworkTableEntry entryObject;

        internal NetworkTableEntry GetEntry()
        {
            if (entryObject == null)
            {
                entryObject = new NetworkTableEntry(inst, Entry);
            }
            return entryObject;
        }
    }
}
