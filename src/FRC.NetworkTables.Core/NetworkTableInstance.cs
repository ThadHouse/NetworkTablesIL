using FRC.NetworkTables.Core.Interop;

namespace NetworkTables
{
    public class NetworkTableInstance
    {
        private NT_Inst m_handle;

        public NetworkTableInstance(NT_Inst handle)
        {
            m_handle = handle;
        }

        public static implicit operator NetworkTableInstance(NT_Inst handle)
        {
            return new NetworkTableInstance(handle);
        }

        public static explicit operator NT_Inst(NetworkTableInstance inst)
        {
            return inst.m_handle;
        }
    }
}
