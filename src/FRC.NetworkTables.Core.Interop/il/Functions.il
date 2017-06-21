.class public abstract auto ansi sealed beforefieldinit FRC.NetworkTables.Core.Interop.Functions
       extends [System.Runtime]System.Object
{
  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Inst
          NT_GetDefaultInstance() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Inst FRC.NetworkTables.Core.Interop.Functions::NT_GetDefaultInstance()
    IL_0005:  ret
  } // end of method Functions::NT_GetDefaultInstance

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Inst
          NT_CreateInstance() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Inst FRC.NetworkTables.Core.Interop.Functions::NT_CreateInstance()
    IL_0005:  ret
  } // end of method Functions::NT_CreateInstance

  .method public hidebysig static void  NT_DestroyInstance(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DestroyInstance(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_DestroyInstance

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Inst
          NT_GetInstanceFromHandle(valuetype FRC.NetworkTables.Core.Interop.NT_Handle handle) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Inst FRC.NetworkTables.Core.Interop.Functions::NT_GetInstanceFromHandle(valuetype FRC.NetworkTables.Core.Interop.NT_Handle)
    IL_0006:  ret
  } // end of method Functions::NT_GetInstanceFromHandle

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Entry
          NT_GetEntry(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                      uint8* name,
                      native uint name_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Entry FRC.NetworkTables.Core.Interop.Functions::NT_GetEntry(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                 uint8*,
                                                                                                                                 native uint)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntry

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Entry
          NT_GetEntries(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                        uint8* prefix,
                        native uint prefix_len,
                        uint32 types,
                        native uint* count) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    count
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Entry FRC.NetworkTables.Core.Interop.Functions::NT_GetEntries(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                   uint8*,
                                                                                                                                   native uint,
                                                                                                                                   uint32,
                                                                                                                                   native uint*)
    IL_000b:  ret
  } // end of method Functions::NT_GetEntries

  .method public hidebysig static uint8  NT_GetEntryName(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                         native uint* name_len) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryName(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                         native uint*)
    IL_0007:  ret
  } // end of method Functions::NT_GetEntryName

  .method public hidebysig static uint64
          NT_GetEntryLastChange(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       uint64 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryLastChange(valuetype FRC.NetworkTables.Core.Interop.NT_Entry)
    IL_0006:  ret
  } // end of method Functions::NT_GetEntryLastChange

  .method public hidebysig static void  NT_GetEntryValue(uint8* name,
                                                         native uint name_len,
                                                         valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryValue(uint8*,
                                                                                         native uint,
                                                                                         valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryValue

  .method public hidebysig static void  NT_GetEntryValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                          valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                          valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0007:  ret
  } // end of method Functions::NT_GetEntryValue2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryValue(uint8* name,
                                  native uint name_len,
                                  valuetype FRC.NetworkTables.Core.Interop.NT_Value* default_value) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryValue(uint8*,
                                                                                                                                            native uint,
                                                                                                                                            valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryValue

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                   valuetype FRC.NetworkTables.Core.Interop.NT_Value* default_value) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                             valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0007:  ret
  } // end of method Functions::NT_SetDefaultEntryValue2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryValue(uint8* name,
                           native uint name_len,
                           valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryValue(uint8*,
                                                                                                                                     native uint,
                                                                                                                                     valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0008:  ret
  } // end of method Functions::NT_SetEntryValue

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                            valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                      valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0007:  ret
  } // end of method Functions::NT_SetEntryValue2

  .method public hidebysig static void  NT_SetEntryTypeValue(uint8* name,
                                                             native uint name_len,
                                                             valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryTypeValue(uint8*,
                                                                                             native uint,
                                                                                             valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0008:  ret
  } // end of method Functions::NT_SetEntryTypeValue

  .method public hidebysig static void  NT_SetEntryTypeValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                              valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryTypeValue2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                              valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0007:  ret
  } // end of method Functions::NT_SetEntryTypeValue2

  .method public hidebysig static void  NT_SetEntryFlags(uint8* name,
                                                         native uint name_len,
                                                         uint32 'flags') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryFlags(uint8*,
                                                                                         native uint,
                                                                                         uint32)
    IL_0008:  ret
  } // end of method Functions::NT_SetEntryFlags

  .method public hidebysig static void  NT_SetEntryFlags2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                          uint32 'flags') cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryFlags2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                          uint32)
    IL_0007:  ret
  } // end of method Functions::NT_SetEntryFlags2

  .method public hidebysig static uint32
          NT_GetEntryFlags(uint8* name,
                           native uint name_len) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       uint32 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryFlags(uint8*,
                                                                                           native uint)
    IL_0007:  ret
  } // end of method Functions::NT_GetEntryFlags

  .method public hidebysig static uint32
          NT_GetEntryFlags2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       uint32 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryFlags2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry)
    IL_0006:  ret
  } // end of method Functions::NT_GetEntryFlags2

  .method public hidebysig static void  NT_DeleteEntry(uint8* name,
                                                       native uint name_len) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DeleteEntry(uint8*,
                                                                                       native uint)
    IL_0007:  ret
  } // end of method Functions::NT_DeleteEntry

  .method public hidebysig static void  NT_DeleteEntry2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DeleteEntry2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry)
    IL_0006:  ret
  } // end of method Functions::NT_DeleteEntry2

  .method public hidebysig static void  NT_DeleteAllEntries() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DeleteAllEntries()
    IL_0005:  ret
  } // end of method Functions::NT_DeleteAllEntries

  .method public hidebysig static void  NT_DeleteAllEntries2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DeleteAllEntries2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_DeleteAllEntries2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo
          NT_GetEntryInfo(uint8* prefix,
                          native uint prefix_len,
                          uint32 types,
                          native uint* count) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryInfo(uint8*,
                                                                                                                                         native uint,
                                                                                                                                         uint32,
                                                                                                                                         native uint*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryInfo

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo2
          NT_GetEntryInfo2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                           uint8* prefix,
                           native uint prefix_len,
                           uint32 types,
                           native uint* count) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    count
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo2 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryInfo2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                           uint8*,
                                                                                                                                           native uint,
                                                                                                                                           uint32,
                                                                                                                                           native uint*)
    IL_000b:  ret
  } // end of method Functions::NT_GetEntryInfo2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo2
          NT_GetEntryInfoHandle(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo2 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryInfoHandle(valuetype FRC.NetworkTables.Core.Interop.NT_Entry)
    IL_0006:  ret
  } // end of method Functions::NT_GetEntryInfoHandle

  .method public hidebysig static void  NT_Flush() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_Flush()
    IL_0005:  ret
  } // end of method Functions::NT_Flush

  .method public hidebysig static void  NT_Flush2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_Flush2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_Flush2

  .method public hidebysig static void  NT_SetListenerOnStart(class FRC.NetworkTables.Core.Interop.NT_OnStart onStart,
                                                              void* data) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetListenerOnStart(class FRC.NetworkTables.Core.Interop.NT_OnStart,
                                                                                              void*)
    IL_0007:  ret
  } // end of method Functions::NT_SetListenerOnStart

  .method public hidebysig static void  NT_SetListenerOnStart2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                               class FRC.NetworkTables.Core.Interop.NT_OnStart onStart,
                                                               void* data) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetListenerOnStart2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                               class FRC.NetworkTables.Core.Interop.NT_OnStart,
                                                                                               void*)
    IL_0008:  ret
  } // end of method Functions::NT_SetListenerOnStart2

  .method public hidebysig static void  NT_SetListenerOnExit(class FRC.NetworkTables.Core.Interop.NT_OnExit onExit,
                                                             void* data) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetListenerOnExit(class FRC.NetworkTables.Core.Interop.NT_OnExit,
                                                                                             void*)
    IL_0007:  ret
  } // end of method Functions::NT_SetListenerOnExit

  .method public hidebysig static void  NT_SetListenerOnExit2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                              class FRC.NetworkTables.Core.Interop.NT_OnExit onExit,
                                                              void* data) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetListenerOnExit2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                              class FRC.NetworkTables.Core.Interop.NT_OnExit,
                                                                                              void*)
    IL_0008:  ret
  } // end of method Functions::NT_SetListenerOnExit2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener
          NT_AddEntryListener(uint8* prefix,
                              native uint prefix_len,
                              void* data,
                              class FRC.NetworkTables.Core.Interop.NT_EntryListenerCallback callback,
                              uint32 'flags') cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    'flags'
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener FRC.NetworkTables.Core.Interop.Functions::NT_AddEntryListener(uint8*,
                                                                                                                                                 native uint,
                                                                                                                                                 void*,
                                                                                                                                                 class FRC.NetworkTables.Core.Interop.NT_EntryListenerCallback,
                                                                                                                                                 uint32)
    IL_000b:  ret
  } // end of method Functions::NT_AddEntryListener

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener
          NT_AddEntryListener2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                               uint8* prefix,
                               native uint prefix_len,
                               void* data,
                               class FRC.NetworkTables.Core.Interop.NT_EntryListenerCallback2 callback,
                               uint32 'flags') cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    callback
    IL_0006:  ldarg.s    'flags'
    IL_0008:  call       valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener FRC.NetworkTables.Core.Interop.Functions::NT_AddEntryListener2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                                  uint8*,
                                                                                                                                                  native uint,
                                                                                                                                                  void*,
                                                                                                                                                  class FRC.NetworkTables.Core.Interop.NT_EntryListenerCallback2,
                                                                                                                                                  uint32)
    IL_000d:  ret
  } // end of method Functions::NT_AddEntryListener2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener
          NT_AddEntryListenerSingle(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                    void* data,
                                    class FRC.NetworkTables.Core.Interop.NT_EntryListenerCallback2 callback,
                                    uint32 'flags') cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener FRC.NetworkTables.Core.Interop.Functions::NT_AddEntryListenerSingle(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                                       void*,
                                                                                                                                                       class FRC.NetworkTables.Core.Interop.NT_EntryListenerCallback2,
                                                                                                                                                       uint32)
    IL_0009:  ret
  } // end of method Functions::NT_AddEntryListenerSingle

  .method public hidebysig static void  NT_RemoveEntryListener(valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener entry_listener) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_RemoveEntryListener(valuetype FRC.NetworkTables.Core.Interop.NT_EntryListener)
    IL_0006:  ret
  } // end of method Functions::NT_RemoveEntryListener

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionListener
          NT_AddConnectionListener(void* data,
                                   class FRC.NetworkTables.Core.Interop.NT_ConnectionListenerCallback callback,
                                   valuetype FRC.NetworkTables.Core.Interop.NT_Bool immediate_notify) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionListener FRC.NetworkTables.Core.Interop.Functions::NT_AddConnectionListener(void*,
                                                                                                                                                           class FRC.NetworkTables.Core.Interop.NT_ConnectionListenerCallback,
                                                                                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0008:  ret
  } // end of method Functions::NT_AddConnectionListener

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionListener
          NT_AddConnectionListener2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                    void* data,
                                    class FRC.NetworkTables.Core.Interop.NT_ConnectionListenerCallback callback,
                                    valuetype FRC.NetworkTables.Core.Interop.NT_Bool immediate_notify) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionListener FRC.NetworkTables.Core.Interop.Functions::NT_AddConnectionListener2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                                            void*,
                                                                                                                                                            class FRC.NetworkTables.Core.Interop.NT_ConnectionListenerCallback,
                                                                                                                                                            valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_AddConnectionListener2

  .method public hidebysig static void  NT_RemoveConnectionListener(valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionListener conn_listener) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_RemoveConnectionListener(valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionListener)
    IL_0006:  ret
  } // end of method Functions::NT_RemoveConnectionListener

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_NotifierDestroyed() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_NotifierDestroyed()
    IL_0005:  ret
  } // end of method Functions::NT_NotifierDestroyed

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_NotifierDestroyed2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_NotifierDestroyed2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_NotifierDestroyed2

  .method public hidebysig static void  NT_SetRpcServerOnStart(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                               class FRC.NetworkTables.Core.Interop.NT_OnStart onStart,
                                                               void* data) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetRpcServerOnStart(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                               class FRC.NetworkTables.Core.Interop.NT_OnStart,
                                                                                               void*)
    IL_0008:  ret
  } // end of method Functions::NT_SetRpcServerOnStart

  .method public hidebysig static void  NT_SetRpcServerOnExit(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                              class FRC.NetworkTables.Core.Interop.NT_OnExit onExit,
                                                              void* data) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetRpcServerOnExit(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                              class FRC.NetworkTables.Core.Interop.NT_OnExit,
                                                                                              void*)
    IL_0008:  ret
  } // end of method Functions::NT_SetRpcServerOnExit

  .method public hidebysig static void  NT_CreateRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                     uint8* def,
                                                     native uint def_len,
                                                     void* data,
                                                     class FRC.NetworkTables.Core.Interop.NT_RpcCallback callback) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    callback
    IL_0006:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_CreateRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                     uint8*,
                                                                                     native uint,
                                                                                     void*,
                                                                                     class FRC.NetworkTables.Core.Interop.NT_RpcCallback)
    IL_000b:  ret
  } // end of method Functions::NT_CreateRpc

  .method public hidebysig static void  NT_CreatePolledRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                           uint8* def,
                                                           native uint def_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_CreatePolledRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                           uint8*,
                                                                                           native uint)
    IL_0008:  ret
  } // end of method Functions::NT_CreatePolledRpc

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_PollRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                     valuetype FRC.NetworkTables.Core.Interop.NT_RpcCallInfo* call_info) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_PollRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                               valuetype FRC.NetworkTables.Core.Interop.NT_RpcCallInfo*)
    IL_0007:  ret
  } // end of method Functions::NT_PollRpc

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_PollRpcTimeout(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                            valuetype FRC.NetworkTables.Core.Interop.NT_RpcCallInfo* call_info,
                            float64 time_out) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_PollRpcTimeout(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                      valuetype FRC.NetworkTables.Core.Interop.NT_RpcCallInfo*,
                                                                                                                                      float64)
    IL_0008:  ret
  } // end of method Functions::NT_PollRpcTimeout

  .method public hidebysig static void  NT_PostRpcResponse(valuetype FRC.NetworkTables.Core.Interop.NT_Entry rpc,
                                                           valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall 'call',
                                                           uint8* result,
                                                           native uint result_len) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_PostRpcResponse(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall,
                                                                                           uint8*,
                                                                                           native uint)
    IL_0009:  ret
  } // end of method Functions::NT_PostRpcResponse

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall
          NT_CallRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Entry rpc,
                     uint8* params,
                     native uint params_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall FRC.NetworkTables.Core.Interop.Functions::NT_CallRpc(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                  uint8*,
                                                                                                                                  native uint)
    IL_0008:  ret
  } // end of method Functions::NT_CallRpc

  .method public hidebysig static uint8  NT_GetRpcResult(valuetype FRC.NetworkTables.Core.Interop.NT_Entry rpc,
                                                         valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall 'call',
                                                         native uint* result_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetRpcResult(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                         valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall,
                                                                                         native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetRpcResult

  .method public hidebysig static uint8  NT_GetRpcResultTimeout(valuetype FRC.NetworkTables.Core.Interop.NT_Entry rpc,
                                                                valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall 'call',
                                                                native uint* result_len,
                                                                float64 time_out) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetRpcResultTimeout(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall,
                                                                                                native uint*,
                                                                                                float64)
    IL_0009:  ret
  } // end of method Functions::NT_GetRpcResultTimeout

  .method public hidebysig static void  NT_CancelRpcResult(valuetype FRC.NetworkTables.Core.Interop.NT_Entry rpc,
                                                           valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall 'call') cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_CancelRpcResult(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_RpcCall)
    IL_0007:  ret
  } // end of method Functions::NT_CancelRpcResult

  .method public hidebysig static uint8  NT_PackRpcDefinition(valuetype FRC.NetworkTables.Core.Interop.NT_RpcDefinition* def,
                                                              native uint* packed_len) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_PackRpcDefinition(valuetype FRC.NetworkTables.Core.Interop.NT_RpcDefinition*,
                                                                                              native uint*)
    IL_0007:  ret
  } // end of method Functions::NT_PackRpcDefinition

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_UnpackRpcDefinition(uint8* packed,
                                 native uint packed_len,
                                 valuetype FRC.NetworkTables.Core.Interop.NT_RpcDefinition* def) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_UnpackRpcDefinition(uint8*,
                                                                                                                                           native uint,
                                                                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_RpcDefinition*)
    IL_0008:  ret
  } // end of method Functions::NT_UnpackRpcDefinition

  .method public hidebysig static uint8  NT_PackRpcValues(valuetype FRC.NetworkTables.Core.Interop.NT_Value** values,
                                                          native uint values_len,
                                                          native uint* packed_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_PackRpcValues(valuetype FRC.NetworkTables.Core.Interop.NT_Value**,
                                                                                          native uint,
                                                                                          native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_PackRpcValues

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Value
          NT_UnpackRpcValues(uint8* packed,
                             native uint packed_len,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Type* types,
                             native uint types_len) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Value FRC.NetworkTables.Core.Interop.Functions::NT_UnpackRpcValues(uint8*,
                                                                                                                                        native uint,
                                                                                                                                        valuetype FRC.NetworkTables.Core.Interop.NT_Type*,
                                                                                                                                        native uint)
    IL_0009:  ret
  } // end of method Functions::NT_UnpackRpcValues

  .method public hidebysig static void  NT_SetNetworkIdentity(uint8* name,
                                                              native uint name_len) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetNetworkIdentity(uint8*,
                                                                                              native uint)
    IL_0007:  ret
  } // end of method Functions::NT_SetNetworkIdentity

  .method public hidebysig static void  NT_SetNetworkIdentity2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                               uint8* name,
                                                               native uint name_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetNetworkIdentity2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                               uint8*,
                                                                                               native uint)
    IL_0008:  ret
  } // end of method Functions::NT_SetNetworkIdentity2

  .method public hidebysig static uint32
          NT_GetNetworkMode() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       uint32 FRC.NetworkTables.Core.Interop.Functions::NT_GetNetworkMode()
    IL_0005:  ret
  } // end of method Functions::NT_GetNetworkMode

  .method public hidebysig static uint32
          NT_GetNetworkMode2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       uint32 FRC.NetworkTables.Core.Interop.Functions::NT_GetNetworkMode2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_GetNetworkMode2

  .method public hidebysig static void  NT_StartServer(uint8* persist_filename,
                                                       uint8* listen_address,
                                                       uint32 port) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartServer(uint8*,
                                                                                       uint8*,
                                                                                       uint32)
    IL_0008:  ret
  } // end of method Functions::NT_StartServer

  .method public hidebysig static void  NT_StartServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                        uint8* persist_filename,
                                                        uint8* listen_address,
                                                        uint32 port) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                        uint8*,
                                                                                        uint8*,
                                                                                        uint32)
    IL_0009:  ret
  } // end of method Functions::NT_StartServer2

  .method public hidebysig static void  NT_StopServer() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopServer()
    IL_0005:  ret
  } // end of method Functions::NT_StopServer

  .method public hidebysig static void  NT_StopServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_StopServer2

  .method public hidebysig static void  NT_StartClientNone() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartClientNone()
    IL_0005:  ret
  } // end of method Functions::NT_StartClientNone

  .method public hidebysig static void  NT_StartClientNone2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartClientNone2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_StartClientNone2

  .method public hidebysig static void  NT_StartClient(uint8* server_name,
                                                       uint32 port) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartClient(uint8*,
                                                                                       uint32)
    IL_0007:  ret
  } // end of method Functions::NT_StartClient

  .method public hidebysig static void  NT_StartClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                        uint8* server_name,
                                                        uint32 port) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                        uint8*,
                                                                                        uint32)
    IL_0008:  ret
  } // end of method Functions::NT_StartClient2

  .method public hidebysig static void  NT_StartClientMulti(native uint count,
                                                            uint8** server_names,
                                                            uint32* ports) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartClientMulti(native uint,
                                                                                            uint8**,
                                                                                            uint32*)
    IL_0008:  ret
  } // end of method Functions::NT_StartClientMulti

  .method public hidebysig static void  NT_StartClientMulti2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                             native uint count,
                                                             uint8** server_names,
                                                             uint32* ports) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartClientMulti2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                             native uint,
                                                                                             uint8**,
                                                                                             uint32*)
    IL_0009:  ret
  } // end of method Functions::NT_StartClientMulti2

  .method public hidebysig static void  NT_StopClient() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopClient()
    IL_0005:  ret
  } // end of method Functions::NT_StopClient

  .method public hidebysig static void  NT_StopClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_StopClient2

  .method public hidebysig static void  NT_SetServer(uint8* server_name,
                                                     uint32 port) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetServer(uint8*,
                                                                                     uint32)
    IL_0007:  ret
  } // end of method Functions::NT_SetServer

  .method public hidebysig static void  NT_SetServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                      uint8* server_name,
                                                      uint32 port) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                      uint8*,
                                                                                      uint32)
    IL_0008:  ret
  } // end of method Functions::NT_SetServer2

  .method public hidebysig static void  NT_SetServerMulti(native uint count,
                                                          uint8** server_names,
                                                          uint32* ports) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetServerMulti(native uint,
                                                                                          uint8**,
                                                                                          uint32*)
    IL_0008:  ret
  } // end of method Functions::NT_SetServerMulti

  .method public hidebysig static void  NT_SetServerMulti2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                           native uint count,
                                                           uint8** server_names,
                                                           uint32* ports) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetServerMulti2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                           native uint,
                                                                                           uint8**,
                                                                                           uint32*)
    IL_0009:  ret
  } // end of method Functions::NT_SetServerMulti2

  .method public hidebysig static void  NT_StartDSClient(uint32 port) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartDSClient(uint32)
    IL_0006:  ret
  } // end of method Functions::NT_StartDSClient

  .method public hidebysig static void  NT_StartDSClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                          uint32 port) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StartDSClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                          uint32)
    IL_0007:  ret
  } // end of method Functions::NT_StartDSClient2

  .method public hidebysig static void  NT_StopDSClient() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopDSClient()
    IL_0005:  ret
  } // end of method Functions::NT_StopDSClient

  .method public hidebysig static void  NT_StopDSClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopDSClient2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_StopDSClient2

  .method public hidebysig static void  NT_StopRpcServer() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopRpcServer()
    IL_0005:  ret
  } // end of method Functions::NT_StopRpcServer

  .method public hidebysig static void  NT_StopRpcServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopRpcServer2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_StopRpcServer2

  .method public hidebysig static void  NT_StopNotifier() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopNotifier()
    IL_0005:  ret
  } // end of method Functions::NT_StopNotifier

  .method public hidebysig static void  NT_StopNotifier2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_StopNotifier2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst)
    IL_0006:  ret
  } // end of method Functions::NT_StopNotifier2

  .method public hidebysig static void  NT_SetUpdateRate(float64 interval) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetUpdateRate(float64)
    IL_0006:  ret
  } // end of method Functions::NT_SetUpdateRate

  .method public hidebysig static void  NT_SetUpdateRate2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                          float64 interval) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetUpdateRate2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                          float64)
    IL_0007:  ret
  } // end of method Functions::NT_SetUpdateRate2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionInfo
          NT_GetConnections(native uint* count) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionInfo FRC.NetworkTables.Core.Interop.Functions::NT_GetConnections(native uint*)
    IL_0006:  ret
  } // end of method Functions::NT_GetConnections

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionInfo
          NT_GetConnections2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                             native uint* count) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionInfo FRC.NetworkTables.Core.Interop.Functions::NT_GetConnections2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                                                                                 native uint*)
    IL_0007:  ret
  } // end of method Functions::NT_GetConnections2

  .method public hidebysig static uint8  NT_SavePersistent(uint8* filename) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_SavePersistent(uint8*)
    IL_0006:  ret
  } // end of method Functions::NT_SavePersistent

  .method public hidebysig static uint8  NT_SavePersistent2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                            uint8* filename) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_SavePersistent2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                            uint8*)
    IL_0007:  ret
  } // end of method Functions::NT_SavePersistent2

  .method public hidebysig static uint8  NT_LoadPersistent(uint8* filename,
                                                           class FRC.NetworkTables.Core.Interop.NT_WarnFunc warn) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_LoadPersistent(uint8*,
                                                                                           class FRC.NetworkTables.Core.Interop.NT_WarnFunc)
    IL_0007:  ret
  } // end of method Functions::NT_LoadPersistent

  .method public hidebysig static uint8  NT_LoadPersistent2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                            uint8* filename,
                                                            class FRC.NetworkTables.Core.Interop.NT_WarnFunc warn) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_LoadPersistent2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                            uint8*,
                                                                                            class FRC.NetworkTables.Core.Interop.NT_WarnFunc)
    IL_0008:  ret
  } // end of method Functions::NT_LoadPersistent2

  .method public hidebysig static void  NT_DisposeValue(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeValue(valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0006:  ret
  } // end of method Functions::NT_DisposeValue

  .method public hidebysig static void  NT_InitValue(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_InitValue(valuetype FRC.NetworkTables.Core.Interop.NT_Value*)
    IL_0006:  ret
  } // end of method Functions::NT_InitValue

  .method public hidebysig static void  NT_DisposeString(valuetype FRC.NetworkTables.Core.Interop.NT_String* str) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeString(valuetype FRC.NetworkTables.Core.Interop.NT_String*)
    IL_0006:  ret
  } // end of method Functions::NT_DisposeString

  .method public hidebysig static void  NT_InitString(valuetype FRC.NetworkTables.Core.Interop.NT_String* str) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_InitString(valuetype FRC.NetworkTables.Core.Interop.NT_String*)
    IL_0006:  ret
  } // end of method Functions::NT_InitString

  .method public hidebysig static void  NT_DisposeEntryArray(valuetype FRC.NetworkTables.Core.Interop.NT_Entry* arr,
                                                             native uint count) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeEntryArray(valuetype FRC.NetworkTables.Core.Interop.NT_Entry*,
                                                                                             native uint)
    IL_0007:  ret
  } // end of method Functions::NT_DisposeEntryArray

  .method public hidebysig static void  NT_DisposeConnectionInfoArray(valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionInfo* arr,
                                                                      native uint count) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeConnectionInfoArray(valuetype FRC.NetworkTables.Core.Interop.NT_ConnectionInfo*,
                                                                                                      native uint)
    IL_0007:  ret
  } // end of method Functions::NT_DisposeConnectionInfoArray

  .method public hidebysig static void  NT_DisposeEntryInfoArray(valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo* arr,
                                                                 native uint count) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeEntryInfoArray(valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo*,
                                                                                                 native uint)
    IL_0007:  ret
  } // end of method Functions::NT_DisposeEntryInfoArray

  .method public hidebysig static void  NT_DisposeEntryInfoArray2(valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo2* arr,
                                                                  native uint count) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeEntryInfoArray2(valuetype FRC.NetworkTables.Core.Interop.NT_EntryInfo2*,
                                                                                                  native uint)
    IL_0007:  ret
  } // end of method Functions::NT_DisposeEntryInfoArray2

  .method public hidebysig static void  NT_DisposeRpcDefinition(valuetype FRC.NetworkTables.Core.Interop.NT_RpcDefinition* def) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeRpcDefinition(valuetype FRC.NetworkTables.Core.Interop.NT_RpcDefinition*)
    IL_0006:  ret
  } // end of method Functions::NT_DisposeRpcDefinition

  .method public hidebysig static void  NT_DisposeRpcCallInfo(valuetype FRC.NetworkTables.Core.Interop.NT_RpcCallInfo* call_info) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_DisposeRpcCallInfo(valuetype FRC.NetworkTables.Core.Interop.NT_RpcCallInfo*)
    IL_0006:  ret
  } // end of method Functions::NT_DisposeRpcCallInfo

  .method public hidebysig static uint64
          NT_Now() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       uint64 FRC.NetworkTables.Core.Interop.Functions::NT_Now()
    IL_0005:  ret
  } // end of method Functions::NT_Now

  .method public hidebysig static void  NT_SetLogger(class FRC.NetworkTables.Core.Interop.NT_LogFunc func,
                                                     uint32 min_level) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetLogger(class FRC.NetworkTables.Core.Interop.NT_LogFunc,
                                                                                     uint32)
    IL_0007:  ret
  } // end of method Functions::NT_SetLogger

  .method public hidebysig static void  NT_SetLogger2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
                                                      class FRC.NetworkTables.Core.Interop.NT_LogFunc func,
                                                      uint32 min_level) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_SetLogger2(valuetype FRC.NetworkTables.Core.Interop.NT_Inst,
                                                                                      class FRC.NetworkTables.Core.Interop.NT_LogFunc,
                                                                                      uint32)
    IL_0008:  ret
  } // end of method Functions::NT_SetLogger2

  .method public hidebysig static uint8  NT_AllocateCharArray(native uint size) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_AllocateCharArray(native uint)
    IL_0006:  ret
  } // end of method Functions::NT_AllocateCharArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_AllocateBooleanArray(native uint size) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_AllocateBooleanArray(native uint)
    IL_0006:  ret
  } // end of method Functions::NT_AllocateBooleanArray

  .method public hidebysig static float64
          NT_AllocateDoubleArray(native uint size) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       float64 FRC.NetworkTables.Core.Interop.Functions::NT_AllocateDoubleArray(native uint)
    IL_0006:  ret
  } // end of method Functions::NT_AllocateDoubleArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_String
          NT_AllocateStringArray(native uint size) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       valuetype FRC.NetworkTables.Core.Interop.NT_String FRC.NetworkTables.Core.Interop.Functions::NT_AllocateStringArray(native uint)
    IL_0006:  ret
  } // end of method Functions::NT_AllocateStringArray

  .method public hidebysig static void  NT_FreeCharArray(uint8* v_char) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_FreeCharArray(uint8*)
    IL_0006:  ret
  } // end of method Functions::NT_FreeCharArray

  .method public hidebysig static void  NT_FreeDoubleArray(float64* v_double) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_FreeDoubleArray(float64*)
    IL_0006:  ret
  } // end of method Functions::NT_FreeDoubleArray

  .method public hidebysig static void  NT_FreeBooleanArray(valuetype FRC.NetworkTables.Core.Interop.NT_Bool* v_boolean) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_FreeBooleanArray(valuetype FRC.NetworkTables.Core.Interop.NT_Bool*)
    IL_0006:  ret
  } // end of method Functions::NT_FreeBooleanArray

  .method public hidebysig static void  NT_FreeStringArray(valuetype FRC.NetworkTables.Core.Interop.NT_String* v_string,
                                                           native uint arr_size) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       void FRC.NetworkTables.Core.Interop.Functions::NT_FreeStringArray(valuetype FRC.NetworkTables.Core.Interop.NT_String*,
                                                                                           native uint)
    IL_0007:  ret
  } // end of method Functions::NT_FreeStringArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetValueBoolean(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                             uint64* last_change,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool* v_boolean) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetValueBoolean(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                                                                       uint64*,
                                                                                                                                       valuetype FRC.NetworkTables.Core.Interop.NT_Bool*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueBoolean

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetValueDouble(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                            uint64* last_change,
                            float64* v_double) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetValueDouble(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                                                                      uint64*,
                                                                                                                                      float64*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueDouble

  .method public hidebysig static uint8  NT_GetValueString(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                                                           uint64* last_change,
                                                           native uint* str_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetValueString(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                           uint64*,
                                                                                           native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueString

  .method public hidebysig static uint8  NT_GetValueRaw(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                                                        uint64* last_change,
                                                        native uint* raw_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetValueRaw(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                        uint64*,
                                                                                        native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueRaw

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetValueBooleanArray(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                                  uint64* last_change,
                                  native uint* arr_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetValueBooleanArray(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                                                                            uint64*,
                                                                                                                                            native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueBooleanArray

  .method public hidebysig static float64
          NT_GetValueDoubleArray(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                                 uint64* last_change,
                                 native uint* arr_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       float64 FRC.NetworkTables.Core.Interop.Functions::NT_GetValueDoubleArray(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                                  uint64*,
                                                                                                  native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueDoubleArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_String
          NT_GetValueStringArray(valuetype FRC.NetworkTables.Core.Interop.NT_Value* 'value',
                                 uint64* last_change,
                                 native uint* arr_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_String FRC.NetworkTables.Core.Interop.Functions::NT_GetValueStringArray(valuetype FRC.NetworkTables.Core.Interop.NT_Value*,
                                                                                                                                             uint64*,
                                                                                                                                             native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetValueStringArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetEntryBoolean(uint8* name,
                             native uint name_len,
                             uint64* last_change,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool* v_boolean) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryBoolean(uint8*,
                                                                                                                                       native uint,
                                                                                                                                       uint64*,
                                                                                                                                       valuetype FRC.NetworkTables.Core.Interop.NT_Bool*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryBoolean

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetEntryBoolean2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                              uint64* last_change,
                              valuetype FRC.NetworkTables.Core.Interop.NT_Bool* v_boolean) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryBoolean2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                        uint64*,
                                                                                                                                        valuetype FRC.NetworkTables.Core.Interop.NT_Bool*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryBoolean2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetEntryDouble(uint8* name,
                            native uint name_len,
                            uint64* last_change,
                            float64* v_double) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryDouble(uint8*,
                                                                                                                                      native uint,
                                                                                                                                      uint64*,
                                                                                                                                      float64*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryDouble

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetEntryDouble2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                             uint64* last_change,
                             float64* v_double) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryDouble2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                       uint64*,
                                                                                                                                       float64*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryDouble2

  .method public hidebysig static uint8  NT_GetEntryString(uint8* name,
                                                           native uint name_len,
                                                           uint64* last_change,
                                                           native uint* str_len) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryString(uint8*,
                                                                                           native uint,
                                                                                           uint64*,
                                                                                           native uint*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryString

  .method public hidebysig static uint8  NT_GetEntryString2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                            uint64* last_change,
                                                            native uint* str_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryString2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                            uint64*,
                                                                                            native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryString2

  .method public hidebysig static uint8  NT_GetEntryRaw(uint8* name,
                                                        native uint name_len,
                                                        uint64* last_change,
                                                        native uint* raw_len) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryRaw(uint8*,
                                                                                        native uint,
                                                                                        uint64*,
                                                                                        native uint*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryRaw

  .method public hidebysig static uint8  NT_GetEntryRaw2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                                         uint64* last_change,
                                                         native uint* raw_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       uint8 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryRaw2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                         uint64*,
                                                                                         native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryRaw2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetEntryBooleanArray(uint8* name,
                                  native uint name_len,
                                  uint64* last_change,
                                  native uint* arr_size) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryBooleanArray(uint8*,
                                                                                                                                            native uint,
                                                                                                                                            uint64*,
                                                                                                                                            native uint*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryBooleanArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_GetEntryBooleanArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                   uint64* last_change,
                                   native uint* arr_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryBooleanArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                             uint64*,
                                                                                                                                             native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryBooleanArray2

  .method public hidebysig static float64
          NT_GetEntryDoubleArray(uint8* name,
                                 native uint name_len,
                                 uint64* last_change,
                                 native uint* arr_size) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       float64 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryDoubleArray(uint8*,
                                                                                                  native uint,
                                                                                                  uint64*,
                                                                                                  native uint*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryDoubleArray

  .method public hidebysig static float64
          NT_GetEntryDoubleArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                  uint64* last_change,
                                  native uint* arr_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       float64 FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryDoubleArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                   uint64*,
                                                                                                   native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryDoubleArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_String
          NT_GetEntryStringArray(uint8* name,
                                 native uint name_len,
                                 uint64* last_change,
                                 native uint* arr_size) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_String FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryStringArray(uint8*,
                                                                                                                                             native uint,
                                                                                                                                             uint64*,
                                                                                                                                             native uint*)
    IL_0009:  ret
  } // end of method Functions::NT_GetEntryStringArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_String
          NT_GetEntryStringArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                  uint64* last_change,
                                  native uint* arr_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_String FRC.NetworkTables.Core.Interop.Functions::NT_GetEntryStringArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                              uint64*,
                                                                                                                                              native uint*)
    IL_0008:  ret
  } // end of method Functions::NT_GetEntryStringArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryBoolean(uint8* name,
                                    native uint name_len,
                                    valuetype FRC.NetworkTables.Core.Interop.NT_Bool default_boolean) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryBoolean(uint8*,
                                                                                                                                              native uint,
                                                                                                                                              valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryBoolean

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryBoolean2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                     valuetype FRC.NetworkTables.Core.Interop.NT_Bool default_boolean) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryBoolean2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                               valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0007:  ret
  } // end of method Functions::NT_SetDefaultEntryBoolean2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryDouble(uint8* name,
                                   native uint name_len,
                                   float64 default_double) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryDouble(uint8*,
                                                                                                                                             native uint,
                                                                                                                                             float64)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryDouble

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryDouble2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                    float64 default_double) cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryDouble2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                              float64)
    IL_0007:  ret
  } // end of method Functions::NT_SetDefaultEntryDouble2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryString(uint8* name,
                                   native uint name_len,
                                   uint8* default_value,
                                   native uint default_len) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryString(uint8*,
                                                                                                                                             native uint,
                                                                                                                                             uint8*,
                                                                                                                                             native uint)
    IL_0009:  ret
  } // end of method Functions::NT_SetDefaultEntryString

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryString2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                    uint8* default_value,
                                    native uint default_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryString2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                              uint8*,
                                                                                                                                              native uint)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryString2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryRaw(uint8* name,
                                native uint name_len,
                                uint8* default_value,
                                native uint default_len) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryRaw(uint8*,
                                                                                                                                          native uint,
                                                                                                                                          uint8*,
                                                                                                                                          native uint)
    IL_0009:  ret
  } // end of method Functions::NT_SetDefaultEntryRaw

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryRaw2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                 uint8* default_value,
                                 native uint default_len) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryRaw2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                           uint8*,
                                                                                                                                           native uint)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryRaw2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryBooleanArray(uint8* name,
                                         native uint name_len,
                                         int32* default_value,
                                         native uint default_size) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryBooleanArray(uint8*,
                                                                                                                                                   native uint,
                                                                                                                                                   int32*,
                                                                                                                                                   native uint)
    IL_0009:  ret
  } // end of method Functions::NT_SetDefaultEntryBooleanArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryBooleanArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                          int32* default_value,
                                          native uint default_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryBooleanArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                                    int32*,
                                                                                                                                                    native uint)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryBooleanArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryDoubleArray(uint8* name,
                                        native uint name_len,
                                        float64* default_value,
                                        native uint default_size) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryDoubleArray(uint8*,
                                                                                                                                                  native uint,
                                                                                                                                                  float64*,
                                                                                                                                                  native uint)
    IL_0009:  ret
  } // end of method Functions::NT_SetDefaultEntryDoubleArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryDoubleArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                         float64* default_value,
                                         native uint default_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryDoubleArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                                   float64*,
                                                                                                                                                   native uint)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryDoubleArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryStringArray(uint8* name,
                                        native uint name_len,
                                        valuetype FRC.NetworkTables.Core.Interop.NT_String* default_value,
                                        native uint default_size) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryStringArray(uint8*,
                                                                                                                                                  native uint,
                                                                                                                                                  valuetype FRC.NetworkTables.Core.Interop.NT_String*,
                                                                                                                                                  native uint)
    IL_0009:  ret
  } // end of method Functions::NT_SetDefaultEntryStringArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetDefaultEntryStringArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                         valuetype FRC.NetworkTables.Core.Interop.NT_String* default_value,
                                         native uint default_size) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetDefaultEntryStringArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                                   valuetype FRC.NetworkTables.Core.Interop.NT_String*,
                                                                                                                                                   native uint)
    IL_0008:  ret
  } // end of method Functions::NT_SetDefaultEntryStringArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryBoolean(uint8* name,
                             native uint name_len,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool v_boolean,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryBoolean(uint8*,
                                                                                                                                       native uint,
                                                                                                                                       valuetype FRC.NetworkTables.Core.Interop.NT_Bool,
                                                                                                                                       valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryBoolean

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryBoolean2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                              valuetype FRC.NetworkTables.Core.Interop.NT_Bool v_boolean,
                              valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryBoolean2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                        valuetype FRC.NetworkTables.Core.Interop.NT_Bool,
                                                                                                                                        valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0008:  ret
  } // end of method Functions::NT_SetEntryBoolean2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryDouble(uint8* name,
                            native uint name_len,
                            float64 v_double,
                            valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryDouble(uint8*,
                                                                                                                                      native uint,
                                                                                                                                      float64,
                                                                                                                                      valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryDouble

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryDouble2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                             float64 v_double,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryDouble2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                       float64,
                                                                                                                                       valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0008:  ret
  } // end of method Functions::NT_SetEntryDouble2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryString(uint8* name,
                            native uint name_len,
                            uint8* str,
                            native uint str_len,
                            valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    force
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryString(uint8*,
                                                                                                                                      native uint,
                                                                                                                                      uint8*,
                                                                                                                                      native uint,
                                                                                                                                      valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_000b:  ret
  } // end of method Functions::NT_SetEntryString

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryString2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                             uint8* str,
                             native uint str_len,
                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryString2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                       uint8*,
                                                                                                                                       native uint,
                                                                                                                                       valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryString2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryRaw(uint8* name,
                         native uint name_len,
                         uint8* raw,
                         native uint raw_len,
                         valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    force
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryRaw(uint8*,
                                                                                                                                   native uint,
                                                                                                                                   uint8*,
                                                                                                                                   native uint,
                                                                                                                                   valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_000b:  ret
  } // end of method Functions::NT_SetEntryRaw

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryRaw2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                          uint8* raw,
                          native uint raw_len,
                          valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryRaw2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                    uint8*,
                                                                                                                                    native uint,
                                                                                                                                    valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryRaw2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryBooleanArray(uint8* name,
                                  native uint name_len,
                                  int32* arr,
                                  native uint size,
                                  valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    force
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryBooleanArray(uint8*,
                                                                                                                                            native uint,
                                                                                                                                            int32*,
                                                                                                                                            native uint,
                                                                                                                                            valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_000b:  ret
  } // end of method Functions::NT_SetEntryBooleanArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryBooleanArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                   int32* arr,
                                   native uint size,
                                   valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryBooleanArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                             int32*,
                                                                                                                                             native uint,
                                                                                                                                             valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryBooleanArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryDoubleArray(uint8* name,
                                 native uint name_len,
                                 float64* arr,
                                 native uint size,
                                 valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    force
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryDoubleArray(uint8*,
                                                                                                                                           native uint,
                                                                                                                                           float64*,
                                                                                                                                           native uint,
                                                                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_000b:  ret
  } // end of method Functions::NT_SetEntryDoubleArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryDoubleArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                  float64* arr,
                                  native uint size,
                                  valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryDoubleArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                            float64*,
                                                                                                                                            native uint,
                                                                                                                                            valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryDoubleArray2

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryStringArray(uint8* name,
                                 native uint name_len,
                                 valuetype FRC.NetworkTables.Core.Interop.NT_String* arr,
                                 native uint size,
                                 valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  ldarg.s    force
    IL_0006:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryStringArray(uint8*,
                                                                                                                                           native uint,
                                                                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_String*,
                                                                                                                                           native uint,
                                                                                                                                           valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_000b:  ret
  } // end of method Functions::NT_SetEntryStringArray

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Bool
          NT_SetEntryStringArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry entry,
                                  valuetype FRC.NetworkTables.Core.Interop.NT_String* arr,
                                  native uint size,
                                  valuetype FRC.NetworkTables.Core.Interop.NT_Bool force) cil managed
  {
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  ldarg.3
    IL_0004:  call       valuetype FRC.NetworkTables.Core.Interop.NT_Bool FRC.NetworkTables.Core.Interop.Functions::NT_SetEntryStringArray2(valuetype FRC.NetworkTables.Core.Interop.NT_Entry,
                                                                                                                                            valuetype FRC.NetworkTables.Core.Interop.NT_String*,
                                                                                                                                            native uint,
                                                                                                                                            valuetype FRC.NetworkTables.Core.Interop.NT_Bool)
    IL_0009:  ret
  } // end of method Functions::NT_SetEntryStringArray2

} // end of class FRC.NetworkTables.Core.Interop.Functions