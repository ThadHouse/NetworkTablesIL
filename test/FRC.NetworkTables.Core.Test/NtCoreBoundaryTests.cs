using FRC.NetworkTables.Core.Interop;
using System;
using System.Runtime.InteropServices;
using Xunit;

namespace FRC.NetworkTables.Core.Test
{
    public class NtCoreBoundaryTests
    {
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
    }
}
