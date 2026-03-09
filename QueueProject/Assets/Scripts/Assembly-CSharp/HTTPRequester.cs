using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public static class HTTPRequester
{
	public delegate void StringDelegate(string data);

	public delegate void ServerDataDelegate(ServerData data);

	private const bool SHOW_DEBUG_LOG = false;

	private static UnityWebRequest s_activeWebRequest;

	private static ServerData s_dataType;

	public static event ServerDataDelegate HTTPResponseReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event StringDelegate HTTPErrorReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void SendHTTPResponseReceivedEvent(ServerData data)
	{
	}

	public static void SendHTTPErrorReceivedEvent(string json)
	{
	}

	public static void GetData(string url, ServerData serverDataType)
	{
	}

	private static void HTTPRequest(string url, ServerData serverDataType)
	{
	}

	private static void PostRequest(string url, ServerData dataType)
	{
	}

	private static void Request_Completed(AsyncOperation obj)
	{
	}

	private static ServerData ParseData(string json, ServerData type)
	{
		return null;
	}
}
