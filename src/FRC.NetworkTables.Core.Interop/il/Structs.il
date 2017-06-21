
.class public auto ansi sealed FRC.NetworkTables.Core.Interop.NT_Type
       extends [System.Runtime]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_UNASSIGNED = int32(0x00000000)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_BOOLEAN = int32(0x00000001)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_DOUBLE = int32(0x00000002)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_STRING = int32(0x00000004)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_RAW = int32(0x00000008)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_BOOLEAN_ARRAY = int32(0x00000010)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_DOUBLE_ARRAY = int32(0x00000020)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_STRING_ARRAY = int32(0x00000040)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_Type NT_RPC = int32(0x00000080)
} // end of class FRC.NetworkTables.Core.Interop.NT_Type

.class public auto ansi sealed FRC.NetworkTables.Core.Interop.NT_EntryFlags
       extends [System.Runtime]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_EntryFlags NT_PERSISTENT = int32(0x00000001)
} // end of class FRC.NetworkTables.Core.Interop.NT_EntryFlags

.class public auto ansi sealed FRC.NetworkTables.Core.Interop.NT_LogLevel
       extends [System.Runtime]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_CRITICAL = int32(0x00000032)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_ERROR = int32(0x00000028)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_WARNING = int32(0x0000001E)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_INFO = int32(0x00000014)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_DEBUG = int32(0x0000000A)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_DEBUG1 = int32(0x00000009)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_DEBUG2 = int32(0x00000008)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_DEBUG3 = int32(0x00000007)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_LogLevel NT_LOG_DEBUG4 = int32(0x00000006)
} // end of class FRC.NetworkTables.Core.Interop.NT_LogLevel

.class public auto ansi sealed FRC.NetworkTables.Core.Interop.NT_NotifyKind
       extends [System.Runtime]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_NONE = int32(0x00000000)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_IMMEDIATE = int32(0x00000001)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_LOCAL = int32(0x00000002)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_NEW = int32(0x00000004)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_DELETE = int32(0x00000008)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_UPDATE = int32(0x00000010)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NotifyKind NT_NOTIFY_FLAGS = int32(0x00000020)
} // end of class FRC.NetworkTables.Core.Interop.NT_NotifyKind

.class public auto ansi sealed FRC.NetworkTables.Core.Interop.NT_NetworkMode
       extends [System.Runtime]System.Enum
{
  .field public specialname rtspecialname int32 value__
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NetworkMode NT_NET_MODE_NONE = int32(0x00000000)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NetworkMode NT_NET_MODE_SERVER = int32(0x00000001)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NetworkMode NT_NET_MODE_CLIENT = int32(0x00000002)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NetworkMode NT_NET_MODE_STARTING = int32(0x00000004)
  .field public static literal valuetype FRC.NetworkTables.Core.Interop.NT_NetworkMode NT_NET_MODE_FAILURE = int32(0x00000008)
} // end of class FRC.NetworkTables.Core.Interop.NT_NetworkMode

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_Bool
       extends [System.Runtime]System.ValueType
{
  .field private int32 m_value
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(int32 'value') aggressiveinlining
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  stfld      int32 FRC.NetworkTables.Core.Interop.NT_Bool::m_value
    IL_0008:  ret
  } // end of method NT_Bool::.ctor

  .method public hidebysig specialname rtspecialname
          instance void  .ctor(bool 'value') aggressiveinlining
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  brtrue.s   IL_0008

    IL_0005:  ldc.i4.0
    IL_0006:  br.s       IL_0009

    IL_0008:  ldc.i4.1
    IL_0009:  stfld      int32 FRC.NetworkTables.Core.Interop.NT_Bool::m_value
    IL_000e:  ret
  } // end of method NT_Bool::.ctor

  .method public hidebysig instance bool
          Get() aggressiveinlining
  {
    // Code size       15 (0xf)
    .maxstack  2
    .locals init (bool V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 FRC.NetworkTables.Core.Interop.NT_Bool::m_value
    IL_0007:  ldc.i4.0
    IL_0008:  cgt.un
    IL_000a:  stloc.0
    IL_000b:  br.s       IL_000d

    IL_000d:  ldloc.0
    IL_000e:  ret
  } // end of method NT_Bool::Get

  .method public hidebysig specialname static
          valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          op_Implicit(bool 'value') aggressiveinlining
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (valuetype FRC.NetworkTables.Core.Interop.NT_Bool V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  newobj     instance void FRC.NetworkTables.Core.Interop.NT_Bool::.ctor(bool)
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method NT_Bool::op_Implicit

} // end of class FRC.NetworkTables.Core.Interop.NT_Bool

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_Handle
       extends [System.Runtime]System.ValueType
{
  .field private int32 m_value
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(int32 'value') aggressiveinlining
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  stfld      int32 FRC.NetworkTables.Core.Interop.NT_Handle::m_value
    IL_0008:  ret
  } // end of method NT_Handle::.ctor

  .method public hidebysig instance int32
          Get() aggressiveinlining
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 FRC.NetworkTables.Core.Interop.NT_Handle::m_value
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method NT_Handle::Get

} // end of class FRC.NetworkTables.Core.Interop.NT_Handle

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_Inst
       extends [System.Runtime]System.ValueType
{
  .field private valuetype FRC.NetworkTables.Core.Interop.NT_Handle m_value
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(int32 'value') aggressiveinlining
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  newobj     instance void FRC.NetworkTables.Core.Interop.NT_Handle::.ctor(int32)
    IL_0008:  stfld      valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_Inst::m_value
    IL_000d:  ret
  } // end of method NT_Inst::.ctor

  .method public hidebysig instance int32
          Get() aggressiveinlining
  {
    // Code size       17 (0x11)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_Inst::m_value
    IL_0007:  call       instance int32 FRC.NetworkTables.Core.Interop.NT_Handle::Get()
    IL_000c:  stloc.0
    IL_000d:  br.s       IL_000f

    IL_000f:  ldloc.0
    IL_0010:  ret
  } // end of method NT_Inst::Get

  .method public hidebysig specialname static
          valuetype FRC.NetworkTables.Core.Interop.NT_Handle
          op_Implicit(valuetype FRC.NetworkTables.Core.Interop.NT_Inst 'value') aggressiveinlining
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (valuetype FRC.NetworkTables.Core.Interop.NT_Handle V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_Inst::m_value
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method NT_Inst::op_Implicit

} // end of class FRC.NetworkTables.Core.Interop.NT_Inst

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_Entry
       extends [System.Runtime]System.ValueType
{
  .field private valuetype FRC.NetworkTables.Core.Interop.NT_Handle m_value
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(int32 'value') aggressiveinlining
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  newobj     instance void FRC.NetworkTables.Core.Interop.NT_Handle::.ctor(int32)
    IL_0008:  stfld      valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_Entry::m_value
    IL_000d:  ret
  } // end of method NT_Entry::.ctor

  .method public hidebysig instance int32
          Get() aggressiveinlining
  {
    // Code size       17 (0x11)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_Entry::m_value
    IL_0007:  call       instance int32 FRC.NetworkTables.Core.Interop.NT_Handle::Get()
    IL_000c:  stloc.0
    IL_000d:  br.s       IL_000f

    IL_000f:  ldloc.0
    IL_0010:  ret
  } // end of method NT_Entry::Get

  .method public hidebysig specialname static
          valuetype FRC.NetworkTables.Core.Interop.NT_Handle
          op_Implicit(valuetype FRC.NetworkTables.Core.Interop.NT_Entry 'value') aggressiveinlining
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (valuetype FRC.NetworkTables.Core.Interop.NT_Handle V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_Entry::m_value
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method NT_Entry::op_Implicit

} // end of class FRC.NetworkTables.Core.Interop.NT_Entry

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_RpcCall
       extends [System.Runtime]System.ValueType
{
  .field private valuetype FRC.NetworkTables.Core.Interop.NT_Handle m_value
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(int32 'value') aggressiveinlining
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  newobj     instance void FRC.NetworkTables.Core.Interop.NT_Handle::.ctor(int32)
    IL_0008:  stfld      valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_RpcCall::m_value
    IL_000d:  ret
  } // end of method NT_RpcCall::.ctor

  .method public hidebysig instance int32
          Get() aggressiveinlining
  {
    // Code size       17 (0x11)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_RpcCall::m_value
    IL_0007:  call       instance int32 FRC.NetworkTables.Core.Interop.NT_Handle::Get()
    IL_000c:  stloc.0
    IL_000d:  br.s       IL_000f

    IL_000f:  ldloc.0
    IL_0010:  ret
  } // end of method NT_RpcCall::Get

  .method public hidebysig specialname static
          valuetype FRC.NetworkTables.Core.Interop.NT_Handle
          op_Implicit(valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall 'value') aggressiveinlining
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (valuetype FRC.NetworkTables.Core.Interop.NT_Handle V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      valuetype FRC.NetworkTables.Core.Interop.NT_Handle FRC.NetworkTables.Core.Interop.NT_RpcCall::m_value
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method NT_RpcCall::op_Implicit

} // end of class FRC.NetworkTables.Core.Interop.NT_RpcCall

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_String
       extends [System.Runtime]System.ValueType
{
  .field public uint8* str
  .field public native uint len
} // end of class FRC.NetworkTables.Core.Interop.NT_String

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.BoolArr
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Bool* arr
  .field public native uint len
} // end of class FRC.NetworkTables.Core.Interop.BoolArr

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.DoubleArr
       extends [System.Runtime]System.ValueType
{
  .field public float64* arr
  .field public native uint len
} // end of class FRC.NetworkTables.Core.Interop.DoubleArr

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.StringArr
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String* arr
  .field public native uint len
} // end of class FRC.NetworkTables.Core.Interop.StringArr

.class public explicit ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.DataUnion
       extends [System.Runtime]System.ValueType
{
  .field [0] public valuetype FRC.NetworkTables.Core.Interop.NT_Bool v_boolean
  .field [0] public float64 v_double
  .field [0] public valuetype FRC.NetworkTables.Core.Interop.NT_String v_string
  .field [0] public valuetype FRC.NetworkTables.Core.Interop.NT_String v_raw
  .field [0] public valuetype FRC.NetworkTables.Core.Interop.BoolArr arr_boolean
  .field [0] public valuetype FRC.NetworkTables.Core.Interop.DoubleArr arr_double
  .field [0] public valuetype FRC.NetworkTables.Core.Interop.StringArr arr_string
} // end of class FRC.NetworkTables.Core.Interop.DataUnion

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_Value
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Type 'type'
  .field public uint64 last_change
  .field public valuetype FRC.NetworkTables.Core.Interop.DataUnion data
} // end of class FRC.NetworkTables.Core.Interop.NT_Value

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_EntryInfo
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String name
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Type 'type'
  .field public uint32 'flags'
  .field public uint64 last_change
} // end of class FRC.NetworkTables.Core.Interop.NT_EntryInfo

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_EntryInfo2
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String name
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Type 'type'
  .field public uint32 'flags'
  .field public uint64 last_change
} // end of class FRC.NetworkTables.Core.Interop.NT_EntryInfo2

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_ConnectionInfo
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String remote_id
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String remote_ip
  .field public uint32 remote_port
  .field public uint64 last_update
  .field public uint32 protocol_version
} // end of class FRC.NetworkTables.Core.Interop.NT_ConnectionInfo

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_RpcParamDef
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String name
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Type 'type'
} // end of class FRC.NetworkTables.Core.Interop.NT_RpcParamDef

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_RpcResultDef
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String name
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Type 'type'
} // end of class FRC.NetworkTables.Core.Interop.NT_RpcResultDef

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_RpcDefinition
       extends [System.Runtime]System.ValueType
{
  .field public uint32 version
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String name
  .field public native uint num_params
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_RpcParamDef* param
  .field public native uint num_results
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_RpcResultDef* results
} // end of class FRC.NetworkTables.Core.Interop.NT_RpcDefinition

.class public sequential ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.NT_RpcCallInfo
       extends [System.Runtime]System.ValueType
{
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_Entry rpc
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall 'call'
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String name
  .field public valuetype FRC.NetworkTables.Core.Interop.NT_String param
} // end of class FRC.NetworkTables.Core.Interop.NT_RpcCallInfo


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\thadh\Documents\GitHub\ThadHouse\NetworkTablesIL\src\FRC.NetworkTables.Core.Interop\obj\temp\FRC.NetworkTables.Core.Interop.dll.res
