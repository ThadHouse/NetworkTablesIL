using System;
using System.Collections.Generic;
using System.Text;

namespace FRC.NetworkTables.Core.Interop
{
    public enum NT_Type
    {
        NT_UNASSIGNED = 0,
        NT_BOOLEAN = 0x01,
        NT_DOUBLE = 0x02,
        NT_STRING = 0x04,
        NT_RAW = 0x08,
        NT_BOOLEAN_ARRAY = 0x10,
        NT_DOUBLE_ARRAY = 0x20,
        NT_STRING_ARRAY = 0x40,
        NT_RPC = 0x80
    }

    public enum NT_EntryFlags { NT_PERSISTENT = 0x01 };

    public enum NT_LogLevel
    {
        NT_LOG_CRITICAL = 50,
        NT_LOG_ERROR = 40,
        NT_LOG_WARNING = 30,
        NT_LOG_INFO = 20,
        NT_LOG_DEBUG = 10,
        NT_LOG_DEBUG1 = 9,
        NT_LOG_DEBUG2 = 8,
        NT_LOG_DEBUG3 = 7,
        NT_LOG_DEBUG4 = 6
    };

    public enum NT_NotifyKind
    {
        NT_NOTIFY_NONE = 0,
        NT_NOTIFY_IMMEDIATE = 0x01, /* initial listener addition */
        NT_NOTIFY_LOCAL = 0x02,     /* changed locally */
        NT_NOTIFY_NEW = 0x04,       /* newly created entry */
        NT_NOTIFY_DELETE = 0x08,    /* deleted */
        NT_NOTIFY_UPDATE = 0x10,    /* value changed */
        NT_NOTIFY_FLAGS = 0x20      /* flags changed */
    };

    public enum NT_NetworkMode
    {
        NT_NET_MODE_NONE = 0x00,        /* not running */
        NT_NET_MODE_SERVER = 0x01,      /* running in server mode */
        NT_NET_MODE_CLIENT = 0x02,      /* running in client mode */
        NT_NET_MODE_STARTING = 0x04,    /* flag for starting (either client or server) */
        NT_NET_MODE_FAILURE = 0x08,     /* flag for failure (either client or server) */
    };
}
