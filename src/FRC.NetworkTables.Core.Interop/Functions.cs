using System;

namespace FRC.NetworkTables.Core.Interop
{
    public static class Functions
    {
        public static IntPtr NT_DisposeEntryNotificationArrayFunctionPointer;
        public static IntPtr NT_DisposeEntryNotificationFunctionPointer;
        public static IntPtr NT_DisposeConnectionNotificationArrayFunctionPointer;
        public static IntPtr NT_DisposeConnectionNotificationFunctionPointer;
        public static IntPtr NT_DisposeLogMessageArrayFunctionPointer;
        public static IntPtr NT_DisposeLogMessageFunctionPointer;
        public static IntPtr NT_NowFunctionPointer;
        public static IntPtr NT_CreateLoggerPollerFunctionPointer;
        public static IntPtr NT_DestroyLoggerPollerFunctionPointer;
        public static IntPtr NT_AddPolledLoggerFunctionPointer;
        public static IntPtr NT_PollLoggerFunctionPointer;
        public static IntPtr NT_PollLoggerTimeoutFunctionPointer;
        public static IntPtr NT_CancelPollLoggerFunctionPointer;
        public static IntPtr NT_RemoveLoggerFunctionPointer;
        public static IntPtr NT_WaitForLoggerQueueFunctionPointer;
        public static IntPtr NT_AllocateCharArrayFunctionPointer;
        public static IntPtr NT_AllocateBooleanArrayFunctionPointer;
        public static IntPtr NT_AllocateDoubleArrayFunctionPointer;
        public static IntPtr NT_AllocateStringArrayFunctionPointer;
        public static IntPtr NT_FreeCharArrayFunctionPointer;
        public static IntPtr NT_FreeDoubleArrayFunctionPointer;
        public static IntPtr NT_FreeBooleanArrayFunctionPointer;
        public static IntPtr NT_FreeStringArrayFunctionPointer;
        public static IntPtr NT_GetDefaultInstanceFunctionPointer;
        public static IntPtr NT_CreateInstanceFunctionPointer;
        public static IntPtr NT_DestroyInstanceFunctionPointer;
        public static IntPtr NT_GetInstanceFromHandleFunctionPointer;
        public static IntPtr NT_GetEntryFunctionPointer;
        public static IntPtr NT_GetEntriesFunctionPointer;
        public static IntPtr NT_GetEntryNameFunctionPointer;
        public static IntPtr NT_GetEntryTypeFunctionPointer;
        public static IntPtr NT_GetEntryLastChangeFunctionPointer;
        public static IntPtr NT_GetEntryValueFunctionPointer;
        public static IntPtr NT_SetDefaultEntryValueFunctionPointer;
        public static IntPtr NT_SetEntryValueFunctionPointer;
        public static IntPtr NT_SetEntryTypeValueFunctionPointer;
        public static IntPtr NT_SetEntryFlagsFunctionPointer;
        public static IntPtr NT_GetEntryFlagsFunctionPointer;
        public static IntPtr NT_DeleteEntryFunctionPointer;
        public static IntPtr NT_DeleteAllEntriesFunctionPointer;
        public static IntPtr NT_GetEntryInfoFunctionPointer;
        public static IntPtr NT_GetEntryInfoHandleFunctionPointer;
        public static IntPtr NT_CreateEntryListenerPollerFunctionPointer;
        public static IntPtr NT_DestroyEntryListenerPollerFunctionPointer;
        public static IntPtr NT_AddPolledEntryListenerFunctionPointer;
        public static IntPtr NT_AddPolledEntryListenerSingleFunctionPointer;
        public static IntPtr NT_PollEntryListenerFunctionPointer;
        public static IntPtr NT_PollEntryListenerTimeoutFunctionPointer;
        public static IntPtr NT_CancelPollEntryListenerFunctionPointer;
        public static IntPtr NT_RemoveEntryListenerFunctionPointer;
        public static IntPtr NT_WaitForEntryListenerQueueFunctionPointer;
        public static IntPtr NT_CreateConnectionListenerPollerFunctionPointer;
        public static IntPtr NT_DestroyConnectionListenerPollerFunctionPointer;
        public static IntPtr NT_AddPolledConnectionListenerFunctionPointer;
        public static IntPtr NT_PollConnectionListenerFunctionPointer;
        public static IntPtr NT_PollConnectionListenerTimeoutFunctionPointer;
        public static IntPtr NT_CancelPollConnectionListenerFunctionPointer;
        public static IntPtr NT_RemoveConnectionListenerFunctionPointer;
        public static IntPtr NT_WaitForConnectionListenerQueueFunctionPointer;
        public static IntPtr NT_CreateRpcCallPollerFunctionPointer;
        public static IntPtr NT_DestroyRpcCallPollerFunctionPointer;
        public static IntPtr NT_CreatePolledRpcFunctionPointer;
        public static IntPtr NT_PollRpcFunctionPointer;
        public static IntPtr NT_PollRpcTimeoutFunctionPointer;
        public static IntPtr NT_CancelPollRpcFunctionPointer;
        public static IntPtr NT_WaitForRpcCallQueueFunctionPointer;
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
        public static IntPtr NT_GetNetworkModeFunctionPointer;
        public static IntPtr NT_StartServerFunctionPointer;
        public static IntPtr NT_StopServerFunctionPointer;
        public static IntPtr NT_StartClientNoneFunctionPointer;
        public static IntPtr NT_StartClientFunctionPointer;
        public static IntPtr NT_StartClientMultiFunctionPointer;
        public static IntPtr NT_StartClientTeamFunctionPointer;
        public static IntPtr NT_StopClientFunctionPointer;
        public static IntPtr NT_SetServerFunctionPointer;
        public static IntPtr NT_SetServerMultiFunctionPointer;
        public static IntPtr NT_SetServerTeamFunctionPointer;
        public static IntPtr NT_StartDSClientFunctionPointer;
        public static IntPtr NT_StopDSClientFunctionPointer;
        public static IntPtr NT_SetUpdateRateFunctionPointer;
        public static IntPtr NT_FlushFunctionPointer;
        public static IntPtr NT_GetConnectionsFunctionPointer;
        public static IntPtr NT_IsConnectedFunctionPointer;
        public static IntPtr NT_SavePersistentFunctionPointer;
        public static IntPtr NT_LoadPersistentFunctionPointer;
        public static IntPtr NT_SaveEntriesFunctionPointer;
        public static IntPtr NT_LoadEntriesFunctionPointer;
        public static IntPtr NT_DisposeValueFunctionPointer;
        public static IntPtr NT_InitValueFunctionPointer;
        public static IntPtr NT_DisposeStringFunctionPointer;
        public static IntPtr NT_InitStringFunctionPointer;
        public static IntPtr NT_DisposeEntryArrayFunctionPointer;
        public static IntPtr NT_DisposeConnectionInfoArrayFunctionPointer;
        public static IntPtr NT_DisposeEntryInfoArrayFunctionPointer;
        public static IntPtr NT_DisposeEntryInfoFunctionPointer;
        public static IntPtr NT_DisposeRpcDefinitionFunctionPointer;
        public static IntPtr NT_DisposeRpcAnswerArrayFunctionPointer;
        public static IntPtr NT_DisposeRpcAnswerFunctionPointer;

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

        public static unsafe NT_Type NT_GetEntryType(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe ulong NT_GetEntryLastChange(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_GetEntryValue(NT_Entry entry, NT_Value* value)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetDefaultEntryValue(NT_Entry entry, NT_Value* default_value)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_SetEntryValue(NT_Entry entry, NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_SetEntryTypeValue(NT_Entry entry, NT_Value* value)
        {
            throw null;
        }

        public static unsafe void NT_SetEntryFlags(NT_Entry entry, uint flags)
        {
            throw null;
        }

        public static unsafe uint NT_GetEntryFlags(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_DeleteEntry(NT_Entry entry)
        {
            throw null;
        }

        public static unsafe void NT_DeleteAllEntries(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe NT_EntryInfo* NT_GetEntryInfo(NT_Inst inst, byte* prefix, UIntPtr prefix_len, uint types, UIntPtr* count)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_GetEntryInfoHandle(NT_Entry entry, NT_EntryInfo* info)
        {
            throw null;
        }

        public static unsafe NT_EntryListenerPoller NT_CreateEntryListenerPoller(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_DestroyEntryListenerPoller(NT_EntryListenerPoller poller)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddPolledEntryListener(NT_EntryListenerPoller poller, byte* prefix, UIntPtr prefix_len, uint flags)
        {
            throw null;
        }

        public static unsafe NT_EntryListener NT_AddPolledEntryListenerSingle(NT_EntryListenerPoller poller, NT_Entry entry, uint flags)
        {
            throw null;
        }

        public static unsafe NT_EntryNotification* NT_PollEntryListener(NT_EntryListenerPoller poller, UIntPtr* len)
        {
            throw null;
        }

        public static unsafe NT_EntryNotification* NT_PollEntryListenerTimeout(NT_EntryListenerPoller poller, UIntPtr* len, double timeout, NT_Bool* timed_out)
        {
            throw null;
        }

        public static unsafe void NT_CancelPollEntryListener(NT_EntryListenerPoller poller)
        {
            throw null;
        }

        public static unsafe void NT_RemoveEntryListener(NT_EntryListener entry_listener)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_WaitForEntryListenerQueue(NT_Inst inst, double timeout)
        {
            throw null;
        }

        public static unsafe NT_ConnectionListenerPoller NT_CreateConnectionListenerPoller(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_DestroyConnectionListenerPoller(NT_ConnectionListenerPoller poller)
        {
            throw null;
        }

        public static unsafe NT_ConnectionListener NT_AddPolledConnectionListener(NT_ConnectionListenerPoller poller, NT_Bool immediate_notify)
        {
            throw null;
        }

        public static unsafe NT_ConnectionNotification* NT_PollConnectionListener(NT_ConnectionListenerPoller poller, UIntPtr* len)
        {
            throw null;
        }

        public static unsafe NT_ConnectionNotification* NT_PollConnectionListenerTimeout(NT_ConnectionListenerPoller poller, UIntPtr* len, double timeout, NT_Bool* timed_out)
        {
            throw null;
        }

        public static unsafe void NT_CancelPollConnectionListener(NT_ConnectionListenerPoller poller)
        {
            throw null;
        }

        public static unsafe void NT_RemoveConnectionListener(NT_ConnectionListener conn_listener)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_WaitForConnectionListenerQueue(NT_Inst inst, double timeout)
        {
            throw null;
        }

        public static unsafe NT_RpcCallPoller NT_CreateRpcCallPoller(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_DestroyRpcCallPoller(NT_RpcCallPoller poller)
        {
            throw null;
        }

        public static unsafe void NT_CreatePolledRpc(NT_Entry entry, byte* def, UIntPtr def_len, NT_RpcCallPoller poller)
        {
            throw null;
        }

        public static unsafe NT_RpcAnswer* NT_PollRpc(NT_RpcCallPoller poller, UIntPtr* len)
        {
            throw null;
        }

        public static unsafe NT_RpcAnswer* NT_PollRpcTimeout(NT_RpcCallPoller poller, UIntPtr* len, double timeout, NT_Bool* timed_out)
        {
            throw null;
        }

        public static unsafe void NT_CancelPollRpc(NT_RpcCallPoller poller)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_WaitForRpcCallQueue(NT_Inst inst, double timeout)
        {
            throw null;
        }

        public static unsafe void NT_PostRpcResponse(NT_Entry entry, NT_RpcCall call, byte* result, UIntPtr result_len)
        {
            throw null;
        }

        public static unsafe NT_RpcCall NT_CallRpc(NT_Entry entry, byte* @params, UIntPtr params_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetRpcResult(NT_Entry entry, NT_RpcCall call, UIntPtr* result_len)
        {
            throw null;
        }

        public static unsafe byte* NT_GetRpcResultTimeout(NT_Entry entry, NT_RpcCall call, UIntPtr* result_len, double timeout, NT_Bool timed_out)
        {
            throw null;
        }

        public static unsafe void NT_CancelRpcResult(NT_Entry entry, NT_RpcCall call)
        {
            throw null;
        }

        public static unsafe byte* NT_PackRpcDefinition(NT_RpcDefinition def, UIntPtr* packed_len)
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

        public static unsafe void NT_SetNetworkIdentity(NT_Inst inst, byte* name, UIntPtr name_len)
        {
            throw null;
        }

        public static unsafe uint NT_GetNetworkMode(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StartServer(NT_Inst inst, byte* persist_filename, byte* listen_address, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StopServer(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StartClientNone(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_StartClient(NT_Inst inst, byte* server_name, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StartClientMulti(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports)
        {
            throw null;
        }

        public static unsafe void NT_StartClientTeam(NT_Inst inst, uint team, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StopClient(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetServer(NT_Inst inst, byte* server_name, uint port)
        {
            throw null;
        }

        public static unsafe void NT_SetServerMulti(NT_Inst inst, UIntPtr count, byte** server_names, uint* ports)
        {
            throw null;
        }

        public static unsafe void NT_SetServerTeam(NT_Inst inst, uint team, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StartDSClient(NT_Inst inst, uint port)
        {
            throw null;
        }

        public static unsafe void NT_StopDSClient(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_SetUpdateRate(NT_Inst inst, double interval)
        {
            throw null;
        }

        public static unsafe void NT_Flush(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe NT_ConnectionInfo* NT_GetConnections(NT_Inst inst, UIntPtr* count)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_IsConnected(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe byte* NT_SavePersistent(NT_Inst inst, byte* filename)
        {
            throw null;
        }

        public static unsafe byte* NT_LoadPersistent(NT_Inst inst, byte* filename, IntPtr warnFunc)
        {
            throw null;
        }

        public static unsafe byte* NT_SaveEntries(NT_Inst inst, byte* filename, byte* prefix, UIntPtr prefix_len)
        {
            throw null;
        }

        public static unsafe byte* NT_LoadEntries(NT_Inst inst, byte* filename, byte* prefix, UIntPtr prefix_len, IntPtr warnFunc)
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

        public static unsafe void NT_DisposeEntryInfo(NT_EntryInfo* info)
        {
            throw null;
        }

        public static unsafe void NT_DisposeRpcDefinition(NT_RpcDefinition* def)
        {
            throw null;
        }

        public static unsafe void NT_DisposeRpcAnswerArray(NT_RpcAnswer* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeRpcAnswer(NT_RpcAnswer* answer)
        {
            throw null;
        }

        public static unsafe void NT_DisposeEntryNotificationArray(NT_EntryNotification* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeEntryNotification(NT_EntryNotification* info)
        {
            throw null;
        }

        public static unsafe void NT_DisposeConnectionNotificationArray(NT_ConnectionNotification* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeConnectionNotification(NT_ConnectionNotification* info)
        {
            throw null;
        }

        public static unsafe void NT_DisposeLogMessageArray(NT_LogMessage* arr, UIntPtr count)
        {
            throw null;
        }

        public static unsafe void NT_DisposeLogMessage(NT_LogMessage* info)
        {
            throw null;
        }

        public static unsafe ulong NT_Now()
        {
            throw null;
        }

        public static unsafe NT_LoggerPoller NT_CreateLoggerPoller(NT_Inst inst)
        {
            throw null;
        }

        public static unsafe void NT_DestroyLoggerPoller(NT_LoggerPoller poller)
        {
            throw null;
        }

        public static unsafe NT_Logger NT_AddPolledLogger(NT_LoggerPoller poller, uint min_level, uint max_level)
        {
            throw null;
        }

        public static unsafe NT_LogMessage* NT_PollLogger(NT_LoggerPoller poller, UIntPtr* len)
        {
            throw null;
        }

        public static unsafe NT_LogMessage* NT_PollLoggerTimeout(NT_LoggerPoller poller, UIntPtr* len, double timeout, NT_Bool* timed_out)
        {
            throw null;
        }

        public static unsafe void NT_CancelPollLogger(NT_LoggerPoller poller)
        {
            throw null;
        }

        public static unsafe void NT_RemoveLogger(NT_Logger logger)
        {
            throw null;
        }

        public static unsafe NT_Bool NT_WaitForLoggerQueue(NT_Inst inst, double timeout)
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
    }
}