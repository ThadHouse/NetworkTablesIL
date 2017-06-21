.class public abstract sealed auto ansi beforefieldinit
  FRC.NetworkTables.Core.Interop.Functions
    extends [System.Runtime]System.Object
{

  .method public hidebysig static valuetype FRC.NetworkTables.Core.Interop.NT_Entry
    NT_GetEntry(
      valuetype FRC.NetworkTables.Core.Interop.NT_Inst inst,
      unsigned int8* name,
      native unsigned int name_len,
      native int func
    ) cil managed
  {
    ldarg.0      // inst
    ldarg.1      // name
    ldarg.2      // name_len
    ldarg.3      // func
    calli unmanaged cdecl int32(int32,void*,native unsigned int)
    ret
  } // end of method Functions::NT_GetEntry
}