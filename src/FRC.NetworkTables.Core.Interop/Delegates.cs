using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace FRC.NetworkTables.Core.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_WarnFunc(UIntPtr line, byte* msg);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_LogFunc(uint level, byte* file, uint line, byte* msg);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_OnStart(void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_OnExit(void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_RpcCallback(void* data, NT_Entry entry, byte* name, UIntPtr name_len, byte* param, UIntPtr param_len, UIntPtr* result_len, NT_ConnectionInfo* conn_info);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_EntryListenerCallback(NT_EntryListener entry_listener, void* data, byte* name, UIntPtr name_len, NT_Value* value, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_EntryListenerCallback2(NT_EntryListener entry_listener, void* data, NT_Entry entry, byte* name, UIntPtr name_len, NT_Value* value, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_ConnectionListenerCallback(NT_ConnectionListener conn_listener, void* data, NT_Bool connected, NT_ConnectionInfo conn);
}
