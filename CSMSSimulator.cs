using System;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ocpp;

public class CSMSSimulator 
{
  public CSMSSimulator(int port)
  {
    this.Start("http://localhost:"+port+"/");
  }
    private int count = 0;
        public async void Start(string listenerPrefix)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(listenerPrefix);
            listener.Start();
            Console.WriteLine("Listening...");
           
            while (true)
            {
                HttpListenerContext listenerContext = await listener.GetContextAsync();
                if (listenerContext.Request.IsWebSocketRequest)
                {
                    ProcessRequest(listenerContext);
                }
                else
                {
                    listenerContext.Response.StatusCode = 400;
                    listenerContext.Response.Close();
                }
            }
        }

             
        private async void ProcessRequest(HttpListenerContext listenerContext)
        {
            WebSocketContext webSocketContext = null;
            try
            {                
                webSocketContext = await listenerContext.AcceptWebSocketAsync(subProtocol: "ocpp1.6");
                Interlocked.Increment(ref count);
                Console.WriteLine("Processed: {0}", count);
            }
            catch(Exception e)
            {
                listenerContext.Response.StatusCode = 500;
                listenerContext.Response.Close();
                Console.WriteLine("Exception: {0}", e);
                return;
            }
                                
            WebSocket webSocket = webSocketContext.WebSocket;                                           

            try
            {
                byte[] receiveBuffer = new byte[65535];

                while (webSocket.State == WebSocketState.Open)
                {
            
                    WebSocketReceiveResult receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);

                    if (receiveResult.MessageType == WebSocketMessageType.Text)
                    {                    
                        string buf = Encoding.ASCII.GetString(receiveBuffer);
                        buf = buf.Replace('\0', ' ').Trim();
                        
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            finally
            {
                if (webSocket != null)
                    webSocket.Dispose();
            }
        }

}
