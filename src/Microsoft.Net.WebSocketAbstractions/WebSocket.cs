#if ASPNETCORE50
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
    public abstract class WebSocket : IDisposable
    {
        public abstract WebSocketCloseStatus? CloseStatus { get; }
        public abstract string CloseStatusDescription { get; }
        public abstract string SubProtocol { get; }
        public abstract WebSocketState State { get; }
        public static TimeSpan DefaultKeepAliveInterval
        {
            get { throw new NotImplementedException(); }
        }
        public abstract void Abort();
        public abstract Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
        public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
        public abstract void Dispose();
        public abstract Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);
        public abstract Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);
    }
}
#else
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Net.WebSockets.WebSocket))]
#endif
