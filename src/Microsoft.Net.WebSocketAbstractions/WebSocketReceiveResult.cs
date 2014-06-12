#if K10
using System;
using System.Runtime;

namespace System.Net.WebSockets
{
    public class WebSocketReceiveResult
    {
        public int Count
        {
            get;
            private set;
        }

        public bool EndOfMessage
        {
            get;
            private set;
        }

        public WebSocketMessageType MessageType
        {
            get;
            private set;
        }

        public WebSocketCloseStatus? CloseStatus
        {
            get;
            private set;
        }

        public string CloseStatusDescription
        {
            get;
            private set;
        }

        public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage) : this(count, messageType, endOfMessage, null, null)
        {
        }

        public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeStatusDescription)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count");
            }
            this.Count = count;
            this.EndOfMessage = endOfMessage;
            this.MessageType = messageType;
            this.CloseStatus = closeStatus;
            this.CloseStatusDescription = closeStatusDescription;
        }
    }
}
#else
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Net.WebSockets.WebSocketReceiveResult))]
#endif