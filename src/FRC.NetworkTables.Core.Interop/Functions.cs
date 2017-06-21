using System;

namespace FRC.NetworkTables.Core.Interop
{
    public static class Functions
    {
        public static unsafe NT_Inst NT_GetDefaultInstance()
        {
            return NT_GetDefaultInstance();
        }

        public static unsafe NT_Inst NT_CreateInstance()
        {
            return NT_CreateInstance();
        }

        public static unsafe void NT_DestroyInstance(NT_Inst inst)
        {
            NT_DestroyInstance(inst);
        }

        public static unsafe NT_Inst NT_GetInstanceFromHandle(NT_Handle handle)
        {
            return NT_GetInstanceFromHandle(handle);
        }

        public static unsafe NT_Entry NT_GetEntry(NT_Inst inst, byte* name, UIntPtr name_len)
        {
            return NT_GetEntry(inst, name, name_len);
        }

        public static unsafe NT_Entry NT_GetEntries(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            return NT_GetEntries(inst, prefix, prefix_len, types, count);
        }

        public static unsafe byte NT_GetEntryName(NT_Entry entry, UIntPtr* name_len)
        {
            return NT_GetEntryName(entry, name_len);
        }

        public static unsafe ulong NT_GetEntryLastChange(NT_Entry entry)
        {
            return NT_GetEntryLastChange(entry);
        }

        public static unsafe void NT_GetEntryValue(byte* name, UIntPtr name_len, NT_Value* value)
        {
            NT_GetEntryValue(name, name_len, value);
        }

        public static unsafe void NT_GetEntryValue2(NT_Entry entry, NT_Value* value)
        {
            NT_GetEntryValue2(entry, value);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryValue(byte* name, UIntPtr name_len, NT_Value* default_value)
        {
            return NT_SetDefaultEntryValue(name, name_len, default_value);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryValue2(NT_Entry entry, NT_Value* default_value)
        {
            return NT_SetDefaultEntryValue2(entry, default_value);
        }

        public static unsafe NT_Bool NT_SetEntryValue(byte* name, UIntPtr name_len, NT_Value* value)
        {
            return NT_SetEntryValue(name, name_len, value);
        }

        public static unsafe NT_Bool NT_SetEntryValue2(NT_Entry entry, NT_Value* value)
        {
            return NT_SetEntryValue2(entry, value);
        }

        public static unsafe void NT_SetEntryTypeValue(byte* name, UIntPtr name_len, NT_Value* value)
        {
            NT_SetEntryTypeValue(name, name_len, value);
        }

        public static unsafe void NT_SetEntryTypeValue2(NT_Entry entry, NT_Value* value)
        {
            NT_SetEntryTypeValue2(entry, value);
        }

        public static unsafe void NT_SetEntryFlags(byte* name, UIntPtr name_len, uint flags)
        {
            NT_SetEntryFlags(name, name_len, flags);
        }

        public static unsafe void NT_SetEntryFlags2(NT_Entry entry, uint flags)
        {
            NT_SetEntryFlags2(entry, flags);
        }

        public static unsafe uint NT_GetEntryFlags(byte* name, UIntPtr name_len)
        {
            return NT_GetEntryFlags(name, name_len);
        }

        public static unsafe uint NT_GetEntryFlags2(NT_Entry entry)
        {
            return NT_GetEntryFlags2(entry);
        }

        public static unsafe void NT_DeleteEntry(byte* name, UIntPtr name_len)
        {
            NT_DeleteEntry(name, name_len);
        }

        public static unsafe void NT_DeleteEntry2(NT_Entry entry)
        {
            NT_DeleteEntry2(entry);
        }

        public static unsafe void NT_DeleteAllEntries()
        {
            NT_DeleteAllEntries();
        }

        public static unsafe void NT_DeleteAllEntries2(NT_Inst inst)
        {
            NT_DeleteAllEntries2(inst);
        }

        public static unsafe NT_EntryInfo NT_GetEntryInfo(byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            return NT_GetEntryInfo(prefix, prefix_len, types, count);
        }

        public static unsafe NT_EntryInfo2 NT_GetEntryInfo2(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            return NT_GetEntryInfo2(inst, prefix, prefix_len, types, count);
        }

        public static unsafe NT_EntryInfo2 NT_GetEntryInfoHandle(NT_Entry entry)
        {
            return NT_GetEntryInfoHandle(entry);
        }

        public static unsafe void NT_Flush()
        {
            NT_Flush();
        }

        public static unsafe void NT_Flush2(NT_Inst inst)
        {
            NT_Flush2(inst);
        }

        public static unsafe void NT_SetListenerOnStart(NT_OnStart onStart, void* data)
        {
            NT_SetListenerOnStart(onStart, data);
        }

        public static unsafe void NT_SetListenerOnStart2(NT_Inst inst, NT_OnStart onStart, void* data)
        {
            NT_SetListenerOnStart2(inst, onStart, data);
        }

        public static unsafe void NT_SetListenerOnExit(NT_OnExit onExit, void* data)
        {
            NT_SetListenerOnExit(onExit, data);
        }

        public static unsafe void NT_SetListenerOnExit2(NT_Inst inst, NT_OnExit onExit, void* data)
        {
            NT_SetListenerOnExit2(inst, onExit, data);
        }

        public static unsafe NT_EntryListener NT_AddEntryListener(byte* prefix, UIntPtr prefix_len, void* data, NT_EntryListenerCallback callback, uint flags)
        {
            return NT_AddEntryListener(prefix, prefix_len, data, callback, flags);
        }

        public static unsafe NT_EntryListener NT_AddEntryListener2(NT_Inst inst, byte* prefix, UIntPtr prefix_len, void* data, NT_EntryListenerCallback2 callback, uint flags)
        {
            return NT_AddEntryListener2(inst, prefix, prefix_len, data, callback, flags);
        }

        public static unsafe NT_EntryListener NT_AddEntryListenerSingle(NT_Entry entry, void* data, NT_EntryListenerCallback2 callback, uint flags)
        {
            return NT_AddEntryListenerSingle(entry, data, callback, flags);
        }

        public static unsafe void NT_RemoveEntryListener(NT_EntryListener entry_listener)
        {
            NT_RemoveEntryListener(entry_listener);
        }

        public static unsafe NT_ConnectionListener NT_AddConnectionListener(void* data, NT_ConnectionListenerCallback callback, NT_Bool immediate_notify)
        {
            return NT_AddConnectionListener(data, callback, immediate_notify);
        }

        public static unsafe NT_ConnectionListener NT_AddConnectionListener2(NT_Inst inst, void* data, NT_ConnectionListenerCallback callback, NT_Bool immediate_notify)
        {
            return NT_AddConnectionListener2(inst, data, callback, immediate_notify);
        }

        public static unsafe void NT_RemoveConnectionListener(NT_ConnectionListener conn_listener)
        {
            NT_RemoveConnectionListener(conn_listener);
        }

        public static unsafe NT_Bool NT_NotifierDestroyed()
        {
            return NT_NotifierDestroyed();
        }

        public static unsafe NT_Bool NT_NotifierDestroyed2(NT_Inst inst)
        {
            return NT_NotifierDestroyed2(inst);
        }

        public static unsafe void NT_SetRpcServerOnStart(NT_Inst inst, NT_OnStart onStart, void* data)
        {
            NT_SetRpcServerOnStart(inst, onStart, data);
        }

        public static unsafe void NT_SetRpcServerOnExit(NT_Inst inst, NT_OnExit onExit, void* data)
        {
            NT_SetRpcServerOnExit(inst, onExit, data);
        }

        public static unsafe void NT_CreateRpc(NT_Entry entry, byte* def, UIntPtr def_len, void* data, NT_RpcCallback callback)
        {
            NT_CreateRpc(entry, def, def_len, data, callback);
        }

        public static unsafe void NT_CreatePolledRpc(NT_Entry entry, byte* def, UIntPtr def_len)
        {
            NT_CreatePolledRpc(entry, def, def_len);
        }

        public static unsafe NT_Bool NT_PollRpc(NT_Inst inst, NT_RpcCallInfo* call_info)
        {
            return NT_PollRpc(inst, call_info);
        }

        public static unsafe NT_Bool NT_PollRpcTimeout(NT_Inst inst, NT_RpcCallInfo* call_info, double time_out)
        {
            return NT_PollRpcTimeout(inst, call_info, time_out);
        }

        public static unsafe void NT_PostRpcResponse(NT_Entry rpc, NT_RpcCall call, byte* result, UIntPtr result_len)
        {
            NT_PostRpcResponse(rpc, call, result, result_len);
        }

        public static unsafe NT_RpcCall NT_CallRpc(NT_Entry rpc, byte* @params, UIntPtr params_len)
        {
            return NT_CallRpc(rpc, @params, params_len);
        }

        public static unsafe byte NT_GetRpcResult(NT_Entry rpc, NT_RpcCall call, UIntPtr* result_len)
        {
            return NT_GetRpcResult(rpc, call, result_len);
        }

        public static unsafe byte NT_GetRpcResultTimeout(NT_Entry rpc, NT_RpcCall call, UIntPtr* result_len, double time_out)
        {
            return NT_GetRpcResultTimeout(rpc, call, result_len, time_out);
        }

        public static unsafe void NT_CancelRpcResult(NT_Entry rpc, NT_RpcCall call)
        {
            NT_CancelRpcResult(rpc, call);
        }

        public static unsafe byte NT_PackRpcDefinition(NT_RpcDefinition* def, UIntPtr* packed_len)
        {
            return NT_PackRpcDefinition(def, packed_len);
        }

        public static unsafe NT_Bool NT_UnpackRpcDefinition(byte* packed, UIntPtr packed_len, NT_RpcDefinition* def)
        {
            return NT_UnpackRpcDefinition(packed, packed_len, def);
        }

        public static unsafe byte NT_PackRpcValues(NT_Value** values, UIntPtr values_len, UIntPtr* packed_len)
        {
            return NT_PackRpcValues(values, values_len, packed_len);
        }

        public static unsafe NT_Value NT_UnpackRpcValues(byte* packed, UIntPtr packed_len, NT_Type* types, UIntPtr types_len)
        {
            return NT_UnpackRpcValues(packed, packed_len, types, types_len);
        }

        public static unsafe void NT_SetNetworkIdentity(byte* name, UIntPtr name_len)
        {
            NT_SetNetworkIdentity(name, name_len);
        }

        public static unsafe void NT_SetNetworkIdentity2(NT_Inst inst, byte* name, UIntPtr name_len)
        {
            NT_SetNetworkIdentity2(inst, name, name_len);
        }

        public static unsafe uint NT_GetNetworkMode()
        {
            return NT_GetNetworkMode();
        }

        public static unsafe uint NT_GetNetworkMode2(NT_Inst inst)
        {
            return NT_GetNetworkMode2(inst);
        }

        public static unsafe void NT_StartServer(byte* persist_filename, byte* listen_address, uint port)
        {
            NT_StartServer(persist_filename, listen_address, port);
        }

        public static unsafe void NT_StartServer2(NT_Inst inst, byte* persist_filename, byte* listen_address, uint port)
        {
            NT_StartServer2(inst, persist_filename, listen_address, port);
        }

        public static unsafe void NT_StopServer()
        {
            NT_StopServer();
        }

        public static unsafe void NT_StopServer2(NT_Inst inst)
        {
            NT_StopServer2(inst);
        }

        public static unsafe void NT_StartClientNone()
        {
            NT_StartClientNone();
        }

        public static unsafe void NT_StartClientNone2(NT_Inst inst)
        {
            NT_StartClientNone2(inst);
        }

        public static unsafe void NT_StartClient(byte* server_name, uint port)
        {
            NT_StartClient(server_name, port);
        }

        public static unsafe void NT_StartClient2(NT_Inst inst, byte* server_name, uint port)
        {
            NT_StartClient2(inst, server_name, port);
        }

        public static unsafe void NT_StartClientMulti(UIntPtr count, byte** server_names, uint* ports)
        {
            NT_StartClientMulti(count, server_names, ports);
        }

        public static unsafe void NT_StartClientMulti2(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports)
        {
            NT_StartClientMulti2(inst, count, server_names, ports);
        }

        public static unsafe void NT_StopClient()
        {
            NT_StopClient();
        }

        public static unsafe void NT_StopClient2(NT_Inst inst)
        {
            NT_StopClient2(inst);
        }

        public static unsafe void NT_SetServer(byte* server_name, uint port)
        {
            NT_SetServer(server_name, port);
        }

        public static unsafe void NT_SetServer2(NT_Inst inst, byte* server_name, uint port)
        {
            NT_SetServer2(inst, server_name, port);
        }

        public static unsafe void NT_SetServerMulti(UIntPtr count, byte** server_names, uint* ports)
        {
            NT_SetServerMulti(count, server_names, ports);
        }

        public static unsafe void NT_SetServerMulti2(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports)
        {
            NT_SetServerMulti2(inst, count, server_names, ports);
        }

        public static unsafe void NT_StartDSClient(uint port)
        {
            NT_StartDSClient(port);
        }

        public static unsafe void NT_StartDSClient2(NT_Inst inst, uint port)
        {
            NT_StartDSClient2(inst, port);
        }

        public static unsafe void NT_StopDSClient()
        {
            NT_StopDSClient();
        }

        public static unsafe void NT_StopDSClient2(NT_Inst inst)
        {
            NT_StopDSClient2(inst);
        }

        public static unsafe void NT_StopRpcServer()
        {
            NT_StopRpcServer();
        }

        public static unsafe void NT_StopRpcServer2(NT_Inst inst)
        {
            NT_StopRpcServer2(inst);
        }

        public static unsafe void NT_StopNotifier()
        {
            NT_StopNotifier();
        }

        public static unsafe void NT_StopNotifier2(NT_Inst inst)
        {
            NT_StopNotifier2(inst);
        }

        public static unsafe void NT_SetUpdateRate(double interval)
        {
            NT_SetUpdateRate(interval);
        }

        public static unsafe void NT_SetUpdateRate2(NT_Inst inst, double interval)
        {
            NT_SetUpdateRate2(inst, interval);
        }

        public static unsafe NT_ConnectionInfo NT_GetConnections(UIntPtr* count)
        {
            return NT_GetConnections(count);
        }

        public static unsafe NT_ConnectionInfo NT_GetConnections2(NT_Inst inst, UIntPtr* count)
        {
            return NT_GetConnections2(inst, count);
        }

        public static unsafe byte NT_SavePersistent(byte* filename)
        {
            return NT_SavePersistent(filename);
        }

        public static unsafe byte NT_SavePersistent2(NT_Inst inst, byte* filename)
        {
            return NT_SavePersistent2(inst, filename);
        }

        public static unsafe byte NT_LoadPersistent(byte* filename, NT_WarnFunc warn)
        {
            return NT_LoadPersistent(filename, warn);
        }

        public static unsafe byte NT_LoadPersistent2(NT_Inst inst, byte* filename, NT_WarnFunc warn)
        {
            return NT_LoadPersistent2(inst, filename, warn);
        }

        public static unsafe void NT_DisposeValue(NT_Value* value)
        {
            NT_DisposeValue(value);
        }

        public static unsafe void NT_InitValue(NT_Value* value)
        {
            NT_InitValue(value);
        }

        public static unsafe void NT_DisposeString(NT_String* str)
        {
            NT_DisposeString(str);
        }

        public static unsafe void NT_InitString(NT_String* str)
        {
            NT_InitString(str);
        }

        public static unsafe void NT_DisposeEntryArray(NT_Entry* arr, UIntPtr count)
        {
            NT_DisposeEntryArray(arr, count);
        }

        public static unsafe void NT_DisposeConnectionInfoArray(NT_ConnectionInfo* arr, UIntPtr count)
        {
            NT_DisposeConnectionInfoArray(arr, count);
        }

        public static unsafe void NT_DisposeEntryInfoArray(NT_EntryInfo* arr, UIntPtr count)
        {
            NT_DisposeEntryInfoArray(arr, count);
        }

        public static unsafe void NT_DisposeEntryInfoArray2(NT_EntryInfo2* arr, UIntPtr count)
        {
            NT_DisposeEntryInfoArray2(arr, count);
        }

        public static unsafe void NT_DisposeRpcDefinition(NT_RpcDefinition* def)
        {
            NT_DisposeRpcDefinition(def);
        }

        public static unsafe void NT_DisposeRpcCallInfo(NT_RpcCallInfo* call_info)
        {
            NT_DisposeRpcCallInfo(call_info);
        }

        public static unsafe ulong NT_Now()
        {
            return NT_Now();
        }

        public static unsafe void NT_SetLogger(NT_LogFunc func, uint min_level)
        {
            NT_SetLogger(func, min_level);
        }

        public static unsafe void NT_SetLogger2(NT_Inst inst, NT_LogFunc func, uint min_level)
        {
            NT_SetLogger2(inst, func, min_level);
        }

        public static unsafe byte NT_AllocateCharArray(UIntPtr size)
        {
            return NT_AllocateCharArray(size);
        }

        public static unsafe NT_Bool NT_AllocateBooleanArray(UIntPtr size)
        {
            return NT_AllocateBooleanArray(size);
        }

        public static unsafe double NT_AllocateDoubleArray(UIntPtr size)
        {
            return NT_AllocateDoubleArray(size);
        }

        public static unsafe NT_String NT_AllocateStringArray(UIntPtr size)
        {
            return NT_AllocateStringArray(size);
        }

        public static unsafe void NT_FreeCharArray(byte* v_char)
        {
            NT_FreeCharArray(v_char);
        }

        public static unsafe void NT_FreeDoubleArray(double* v_double)
        {
            NT_FreeDoubleArray(v_double);
        }

        public static unsafe void NT_FreeBooleanArray(NT_Bool* v_boolean)
        {
            NT_FreeBooleanArray(v_boolean);
        }

        public static unsafe void NT_FreeStringArray(NT_String* v_string, UIntPtr arr_size)
        {
            NT_FreeStringArray(v_string, arr_size);
        }

        public static unsafe NT_Bool NT_GetValueBoolean(NT_Value* value, ulong* last_change, NT_Bool* v_boolean)
        {
            return NT_GetValueBoolean(value, last_change, v_boolean);
        }

        public static unsafe NT_Bool NT_GetValueDouble(NT_Value* value, ulong* last_change, double* v_double)
        {
            return NT_GetValueDouble(value, last_change, v_double);
        }

        public static unsafe byte NT_GetValueString(NT_Value* value, ulong* last_change, UIntPtr* str_len)
        {
            return NT_GetValueString(value, last_change, str_len);
        }

        public static unsafe byte NT_GetValueRaw(NT_Value* value, ulong* last_change, UIntPtr* raw_len)
        {
            return NT_GetValueRaw(value, last_change, raw_len);
        }

        public static unsafe NT_Bool NT_GetValueBooleanArray(NT_Value* value, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetValueBooleanArray(value, last_change, arr_size);
        }

        public static unsafe double NT_GetValueDoubleArray(NT_Value* value, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetValueDoubleArray(value, last_change, arr_size);
        }

        public static unsafe NT_String NT_GetValueStringArray(NT_Value* value, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetValueStringArray(value, last_change, arr_size);
        }

        public static unsafe NT_Bool NT_GetEntryBoolean(byte* name, UIntPtr name_len, ulong* last_change, NT_Bool* v_boolean)
        {
            return NT_GetEntryBoolean(name, name_len, last_change, v_boolean);
        }

        public static unsafe NT_Bool NT_GetEntryBoolean2(NT_Entry entry, ulong* last_change, NT_Bool* v_boolean)
        {
            return NT_GetEntryBoolean2(entry, last_change, v_boolean);
        }

        public static unsafe NT_Bool NT_GetEntryDouble(byte* name, UIntPtr name_len, ulong* last_change, double* v_double)
        {
            return NT_GetEntryDouble(name, name_len, last_change, v_double);
        }

        public static unsafe NT_Bool NT_GetEntryDouble2(NT_Entry entry, ulong* last_change, double* v_double)
        {
            return NT_GetEntryDouble2(entry, last_change, v_double);
        }

        public static unsafe byte NT_GetEntryString(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* str_len)
        {
            return NT_GetEntryString(name, name_len, last_change, str_len);
        }

        public static unsafe byte NT_GetEntryString2(NT_Entry entry, ulong* last_change, UIntPtr* str_len)
        {
            return NT_GetEntryString2(entry, last_change, str_len);
        }

        public static unsafe byte NT_GetEntryRaw(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* raw_len)
        {
            return NT_GetEntryRaw(name, name_len, last_change, raw_len);
        }

        public static unsafe byte NT_GetEntryRaw2(NT_Entry entry, ulong* last_change, UIntPtr* raw_len)
        {
            return NT_GetEntryRaw2(entry, last_change, raw_len);
        }

        public static unsafe NT_Bool NT_GetEntryBooleanArray(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetEntryBooleanArray(name, name_len, last_change, arr_size);
        }

        public static unsafe NT_Bool NT_GetEntryBooleanArray2(NT_Entry entry, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetEntryBooleanArray2(entry, last_change, arr_size);
        }

        public static unsafe double NT_GetEntryDoubleArray(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetEntryDoubleArray(name, name_len, last_change, arr_size);
        }

        public static unsafe double NT_GetEntryDoubleArray2(NT_Entry entry, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetEntryDoubleArray2(entry, last_change, arr_size);
        }

        public static unsafe NT_String NT_GetEntryStringArray(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetEntryStringArray(name, name_len, last_change, arr_size);
        }

        public static unsafe NT_String NT_GetEntryStringArray2(NT_Entry entry, ulong* last_change, UIntPtr* arr_size)
        {
            return NT_GetEntryStringArray2(entry, last_change, arr_size);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBoolean(byte* name, UIntPtr name_len, NT_Bool default_boolean)
        {
            return NT_SetDefaultEntryBoolean(name, name_len, default_boolean);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBoolean2(NT_Entry entry, NT_Bool default_boolean)
        {
            return NT_SetDefaultEntryBoolean2(entry, default_boolean);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDouble(byte* name, UIntPtr name_len, double default_double)
        {
            return NT_SetDefaultEntryDouble(name, name_len, default_double);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDouble2(NT_Entry entry, double default_double)
        {
            return NT_SetDefaultEntryDouble2(entry, default_double);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryString(byte* name, UIntPtr name_len, byte* default_value, UIntPtr default_len)
        {
            return NT_SetDefaultEntryString(name, name_len, default_value, default_len);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryString2(NT_Entry entry, byte* default_value, UIntPtr default_len)
        {
            return NT_SetDefaultEntryString2(entry, default_value, default_len);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryRaw(byte* name, UIntPtr name_len, byte* default_value, UIntPtr default_len)
        {
            return NT_SetDefaultEntryRaw(name, name_len, default_value, default_len);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryRaw2(NT_Entry entry, byte* default_value, UIntPtr default_len)
        {
            return NT_SetDefaultEntryRaw2(entry, default_value, default_len);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBooleanArray(byte* name, UIntPtr name_len, int* default_value, UIntPtr default_size)
        {
            return NT_SetDefaultEntryBooleanArray(name, name_len, default_value, default_size);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBooleanArray2(NT_Entry entry, int* default_value, UIntPtr default_size)
        {
            return NT_SetDefaultEntryBooleanArray2(entry, default_value, default_size);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDoubleArray(byte* name, UIntPtr name_len, double* default_value, UIntPtr default_size)
        {
            return NT_SetDefaultEntryDoubleArray(name, name_len, default_value, default_size);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDoubleArray2(NT_Entry entry, double* default_value, UIntPtr default_size)
        {
            return NT_SetDefaultEntryDoubleArray2(entry, default_value, default_size);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryStringArray(byte* name, UIntPtr name_len, NT_String* default_value, UIntPtr default_size)
        {
            return NT_SetDefaultEntryStringArray(name, name_len, default_value, default_size);
        }

        public static unsafe NT_Bool NT_SetDefaultEntryStringArray2(NT_Entry entry, NT_String* default_value, UIntPtr default_size)
        {
            return NT_SetDefaultEntryStringArray2(entry, default_value, default_size);
        }

        public static unsafe NT_Bool NT_SetEntryBoolean(byte* name, UIntPtr name_len, NT_Bool v_boolean, NT_Bool force)
        {
            return NT_SetEntryBoolean(name, name_len, v_boolean, force);
        }

        public static unsafe NT_Bool NT_SetEntryBoolean2(NT_Entry entry, NT_Bool v_boolean, NT_Bool force)
        {
            return NT_SetEntryBoolean2(entry, v_boolean, force);
        }

        public static unsafe NT_Bool NT_SetEntryDouble(byte* name, UIntPtr name_len, double v_double, NT_Bool force)
        {
            return NT_SetEntryDouble(name, name_len, v_double, force);
        }

        public static unsafe NT_Bool NT_SetEntryDouble2(NT_Entry entry, double v_double, NT_Bool force)
        {
            return NT_SetEntryDouble2(entry, v_double, force);
        }

        public static unsafe NT_Bool NT_SetEntryString(byte* name, UIntPtr name_len, byte* str, UIntPtr str_len, NT_Bool force)
        {
            return NT_SetEntryString(name, name_len, str, str_len, force);
        }

        public static unsafe NT_Bool NT_SetEntryString2(NT_Entry entry, byte* str, UIntPtr str_len, NT_Bool force)
        {
            return NT_SetEntryString2(entry, str, str_len, force);
        }

        public static unsafe NT_Bool NT_SetEntryRaw(byte* name, UIntPtr name_len, byte* raw, UIntPtr raw_len, NT_Bool force)
        {
            return NT_SetEntryRaw(name, name_len, raw, raw_len, force);
        }

        public static unsafe NT_Bool NT_SetEntryRaw2(NT_Entry entry, byte* raw, UIntPtr raw_len, NT_Bool force)
        {
            return NT_SetEntryRaw2(entry, raw, raw_len, force);
        }

        public static unsafe NT_Bool NT_SetEntryBooleanArray(byte* name, UIntPtr name_len, int* arr, UIntPtr size, NT_Bool force)
        {
            return NT_SetEntryBooleanArray(name, name_len, arr, size, force);
        }

        public static unsafe NT_Bool NT_SetEntryBooleanArray2(NT_Entry entry, int* arr, UIntPtr size, NT_Bool force)
        {
            return NT_SetEntryBooleanArray2(entry, arr, size, force);
        }

        public static unsafe NT_Bool NT_SetEntryDoubleArray(byte* name, UIntPtr name_len, double* arr, UIntPtr size, NT_Bool force)
        {
            return NT_SetEntryDoubleArray(name, name_len, arr, size, force);
        }

        public static unsafe NT_Bool NT_SetEntryDoubleArray2(NT_Entry entry, double* arr, UIntPtr size, NT_Bool force)
        {
            return NT_SetEntryDoubleArray2(entry, arr, size, force);
        }

        public static unsafe NT_Bool NT_SetEntryStringArray(byte* name, UIntPtr name_len, NT_String* arr, UIntPtr size, NT_Bool force)
        {
            return NT_SetEntryStringArray(name, name_len, arr, size, force);
        }

        public static unsafe NT_Bool NT_SetEntryStringArray2(NT_Entry entry, NT_String* arr, UIntPtr size, NT_Bool force)
        {
            return NT_SetEntryStringArray2(entry, arr, size, force);
        }
    }
}