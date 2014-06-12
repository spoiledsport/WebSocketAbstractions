#if K10
namespace System.Net.WebSockets
{
    public enum WebSocketMessageType
    {
        Text,
        Binary,
        Close
    }
}
#else
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Net.WebSockets.WebSocketMessageType))]
#endif
