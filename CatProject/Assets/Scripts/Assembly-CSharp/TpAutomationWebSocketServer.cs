using UniRx;
using WebSocketSharp.Server;

public class TpAutomationWebSocketServer
{
	private readonly string host;

	private readonly int port;

	private readonly string path;

	private readonly string uri;

	private WebSocketServer wsServer;

	public Subject<TpAutomationWebSocketBehaviourMessageArgs> OnMessageStream;

	public Subject<TpAutomationWebSocketBehaviourCloseArgs> OnCloseStream;

	public Subject<TpAutomationWebSocketBehaviourOpenArgs> OnConnectStream;

	public Subject<TpAutomationWebSocketBehaviourErrorArgs> OnErrorStream;

	public bool IsAlive => false;

	public TpAutomationWebSocketServer(string host, int port, string path)
	{
	}

	public void Listen()
	{
	}

	public void Stop()
	{
	}

	public void Send(string socketID, string message)
	{
	}
}
