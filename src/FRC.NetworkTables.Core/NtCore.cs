﻿using FRC.NetworkTables.Core.Interop;
using System;
using System.Collections.Generic;
using System.Text;
using FRC;
using System.Runtime.CompilerServices;
using NetworkTables;

namespace FRC.NetworkTables.Core
{
    public static class NtCore
    {


        public static NetworkTableInstance NT_GetDefaultInstance()
        {
            return Functions.NT_GetDefaultInstance();
        }

        public static NetworkTableInstance NT_CreateInstance()
        {
            return Functions.NT_CreateInstance();
        }

        public static void NT_DestroyInstance(NetworkTableInstance inst)
        {
            Functions.NT_DestroyInstance((NT_Inst)inst);
        }

        public static NetworkTableInstance NT_GetInstanceFromHandle(NT_Handle handle)
        {
            return Functions.NT_GetInstanceFromHandle(handle);
        }

        public static unsafe NetworkTableEntry NT_GetEntry(NetworkTableInstance inst, string str)
        {
            var nativeStr = UTF8String.CreateCachedUTF8String(str);
            return Functions.NT_GetEntry((NT_Inst)inst, nativeStr.Buffer, nativeStr.Length);
        }

        public static unsafe NetworkTableEntry[] NT_GetEntries(NT_Inst inst, string prefix, uint types, UIntPtr* count)
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

        public static unsafe string NT_GetEntryName(NetworkTableEntry entry)
        {
            UIntPtr len;
            var nativeStr = Functions.NT_GetEntryName((NT_Entry)entry, &len);
            var str = UTF8String.ReadUTF8String(nativeStr);
            Functions.NT_FreeCharArray(nativeStr);
            return str;
        }

        public static ulong NT_GetEntryLastChange(NetworkTableEntry entry)
        {
            return Functions.NT_GetEntryLastChange((NT_Entry)entry);
        }

        public static unsafe NetworkTableValue NT_GetEntryValue(string name)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            Functions.NT_GetEntryValue(nativeName.Buffer, nativeName.Length, &val);
            var retVal = NetworkTableValue.CreateFromNative(&val);
            Functions.NT_DisposeValue(&val);
            return retVal;
        }

        public static unsafe NetworkTableValue NT_GetEntryValue(NetworkTableEntry entry)
        {
            NT_Value val;
            Functions.NT_GetEntryValue2((NT_Entry)entry, &val);
            var retVal = NetworkTableValue.CreateFromNative(&val);
            Functions.NT_DisposeValue(&val);
            return retVal;
        }

        public static unsafe bool NT_SetDefaultEntryValue(string name, NetworkTableValue default_value)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            NetworkTableValue.CreateNative(default_value, &val);
            var ret = Functions.NT_SetDefaultEntryValue(nativeName.Buffer, nativeName.Length, &val);
            NetworkTableValue.DisposeNative(&val);
            return ret.Get();
        }

        public static unsafe bool NT_SetDefaultEntryValue2(NetworkTableEntry entry, NetworkTableValue default_value)
        {
            NT_Value val;
            NetworkTableValue.CreateNative(default_value, &val);
            var ret = Functions.NT_SetDefaultEntryValue2((NT_Entry)entry, &val);
            NetworkTableValue.DisposeNative(&val);
            return ret.Get();
        }

        public static unsafe bool NT_SetEntryValue(string name, NetworkTableValue value)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            NetworkTableValue.CreateNative(value, &val);
            var ret = Functions.NT_SetEntryValue(nativeName.Buffer, nativeName.Length, &val);
            NetworkTableValue.DisposeNative(&val);
            return ret.Get();
        }

        public static unsafe bool NT_SetEntryValue2(NetworkTableEntry entry, NetworkTableValue value)
        {
            NT_Value val;
            NetworkTableValue.CreateNative(value, &val);
            var ret = Functions.NT_SetDefaultEntryValue2((NT_Entry)entry, &val);
            NetworkTableValue.DisposeNative(&val);
            return ret.Get();
        }

        public static unsafe void NT_SetEntryTypeValue(string name, NetworkTableValue value)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            NT_Value val;
            NetworkTableValue.CreateNative(value, &val);
            Functions.NT_SetEntryTypeValue(nativeName.Buffer, nativeName.Length, &val);
            NetworkTableValue.DisposeNative(&val);
        }

        public static unsafe void NT_SetEntryTypeValue2(NetworkTableEntry entry, NetworkTableValue value)
        {
            NT_Value val;
            NetworkTableValue.CreateNative(value, &val);
            Functions.NT_SetEntryTypeValue2((NT_Entry)entry, &val);
            NetworkTableValue.DisposeNative(&val);

        }

        public static unsafe void NT_SetEntryFlags(string name, uint flags)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            Functions.NT_SetEntryFlags(nativeName.Buffer, nativeName.Length, flags);
        }

        public static unsafe void NT_SetEntryFlags2(NetworkTableEntry entry, uint flags)
        {
            Functions.NT_SetEntryFlags2((NT_Entry)entry, flags);
        }

        public static unsafe uint NT_GetEntryFlags(string name)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            return Functions.NT_GetEntryFlags(nativeName.Buffer, nativeName.Length);
        }

        public static unsafe uint NT_GetEntryFlags2(NetworkTableEntry entry)
        {
            return Functions.NT_GetEntryFlags2((NT_Entry)entry);
        }

        public static unsafe void NT_DeleteEntry(string name)
        {
            var nativeName = UTF8String.CreateCachedUTF8String(name);
            Functions.NT_DeleteEntry(nativeName.Buffer, nativeName.Length);
        }

        public static unsafe void NT_DeleteEntry2(NetworkTableEntry entry)
        {
            Functions.NT_DeleteEntry2((NT_Entry)entry);
        }

        public static unsafe void NT_DeleteAllEntries()
        {
            Functions.NT_DeleteAllEntries();
        }

        public static unsafe void NT_DeleteAllEntries2(NetworkTableInstance inst)
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

        public static unsafe NT_Bool NT_SetEntryStringArray(string name, NT_String* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryStringArray2(NetworkTableEntry entry, NT_String* arr, UIntPtr size, NT_Bool force)
        {
            throw null;
        }
    }
}
