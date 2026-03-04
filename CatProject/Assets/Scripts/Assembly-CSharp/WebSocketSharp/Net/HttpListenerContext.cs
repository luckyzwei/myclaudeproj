using System;
using System.Security.Principal;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerContext
	{
		private HttpConnection _connection;

		private string _errorMessage;

		private int _errorStatusCode;

		private HttpListener _listener;

		private HttpListenerRequest _request;

		private HttpListenerResponse _response;

		private IPrincipal _user;

		private HttpListenerWebSocketContext _websocketContext;

		internal HttpConnection Connection => null;

		internal string ErrorMessage
		{
		get { return _errorMessage; }
		set { _errorMessage = value; }
	}

		internal int ErrorStatusCode
		{
		get { return _errorStatusCode; }
		set { _errorStatusCode = value; }
	}

		internal bool HasErrorMessage => false;

		internal HttpListener Listener
		{
		get { return _listener; }
		set { _listener = value; }
	}

		public HttpListenerRequest Request => null;

		public HttpListenerResponse Response => null;

		public IPrincipal User => null;

		internal HttpListenerContext(HttpConnection connection)
		{
		}

		private static string createErrorContent(int statusCode, string statusDescription, string message)
		{
			return null;
		}

		internal HttpListenerWebSocketContext GetWebSocketContext(string protocol)
		{
			return null;
		}

		internal void SendAuthenticationChallenge(AuthenticationSchemes scheme, string realm)
		{
		}

		internal void SendError()
		{
		}

		internal void SendError(int statusCode)
		{
		}

		internal void SendError(int statusCode, string message)
		{
		}

		internal bool SetUser(AuthenticationSchemes scheme, string realm, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			return false;
		}

		internal void Unregister()
		{
		}

		public HttpListenerWebSocketContext AcceptWebSocket(string protocol)
		{
			return null;
		}

		public HttpListenerWebSocketContext AcceptWebSocket(string protocol, Action<WebSocket> initializer)
		{
			return null;
		}
	}
}
