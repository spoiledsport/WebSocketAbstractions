#if ASPNETCORE50
using System;

namespace System.Net.WebSockets
{
    public enum WebSocketState
    {
        None,
        Connecting,
        Open,
        CloseSent,
        CloseReceived,
        Closed,
        Aborted
    }
}
#else
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Net.WebSockets.WebSocketState))]
#endif
