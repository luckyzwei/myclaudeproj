using UnityEngine;

public class TpRuntimeCommunicationHandler : MonoBehaviour
{
	private TpAutomationWebSocketServer Server;

	public string host;

	public int port;

	private TpCommandHandler commandHandler;

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
