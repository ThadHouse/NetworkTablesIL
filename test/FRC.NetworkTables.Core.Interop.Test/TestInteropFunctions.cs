using System;
using System.Runtime.InteropServices;
using Xunit;

namespace FRC.NetworkTables.Core.Interop.Test
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Inst NT_GetDefaultInstanceDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Inst NT_CreateInstanceDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DestroyInstanceDelegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Inst NT_GetInstanceFromHandleDelegate(NT_Handle handle);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Entry NT_GetEntryDelegate(NT_Inst inst, byte* name, UIntPtr name_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Entry* NT_GetEntriesDelegate(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetEntryNameDelegate(NT_Entry entry, UIntPtr* name_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ulong NT_GetEntryLastChangeDelegate(NT_Entry entry);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_GetEntryValueDelegate(byte* name, UIntPtr name_len, NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_GetEntryValue2Delegate(NT_Entry entry, NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryValueDelegate(byte* name, UIntPtr name_len, NT_Value* default_value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryValue2Delegate(NT_Entry entry, NT_Value* default_value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryValueDelegate(byte* name, UIntPtr name_len, NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryValue2Delegate(NT_Entry entry, NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetEntryTypeValueDelegate(byte* name, UIntPtr name_len, NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetEntryTypeValue2Delegate(NT_Entry entry, NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetEntryFlagsDelegate(byte* name, UIntPtr name_len, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetEntryFlags2Delegate(NT_Entry entry, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint NT_GetEntryFlagsDelegate(byte* name, UIntPtr name_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint NT_GetEntryFlags2Delegate(NT_Entry entry);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DeleteEntryDelegate(byte* name, UIntPtr name_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DeleteEntry2Delegate(NT_Entry entry);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DeleteAllEntriesDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DeleteAllEntries2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_EntryInfo* NT_GetEntryInfoDelegate(byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_EntryInfo2* NT_GetEntryInfo2Delegate(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_EntryInfo2* NT_GetEntryInfoHandleDelegate(NT_Entry entry);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_FlushDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_Flush2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetListenerOnStartDelegate(IntPtr onStart, void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetListenerOnStart2Delegate(NT_Inst inst, IntPtr onStart, void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetListenerOnExitDelegate(IntPtr onExit, void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetListenerOnExit2Delegate(NT_Inst inst, IntPtr onExit, void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_EntryListener NT_AddEntryListenerDelegate(byte* prefix, UIntPtr prefix_len, void* data, IntPtr callback, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_EntryListener NT_AddEntryListener2Delegate(NT_Inst inst, byte* prefix, UIntPtr prefix_len, void* data, IntPtr callback, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_EntryListener NT_AddEntryListenerSingleDelegate(NT_Entry entry, void* data, IntPtr callback, uint flags);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_RemoveEntryListenerDelegate(NT_EntryListener entry_listener);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_ConnectionListener NT_AddConnectionListenerDelegate(void* data, IntPtr callback, NT_Bool immediate_notify);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_ConnectionListener NT_AddConnectionListener2Delegate(NT_Inst inst, void* data, IntPtr callback, NT_Bool immediate_notify);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_RemoveConnectionListenerDelegate(NT_ConnectionListener conn_listener);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_NotifierDestroyedDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_NotifierDestroyed2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetRpcServerOnStartDelegate(NT_Inst inst, IntPtr onStart, void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetRpcServerOnExitDelegate(NT_Inst inst, IntPtr onExit, void* data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_CreateRpcDelegate(NT_Entry entry, byte* def, UIntPtr def_len, void* data, IntPtr callback);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_CreatePolledRpcDelegate(NT_Entry entry, byte* def, UIntPtr def_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_PollRpcDelegate(NT_Inst inst, NT_RpcCallInfo* call_info);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_PollRpcTimeoutDelegate(NT_Inst inst, NT_RpcCallInfo* call_info, double time_out);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_PostRpcResponseDelegate(NT_Entry rpc, NT_RpcCall call, byte* result, UIntPtr result_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_RpcCall NT_CallRpcDelegate(NT_Entry rpc, byte* @params, UIntPtr params_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetRpcResultDelegate(NT_Entry rpc, NT_RpcCall call, UIntPtr* result_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetRpcResultTimeoutDelegate(NT_Entry rpc, NT_RpcCall call, UIntPtr* result_len, double time_out);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_CancelRpcResultDelegate(NT_Entry rpc, NT_RpcCall call);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_PackRpcDefinitionDelegate(NT_RpcDefinition* def, UIntPtr* packed_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_UnpackRpcDefinitionDelegate(byte* packed, UIntPtr packed_len, NT_RpcDefinition* def);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_PackRpcValuesDelegate(NT_Value** values, UIntPtr values_len, UIntPtr* packed_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Value** NT_UnpackRpcValuesDelegate(byte* packed, UIntPtr packed_len, NT_Type* types, UIntPtr types_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetNetworkIdentityDelegate(byte* name, UIntPtr name_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetNetworkIdentity2Delegate(NT_Inst inst, byte* name, UIntPtr name_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint NT_GetNetworkModeDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint NT_GetNetworkMode2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartServerDelegate(byte* persist_filename, byte* listen_address, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartServer2Delegate(NT_Inst inst, byte* persist_filename, byte* listen_address, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopServerDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopServer2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartClientNoneDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartClientNone2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartClientDelegate(byte* server_name, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartClient2Delegate(NT_Inst inst, byte* server_name, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartClientMultiDelegate(UIntPtr count, byte** server_names, uint* ports);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartClientMulti2Delegate(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopClientDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopClient2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetServerDelegate(byte* server_name, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetServer2Delegate(NT_Inst inst, byte* server_name, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetServerMultiDelegate(UIntPtr count, byte** server_names, uint* ports);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetServerMulti2Delegate(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartDSClientDelegate(uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StartDSClient2Delegate(NT_Inst inst, uint port);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopDSClientDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopDSClient2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopRpcServerDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopRpcServer2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopNotifierDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_StopNotifier2Delegate(NT_Inst inst);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetUpdateRateDelegate(double interval);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetUpdateRate2Delegate(NT_Inst inst, double interval);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_ConnectionInfo* NT_GetConnectionsDelegate(UIntPtr* count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_ConnectionInfo* NT_GetConnections2Delegate(NT_Inst inst, UIntPtr* count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_SavePersistentDelegate(byte* filename);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_SavePersistent2Delegate(NT_Inst inst, byte* filename);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_LoadPersistentDelegate(byte* filename, IntPtr warn);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_LoadPersistent2Delegate(NT_Inst inst, byte* filename, IntPtr warn);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeValueDelegate(NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_InitValueDelegate(NT_Value* value);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeStringDelegate(NT_String* str);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_InitStringDelegate(NT_String* str);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeEntryArrayDelegate(NT_Entry* arr, UIntPtr count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeConnectionInfoArrayDelegate(NT_ConnectionInfo* arr, UIntPtr count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeEntryInfoArrayDelegate(NT_EntryInfo* arr, UIntPtr count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeEntryInfoArray2Delegate(NT_EntryInfo2* arr, UIntPtr count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeRpcDefinitionDelegate(NT_RpcDefinition* def);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_DisposeRpcCallInfoDelegate(NT_RpcCallInfo* call_info);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ulong NT_NowDelegate();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetLoggerDelegate(IntPtr func, uint min_level);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_SetLogger2Delegate(NT_Inst inst, IntPtr func, uint min_level);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_AllocateCharArrayDelegate(UIntPtr size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool* NT_AllocateBooleanArrayDelegate(UIntPtr size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate double* NT_AllocateDoubleArrayDelegate(UIntPtr size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_String* NT_AllocateStringArrayDelegate(UIntPtr size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_FreeCharArrayDelegate(byte* v_char);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_FreeDoubleArrayDelegate(double* v_double);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_FreeBooleanArrayDelegate(NT_Bool* v_boolean);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void NT_FreeStringArrayDelegate(NT_String* v_string, UIntPtr arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_GetValueBooleanDelegate(NT_Value* value, ulong* last_change, NT_Bool* v_boolean);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_GetValueDoubleDelegate(NT_Value* value, ulong* last_change, double* v_double);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetValueStringDelegate(NT_Value* value, ulong* last_change, UIntPtr* str_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetValueRawDelegate(NT_Value* value, ulong* last_change, UIntPtr* raw_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool* NT_GetValueBooleanArrayDelegate(NT_Value* value, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate double* NT_GetValueDoubleArrayDelegate(NT_Value* value, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_String* NT_GetValueStringArrayDelegate(NT_Value* value, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_GetEntryBooleanDelegate(byte* name, UIntPtr name_len, ulong* last_change, NT_Bool* v_boolean);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_GetEntryBoolean2Delegate(NT_Entry entry, ulong* last_change, NT_Bool* v_boolean);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_GetEntryDoubleDelegate(byte* name, UIntPtr name_len, ulong* last_change, double* v_double);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_GetEntryDouble2Delegate(NT_Entry entry, ulong* last_change, double* v_double);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetEntryStringDelegate(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* str_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetEntryString2Delegate(NT_Entry entry, ulong* last_change, UIntPtr* str_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetEntryRawDelegate(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* raw_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* NT_GetEntryRaw2Delegate(NT_Entry entry, ulong* last_change, UIntPtr* raw_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool* NT_GetEntryBooleanArrayDelegate(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool* NT_GetEntryBooleanArray2Delegate(NT_Entry entry, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate double* NT_GetEntryDoubleArrayDelegate(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate double* NT_GetEntryDoubleArray2Delegate(NT_Entry entry, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_String* NT_GetEntryStringArrayDelegate(byte* name, UIntPtr name_len, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_String* NT_GetEntryStringArray2Delegate(NT_Entry entry, ulong* last_change, UIntPtr* arr_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryBooleanDelegate(byte* name, UIntPtr name_len, NT_Bool default_boolean);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryBoolean2Delegate(NT_Entry entry, NT_Bool default_boolean);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryDoubleDelegate(byte* name, UIntPtr name_len, double default_double);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryDouble2Delegate(NT_Entry entry, double default_double);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryStringDelegate(byte* name, UIntPtr name_len, byte* default_value, UIntPtr default_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryString2Delegate(NT_Entry entry, byte* default_value, UIntPtr default_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryRawDelegate(byte* name, UIntPtr name_len, byte* default_value, UIntPtr default_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryRaw2Delegate(NT_Entry entry, byte* default_value, UIntPtr default_len);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryBooleanArrayDelegate(byte* name, UIntPtr name_len, int* default_value, UIntPtr default_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryBooleanArray2Delegate(NT_Entry entry, int* default_value, UIntPtr default_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryDoubleArrayDelegate(byte* name, UIntPtr name_len, double* default_value, UIntPtr default_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryDoubleArray2Delegate(NT_Entry entry, double* default_value, UIntPtr default_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryStringArrayDelegate(byte* name, UIntPtr name_len, NT_String* default_value, UIntPtr default_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetDefaultEntryStringArray2Delegate(NT_Entry entry, NT_String* default_value, UIntPtr default_size);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryBooleanDelegate(byte* name, UIntPtr name_len, NT_Bool v_boolean, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryBoolean2Delegate(NT_Entry entry, NT_Bool v_boolean, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryDoubleDelegate(byte* name, UIntPtr name_len, double v_double, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryDouble2Delegate(NT_Entry entry, double v_double, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryStringDelegate(byte* name, UIntPtr name_len, byte* str, UIntPtr str_len, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryString2Delegate(NT_Entry entry, byte* str, UIntPtr str_len, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryRawDelegate(byte* name, UIntPtr name_len, byte* raw, UIntPtr raw_len, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryRaw2Delegate(NT_Entry entry, byte* raw, UIntPtr raw_len, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryBooleanArrayDelegate(byte* name, UIntPtr name_len, int* arr, UIntPtr size, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryBooleanArray2Delegate(NT_Entry entry, int* arr, UIntPtr size, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryDoubleArrayDelegate(byte* name, UIntPtr name_len, double* arr, UIntPtr size, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryDoubleArray2Delegate(NT_Entry entry, double* arr, UIntPtr size, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryStringArrayDelegate(byte* name, UIntPtr name_len, NT_String* arr, UIntPtr size, NT_Bool force);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate NT_Bool NT_SetEntryStringArray2Delegate(NT_Entry entry, NT_String* arr, UIntPtr size, NT_Bool force);

    public class TestInteropFunctions
    {
        [Fact]
        public unsafe void TestNT_GetDefaultInstance()
        {
            NT_GetDefaultInstanceDelegate func = () =>
            {
                return default(NT_Inst);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetDefaultInstanceFunctionPointer;
            Functions.NT_GetDefaultInstanceFunctionPointer = ptr;

            var ret = Functions.NT_GetDefaultInstance();

            Functions.NT_GetDefaultInstanceFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_CreateInstance()
        {
            NT_CreateInstanceDelegate func = () =>
            {
                return default(NT_Inst);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_CreateInstanceFunctionPointer;
            Functions.NT_CreateInstanceFunctionPointer = ptr;

            var ret = Functions.NT_CreateInstance();

            Functions.NT_CreateInstanceFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DestroyInstance()
        {
            NT_DestroyInstanceDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DestroyInstanceFunctionPointer;
            Functions.NT_DestroyInstanceFunctionPointer = ptr;

            Functions.NT_DestroyInstance(default(NT_Inst));

            Functions.NT_DestroyInstanceFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetInstanceFromHandle()
        {
            NT_GetInstanceFromHandleDelegate func = (a) =>
            {
                return default(NT_Inst);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetInstanceFromHandleFunctionPointer;
            Functions.NT_GetInstanceFromHandleFunctionPointer = ptr;

            var ret = Functions.NT_GetInstanceFromHandle(default(NT_Handle));

            Functions.NT_GetInstanceFromHandleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntry()
        {
            NT_GetEntryDelegate func = (a, b, c) =>
            {
                return default(NT_Entry);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryFunctionPointer;
            Functions.NT_GetEntryFunctionPointer = ptr;

            var ret = Functions.NT_GetEntry(default(NT_Inst), default(byte*), default(UIntPtr));

            Functions.NT_GetEntryFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntries()
        {
            NT_GetEntriesDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_Entry*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntriesFunctionPointer;
            Functions.NT_GetEntriesFunctionPointer = ptr;

            var ret = Functions.NT_GetEntries(default(NT_Inst), default(byte*), default(UIntPtr), default(uint), default(UIntPtr*));

            Functions.NT_GetEntriesFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryName()
        {
            NT_GetEntryNameDelegate func = (a, b) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryNameFunctionPointer;
            Functions.NT_GetEntryNameFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryName(default(NT_Entry), default(UIntPtr*));

            Functions.NT_GetEntryNameFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryLastChange()
        {
            NT_GetEntryLastChangeDelegate func = (a) =>
            {
                return default(ulong);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryLastChangeFunctionPointer;
            Functions.NT_GetEntryLastChangeFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryLastChange(default(NT_Entry));

            Functions.NT_GetEntryLastChangeFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryValue()
        {
            NT_GetEntryValueDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryValueFunctionPointer;
            Functions.NT_GetEntryValueFunctionPointer = ptr;

            Functions.NT_GetEntryValue(default(byte*), default(UIntPtr), default(NT_Value*));

            Functions.NT_GetEntryValueFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryValue2()
        {
            NT_GetEntryValue2Delegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryValue2FunctionPointer;
            Functions.NT_GetEntryValue2FunctionPointer = ptr;

            Functions.NT_GetEntryValue2(default(NT_Entry), default(NT_Value*));

            Functions.NT_GetEntryValue2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryValue()
        {
            NT_SetDefaultEntryValueDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryValueFunctionPointer;
            Functions.NT_SetDefaultEntryValueFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryValue(default(byte*), default(UIntPtr), default(NT_Value*));

            Functions.NT_SetDefaultEntryValueFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryValue2()
        {
            NT_SetDefaultEntryValue2Delegate func = (a, b) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryValue2FunctionPointer;
            Functions.NT_SetDefaultEntryValue2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryValue2(default(NT_Entry), default(NT_Value*));

            Functions.NT_SetDefaultEntryValue2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryValue()
        {
            NT_SetEntryValueDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryValueFunctionPointer;
            Functions.NT_SetEntryValueFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryValue(default(byte*), default(UIntPtr), default(NT_Value*));

            Functions.NT_SetEntryValueFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryValue2()
        {
            NT_SetEntryValue2Delegate func = (a, b) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryValue2FunctionPointer;
            Functions.NT_SetEntryValue2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryValue2(default(NT_Entry), default(NT_Value*));

            Functions.NT_SetEntryValue2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryTypeValue()
        {
            NT_SetEntryTypeValueDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryTypeValueFunctionPointer;
            Functions.NT_SetEntryTypeValueFunctionPointer = ptr;

            Functions.NT_SetEntryTypeValue(default(byte*), default(UIntPtr), default(NT_Value*));

            Functions.NT_SetEntryTypeValueFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryTypeValue2()
        {
            NT_SetEntryTypeValue2Delegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryTypeValue2FunctionPointer;
            Functions.NT_SetEntryTypeValue2FunctionPointer = ptr;

            Functions.NT_SetEntryTypeValue2(default(NT_Entry), default(NT_Value*));

            Functions.NT_SetEntryTypeValue2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryFlags()
        {
            NT_SetEntryFlagsDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryFlagsFunctionPointer;
            Functions.NT_SetEntryFlagsFunctionPointer = ptr;

            Functions.NT_SetEntryFlags(default(byte*), default(UIntPtr), default(uint));

            Functions.NT_SetEntryFlagsFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryFlags2()
        {
            NT_SetEntryFlags2Delegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryFlags2FunctionPointer;
            Functions.NT_SetEntryFlags2FunctionPointer = ptr;

            Functions.NT_SetEntryFlags2(default(NT_Entry), default(uint));

            Functions.NT_SetEntryFlags2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryFlags()
        {
            NT_GetEntryFlagsDelegate func = (a, b) =>
            {
                return default(uint);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryFlagsFunctionPointer;
            Functions.NT_GetEntryFlagsFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryFlags(default(byte*), default(UIntPtr));

            Functions.NT_GetEntryFlagsFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryFlags2()
        {
            NT_GetEntryFlags2Delegate func = (a) =>
            {
                return default(uint);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryFlags2FunctionPointer;
            Functions.NT_GetEntryFlags2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryFlags2(default(NT_Entry));

            Functions.NT_GetEntryFlags2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DeleteEntry()
        {
            NT_DeleteEntryDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DeleteEntryFunctionPointer;
            Functions.NT_DeleteEntryFunctionPointer = ptr;

            Functions.NT_DeleteEntry(default(byte*), default(UIntPtr));

            Functions.NT_DeleteEntryFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DeleteEntry2()
        {
            NT_DeleteEntry2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DeleteEntry2FunctionPointer;
            Functions.NT_DeleteEntry2FunctionPointer = ptr;

            Functions.NT_DeleteEntry2(default(NT_Entry));

            Functions.NT_DeleteEntry2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DeleteAllEntries()
        {
            NT_DeleteAllEntriesDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DeleteAllEntriesFunctionPointer;
            Functions.NT_DeleteAllEntriesFunctionPointer = ptr;

            Functions.NT_DeleteAllEntries();

            Functions.NT_DeleteAllEntriesFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DeleteAllEntries2()
        {
            NT_DeleteAllEntries2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DeleteAllEntries2FunctionPointer;
            Functions.NT_DeleteAllEntries2FunctionPointer = ptr;

            Functions.NT_DeleteAllEntries2(default(NT_Inst));

            Functions.NT_DeleteAllEntries2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryInfo()
        {
            NT_GetEntryInfoDelegate func = (a, b, c, d) =>
            {
                return default(NT_EntryInfo*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryInfoFunctionPointer;
            Functions.NT_GetEntryInfoFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryInfo(default(byte*), default(UIntPtr), default(uint), default(UIntPtr*));

            Functions.NT_GetEntryInfoFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryInfo2()
        {
            NT_GetEntryInfo2Delegate func = (a, b, c, d, e) =>
            {
                return default(NT_EntryInfo2*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryInfo2FunctionPointer;
            Functions.NT_GetEntryInfo2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryInfo2(default(NT_Inst), default(byte*), default(UIntPtr), default(uint), default(UIntPtr*));

            Functions.NT_GetEntryInfo2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryInfoHandle()
        {
            NT_GetEntryInfoHandleDelegate func = (a) =>
            {
                return default(NT_EntryInfo2*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryInfoHandleFunctionPointer;
            Functions.NT_GetEntryInfoHandleFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryInfoHandle(default(NT_Entry));

            Functions.NT_GetEntryInfoHandleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_Flush()
        {
            NT_FlushDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_FlushFunctionPointer;
            Functions.NT_FlushFunctionPointer = ptr;

            Functions.NT_Flush();

            Functions.NT_FlushFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_Flush2()
        {
            NT_Flush2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_Flush2FunctionPointer;
            Functions.NT_Flush2FunctionPointer = ptr;

            Functions.NT_Flush2(default(NT_Inst));

            Functions.NT_Flush2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetListenerOnStart()
        {
            NT_SetListenerOnStartDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetListenerOnStartFunctionPointer;
            Functions.NT_SetListenerOnStartFunctionPointer = ptr;

            Functions.NT_SetListenerOnStart(default(IntPtr), default(void*));

            Functions.NT_SetListenerOnStartFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetListenerOnStart2()
        {
            NT_SetListenerOnStart2Delegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetListenerOnStart2FunctionPointer;
            Functions.NT_SetListenerOnStart2FunctionPointer = ptr;

            Functions.NT_SetListenerOnStart2(default(NT_Inst), default(IntPtr), default(void*));

            Functions.NT_SetListenerOnStart2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetListenerOnExit()
        {
            NT_SetListenerOnExitDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetListenerOnExitFunctionPointer;
            Functions.NT_SetListenerOnExitFunctionPointer = ptr;

            Functions.NT_SetListenerOnExit(default(IntPtr), default(void*));

            Functions.NT_SetListenerOnExitFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetListenerOnExit2()
        {
            NT_SetListenerOnExit2Delegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetListenerOnExit2FunctionPointer;
            Functions.NT_SetListenerOnExit2FunctionPointer = ptr;

            Functions.NT_SetListenerOnExit2(default(NT_Inst), default(IntPtr), default(void*));

            Functions.NT_SetListenerOnExit2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AddEntryListener()
        {
            NT_AddEntryListenerDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_EntryListener);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AddEntryListenerFunctionPointer;
            Functions.NT_AddEntryListenerFunctionPointer = ptr;

            var ret = Functions.NT_AddEntryListener(default(byte*), default(UIntPtr), default(void*), default(IntPtr), default(uint));

            Functions.NT_AddEntryListenerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AddEntryListener2()
        {
            NT_AddEntryListener2Delegate func = (a, b, c, d, e, f) =>
            {
                return default(NT_EntryListener);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AddEntryListener2FunctionPointer;
            Functions.NT_AddEntryListener2FunctionPointer = ptr;

            var ret = Functions.NT_AddEntryListener2(default(NT_Inst), default(byte*), default(UIntPtr), default(void*), default(IntPtr), default(uint));

            Functions.NT_AddEntryListener2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AddEntryListenerSingle()
        {
            NT_AddEntryListenerSingleDelegate func = (a, b, c, d) =>
            {
                return default(NT_EntryListener);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AddEntryListenerSingleFunctionPointer;
            Functions.NT_AddEntryListenerSingleFunctionPointer = ptr;

            var ret = Functions.NT_AddEntryListenerSingle(default(NT_Entry), default(void*), default(IntPtr), default(uint));

            Functions.NT_AddEntryListenerSingleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_RemoveEntryListener()
        {
            NT_RemoveEntryListenerDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_RemoveEntryListenerFunctionPointer;
            Functions.NT_RemoveEntryListenerFunctionPointer = ptr;

            Functions.NT_RemoveEntryListener(default(NT_EntryListener));

            Functions.NT_RemoveEntryListenerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AddConnectionListener()
        {
            NT_AddConnectionListenerDelegate func = (a, b, c) =>
            {
                return default(NT_ConnectionListener);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AddConnectionListenerFunctionPointer;
            Functions.NT_AddConnectionListenerFunctionPointer = ptr;

            var ret = Functions.NT_AddConnectionListener(default(void*), default(IntPtr), default(NT_Bool));

            Functions.NT_AddConnectionListenerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AddConnectionListener2()
        {
            NT_AddConnectionListener2Delegate func = (a, b, c, d) =>
            {
                return default(NT_ConnectionListener);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AddConnectionListener2FunctionPointer;
            Functions.NT_AddConnectionListener2FunctionPointer = ptr;

            var ret = Functions.NT_AddConnectionListener2(default(NT_Inst), default(void*), default(IntPtr), default(NT_Bool));

            Functions.NT_AddConnectionListener2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_RemoveConnectionListener()
        {
            NT_RemoveConnectionListenerDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_RemoveConnectionListenerFunctionPointer;
            Functions.NT_RemoveConnectionListenerFunctionPointer = ptr;

            Functions.NT_RemoveConnectionListener(default(NT_ConnectionListener));

            Functions.NT_RemoveConnectionListenerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_NotifierDestroyed()
        {
            NT_NotifierDestroyedDelegate func = () =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_NotifierDestroyedFunctionPointer;
            Functions.NT_NotifierDestroyedFunctionPointer = ptr;

            var ret = Functions.NT_NotifierDestroyed();

            Functions.NT_NotifierDestroyedFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_NotifierDestroyed2()
        {
            NT_NotifierDestroyed2Delegate func = (a) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_NotifierDestroyed2FunctionPointer;
            Functions.NT_NotifierDestroyed2FunctionPointer = ptr;

            var ret = Functions.NT_NotifierDestroyed2(default(NT_Inst));

            Functions.NT_NotifierDestroyed2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetRpcServerOnStart()
        {
            NT_SetRpcServerOnStartDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetRpcServerOnStartFunctionPointer;
            Functions.NT_SetRpcServerOnStartFunctionPointer = ptr;

            Functions.NT_SetRpcServerOnStart(default(NT_Inst), default(IntPtr), default(void*));

            Functions.NT_SetRpcServerOnStartFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetRpcServerOnExit()
        {
            NT_SetRpcServerOnExitDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetRpcServerOnExitFunctionPointer;
            Functions.NT_SetRpcServerOnExitFunctionPointer = ptr;

            Functions.NT_SetRpcServerOnExit(default(NT_Inst), default(IntPtr), default(void*));

            Functions.NT_SetRpcServerOnExitFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_CreateRpc()
        {
            NT_CreateRpcDelegate func = (a, b, c, d, e) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_CreateRpcFunctionPointer;
            Functions.NT_CreateRpcFunctionPointer = ptr;

            Functions.NT_CreateRpc(default(NT_Entry), default(byte*), default(UIntPtr), default(void*), default(IntPtr));

            Functions.NT_CreateRpcFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_CreatePolledRpc()
        {
            NT_CreatePolledRpcDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_CreatePolledRpcFunctionPointer;
            Functions.NT_CreatePolledRpcFunctionPointer = ptr;

            Functions.NT_CreatePolledRpc(default(NT_Entry), default(byte*), default(UIntPtr));

            Functions.NT_CreatePolledRpcFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_PollRpc()
        {
            NT_PollRpcDelegate func = (a, b) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_PollRpcFunctionPointer;
            Functions.NT_PollRpcFunctionPointer = ptr;

            var ret = Functions.NT_PollRpc(default(NT_Inst), default(NT_RpcCallInfo*));

            Functions.NT_PollRpcFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_PollRpcTimeout()
        {
            NT_PollRpcTimeoutDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_PollRpcTimeoutFunctionPointer;
            Functions.NT_PollRpcTimeoutFunctionPointer = ptr;

            var ret = Functions.NT_PollRpcTimeout(default(NT_Inst), default(NT_RpcCallInfo*), default(double));

            Functions.NT_PollRpcTimeoutFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_PostRpcResponse()
        {
            NT_PostRpcResponseDelegate func = (a, b, c, d) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_PostRpcResponseFunctionPointer;
            Functions.NT_PostRpcResponseFunctionPointer = ptr;

            Functions.NT_PostRpcResponse(default(NT_Entry), default(NT_RpcCall), default(byte*), default(UIntPtr));

            Functions.NT_PostRpcResponseFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_CallRpc()
        {
            NT_CallRpcDelegate func = (a, b, c) =>
            {
                return default(NT_RpcCall);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_CallRpcFunctionPointer;
            Functions.NT_CallRpcFunctionPointer = ptr;

            var ret = Functions.NT_CallRpc(default(NT_Entry), default(byte*), default(UIntPtr));

            Functions.NT_CallRpcFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetRpcResult()
        {
            NT_GetRpcResultDelegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetRpcResultFunctionPointer;
            Functions.NT_GetRpcResultFunctionPointer = ptr;

            var ret = Functions.NT_GetRpcResult(default(NT_Entry), default(NT_RpcCall), default(UIntPtr*));

            Functions.NT_GetRpcResultFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetRpcResultTimeout()
        {
            NT_GetRpcResultTimeoutDelegate func = (a, b, c, d) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetRpcResultTimeoutFunctionPointer;
            Functions.NT_GetRpcResultTimeoutFunctionPointer = ptr;

            var ret = Functions.NT_GetRpcResultTimeout(default(NT_Entry), default(NT_RpcCall), default(UIntPtr*), default(double));

            Functions.NT_GetRpcResultTimeoutFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_CancelRpcResult()
        {
            NT_CancelRpcResultDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_CancelRpcResultFunctionPointer;
            Functions.NT_CancelRpcResultFunctionPointer = ptr;

            Functions.NT_CancelRpcResult(default(NT_Entry), default(NT_RpcCall));

            Functions.NT_CancelRpcResultFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_PackRpcDefinition()
        {
            NT_PackRpcDefinitionDelegate func = (a, b) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_PackRpcDefinitionFunctionPointer;
            Functions.NT_PackRpcDefinitionFunctionPointer = ptr;

            var ret = Functions.NT_PackRpcDefinition(default(NT_RpcDefinition*), default(UIntPtr*));

            Functions.NT_PackRpcDefinitionFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_UnpackRpcDefinition()
        {
            NT_UnpackRpcDefinitionDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_UnpackRpcDefinitionFunctionPointer;
            Functions.NT_UnpackRpcDefinitionFunctionPointer = ptr;

            var ret = Functions.NT_UnpackRpcDefinition(default(byte*), default(UIntPtr), default(NT_RpcDefinition*));

            Functions.NT_UnpackRpcDefinitionFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_PackRpcValues()
        {
            NT_PackRpcValuesDelegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_PackRpcValuesFunctionPointer;
            Functions.NT_PackRpcValuesFunctionPointer = ptr;

            var ret = Functions.NT_PackRpcValues(default(NT_Value**), default(UIntPtr), default(UIntPtr*));

            Functions.NT_PackRpcValuesFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_UnpackRpcValues()
        {
            NT_UnpackRpcValuesDelegate func = (a, b, c, d) =>
            {
                return default(NT_Value**);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_UnpackRpcValuesFunctionPointer;
            Functions.NT_UnpackRpcValuesFunctionPointer = ptr;

            var ret = Functions.NT_UnpackRpcValues(default(byte*), default(UIntPtr), default(NT_Type*), default(UIntPtr));

            Functions.NT_UnpackRpcValuesFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetNetworkIdentity()
        {
            NT_SetNetworkIdentityDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetNetworkIdentityFunctionPointer;
            Functions.NT_SetNetworkIdentityFunctionPointer = ptr;

            Functions.NT_SetNetworkIdentity(default(byte*), default(UIntPtr));

            Functions.NT_SetNetworkIdentityFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetNetworkIdentity2()
        {
            NT_SetNetworkIdentity2Delegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetNetworkIdentity2FunctionPointer;
            Functions.NT_SetNetworkIdentity2FunctionPointer = ptr;

            Functions.NT_SetNetworkIdentity2(default(NT_Inst), default(byte*), default(UIntPtr));

            Functions.NT_SetNetworkIdentity2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetNetworkMode()
        {
            NT_GetNetworkModeDelegate func = () =>
            {
                return default(uint);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetNetworkModeFunctionPointer;
            Functions.NT_GetNetworkModeFunctionPointer = ptr;

            var ret = Functions.NT_GetNetworkMode();

            Functions.NT_GetNetworkModeFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetNetworkMode2()
        {
            NT_GetNetworkMode2Delegate func = (a) =>
            {
                return default(uint);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetNetworkMode2FunctionPointer;
            Functions.NT_GetNetworkMode2FunctionPointer = ptr;

            var ret = Functions.NT_GetNetworkMode2(default(NT_Inst));

            Functions.NT_GetNetworkMode2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartServer()
        {
            NT_StartServerDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartServerFunctionPointer;
            Functions.NT_StartServerFunctionPointer = ptr;

            Functions.NT_StartServer(default(byte*), default(byte*), default(uint));

            Functions.NT_StartServerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartServer2()
        {
            NT_StartServer2Delegate func = (a, b, c, d) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartServer2FunctionPointer;
            Functions.NT_StartServer2FunctionPointer = ptr;

            Functions.NT_StartServer2(default(NT_Inst), default(byte*), default(byte*), default(uint));

            Functions.NT_StartServer2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopServer()
        {
            NT_StopServerDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopServerFunctionPointer;
            Functions.NT_StopServerFunctionPointer = ptr;

            Functions.NT_StopServer();

            Functions.NT_StopServerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopServer2()
        {
            NT_StopServer2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopServer2FunctionPointer;
            Functions.NT_StopServer2FunctionPointer = ptr;

            Functions.NT_StopServer2(default(NT_Inst));

            Functions.NT_StopServer2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartClientNone()
        {
            NT_StartClientNoneDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartClientNoneFunctionPointer;
            Functions.NT_StartClientNoneFunctionPointer = ptr;

            Functions.NT_StartClientNone();

            Functions.NT_StartClientNoneFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartClientNone2()
        {
            NT_StartClientNone2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartClientNone2FunctionPointer;
            Functions.NT_StartClientNone2FunctionPointer = ptr;

            Functions.NT_StartClientNone2(default(NT_Inst));

            Functions.NT_StartClientNone2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartClient()
        {
            NT_StartClientDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartClientFunctionPointer;
            Functions.NT_StartClientFunctionPointer = ptr;

            Functions.NT_StartClient(default(byte*), default(uint));

            Functions.NT_StartClientFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartClient2()
        {
            NT_StartClient2Delegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartClient2FunctionPointer;
            Functions.NT_StartClient2FunctionPointer = ptr;

            Functions.NT_StartClient2(default(NT_Inst), default(byte*), default(uint));

            Functions.NT_StartClient2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartClientMulti()
        {
            NT_StartClientMultiDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartClientMultiFunctionPointer;
            Functions.NT_StartClientMultiFunctionPointer = ptr;

            Functions.NT_StartClientMulti(default(UIntPtr), default(byte**), default(uint*));

            Functions.NT_StartClientMultiFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartClientMulti2()
        {
            NT_StartClientMulti2Delegate func = (a, b, c, d) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartClientMulti2FunctionPointer;
            Functions.NT_StartClientMulti2FunctionPointer = ptr;

            Functions.NT_StartClientMulti2(default(NT_Inst), default(UIntPtr), default(byte**), default(uint*));

            Functions.NT_StartClientMulti2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopClient()
        {
            NT_StopClientDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopClientFunctionPointer;
            Functions.NT_StopClientFunctionPointer = ptr;

            Functions.NT_StopClient();

            Functions.NT_StopClientFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopClient2()
        {
            NT_StopClient2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopClient2FunctionPointer;
            Functions.NT_StopClient2FunctionPointer = ptr;

            Functions.NT_StopClient2(default(NT_Inst));

            Functions.NT_StopClient2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetServer()
        {
            NT_SetServerDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetServerFunctionPointer;
            Functions.NT_SetServerFunctionPointer = ptr;

            Functions.NT_SetServer(default(byte*), default(uint));

            Functions.NT_SetServerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetServer2()
        {
            NT_SetServer2Delegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetServer2FunctionPointer;
            Functions.NT_SetServer2FunctionPointer = ptr;

            Functions.NT_SetServer2(default(NT_Inst), default(byte*), default(uint));

            Functions.NT_SetServer2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetServerMulti()
        {
            NT_SetServerMultiDelegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetServerMultiFunctionPointer;
            Functions.NT_SetServerMultiFunctionPointer = ptr;

            Functions.NT_SetServerMulti(default(UIntPtr), default(byte**), default(uint*));

            Functions.NT_SetServerMultiFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetServerMulti2()
        {
            NT_SetServerMulti2Delegate func = (a, b, c, d) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetServerMulti2FunctionPointer;
            Functions.NT_SetServerMulti2FunctionPointer = ptr;

            Functions.NT_SetServerMulti2(default(NT_Inst), default(UIntPtr), default(byte**), default(uint*));

            Functions.NT_SetServerMulti2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartDSClient()
        {
            NT_StartDSClientDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartDSClientFunctionPointer;
            Functions.NT_StartDSClientFunctionPointer = ptr;

            Functions.NT_StartDSClient(default(uint));

            Functions.NT_StartDSClientFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StartDSClient2()
        {
            NT_StartDSClient2Delegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StartDSClient2FunctionPointer;
            Functions.NT_StartDSClient2FunctionPointer = ptr;

            Functions.NT_StartDSClient2(default(NT_Inst), default(uint));

            Functions.NT_StartDSClient2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopDSClient()
        {
            NT_StopDSClientDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopDSClientFunctionPointer;
            Functions.NT_StopDSClientFunctionPointer = ptr;

            Functions.NT_StopDSClient();

            Functions.NT_StopDSClientFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopDSClient2()
        {
            NT_StopDSClient2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopDSClient2FunctionPointer;
            Functions.NT_StopDSClient2FunctionPointer = ptr;

            Functions.NT_StopDSClient2(default(NT_Inst));

            Functions.NT_StopDSClient2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopRpcServer()
        {
            NT_StopRpcServerDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopRpcServerFunctionPointer;
            Functions.NT_StopRpcServerFunctionPointer = ptr;

            Functions.NT_StopRpcServer();

            Functions.NT_StopRpcServerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopRpcServer2()
        {
            NT_StopRpcServer2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopRpcServer2FunctionPointer;
            Functions.NT_StopRpcServer2FunctionPointer = ptr;

            Functions.NT_StopRpcServer2(default(NT_Inst));

            Functions.NT_StopRpcServer2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopNotifier()
        {
            NT_StopNotifierDelegate func = () =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopNotifierFunctionPointer;
            Functions.NT_StopNotifierFunctionPointer = ptr;

            Functions.NT_StopNotifier();

            Functions.NT_StopNotifierFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_StopNotifier2()
        {
            NT_StopNotifier2Delegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_StopNotifier2FunctionPointer;
            Functions.NT_StopNotifier2FunctionPointer = ptr;

            Functions.NT_StopNotifier2(default(NT_Inst));

            Functions.NT_StopNotifier2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetUpdateRate()
        {
            NT_SetUpdateRateDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetUpdateRateFunctionPointer;
            Functions.NT_SetUpdateRateFunctionPointer = ptr;

            Functions.NT_SetUpdateRate(default(double));

            Functions.NT_SetUpdateRateFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetUpdateRate2()
        {
            NT_SetUpdateRate2Delegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetUpdateRate2FunctionPointer;
            Functions.NT_SetUpdateRate2FunctionPointer = ptr;

            Functions.NT_SetUpdateRate2(default(NT_Inst), default(double));

            Functions.NT_SetUpdateRate2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetConnections()
        {
            NT_GetConnectionsDelegate func = (a) =>
            {
                return default(NT_ConnectionInfo*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetConnectionsFunctionPointer;
            Functions.NT_GetConnectionsFunctionPointer = ptr;

            var ret = Functions.NT_GetConnections(default(UIntPtr*));

            Functions.NT_GetConnectionsFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetConnections2()
        {
            NT_GetConnections2Delegate func = (a, b) =>
            {
                return default(NT_ConnectionInfo*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetConnections2FunctionPointer;
            Functions.NT_GetConnections2FunctionPointer = ptr;

            var ret = Functions.NT_GetConnections2(default(NT_Inst), default(UIntPtr*));

            Functions.NT_GetConnections2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SavePersistent()
        {
            NT_SavePersistentDelegate func = (a) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SavePersistentFunctionPointer;
            Functions.NT_SavePersistentFunctionPointer = ptr;

            var ret = Functions.NT_SavePersistent(default(byte*));

            Functions.NT_SavePersistentFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SavePersistent2()
        {
            NT_SavePersistent2Delegate func = (a, b) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SavePersistent2FunctionPointer;
            Functions.NT_SavePersistent2FunctionPointer = ptr;

            var ret = Functions.NT_SavePersistent2(default(NT_Inst), default(byte*));

            Functions.NT_SavePersistent2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_LoadPersistent()
        {
            NT_LoadPersistentDelegate func = (a, b) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_LoadPersistentFunctionPointer;
            Functions.NT_LoadPersistentFunctionPointer = ptr;

            var ret = Functions.NT_LoadPersistent(default(byte*), default(IntPtr));

            Functions.NT_LoadPersistentFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_LoadPersistent2()
        {
            NT_LoadPersistent2Delegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_LoadPersistent2FunctionPointer;
            Functions.NT_LoadPersistent2FunctionPointer = ptr;

            var ret = Functions.NT_LoadPersistent2(default(NT_Inst), default(byte*), default(IntPtr));

            Functions.NT_LoadPersistent2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeValue()
        {
            NT_DisposeValueDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeValueFunctionPointer;
            Functions.NT_DisposeValueFunctionPointer = ptr;

            Functions.NT_DisposeValue(default(NT_Value*));

            Functions.NT_DisposeValueFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_InitValue()
        {
            NT_InitValueDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_InitValueFunctionPointer;
            Functions.NT_InitValueFunctionPointer = ptr;

            Functions.NT_InitValue(default(NT_Value*));

            Functions.NT_InitValueFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeString()
        {
            NT_DisposeStringDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeStringFunctionPointer;
            Functions.NT_DisposeStringFunctionPointer = ptr;

            Functions.NT_DisposeString(default(NT_String*));

            Functions.NT_DisposeStringFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_InitString()
        {
            NT_InitStringDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_InitStringFunctionPointer;
            Functions.NT_InitStringFunctionPointer = ptr;

            Functions.NT_InitString(default(NT_String*));

            Functions.NT_InitStringFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeEntryArray()
        {
            NT_DisposeEntryArrayDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeEntryArrayFunctionPointer;
            Functions.NT_DisposeEntryArrayFunctionPointer = ptr;

            Functions.NT_DisposeEntryArray(default(NT_Entry*), default(UIntPtr));

            Functions.NT_DisposeEntryArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeConnectionInfoArray()
        {
            NT_DisposeConnectionInfoArrayDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeConnectionInfoArrayFunctionPointer;
            Functions.NT_DisposeConnectionInfoArrayFunctionPointer = ptr;

            Functions.NT_DisposeConnectionInfoArray(default(NT_ConnectionInfo*), default(UIntPtr));

            Functions.NT_DisposeConnectionInfoArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeEntryInfoArray()
        {
            NT_DisposeEntryInfoArrayDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeEntryInfoArrayFunctionPointer;
            Functions.NT_DisposeEntryInfoArrayFunctionPointer = ptr;

            Functions.NT_DisposeEntryInfoArray(default(NT_EntryInfo*), default(UIntPtr));

            Functions.NT_DisposeEntryInfoArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeEntryInfoArray2()
        {
            NT_DisposeEntryInfoArray2Delegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeEntryInfoArray2FunctionPointer;
            Functions.NT_DisposeEntryInfoArray2FunctionPointer = ptr;

            Functions.NT_DisposeEntryInfoArray2(default(NT_EntryInfo2*), default(UIntPtr));

            Functions.NT_DisposeEntryInfoArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeRpcDefinition()
        {
            NT_DisposeRpcDefinitionDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeRpcDefinitionFunctionPointer;
            Functions.NT_DisposeRpcDefinitionFunctionPointer = ptr;

            Functions.NT_DisposeRpcDefinition(default(NT_RpcDefinition*));

            Functions.NT_DisposeRpcDefinitionFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_DisposeRpcCallInfo()
        {
            NT_DisposeRpcCallInfoDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_DisposeRpcCallInfoFunctionPointer;
            Functions.NT_DisposeRpcCallInfoFunctionPointer = ptr;

            Functions.NT_DisposeRpcCallInfo(default(NT_RpcCallInfo*));

            Functions.NT_DisposeRpcCallInfoFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_Now()
        {
            NT_NowDelegate func = () =>
            {
                return default(ulong);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_NowFunctionPointer;
            Functions.NT_NowFunctionPointer = ptr;

            var ret = Functions.NT_Now();

            Functions.NT_NowFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetLogger()
        {
            NT_SetLoggerDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetLoggerFunctionPointer;
            Functions.NT_SetLoggerFunctionPointer = ptr;

            Functions.NT_SetLogger(default(IntPtr), default(uint));

            Functions.NT_SetLoggerFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetLogger2()
        {
            NT_SetLogger2Delegate func = (a, b, c) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetLogger2FunctionPointer;
            Functions.NT_SetLogger2FunctionPointer = ptr;

            Functions.NT_SetLogger2(default(NT_Inst), default(IntPtr), default(uint));

            Functions.NT_SetLogger2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AllocateCharArray()
        {
            NT_AllocateCharArrayDelegate func = (a) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AllocateCharArrayFunctionPointer;
            Functions.NT_AllocateCharArrayFunctionPointer = ptr;

            var ret = Functions.NT_AllocateCharArray(default(UIntPtr));

            Functions.NT_AllocateCharArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AllocateBooleanArray()
        {
            NT_AllocateBooleanArrayDelegate func = (a) =>
            {
                return default(NT_Bool*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AllocateBooleanArrayFunctionPointer;
            Functions.NT_AllocateBooleanArrayFunctionPointer = ptr;

            var ret = Functions.NT_AllocateBooleanArray(default(UIntPtr));

            Functions.NT_AllocateBooleanArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AllocateDoubleArray()
        {
            NT_AllocateDoubleArrayDelegate func = (a) =>
            {
                return default(double*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AllocateDoubleArrayFunctionPointer;
            Functions.NT_AllocateDoubleArrayFunctionPointer = ptr;

            var ret = Functions.NT_AllocateDoubleArray(default(UIntPtr));

            Functions.NT_AllocateDoubleArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_AllocateStringArray()
        {
            NT_AllocateStringArrayDelegate func = (a) =>
            {
                return default(NT_String*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_AllocateStringArrayFunctionPointer;
            Functions.NT_AllocateStringArrayFunctionPointer = ptr;

            var ret = Functions.NT_AllocateStringArray(default(UIntPtr));

            Functions.NT_AllocateStringArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_FreeCharArray()
        {
            NT_FreeCharArrayDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_FreeCharArrayFunctionPointer;
            Functions.NT_FreeCharArrayFunctionPointer = ptr;

            Functions.NT_FreeCharArray(default(byte*));

            Functions.NT_FreeCharArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_FreeDoubleArray()
        {
            NT_FreeDoubleArrayDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_FreeDoubleArrayFunctionPointer;
            Functions.NT_FreeDoubleArrayFunctionPointer = ptr;

            Functions.NT_FreeDoubleArray(default(double*));

            Functions.NT_FreeDoubleArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_FreeBooleanArray()
        {
            NT_FreeBooleanArrayDelegate func = (a) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_FreeBooleanArrayFunctionPointer;
            Functions.NT_FreeBooleanArrayFunctionPointer = ptr;

            Functions.NT_FreeBooleanArray(default(NT_Bool*));

            Functions.NT_FreeBooleanArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_FreeStringArray()
        {
            NT_FreeStringArrayDelegate func = (a, b) =>
            {
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_FreeStringArrayFunctionPointer;
            Functions.NT_FreeStringArrayFunctionPointer = ptr;

            Functions.NT_FreeStringArray(default(NT_String*), default(UIntPtr));

            Functions.NT_FreeStringArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueBoolean()
        {
            NT_GetValueBooleanDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueBooleanFunctionPointer;
            Functions.NT_GetValueBooleanFunctionPointer = ptr;

            var ret = Functions.NT_GetValueBoolean(default(NT_Value*), default(ulong*), default(NT_Bool*));

            Functions.NT_GetValueBooleanFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueDouble()
        {
            NT_GetValueDoubleDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueDoubleFunctionPointer;
            Functions.NT_GetValueDoubleFunctionPointer = ptr;

            var ret = Functions.NT_GetValueDouble(default(NT_Value*), default(ulong*), default(double*));

            Functions.NT_GetValueDoubleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueString()
        {
            NT_GetValueStringDelegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueStringFunctionPointer;
            Functions.NT_GetValueStringFunctionPointer = ptr;

            var ret = Functions.NT_GetValueString(default(NT_Value*), default(ulong*), default(UIntPtr*));

            Functions.NT_GetValueStringFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueRaw()
        {
            NT_GetValueRawDelegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueRawFunctionPointer;
            Functions.NT_GetValueRawFunctionPointer = ptr;

            var ret = Functions.NT_GetValueRaw(default(NT_Value*), default(ulong*), default(UIntPtr*));

            Functions.NT_GetValueRawFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueBooleanArray()
        {
            NT_GetValueBooleanArrayDelegate func = (a, b, c) =>
            {
                return default(NT_Bool*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueBooleanArrayFunctionPointer;
            Functions.NT_GetValueBooleanArrayFunctionPointer = ptr;

            var ret = Functions.NT_GetValueBooleanArray(default(NT_Value*), default(ulong*), default(UIntPtr*));

            Functions.NT_GetValueBooleanArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueDoubleArray()
        {
            NT_GetValueDoubleArrayDelegate func = (a, b, c) =>
            {
                return default(double*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueDoubleArrayFunctionPointer;
            Functions.NT_GetValueDoubleArrayFunctionPointer = ptr;

            var ret = Functions.NT_GetValueDoubleArray(default(NT_Value*), default(ulong*), default(UIntPtr*));

            Functions.NT_GetValueDoubleArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetValueStringArray()
        {
            NT_GetValueStringArrayDelegate func = (a, b, c) =>
            {
                return default(NT_String*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetValueStringArrayFunctionPointer;
            Functions.NT_GetValueStringArrayFunctionPointer = ptr;

            var ret = Functions.NT_GetValueStringArray(default(NT_Value*), default(ulong*), default(UIntPtr*));

            Functions.NT_GetValueStringArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryBoolean()
        {
            NT_GetEntryBooleanDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryBooleanFunctionPointer;
            Functions.NT_GetEntryBooleanFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryBoolean(default(byte*), default(UIntPtr), default(ulong*), default(NT_Bool*));

            Functions.NT_GetEntryBooleanFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryBoolean2()
        {
            NT_GetEntryBoolean2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryBoolean2FunctionPointer;
            Functions.NT_GetEntryBoolean2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryBoolean2(default(NT_Entry), default(ulong*), default(NT_Bool*));

            Functions.NT_GetEntryBoolean2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryDouble()
        {
            NT_GetEntryDoubleDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryDoubleFunctionPointer;
            Functions.NT_GetEntryDoubleFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryDouble(default(byte*), default(UIntPtr), default(ulong*), default(double*));

            Functions.NT_GetEntryDoubleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryDouble2()
        {
            NT_GetEntryDouble2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryDouble2FunctionPointer;
            Functions.NT_GetEntryDouble2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryDouble2(default(NT_Entry), default(ulong*), default(double*));

            Functions.NT_GetEntryDouble2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryString()
        {
            NT_GetEntryStringDelegate func = (a, b, c, d) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryStringFunctionPointer;
            Functions.NT_GetEntryStringFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryString(default(byte*), default(UIntPtr), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryStringFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryString2()
        {
            NT_GetEntryString2Delegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryString2FunctionPointer;
            Functions.NT_GetEntryString2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryString2(default(NT_Entry), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryString2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryRaw()
        {
            NT_GetEntryRawDelegate func = (a, b, c, d) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryRawFunctionPointer;
            Functions.NT_GetEntryRawFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryRaw(default(byte*), default(UIntPtr), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryRawFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryRaw2()
        {
            NT_GetEntryRaw2Delegate func = (a, b, c) =>
            {
                return default(byte*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryRaw2FunctionPointer;
            Functions.NT_GetEntryRaw2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryRaw2(default(NT_Entry), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryRaw2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryBooleanArray()
        {
            NT_GetEntryBooleanArrayDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryBooleanArrayFunctionPointer;
            Functions.NT_GetEntryBooleanArrayFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryBooleanArray(default(byte*), default(UIntPtr), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryBooleanArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryBooleanArray2()
        {
            NT_GetEntryBooleanArray2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryBooleanArray2FunctionPointer;
            Functions.NT_GetEntryBooleanArray2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryBooleanArray2(default(NT_Entry), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryBooleanArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryDoubleArray()
        {
            NT_GetEntryDoubleArrayDelegate func = (a, b, c, d) =>
            {
                return default(double*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryDoubleArrayFunctionPointer;
            Functions.NT_GetEntryDoubleArrayFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryDoubleArray(default(byte*), default(UIntPtr), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryDoubleArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryDoubleArray2()
        {
            NT_GetEntryDoubleArray2Delegate func = (a, b, c) =>
            {
                return default(double*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryDoubleArray2FunctionPointer;
            Functions.NT_GetEntryDoubleArray2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryDoubleArray2(default(NT_Entry), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryDoubleArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryStringArray()
        {
            NT_GetEntryStringArrayDelegate func = (a, b, c, d) =>
            {
                return default(NT_String*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryStringArrayFunctionPointer;
            Functions.NT_GetEntryStringArrayFunctionPointer = ptr;

            var ret = Functions.NT_GetEntryStringArray(default(byte*), default(UIntPtr), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryStringArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_GetEntryStringArray2()
        {
            NT_GetEntryStringArray2Delegate func = (a, b, c) =>
            {
                return default(NT_String*);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_GetEntryStringArray2FunctionPointer;
            Functions.NT_GetEntryStringArray2FunctionPointer = ptr;

            var ret = Functions.NT_GetEntryStringArray2(default(NT_Entry), default(ulong*), default(UIntPtr*));

            Functions.NT_GetEntryStringArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryBoolean()
        {
            NT_SetDefaultEntryBooleanDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryBooleanFunctionPointer;
            Functions.NT_SetDefaultEntryBooleanFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryBoolean(default(byte*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetDefaultEntryBooleanFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryBoolean2()
        {
            NT_SetDefaultEntryBoolean2Delegate func = (a, b) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryBoolean2FunctionPointer;
            Functions.NT_SetDefaultEntryBoolean2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryBoolean2(default(NT_Entry), default(NT_Bool));

            Functions.NT_SetDefaultEntryBoolean2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryDouble()
        {
            NT_SetDefaultEntryDoubleDelegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryDoubleFunctionPointer;
            Functions.NT_SetDefaultEntryDoubleFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryDouble(default(byte*), default(UIntPtr), default(double));

            Functions.NT_SetDefaultEntryDoubleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryDouble2()
        {
            NT_SetDefaultEntryDouble2Delegate func = (a, b) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryDouble2FunctionPointer;
            Functions.NT_SetDefaultEntryDouble2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryDouble2(default(NT_Entry), default(double));

            Functions.NT_SetDefaultEntryDouble2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryString()
        {
            NT_SetDefaultEntryStringDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryStringFunctionPointer;
            Functions.NT_SetDefaultEntryStringFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryString(default(byte*), default(UIntPtr), default(byte*), default(UIntPtr));

            Functions.NT_SetDefaultEntryStringFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryString2()
        {
            NT_SetDefaultEntryString2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryString2FunctionPointer;
            Functions.NT_SetDefaultEntryString2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryString2(default(NT_Entry), default(byte*), default(UIntPtr));

            Functions.NT_SetDefaultEntryString2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryRaw()
        {
            NT_SetDefaultEntryRawDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryRawFunctionPointer;
            Functions.NT_SetDefaultEntryRawFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryRaw(default(byte*), default(UIntPtr), default(byte*), default(UIntPtr));

            Functions.NT_SetDefaultEntryRawFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryRaw2()
        {
            NT_SetDefaultEntryRaw2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryRaw2FunctionPointer;
            Functions.NT_SetDefaultEntryRaw2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryRaw2(default(NT_Entry), default(byte*), default(UIntPtr));

            Functions.NT_SetDefaultEntryRaw2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryBooleanArray()
        {
            NT_SetDefaultEntryBooleanArrayDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryBooleanArrayFunctionPointer;
            Functions.NT_SetDefaultEntryBooleanArrayFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryBooleanArray(default(byte*), default(UIntPtr), default(int*), default(UIntPtr));

            Functions.NT_SetDefaultEntryBooleanArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryBooleanArray2()
        {
            NT_SetDefaultEntryBooleanArray2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryBooleanArray2FunctionPointer;
            Functions.NT_SetDefaultEntryBooleanArray2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryBooleanArray2(default(NT_Entry), default(int*), default(UIntPtr));

            Functions.NT_SetDefaultEntryBooleanArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryDoubleArray()
        {
            NT_SetDefaultEntryDoubleArrayDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryDoubleArrayFunctionPointer;
            Functions.NT_SetDefaultEntryDoubleArrayFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryDoubleArray(default(byte*), default(UIntPtr), default(double*), default(UIntPtr));

            Functions.NT_SetDefaultEntryDoubleArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryDoubleArray2()
        {
            NT_SetDefaultEntryDoubleArray2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryDoubleArray2FunctionPointer;
            Functions.NT_SetDefaultEntryDoubleArray2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryDoubleArray2(default(NT_Entry), default(double*), default(UIntPtr));

            Functions.NT_SetDefaultEntryDoubleArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryStringArray()
        {
            NT_SetDefaultEntryStringArrayDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryStringArrayFunctionPointer;
            Functions.NT_SetDefaultEntryStringArrayFunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryStringArray(default(byte*), default(UIntPtr), default(NT_String*), default(UIntPtr));

            Functions.NT_SetDefaultEntryStringArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetDefaultEntryStringArray2()
        {
            NT_SetDefaultEntryStringArray2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetDefaultEntryStringArray2FunctionPointer;
            Functions.NT_SetDefaultEntryStringArray2FunctionPointer = ptr;

            var ret = Functions.NT_SetDefaultEntryStringArray2(default(NT_Entry), default(NT_String*), default(UIntPtr));

            Functions.NT_SetDefaultEntryStringArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryBoolean()
        {
            NT_SetEntryBooleanDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryBooleanFunctionPointer;
            Functions.NT_SetEntryBooleanFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryBoolean(default(byte*), default(UIntPtr), default(NT_Bool), default(NT_Bool));

            Functions.NT_SetEntryBooleanFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryBoolean2()
        {
            NT_SetEntryBoolean2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryBoolean2FunctionPointer;
            Functions.NT_SetEntryBoolean2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryBoolean2(default(NT_Entry), default(NT_Bool), default(NT_Bool));

            Functions.NT_SetEntryBoolean2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryDouble()
        {
            NT_SetEntryDoubleDelegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryDoubleFunctionPointer;
            Functions.NT_SetEntryDoubleFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryDouble(default(byte*), default(UIntPtr), default(double), default(NT_Bool));

            Functions.NT_SetEntryDoubleFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryDouble2()
        {
            NT_SetEntryDouble2Delegate func = (a, b, c) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryDouble2FunctionPointer;
            Functions.NT_SetEntryDouble2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryDouble2(default(NT_Entry), default(double), default(NT_Bool));

            Functions.NT_SetEntryDouble2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryString()
        {
            NT_SetEntryStringDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryStringFunctionPointer;
            Functions.NT_SetEntryStringFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryString(default(byte*), default(UIntPtr), default(byte*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryStringFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryString2()
        {
            NT_SetEntryString2Delegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryString2FunctionPointer;
            Functions.NT_SetEntryString2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryString2(default(NT_Entry), default(byte*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryString2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryRaw()
        {
            NT_SetEntryRawDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryRawFunctionPointer;
            Functions.NT_SetEntryRawFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryRaw(default(byte*), default(UIntPtr), default(byte*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryRawFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryRaw2()
        {
            NT_SetEntryRaw2Delegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryRaw2FunctionPointer;
            Functions.NT_SetEntryRaw2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryRaw2(default(NT_Entry), default(byte*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryRaw2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryBooleanArray()
        {
            NT_SetEntryBooleanArrayDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryBooleanArrayFunctionPointer;
            Functions.NT_SetEntryBooleanArrayFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryBooleanArray(default(byte*), default(UIntPtr), default(int*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryBooleanArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryBooleanArray2()
        {
            NT_SetEntryBooleanArray2Delegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryBooleanArray2FunctionPointer;
            Functions.NT_SetEntryBooleanArray2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryBooleanArray2(default(NT_Entry), default(int*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryBooleanArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryDoubleArray()
        {
            NT_SetEntryDoubleArrayDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryDoubleArrayFunctionPointer;
            Functions.NT_SetEntryDoubleArrayFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryDoubleArray(default(byte*), default(UIntPtr), default(double*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryDoubleArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryDoubleArray2()
        {
            NT_SetEntryDoubleArray2Delegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryDoubleArray2FunctionPointer;
            Functions.NT_SetEntryDoubleArray2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryDoubleArray2(default(NT_Entry), default(double*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryDoubleArray2FunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryStringArray()
        {
            NT_SetEntryStringArrayDelegate func = (a, b, c, d, e) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryStringArrayFunctionPointer;
            Functions.NT_SetEntryStringArrayFunctionPointer = ptr;

            var ret = Functions.NT_SetEntryStringArray(default(byte*), default(UIntPtr), default(NT_String*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryStringArrayFunctionPointer = tmp;
        }

        [Fact]
        public unsafe void TestNT_SetEntryStringArray2()
        {
            NT_SetEntryStringArray2Delegate func = (a, b, c, d) =>
            {
                return default(NT_Bool);
            };

            var ptr = Marshal.GetFunctionPointerForDelegate(func);
            var tmp = Functions.NT_SetEntryStringArray2FunctionPointer;
            Functions.NT_SetEntryStringArray2FunctionPointer = ptr;

            var ret = Functions.NT_SetEntryStringArray2(default(NT_Entry), default(NT_String*), default(UIntPtr), default(NT_Bool));

            Functions.NT_SetEntryStringArray2FunctionPointer = tmp;
        }
    }
}
