using WebSocketSharp;
using WebSocketSharp.Server;

public class TpAutomationWebSocketBehaviour : WebSocketBehavior
{
	public TpAutomationWebSocketServer Server { get; set; }

	protected override void OnClose(CloseEventArgs e)
	{
	}

	protected override void OnError(ErrorEventArgs e)
	{
	}

	protected override void OnMessage(MessageEventArgs e)
	{
	}

	protected override void OnOpen()
	{
	}
}
