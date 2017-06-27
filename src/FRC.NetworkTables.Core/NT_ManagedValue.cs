using FRC.NetworkTables.Core.Interop;
using NetworkTables;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FRC.NetworkTables.Core
{
    public struct NT_ManagedValue
    {
        public NtType Type;
        public long LastChange;
        public NT_EntryUnion Data;

        public unsafe static void CreateNativeFromManaged(NT_ManagedValue v, NT_Value* value)
        {
            value->last_change = (ulong)v.LastChange;
            value->type = (NT_Type)v.Type;
            switch (v.Type)
            {
                case NtType.Boolean:
                    value->data.v_boolean = v.Data.VBoolean;
                    break;
                case NtType.Double:
                    value->data.v_double = v.Data.VDouble;
                    break;
                case NtType.String:
                    NtCore.CreateNtString(v.Data.VString, &value->data.v_string);
                    break;
                case NtType.Rpc:
                case NtType.Raw:
                    value->data.v_raw.str = (byte*)Marshal.AllocHGlobal(v.Data.VRaw.Length);
                    value->data.v_raw.len = (UIntPtr)v.Data.VRaw.Length;
                    for (int i = 0; i < v.Data.VRaw.Length; i++)
                    {
                        value->data.v_raw.str[i] = v.Data.VRaw[i];
                    }
                    break;
                case NtType.BooleanArray:
                    value->data.arr_boolean.arr = (NT_Bool*)Marshal.AllocHGlobal(v.Data.VBooleanArray.Length * sizeof(NT_Bool));
                    value->data.arr_boolean.len = (UIntPtr)v.Data.VBooleanArray.Length;
                    for (int i = 0; i < v.Data.VBooleanArray.Length; i++)
                    {
                        value->data.arr_boolean.arr[i] = v.Data.VBooleanArray[i];
                    }
                    break;
                case NtType.DoubleArray:
                    value->data.arr_double.arr = (double*)Marshal.AllocHGlobal(v.Data.VDoubleArray.Length * sizeof(double));
                    value->data.arr_double.len = (UIntPtr)v.Data.VDoubleArray.Length;
                    for (int i = 0; i < v.Data.VDoubleArray.Length; i++)
                    {
                        value->data.arr_double.arr[i] = v.Data.VDoubleArray[i];
                    }
                    break;
                case NtType.StringArray:
                    value->data.arr_string.arr = (NT_String*)Marshal.AllocHGlobal(v.Data.VStringArray.Length * sizeof(NT_String));
                    value->data.arr_string.len = (UIntPtr)v.Data.VStringArray.Length;
                    for (int i = 0; i < v.Data.VStringArray.Length; i++)
                    {
                        NtCore.CreateNtString(v.Data.VStringArray[i], &value->data.arr_string.arr[i]);
                    }
                    break;
            }
        }

        public unsafe static void DisposeCreatedNative(NT_Value* v)
        {
            switch (v->type)
            {
                case NT_Type.NT_STRING:
                    NtCore.DisposeNtString(&v->data.v_string);
                    break;
                case NT_Type.NT_RPC:
                case NT_Type.NT_RAW:
                    Marshal.FreeHGlobal((IntPtr)v->data.v_raw.str);
                    break;
                case NT_Type.NT_BOOLEAN_ARRAY:
                    Marshal.FreeHGlobal((IntPtr)v->data.arr_boolean.arr);
                    break;
                case NT_Type.NT_DOUBLE_ARRAY:
                    Marshal.FreeHGlobal((IntPtr)v->data.arr_double.arr);
                    break;
                case NT_Type.NT_STRING_ARRAY:
                    int len = (int)v->data.arr_string.len;
                    for (int i = 0; i < len; i++)
                    {
                        NtCore.DisposeNtString(&v->data.arr_string.arr[i]);
                    }
                    Marshal.FreeHGlobal((IntPtr)v->data.arr_string.arr);
                    break;
            }
        }

        public unsafe static NT_ManagedValue CreateManagedFromNative(NT_Value* v)
        {
            NT_ManagedValue value = new NT_ManagedValue();
            value.LastChange = (long)v->last_change;
            value.Type = (NtType)v->type;
            switch (v->type)
            {
                case NT_Type.NT_UNASSIGNED:
                    break;
                case NT_Type.NT_BOOLEAN:
                    value.Data.VBoolean = v->data.v_boolean.Get();
                    break;
                case NT_Type.NT_DOUBLE:
                    value.Data.VDouble = v->data.v_double;
                    break;
                case NT_Type.NT_STRING:
                    value.Data.VString = UTF8String.ReadUTF8String(v->data.v_string.str, v->data.v_string.len);
                    break;
                case NT_Type.NT_RPC:
                case NT_Type.NT_RAW:
                    value.Data.VRaw = new byte[(int)v->data.v_raw.len];
                    for (int i = 0; i < value.Data.VRaw.Length; i++)
                    {
                        value.Data.VRaw[i] = v->data.v_raw.str[i];
                    }
                    break;
                case NT_Type.NT_BOOLEAN_ARRAY:
                    value.Data.VBooleanArray = new bool[(int)v->data.arr_boolean.len];
                    for (int i = 0; i < value.Data.VBooleanArray.Length; i++)
                    {
                        value.Data.VBooleanArray[i] = v->data.arr_boolean.arr[i].Get();
                    }
                    break;
                case NT_Type.NT_DOUBLE_ARRAY:
                    value.Data.VDoubleArray = new double[(int)v->data.arr_double.len];
                    for (int i = 0; i < value.Data.VDoubleArray.Length; i++)
                    {
                        value.Data.VDoubleArray[i] = v->data.arr_double.arr[i];
                    }
                    break;
                case NT_Type.NT_STRING_ARRAY:
                    value.Data.VStringArray = new string[(int)v->data.arr_string.len];
                    for (int i = 0; i < value.Data.VStringArray.Length; i++)
                    {
                        value.Data.VStringArray[i] = UTF8String.ReadUTF8String(v->data.arr_string.arr[i].str, v->data.arr_string.arr[i].len);
                    }
                    break;
            }
            return value;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NT_EntryUnion
    {
        [FieldOffset(0)]
        public bool VBoolean;
        [FieldOffset(0)]
        public double VDouble;
        [FieldOffset(0)]
        public string VString;
        [FieldOffset(0)]
        public byte[] VRaw;
        [FieldOffset(0)]
        public bool[] VBooleanArray;
        [FieldOffset(0)]
        public double[] VDoubleArray;
        [FieldOffset(0)]
        public string[] VStringArray;
    }
}
