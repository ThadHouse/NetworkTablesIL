using System;
using System.Collections.Generic;
using System.Text;

namespace FRC.NetworkTables.Core
{
    public struct CallbackHandle
    {
        internal IntPtr Value { get; set; }

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
