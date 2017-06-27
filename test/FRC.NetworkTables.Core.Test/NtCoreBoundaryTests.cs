using FRC.NetworkTables.Core.Interop;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;

namespace FRC.NetworkTables.Core.Test
{
    public class NtCoreBoundaryTests
    {
        public unsafe T[] ReadArrayFromPointer<T>(void* data, UIntPtr len)
        {
            T[] tmp = new T[(int)len];
            int tSize = Unsafe.SizeOf<T>();
            byte* bData = (byte*)data;
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = Unsafe.Read<T>(bData + tSize * i);
            }
            return tmp;
        }

        public byte[] ToUTF8String(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }


        [Fact]
        public void TestGetDefaultInstance()
        {
            var tmpPtr = Functions.NT_GetDefaultInstanceFunctionPointer;
            try
            {
                int count = 0;
                Interop.Test.NT_GetDefaultInstanceDelegate del = () =>
                {
                    return new NT_Inst(count);
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_GetDefaultInstanceFunctionPointer = delPtr;

                for (count = 0; count < 100; count++)
                {
                    var item = NtCore.NT_GetDefaultInstance();
                    Assert.Equal(count, item.Get());
                }
            }
            finally
            {
                Functions.NT_GetDefaultInstanceFunctionPointer = tmpPtr;
            }
        }

        [Fact]
        public void TestCreateInstance()
        {
            var tmpPtr = Functions.NT_CreateInstanceFunctionPointer;
            try
            {
                int count = 0;
                Interop.Test.NT_CreateInstanceDelegate del = () =>
                {
                    return new NT_Inst(count);
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_CreateInstanceFunctionPointer = delPtr;

                for (count = 0; count < 100; count++)
                {
                    var item = NtCore.NT_CreateInstance();
                    Assert.Equal(count, item.Get());
                }
            }
            finally
            {
                Functions.NT_CreateInstanceFunctionPointer = tmpPtr;
            }
        }

        [Fact]
        public void TestDestroyInstance()
        {
            var tmpPtr = Functions.NT_DestroyInstanceFunctionPointer;
            try
            {
                int count = 0;
                NT_Inst item = default(NT_Inst);
                Interop.Test.NT_DestroyInstanceDelegate del = (i) =>
                {
                    item = i;
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_DestroyInstanceFunctionPointer = delPtr;

                for (count = 0; count < 100; count++)
                {
                    NtCore.NT_DestroyInstance(new NT_Inst(count));
                    Assert.Equal(count, item.Get());
                }
            }
            finally
            {
                Functions.NT_DestroyInstanceFunctionPointer = tmpPtr;
            }
        }

        [Fact]
        public void TestGetInstanceFromHandle()
        {
            var tmpPtr = Functions.NT_GetInstanceFromHandleFunctionPointer;
            try
            {
                int count = 0;
                NT_Handle item = default(NT_Handle);
                Interop.Test.NT_GetInstanceFromHandleDelegate del = (i) =>
                {
                    item = i;
                    return new NT_Inst(count);
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_GetInstanceFromHandleFunctionPointer = delPtr;

                for (count = 0; count < 100; count++)
                {
                    var ret = NtCore.NT_GetInstanceFromHandle(new NT_Handle(count));
                    Assert.Equal(count, item.Get());
                    Assert.Equal(count, ret.Get());
                }
            }
            finally
            {
                Functions.NT_GetInstanceFromHandleFunctionPointer = tmpPtr;
            }
        }

        [Fact]
        public unsafe void TestGetEntry()
        {
            var tmpPtr = Functions.NT_GetEntryFunctionPointer;
            try
            {
                int count = 0;
                NT_Inst item = default(NT_Inst);
                byte[] buffer = null;
                Interop.Test.NT_GetEntryDelegate del = (i, s, sl) =>
                {
                    buffer = ReadArrayFromPointer<byte>(s, sl);
                    item = i;
                    return new NT_Entry(count);
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_GetEntryFunctionPointer = delPtr;

                for (count = 0; count < 100; count++)
                {
                    var ret = NtCore.NT_GetEntry(new NT_Inst(count), count.ToString());
                    Assert.Equal(count, item.Get());
                    Assert.Equal(count, ret.Get());
                    byte[] data = ToUTF8String(count.ToString());
                    Assert.Equal(buffer, data);

                }
            }
            finally
            {
                Functions.NT_GetEntryFunctionPointer = tmpPtr;
            }
        }

        [Fact]
        public unsafe void TestGetEntryHandles()
        {
            var tmpPtr = Functions.NT_GetEntriesFunctionPointer;
            var tmpDeletePtr = Functions.NT_DisposeEntryArrayFunctionPointer;
            try
            {
                int count = 0;
                NT_Inst item = default(NT_Inst);
                uint type = 0;
                byte[] buffer = null;
                Interop.Test.NT_GetEntriesDelegate del = (i, s, sl, t, oC) =>
                {
                    var retPtr = (NT_Entry*)Marshal.AllocHGlobal(4 * count);
                    for (int j = 0; j < count; j++)
                    {
                        retPtr[j] = new NT_Entry(j + 1);
                    }

                    buffer = ReadArrayFromPointer<byte>(s, sl);
                    type = t;
                    item = i;
                    *oC = (UIntPtr)count;
                    return retPtr;
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_GetEntriesFunctionPointer = delPtr;

                Interop.Test.NT_DisposeEntryArrayDelegate dDel = (p, l) =>
                {
                    Marshal.FreeHGlobal((IntPtr)p);
                };

                var dDelPtr = Marshal.GetFunctionPointerForDelegate(dDel);
                Functions.NT_DisposeEntryArrayFunctionPointer = dDelPtr;

                for (count = 0; count < 100; count++)
                {
                    var ret = NtCore.NT_GetEntryHandles(new NT_Inst(count), count.ToString(), (uint)count);
                    Assert.Equal(count, item.Get());
                    Assert.Equal(count, ret.Length);
                    Assert.Equal((uint)count, type);
                    byte[] data = ToUTF8String(count.ToString());
                    Assert.Equal(data, buffer);
                    for (int i = 0; i < count; i++)
                    {
                        Assert.Equal(i + 1, ret[i].Get());
                    }
                }
            }
            finally
            {
                Functions.NT_GetEntriesFunctionPointer = tmpPtr;
                Functions.NT_DisposeEntryArrayFunctionPointer = tmpDeletePtr;
            }
        }

        [Fact]
        public unsafe void TestGetEntries()
        {
            var tmpPtr = Functions.NT_GetEntriesFunctionPointer;
            var tmpDeletePtr = Functions.NT_DisposeEntryArrayFunctionPointer;
            try
            {
                int count = 0;
                NT_Inst item = default(NT_Inst);
                uint type = 0;
                byte[] buffer = null;
                Interop.Test.NT_GetEntriesDelegate del = (i, s, sl, t, oC) =>
                {
                    var retPtr = (NT_Entry*)Marshal.AllocHGlobal(4 * count);
                    for (int j = 0; j < count; j++)
                    {
                        retPtr[j] = new NT_Entry(j + 1);
                    }

                    buffer = ReadArrayFromPointer<byte>(s, sl);
                    type = t;
                    item = i;
                    *oC = (UIntPtr)count;
                    return retPtr;
                };
                var delPtr = Marshal.GetFunctionPointerForDelegate(del);
                Functions.NT_GetEntriesFunctionPointer = delPtr;

                Interop.Test.NT_DisposeEntryArrayDelegate dDel = (p, l) =>
                {
                    Marshal.FreeHGlobal((IntPtr)p);
                };

                var dDelPtr = Marshal.GetFunctionPointerForDelegate(dDel);
                Functions.NT_DisposeEntryArrayFunctionPointer = dDelPtr;

                for (count = 0; count < 100; count++)
                {
                    var ret = NtCore.NT_GetEntries(new NT_Inst(count), count.ToString(), (uint)count);
                    Assert.Equal(count, item.Get());
                    Assert.Equal(count, ret.Length);
                    Assert.Equal((uint)count, type);
                    byte[] data = ToUTF8String(count.ToString());
                    Assert.Equal(data, buffer);
                    for (int i = 0; i < count; i++)
                    {
                        Assert.Equal(i + 1, ((NT_Entry)ret[i]).Get());
                    }
                }
            }
            finally
            {
                Functions.NT_GetEntriesFunctionPointer = tmpPtr;
                Functions.NT_DisposeEntryArrayFunctionPointer = tmpDeletePtr;
            }
        }
    }
}
