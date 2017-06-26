using System;

namespace FRC.NetworkTables.Core.Interop
{
    public static class Functions
    {
        public static IntPtr NT_GetDefaultInstanceFunctionPointer;
        public static IntPtr NT_CreateInstanceFunctionPointer;
        public static IntPtr NT_DestroyInstanceFunctionPointer;
        public static IntPtr NT_GetInstanceFromHandleFunctionPointer;
        public static IntPtr NT_GetEntryFunctionPointer;
        public static IntPtr NT_GetEntriesFunctionPointer;
        public static IntPtr NT_GetEntryNameFunctionPointer;
        public static IntPtr NT_GetEntryLastChangeFunctionPointer;
        public static IntPtr NT_GetEntryValueFunctionPointer;
        public static IntPtr NT_GetEntryValue2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryValueFunctionPointer;
        public static IntPtr NT_SetDefaultEntryValue2FunctionPointer;
        public static IntPtr NT_SetEntryValueFunctionPointer;
        public static IntPtr NT_SetEntryValue2FunctionPointer;
        public static IntPtr NT_SetEntryTypeValueFunctionPointer;
        public static IntPtr NT_SetEntryTypeValue2FunctionPointer;
        public static IntPtr NT_SetEntryFlagsFunctionPointer;
        public static IntPtr NT_SetEntryFlags2FunctionPointer;
        public static IntPtr NT_GetEntryFlagsFunctionPointer;
        public static IntPtr NT_GetEntryFlags2FunctionPointer;
        public static IntPtr NT_DeleteEntryFunctionPointer;
        public static IntPtr NT_DeleteEntry2FunctionPointer;
        public static IntPtr NT_DeleteAllEntriesFunctionPointer;
        public static IntPtr NT_DeleteAllEntries2FunctionPointer;
        public static IntPtr NT_GetEntryInfoFunctionPointer;
        public static IntPtr NT_GetEntryInfo2FunctionPointer;
        public static IntPtr NT_GetEntryInfoHandleFunctionPointer;
        public static IntPtr NT_FlushFunctionPointer;
        public static IntPtr NT_Flush2FunctionPointer;
        public static IntPtr NT_SetListenerOnStartFunctionPointer;
        public static IntPtr NT_SetListenerOnStart2FunctionPointer;
        public static IntPtr NT_SetListenerOnExitFunctionPointer;
        public static IntPtr NT_SetListenerOnExit2FunctionPointer;
        public static IntPtr NT_AddEntryListenerFunctionPointer;
        public static IntPtr NT_AddEntryListener2FunctionPointer;
        public static IntPtr NT_AddEntryListenerSingleFunctionPointer;
        public static IntPtr NT_RemoveEntryListenerFunctionPointer;
        public static IntPtr NT_AddConnectionListenerFunctionPointer;
        public static IntPtr NT_AddConnectionListener2FunctionPointer;
        public static IntPtr NT_RemoveConnectionListenerFunctionPointer;
        public static IntPtr NT_NotifierDestroyedFunctionPointer;
        public static IntPtr NT_NotifierDestroyed2FunctionPointer;
        public static IntPtr NT_SetRpcServerOnStartFunctionPointer;
        public static IntPtr NT_SetRpcServerOnExitFunctionPointer;
        public static IntPtr NT_CreateRpcFunctionPointer;
        public static IntPtr NT_CreatePolledRpcFunctionPointer;
        public static IntPtr NT_PollRpcFunctionPointer;
        public static IntPtr NT_PollRpcTimeoutFunctionPointer;
        public static IntPtr NT_PostRpcResponseFunctionPointer;
        public static IntPtr NT_CallRpcFunctionPointer;
        public static IntPtr NT_GetRpcResultFunctionPointer;
        public static IntPtr NT_GetRpcResultTimeoutFunctionPointer;
        public static IntPtr NT_CancelRpcResultFunctionPointer;
        public static IntPtr NT_PackRpcDefinitionFunctionPointer;
        public static IntPtr NT_UnpackRpcDefinitionFunctionPointer;
        public static IntPtr NT_PackRpcValuesFunctionPointer;
        public static IntPtr NT_UnpackRpcValuesFunctionPointer;
        public static IntPtr NT_SetNetworkIdentityFunctionPointer;
        public static IntPtr NT_SetNetworkIdentity2FunctionPointer;
        public static IntPtr NT_GetNetworkModeFunctionPointer;
        public static IntPtr NT_GetNetworkMode2FunctionPointer;
        public static IntPtr NT_StartServerFunctionPointer;
        public static IntPtr NT_StartServer2FunctionPointer;
        public static IntPtr NT_StopServerFunctionPointer;
        public static IntPtr NT_StopServer2FunctionPointer;
        public static IntPtr NT_StartClientNoneFunctionPointer;
        public static IntPtr NT_StartClientNone2FunctionPointer;
        public static IntPtr NT_StartClientFunctionPointer;
        public static IntPtr NT_StartClient2FunctionPointer;
        public static IntPtr NT_StartClientMultiFunctionPointer;
        public static IntPtr NT_StartClientMulti2FunctionPointer;
        public static IntPtr NT_StopClientFunctionPointer;
        public static IntPtr NT_StopClient2FunctionPointer;
        public static IntPtr NT_SetServerFunctionPointer;
        public static IntPtr NT_SetServer2FunctionPointer;
        public static IntPtr NT_SetServerMultiFunctionPointer;
        public static IntPtr NT_SetServerMulti2FunctionPointer;
        public static IntPtr NT_StartDSClientFunctionPointer;
        public static IntPtr NT_StartDSClient2FunctionPointer;
        public static IntPtr NT_StopDSClientFunctionPointer;
        public static IntPtr NT_StopDSClient2FunctionPointer;
        public static IntPtr NT_StopRpcServerFunctionPointer;
        public static IntPtr NT_StopRpcServer2FunctionPointer;
        public static IntPtr NT_StopNotifierFunctionPointer;
        public static IntPtr NT_StopNotifier2FunctionPointer;
        public static IntPtr NT_SetUpdateRateFunctionPointer;
        public static IntPtr NT_SetUpdateRate2FunctionPointer;
        public static IntPtr NT_GetConnectionsFunctionPointer;
        public static IntPtr NT_GetConnections2FunctionPointer;
        public static IntPtr NT_SavePersistentFunctionPointer;
        public static IntPtr NT_SavePersistent2FunctionPointer;
        public static IntPtr NT_LoadPersistentFunctionPointer;
        public static IntPtr NT_LoadPersistent2FunctionPointer;
        public static IntPtr NT_DisposeValueFunctionPointer;
        public static IntPtr NT_InitValueFunctionPointer;
        public static IntPtr NT_DisposeStringFunctionPointer;
        public static IntPtr NT_InitStringFunctionPointer;
        public static IntPtr NT_DisposeEntryArrayFunctionPointer;
        public static IntPtr NT_DisposeConnectionInfoArrayFunctionPointer;
        public static IntPtr NT_DisposeEntryInfoArrayFunctionPointer;
        public static IntPtr NT_DisposeEntryInfoArray2FunctionPointer;
        public static IntPtr NT_DisposeRpcDefinitionFunctionPointer;
        public static IntPtr NT_DisposeRpcCallInfoFunctionPointer;
        public static IntPtr NT_NowFunctionPointer;
        public static IntPtr NT_SetLoggerFunctionPointer;
        public static IntPtr NT_SetLogger2FunctionPointer;
        public static IntPtr NT_AllocateCharArrayFunctionPointer;
        public static IntPtr NT_AllocateBooleanArrayFunctionPointer;
        public static IntPtr NT_AllocateDoubleArrayFunctionPointer;
        public static IntPtr NT_AllocateStringArrayFunctionPointer;
        public static IntPtr NT_FreeCharArrayFunctionPointer;
        public static IntPtr NT_FreeDoubleArrayFunctionPointer;
        public static IntPtr NT_FreeBooleanArrayFunctionPointer;
        public static IntPtr NT_FreeStringArrayFunctionPointer;
        public static IntPtr NT_GetValueBooleanFunctionPointer;
        public static IntPtr NT_GetValueDoubleFunctionPointer;
        public static IntPtr NT_GetValueStringFunctionPointer;
        public static IntPtr NT_GetValueRawFunctionPointer;
        public static IntPtr NT_GetValueBooleanArrayFunctionPointer;
        public static IntPtr NT_GetValueDoubleArrayFunctionPointer;
        public static IntPtr NT_GetValueStringArrayFunctionPointer;
        public static IntPtr NT_GetEntryBooleanFunctionPointer;
        public static IntPtr NT_GetEntryBoolean2FunctionPointer;
        public static IntPtr NT_GetEntryDoubleFunctionPointer;
        public static IntPtr NT_GetEntryDouble2FunctionPointer;
        public static IntPtr NT_GetEntryStringFunctionPointer;
        public static IntPtr NT_GetEntryString2FunctionPointer;
        public static IntPtr NT_GetEntryRawFunctionPointer;
        public static IntPtr NT_GetEntryRaw2FunctionPointer;
        public static IntPtr NT_GetEntryBooleanArrayFunctionPointer;
        public static IntPtr NT_GetEntryBooleanArray2FunctionPointer;
        public static IntPtr NT_GetEntryDoubleArrayFunctionPointer;
        public static IntPtr NT_GetEntryDoubleArray2FunctionPointer;
        public static IntPtr NT_GetEntryStringArrayFunctionPointer;
        public static IntPtr NT_GetEntryStringArray2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryBooleanFunctionPointer;
        public static IntPtr NT_SetDefaultEntryBoolean2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryDoubleFunctionPointer;
        public static IntPtr NT_SetDefaultEntryDouble2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryStringFunctionPointer;
        public static IntPtr NT_SetDefaultEntryString2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryRawFunctionPointer;
        public static IntPtr NT_SetDefaultEntryRaw2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryBooleanArrayFunctionPointer;
        public static IntPtr NT_SetDefaultEntryBooleanArray2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryDoubleArrayFunctionPointer;
        public static IntPtr NT_SetDefaultEntryDoubleArray2FunctionPointer;
        public static IntPtr NT_SetDefaultEntryStringArrayFunctionPointer;
        public static IntPtr NT_SetDefaultEntryStringArray2FunctionPointer;
        public static IntPtr NT_SetEntryBooleanFunctionPointer;
        public static IntPtr NT_SetEntryBoolean2FunctionPointer;
        public static IntPtr NT_SetEntryDoubleFunctionPointer;
        public static IntPtr NT_SetEntryDouble2FunctionPointer;
        public static IntPtr NT_SetEntryStringFunctionPointer;
        public static IntPtr NT_SetEntryString2FunctionPointer;
        public static IntPtr NT_SetEntryRawFunctionPointer;
        public static IntPtr NT_SetEntryRaw2FunctionPointer;
        public static IntPtr NT_SetEntryBooleanArrayFunctionPointer;
        public static IntPtr NT_SetEntryBooleanArray2FunctionPointer;
        public static IntPtr NT_SetEntryDoubleArrayFunctionPointer;
        public static IntPtr NT_SetEntryDoubleArray2FunctionPointer;
        public static IntPtr NT_SetEntryStringArrayFunctionPointer;
        public static IntPtr NT_SetEntryStringArray2FunctionPointer;

        public static unsafe NT_Inst NT_GetDefaultInstance()
        {
            throw null;
        }

        public static unsafe NT_Inst NT_CreateInstance()
        {
            throw null;
        }

        public static unsafe void NT_DestroyInstance(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe NT_Inst NT_GetInstanceFromHandle(NT_Handle handle)
        {
            throw null;
        }

        public static unsafe NT_Entry NT_GetEntry(NT_Inst inst, byte* name, UIntPtr name_len)
        {
            throw null;
        }

        public static unsafe NT_Entry* NT_GetEntries(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryName(NT_Entry entry, UIntPtr* name_len)
        {
            throw null;
        }

        public static unsafe ulong NT_GetEntryLastChange(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_GetEntryValue(byte* name, UIntPtr name_len, NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_GetEntryValue2(NT_Entry entry, NT_Value* value)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryValue(byte* name, UIntPtr name_len, NT_Value* default_value)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryValue2(NT_Entry entry, NT_Value* default_value)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryValue(byte* name, UIntPtr name_len, NT_Value* value)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryValue2(NT_Entry entry, NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_SetEntryTypeValue(byte* name, UIntPtr name_len, NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_SetEntryTypeValue2(NT_Entry entry, NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_SetEntryFlags(byte* name, UIntPtr name_len, uint flags)
        {
            throw null;
        }

        public static unsafe void NT_SetEntryFlags2(NT_Entry entry, uint flags)
        {
            throw null;
        }

        public static unsafe uint NT_GetEntryFlags(byte* name, UIntPtr name_len)
        {
            throw null;
        }

        public static unsafe uint NT_GetEntryFlags2(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_DeleteEntry(byte* name, UIntPtr name_len)
        {
            throw null;
        }

        public static unsafe void NT_DeleteEntry2(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_DeleteAllEntries()
        {
            throw null;
        }

        public static unsafe void NT_DeleteAllEntries2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe NT_EntryInfo* NT_GetEntryInfo(byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            throw null;
        }

        public static unsafe NT_EntryInfo2* NT_GetEntryInfo2(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            throw null;
        }

        public static unsafe NT_EntryInfo2* NT_GetEntryInfoHandle(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_Flush()
        {
            throw null;
        }

        public static unsafe void NT_Flush2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetListenerOnStart(IntPtr onStart, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetListenerOnStart2(NT_Inst inst, IntPtr onStart, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetListenerOnExit(IntPtr onExit, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetListenerOnExit2(NT_Inst inst, IntPtr onExit, void* data)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddEntryListener(byte* prefix, UIntPtr prefix_len, void* data, IntPtr callback, uint flags)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddEntryListener2(NT_Inst inst, byte* prefix, UIntPtr prefix_len, void* data, IntPtr callback, uint flags)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddEntryListenerSingle(NT_Entry entry, void* data, IntPtr callback, uint flags)
        {
            throw null;
        }

        public static unsafe void NT_RemoveEntryListener(NT_EntryListener entry_listener)
        {
            throw null;
        }

        public static unsafe NT_ConnectionListener NT_AddConnectionListener(void* data, IntPtr callback, NT_Bool immediate_notify)
        {
            throw null;
        }

        public static unsafe NT_ConnectionListener NT_AddConnectionListener2(NT_Inst inst, void* data, IntPtr callback, NT_Bool immediate_notify)
        {
            throw null;
        }

        public static unsafe void NT_RemoveConnectionListener(NT_ConnectionListener conn_listener)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_NotifierDestroyed()
        {
            throw null;
        }

        public static unsafe NT_Bool NT_NotifierDestroyed2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetRpcServerOnStart(NT_Inst inst, IntPtr onStart, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetRpcServerOnExit(NT_Inst inst, IntPtr onExit, void* data)
        {
            throw null;
        }

        public static unsafe void NT_CreateRpc(NT_Entry entry, byte* def, UIntPtr def_len, void* data, IntPtr callback)
        {
            throw null;
        }

        public static unsafe void NT_CreatePolledRpc(NT_Entry entry, byte* def, UIntPtr def_len)
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

        public static unsafe void NT_SetNetworkIdentity(byte* name, UIntPtr name_len)
        {
            throw null;
        }

        public static unsafe void NT_SetNetworkIdentity2(NT_Inst inst, byte* name, UIntPtr name_len)
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

        public static unsafe byte* NT_LoadPersistent(byte* filename, IntPtr warn)
        {
            throw null;
        }

        public static unsafe byte* NT_LoadPersistent2(NT_Inst inst, byte* filename, IntPtr warn)
        {
            throw null;
        }

        public static unsafe void NT_DisposeValue(NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_InitValue(NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_DisposeString(NT_String* str)
        {
            throw null;
        }

        public static unsafe void NT_InitString(NT_String* str)
        {
            throw null;
        }

        public static unsafe void NT_DisposeEntryArray(NT_Entry* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeConnectionInfoArray(NT_ConnectionInfo* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeEntryInfoArray(NT_EntryInfo* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeEntryInfoArray2(NT_EntryInfo2* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeRpcDefinition(NT_RpcDefinition* def)
        {
            throw null;
        }

        public static unsafe void NT_DisposeRpcCallInfo(NT_RpcCallInfo* call_info)
        {
            throw null;
        }

        public static unsafe ulong NT_Now()
        {
            throw null;
        }

        public static unsafe void NT_SetLogger(IntPtr func, uint min_level)
        {
            throw null;
        }

        public static unsafe void NT_SetLogger2(NT_Inst inst, IntPtr func, uint min_level)
        {
            throw null;
        }

        public static unsafe byte* NT_AllocateCharArray(UIntPtr size)
        {
            throw null;
        }

        public static unsafe NT_Bool* NT_AllocateBooleanArray(UIntPtr size)
        {
            throw null;
        }

        public static unsafe double* NT_AllocateDoubleArray(UIntPtr size)
        {
            throw null;
        }

        public static unsafe NT_String* NT_AllocateStringArray(UIntPtr size)
        {
            throw null;
        }

        public static unsafe void NT_FreeCharArray(byte* v_char)
        {
            throw null;
        }

        public static unsafe void NT_FreeDoubleArray(double* v_double)
        {
            throw null;
        }

        public static unsafe void NT_FreeBooleanArray(NT_Bool* v_boolean)
        {
            throw null;
        }

        public static unsafe void NT_FreeStringArray(NT_String* v_string, UIntPtr arr_size)
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

        public static unsafe NT_Bool NT_GetEntryBoolean(byte* name, UIntPtr name_len, ulong* last_change, NT_Bool* v_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryBoolean2(NT_Entry entry, ulong* last_change, NT_Bool* v_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryDouble(byte* name, UIntPtr name_len, ulong* last_change, double* v_double)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryDouble2(NT_Entry entry, ulong* last_change, double* v_double)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryString(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* str_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryString2(NT_Entry entry, ulong* last_change, UIntPtr* str_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryRaw(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* raw_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetEntryRaw2(NT_Entry entry, ulong* last_change, UIntPtr* raw_len)
        {
            throw null;
        }

        public static unsafe NT_Bool* NT_GetEntryBooleanArray(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_Bool* NT_GetEntryBooleanArray2(NT_Entry entry, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe double* NT_GetEntryDoubleArray(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe double* NT_GetEntryDoubleArray2(NT_Entry entry, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_String* NT_GetEntryStringArray(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_String* NT_GetEntryStringArray2(NT_Entry entry, ulong* last_change, UIntPtr* arr_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBoolean(byte* name, UIntPtr name_len, NT_Bool default_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBoolean2(NT_Entry entry, NT_Bool default_boolean)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDouble(byte* name, UIntPtr name_len, double default_double)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDouble2(NT_Entry entry, double default_double)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryString(byte* name, UIntPtr name_len, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryString2(NT_Entry entry, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryRaw(byte* name, UIntPtr name_len, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryRaw2(NT_Entry entry, byte* default_value, UIntPtr default_len)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBooleanArray(byte* name, UIntPtr name_len, int* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryBooleanArray2(NT_Entry entry, int* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDoubleArray(byte* name, UIntPtr name_len, double* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryDoubleArray2(NT_Entry entry, double* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryStringArray(byte* name, UIntPtr name_len, NT_String* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryStringArray2(NT_Entry entry, NT_String* default_value, UIntPtr default_size)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBoolean(byte* name, UIntPtr name_len, NT_Bool v_boolean, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBoolean2(NT_Entry entry, NT_Bool v_boolean, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDouble(byte* name, UIntPtr name_len, double v_double, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDouble2(NT_Entry entry, double v_double, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryString(byte* name, UIntPtr name_len, byte* str, UIntPtr str_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryString2(NT_Entry entry, byte* str, UIntPtr str_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryRaw(byte* name, UIntPtr name_len, byte* raw, UIntPtr raw_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryRaw2(NT_Entry entry, byte* raw, UIntPtr raw_len, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBooleanArray(byte* name, UIntPtr name_len, int* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryBooleanArray2(NT_Entry entry, int* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDoubleArray(byte* name, UIntPtr name_len, double* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryDoubleArray2(NT_Entry entry, double* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryStringArray(byte* name, UIntPtr name_len, NT_String* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryStringArray2(NT_Entry entry, NT_String* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }
    }
}