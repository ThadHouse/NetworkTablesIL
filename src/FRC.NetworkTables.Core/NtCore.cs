using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.Text;
using FRC;
using System.Runtime.CompilerServices;

namespace FRC.NetworkTables.Core
{
    public class NtCore
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
            return Functions.NT_GetEntry(inst, (byte*)nativeStr.Buffer.ToPointer(), nativeStr.Length);
        }

        public static unsafe T[] CopyArray<T>(void* source, int len)
        {
            T[] arr = new T[len];
            var size = Unsafe.SizeOf<T>();
            for (int i = 0; i < len; i++)
            {
                Unsafe.Copy((byte*)source + size * i, ref arr[i]);
            }
            return arr;
        }

        public static unsafe NT_Entry[] NT_GetEntries(NT_Inst inst, string prefix, uint types, UIntPtr* count)
        {
            var nativePrefix = UTF8String.CreateCachedUTF8String(prefix);
            UIntPtr len;
            var entriesPtr = Functions.NT_GetEntries(inst, (byte*)nativePrefix.Buffer.ToPointer(), nativePrefix.Length, types, &len);
            int lenInt = (int)len;
            NT_Entry[] entries = new NT_Entry[lenInt];
            
            for (int i = 0; i < lenInt; i++)
            {
                Unsafe.Copy(ref entries[i], &entriesPtr[i]);
            }

            Functions.
                NT_DisposeEntryArray(entriesPtr, len);

            return entries;
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

        public static unsafe void NT_SetListenerOnStart(NT_OnStart onStart, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetListenerOnStart2(NT_Inst inst, NT_OnStart onStart, void* data)
        {
            throw null;
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

        public static unsafe NT_EntryListener NT_AddEntryListenerSingle(NT_Entry entry, void* data, NT_EntryListenerCallback2 callback, uint flags)
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

        public static unsafe NT_Bool NT_NotifierDestroyed()
        {
            throw null;
        }

        public static unsafe NT_Bool NT_NotifierDestroyed2(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetRpcServerOnStart(NT_Inst inst, NT_OnStart onStart, void* data)
        {
            throw null;
        }

        public static unsafe void NT_SetRpcServerOnExit(NT_Inst inst, NT_OnExit onExit, void* data)
        {
            throw null;
        }

        public static unsafe void NT_CreateRpc(NT_Entry entry, byte* def, UIntPtr def_len, void* data, NT_RpcCallback callback)
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

        public static unsafe byte* NT_LoadPersistent(byte* filename, NT_WarnFunc warn)
        {
            throw null;
        }

        public static unsafe byte* NT_LoadPersistent2(NT_Inst inst, byte* filename, NT_WarnFunc warn)
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

        public static unsafe void NT_SetLogger(NT_LogFunc func, uint min_level)
        {
            throw null;
        }

        public static unsafe void NT_SetLogger2(NT_Inst inst, NT_LogFunc func, uint min_level)
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
