using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.Text;
using FRC;
using System.Runtime.CompilerServices;
using NetworkTables;
using System.Runtime.InteropServices;
using System.Collections.Concurrent;

namespace FRC.NetworkTables.Core
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

    public static class NtCore
    {
        public static NT_Inst NT_GetDefaultInstance()
        {
            return Functions.NT_GetDefaultInstance();
        }

        public static NT_Inst NT_CreateInstance()
        {
            return Functions.NT_CreateInstance();
        }

        public static void NT_DestroyInstance(NT_Inst inst)
        {
            Functions.NT_DestroyInstance(inst);
        }

        public static NT_Inst NT_GetInstanceFromHandle(NT_Handle handle)
        {
            return Functions.NT_GetInstanceFromHandle(handle);
        }

        public static unsafe NT_Entry NT_GetEntry(NT_Inst inst, string str)
        {
            var nativeStr = UTF8String.CreateCachedUTF8String(str);
            return Functions.NT_GetEntry(inst, nativeStr.Buffer, nativeStr.Length);
        }

        public static unsafe NT_Entry[] NT_GetEntryHandles(NT_Inst inst, string prefix, uint types)
        {
            var nativePrefix = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr len;
            var entriesPtr = Functions.NT_GetEntries(inst, nativePrefix.Buffer, nativePrefix.Length, types, &len);
            int lenInt = (int)len;
            NT_Entry[] entries = new NT_Entry[lenInt];
            
            for (int i = 0; i < lenInt; i++)
            {
                entries[i] = entriesPtr[i];
            }

            Functions.NT_DisposeEntryArray(entriesPtr, len);

            return entries;
        }

        public static unsafe NetworkTableEntry[] NT_GetEntries(NT_Inst inst, string prefix, uint types)
        {
            var nativePrefix = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr len;
            var entriesPtr = Functions.NT_GetEntries(inst, nativePrefix.Buffer, nativePrefix.Length, types, &len);
            int lenInt = (int)len;
            NetworkTableEntry[] entries = new NetworkTableEntry[lenInt];

            for (int i = 0; i < lenInt; i++)
            {
                entries[i] = new NetworkTableEntry(entriesPtr[i]);
            }

            Functions.NT_DisposeEntryArray(entriesPtr, len);

            return entries;
        }

        public static unsafe string NT_GetEntryName(NT_Entry entry)
        {
            UIntPtr len;
            var nativeStr = Functions.NT_GetEntryName(entry, &len);
            var str = UTF8String.ReadUTF8String(nativeStr);
            Functions.NT_FreeCharArray(nativeStr);
            return str;
        }

        public static ulong NT_GetEntryLastChange(NT_Entry entry)
        {
            return Functions.NT_GetEntryLastChange(entry);
        }

        public static unsafe NT_ManagedValue NT_GetEntryValue(string name)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            Functions.NT_GetEntryValue(nativeName.Buffer, nativeName.Length, &val);
            var retVal = NT_ManagedValue.CreateManagedFromNative(&val);
            Functions.NT_DisposeValue(&val);
            return retVal;
        }

        public static unsafe NT_ManagedValue NT_GetEntryValue(NT_Entry entry)
        {
            NT_Value val;
            Functions.NT_GetEntryValue2(entry, &val);
            var retVal = NT_ManagedValue.CreateManagedFromNative(&val);
            Functions.NT_DisposeValue(&val);
            return retVal;
        }

        public static unsafe bool NT_SetDefaultEntryValue(string name, NT_ManagedValue default_value)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            NT_ManagedValue.CreateNativeFromManaged(default_value, &val);
            var ret = Functions.NT_SetDefaultEntryValue(nativeName.Buffer, nativeName.Length, &val);
            NT_ManagedValue.DisposeCreatedNative(&val);
            return ret.Get();
        }

        public static unsafe bool NT_SetDefaultEntryValue2(NT_Entry entry, NT_ManagedValue default_value)
        {
            NT_Value val;
            NT_ManagedValue.CreateNativeFromManaged(default_value, &val);
            var ret = Functions.NT_SetDefaultEntryValue2(entry, &val);
            NT_ManagedValue.DisposeCreatedNative(&val);
            return ret.Get();
        }

        public static unsafe bool NT_SetEntryValue(string name, NT_ManagedValue value)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            NT_ManagedValue.CreateNativeFromManaged(value, &val);
            var ret = Functions.NT_SetEntryValue(nativeName.Buffer, nativeName.Length, &val);
            NT_ManagedValue.DisposeCreatedNative(&val);
            return ret.Get();
        }

        public static unsafe bool NT_SetEntryValue2(NT_Entry entry, NT_ManagedValue value)
        {
            NT_Value val;
            NT_ManagedValue.CreateNativeFromManaged(value, &val);
            var ret = Functions.NT_SetDefaultEntryValue2((NT_Entry)entry, &val);
            NT_ManagedValue.DisposeCreatedNative(&val);
            return ret.Get();
        }

        public static unsafe void NT_SetEntryTypeValue(string name, NT_ManagedValue value)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            NT_ManagedValue.CreateNativeFromManaged(value, &val);
            Functions.NT_SetEntryTypeValue(nativeName.Buffer, nativeName.Length, &val);
            NT_ManagedValue.DisposeCreatedNative(&val);
        }

        public static unsafe void NT_SetEntryTypeValue2(NT_Entry entry, NT_ManagedValue value)
        {
            NT_Value val;
            NT_ManagedValue.CreateNativeFromManaged(value, &val);
            Functions.NT_SetEntryTypeValue2((NT_Entry)entry, &val);
            NT_ManagedValue.DisposeCreatedNative(&val);

        }

        public static unsafe void NT_SetEntryFlags(string name, uint flags)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            Functions.NT_SetEntryFlags(nativeName.Buffer, nativeName.Length, flags);
        }

        public static unsafe void NT_SetEntryFlags2(NT_Entry entry, uint flags)
        {
            Functions.NT_SetEntryFlags2((NT_Entry)entry, flags);
        }

        public static unsafe uint NT_GetEntryFlags(string name)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            return Functions.NT_GetEntryFlags(nativeName.Buffer, nativeName.Length);
        }

        public static unsafe uint NT_GetEntryFlags2(NT_Entry entry)
        {
            return Functions.NT_GetEntryFlags2((NT_Entry)entry);
        }

        public static unsafe void NT_DeleteEntry(string name)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            Functions.NT_DeleteEntry(nativeName.Buffer, nativeName.Length);
        }

        public static unsafe void NT_DeleteEntry2(NT_Entry entry)
        {
            Functions.NT_DeleteEntry2((NT_Entry)entry);
        }

        public static unsafe void NT_DeleteAllEntries()
        {
            Functions.NT_DeleteAllEntries();
        }

        public static unsafe void NT_DeleteAllEntries2(NT_Inst inst)
        {
            Functions.NT_DeleteAllEntries2((NT_Inst)inst);
        }

        public static unsafe EntryInfo[] NT_GetEntryInfo(string prefix, uint types)
        {
            var nativePrefix = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr len;
            var ret = Functions.NT_GetEntryInfo(nativePrefix.Buffer, nativePrefix.Length, types, &len);
            int lenInt = (int)len;
            EntryInfo[] retArr = new EntryInfo[lenInt];
            for (int i = 0; i < lenInt; i++)
            {
                retArr[i] = new EntryInfo(&ret[i]);
            }
            Functions.NT_DisposeEntryInfoArray(ret, len);
            return retArr;
        }

        public static unsafe EntryInfo2[] NT_GetEntryInfo2(NetworkTableInstance inst, string prefix, uint types)
        {
            var nativePrefix = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr len;
            var ret = Functions.NT_GetEntryInfo2((NT_Inst) inst, nativePrefix.Buffer, nativePrefix.Length, types, &len);
            int lenInt = (int)len;
            EntryInfo2[] retArr = new EntryInfo2[lenInt];
            for (int i = 0; i < lenInt; i++)
            {
                retArr[i] = new EntryInfo2(&ret[i]);
            }
            Functions.NT_DisposeEntryInfoArray2(ret, len);
            return retArr;
        }

        public static unsafe EntryInfo2 NT_GetEntryInfoHandle(NetworkTableEntry entry)
        {
            var info = Functions.NT_GetEntryInfoHandle((NT_Entry)entry);
            var ret = new EntryInfo2(info);
            Functions.NT_DisposeEntryInfoArray2(info, new UIntPtr(1));
            return ret;
        }

        public static unsafe void NT_Flush()
        {
            Functions.NT_Flush();
        }

        public static unsafe void NT_Flush2(NetworkTableInstance inst)
        {
            Functions.NT_Flush2((NT_Inst)inst);
        }

        private static ConcurrentDictionary<CallbackHandle, NT_OnStart> m_OnStartDelegates = new ConcurrentDictionary<CallbackHandle, NT_OnStart>();

        public static unsafe CallbackHandle NT_SetListenerOnStart<T>(Action<T> onStart, T data)
        {
            NT_OnStart func = (vP) =>
            {
                onStart?.Invoke(data);
            };

            var fPtr = Marshal.GetFunctionPointerForDelegate(func);
            CallbackHandle handle = new CallbackHandle()
            {
                Value = fPtr
            };
            m_OnStartDelegates.TryAdd(handle, func);
            Functions.NT_SetListenerOnStart(fPtr, null);
            return handle;
        }

        public static unsafe CallbackHandle NT_SetListenerOnStart2<T>(NetworkTableInstance inst, Action<T> onStart, T data)
        {
            NT_OnStart func = (vP) =>
            {
                onStart?.Invoke(data);
            };

            var fPtr = Marshal.GetFunctionPointerForDelegate(func);
            CallbackHandle handle = new CallbackHandle()
            {
                Value = fPtr
            };
            m_OnStartDelegates.TryAdd(handle, func);
            Functions.NT_SetListenerOnStart2((NT_Inst)inst, fPtr, null);
            return handle;
        }

        public static unsafe void NT_SetListenerOnExit(NT_OnExit onExit, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetListenerOnExit2(NT_Inst inst, NT_OnExit onExit, void* data)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddEntryListener(byte* prefix, UIntPtr prefix_len, void* data, NT_EntryListenerCallback callback, uint flags)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddEntryListener2(NT_Inst inst, byte* prefix, UIntPtr prefix_len, void* data, NT_EntryListenerCallback2 callback, uint flags)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddEntryListenerSingle(NetworkTableEntry entry, void* data, NT_EntryListenerCallback2 callback, uint flags)
        {
            throw null;
        }

        public static unsafe void NT_RemoveEntryListener(NT_EntryListener entry_listener)
        {
            throw null;
        }

        public static unsafe NT_ConnectionListener NT_AddConnectionListener(void* data, NT_ConnectionListenerCallback callback, NT_Bool immediate_notify)
        {
            throw null;
        }

        public static unsafe NT_ConnectionListener NT_AddConnectionListener2(NT_Inst inst, void* data, NT_ConnectionListenerCallback callback, NT_Bool immediate_notify)
        {
            throw null;
        }

        public static unsafe void NT_RemoveConnectionListener(NT_ConnectionListener conn_listener)
        {
            throw null;
        }

        public static bool NT_NotifierDestroyed()
        {
            return Functions.NT_NotifierDestroyed().Get();
        }

        public static bool NT_NotifierDestroyed2(NetworkTableInstance inst)
        {
            return Functions.NT_NotifierDestroyed2((NT_Inst)inst).Get();
        }

        public static unsafe void NT_SetRpcServerOnStart(NT_Inst inst, NT_OnStart onStart, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetRpcServerOnExit(NT_Inst inst, NT_OnExit onExit, void* data)
        {
            throw null;
        }

        public static unsafe void NT_CreateRpc(NetworkTableEntry entry, byte* def, UIntPtr def_len, void* data, NT_RpcCallback callback)
        {
            throw null;
        }

        public static unsafe void NT_CreatePolledRpc(NetworkTableEntry entry, byte* def, UIntPtr def_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_PollRpc(NT_Inst inst, NT_RpcCallInfo* call_info)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_PollRpcTimeout(NT_Inst inst, NT_RpcCallInfo* call_info, double time_out)
        {
            throw null;
        }

        public static unsafe void NT_PostRpcResponse(NT_Entry rpc, NT_RpcCall call, byte* result, UIntPtr result_len)
        {
            throw null;
        }

        public static unsafe NT_RpcCall NT_CallRpc(NT_Entry rpc, byte* @params, UIntPtr params_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetRpcResult(NT_Entry rpc, NT_RpcCall call, UIntPtr* result_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetRpcResultTimeout(NT_Entry rpc, NT_RpcCall call, UIntPtr* result_len, double time_out)
        {
            throw null;
        }

        public static unsafe void NT_CancelRpcResult(NT_Entry rpc, NT_RpcCall call)
        {
            throw null;
        }

        public static unsafe byte* NT_PackRpcDefinition(NT_RpcDefinition* def, UIntPtr* packed_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_UnpackRpcDefinition(byte* packed, UIntPtr packed_len, NT_RpcDefinition* def)
        {
            throw null;
        }

        public static unsafe byte* NT_PackRpcValues(NT_Value** values, UIntPtr values_len, UIntPtr* packed_len)
        {
            throw null;
        }

        public static unsafe NT_Value** NT_UnpackRpcValues(byte* packed, UIntPtr packed_len, NT_Type* types, UIntPtr types_len)
        {
            throw null;
        }

        public static unsafe void NT_SetNetworkIdentity(string name)
        {
            throw null;
        }

        public static unsafe void NT_SetNetworkIdentity2(NT_Inst inst, string name)
        {
            throw null;
        }

        public static unsafe uint NT_GetNetworkMode()
        {
            throw null;
        }

        public static unsafe uint NT_GetNetworkMode2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StartServer(byte* persist_filename, byte* listen_address, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StartServer2(NT_Inst inst, byte* persist_filename, byte* listen_address, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StopServer()
        {
            throw null;
        }

        public static unsafe void NT_StopServer2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StartClientNone()
        {
            throw null;
        }

        public static unsafe void NT_StartClientNone2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StartClient(byte* server_name, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StartClient2(NT_Inst inst, byte* server_name, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StartClientMulti(UIntPtr count, byte** server_names, uint* ports)
        {
            throw null;
        }

        public static unsafe void NT_StartClientMulti2(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports)
        {
            throw null;
        }

        public static unsafe void NT_StopClient()
        {
            throw null;
        }

        public static unsafe void NT_StopClient2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetServer(byte* server_name, uint port)
        {
            throw null;
        }

        public static unsafe void NT_SetServer2(NT_Inst inst, byte* server_name, uint port)
        {
            throw null;
        }

        public static unsafe void NT_SetServerMulti(UIntPtr count, byte** server_names, uint* ports)
        {
            throw null;
        }

        public static unsafe void NT_SetServerMulti2(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports)
        {
            throw null;
        }

        public static unsafe void NT_StartDSClient(uint port)
        {
            throw null;
        }

        public static unsafe void NT_StartDSClient2(NT_Inst inst, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StopDSClient()
        {
            throw null;
        }

        public static unsafe void NT_StopDSClient2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StopRpcServer()
        {
            throw null;
        }

        public static unsafe void NT_StopRpcServer2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StopNotifier()
        {
            throw null;
        }

        public static unsafe void NT_StopNotifier2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetUpdateRate(double interval)
        {
            throw null;
        }

        public static unsafe void NT_SetUpdateRate2(NT_Inst inst, double interval)
        {
            throw null;
        }

        public static unsafe NT_ConnectionInfo* NT_GetConnections(UIntPtr* count)
        {
            throw null;
        }

        public static unsafe NT_ConnectionInfo* NT_GetConnections2(NT_Inst inst, UIntPtr* count)
        {
            throw null;
        }

        public static unsafe byte* NT_SavePersistent(byte* filename)
        {
            throw null;
        }

        public static unsafe byte* NT_SavePersistent2(NT_Inst inst, byte* filename)
        {
            throw null;
        }

        public static unsafe byte* NT_LoadPersistent(byte* filename, NT_WarnFunc warn)
        {
            throw null;
        }

        public static unsafe byte* NT_LoadPersistent2(NT_Inst inst, byte* filename, NT_WarnFunc warn)
        {
            throw null;
        }

        public static unsafe ulong NT_Now()
        {
            return Functions.NT_Now();
        }

        public static unsafe void NT_SetLogger(NT_LogFunc func, uint min_level)
        {
            throw null;
        }

        public static unsafe void NT_SetLogger2(NetworkTableInstance inst, NT_LogFunc func, uint min_level)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetValueBoolean(NT_Value* value, ulong* last_change, NT_Bool* v_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetValueDouble(NT_Value* value, ulong* last_change, double* v_double)
        {
            throw null;
        }

        public static unsafe byte* NT_GetValueString(NT_Value* value, ulong* last_change, UIntPtr* str_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetValueRaw(NT_Value* value, ulong* last_change, UIntPtr* raw_len)
        {
            throw null;
        }

        public static unsafe NT_Bool* NT_GetValueBooleanArray(NT_Value* value, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe double* NT_GetValueDoubleArray(NT_Value* value, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_String* NT_GetValueStringArray(NT_Value* value, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryBoolean(string name, ulong* last_change, NT_Bool* v_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryBoolean2(NetworkTableEntry entry, ulong* last_change, NT_Bool* v_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryDouble(string name, ulong* last_change, double* v_double)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryDouble2(NetworkTableEntry entry, ulong* last_change, double* v_double)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryString(string name, ulong* last_change, UIntPtr* str_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryString2(NetworkTableEntry entry, ulong* last_change, UIntPtr* str_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryRaw(string name, ulong* last_change, UIntPtr* raw_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryRaw2(NetworkTableEntry entry, ulong* last_change, UIntPtr* raw_len)
        {
            throw null;
        }

        public static unsafe NT_Bool* NT_GetEntryBooleanArray(string name, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_Bool* NT_GetEntryBooleanArray2(NetworkTableEntry entry, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe double* NT_GetEntryDoubleArray(string name, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe double* NT_GetEntryDoubleArray2(NetworkTableEntry entry, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_String* NT_GetEntryStringArray(string name, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_String* NT_GetEntryStringArray2(NetworkTableEntry entry, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBoolean(string name, NT_Bool default_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBoolean2(NetworkTableEntry entry, NT_Bool default_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDouble(string name, double default_double)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDouble2(NetworkTableEntry entry, double default_double)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryString(string name, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryString2(NetworkTableEntry entry, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryRaw(string name, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryRaw2(NetworkTableEntry entry, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBooleanArray(string name, int* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBooleanArray2(NetworkTableEntry entry, int* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDoubleArray(string name, double* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDoubleArray2(NetworkTableEntry entry, double* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryStringArray(string name, NT_String* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryStringArray2(NetworkTableEntry entry, NT_String* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBoolean(string name, NT_Bool v_boolean, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBoolean2(NetworkTableEntry entry, NT_Bool v_boolean, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDouble(string name, double v_double, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDouble2(NetworkTableEntry entry, double v_double, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryString(string name, byte* str, UIntPtr str_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryString2(NetworkTableEntry entry, byte* str, UIntPtr str_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryRaw(string name, byte* raw, UIntPtr raw_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryRaw2(NetworkTableEntry entry, byte* raw, UIntPtr raw_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBooleanArray(string name, int* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBooleanArray2(NetworkTableEntry entry, int* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDoubleArray(string name, double* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDoubleArray2(NetworkTableEntry entry, double* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe bool NT_SetEntryStringArray(string name, IList<string> arr, bool force)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_String* dataPtr = (NT_String*)Marshal.AllocHGlobal(arr.Count * Unsafe.SizeOf<NT_String>());

            for (int i = 0; i < arr.Count; i++)
            {
                CreateNtString(arr[i], &dataPtr[i]);
            }

            var ret = Functions.NT_SetEntryStringArray(nativeName.Buffer, nativeName.Length, dataPtr, (UIntPtr)arr.Count, force);

            for (int i = 0; i < arr.Count; i++)
            {
                DisposeNtString(&dataPtr[i]);
            }

            Marshal.FreeHGlobal((IntPtr)dataPtr);

            return ret.Get();
        }

        public static unsafe bool NT_SetEntryStringArray2(NetworkTableEntry entry, string[] arr, bool force)
        {
            NT_String* dataPtr = (NT_String*)Marshal.AllocHGlobal(arr.Length * Unsafe.SizeOf<NT_String>());

            for (int i = 0; i < arr.Length; i++)
            {
                CreateNtString(arr[i], &dataPtr[i]);
            }

            var ret = Functions.NT_SetEntryStringArray2((NT_Entry)entry, dataPtr, (UIntPtr)arr.Length, force);

            for (int i = 0; i < arr.Length; i++)
            {
                DisposeNtString(&dataPtr[i]);
            }

            Marshal.FreeHGlobal((IntPtr)dataPtr);

            return ret.Get();
        }

        internal static unsafe void CreateNtString(string vStr, NT_String* nStr)
        {
            fixed (char* str = vStr)
            {
                var encoding = Encoding.UTF8;
                int bytes = encoding.GetByteCount(vStr);
                nStr->str = (byte*)Marshal.AllocHGlobal((bytes) * sizeof(byte));
                nStr->len = (UIntPtr)bytes;
                encoding.GetBytes(str, vStr.Length, nStr->str, bytes);
            }
        }

        internal static unsafe void DisposeNtString(NT_String* str)
        {
            Marshal.FreeHGlobal((IntPtr)str->str);
        }

    }
}
