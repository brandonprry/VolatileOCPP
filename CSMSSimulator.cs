using System;
using Newtonsoft.Json.Linq;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ocpp;

public class CSMSSimulator : WebSocketBehavior
{
    protected override void OnMessage (MessageEventArgs e)
    {
         JToken[] ret = JArray.Parse(e.Data).ToArray<JToken>();


      Send ("no");
    }

}
