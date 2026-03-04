using System;

namespace WebSocketSharp
{
	public class WebSocketException : Exception
	{
		private ushort _code;

		public ushort Code => 0;

		private WebSocketException(ushort code, string message, Exception innerException)
	{
		_code = (ushort)code;
	}

		internal WebSocketException()
		{
		}

		internal WebSocketException(Exception innerException)
		{
		}

		internal WebSocketException(string message)
		{
		}

		internal WebSocketException(CloseStatusCode code)
	{
		_code = (ushort)code;
	}

		internal WebSocketException(string message, Exception innerException)
		{
		}

		internal WebSocketException(CloseStatusCode code, Exception innerException)
	{
		_code = (ushort)code;
	}

		internal WebSocketException(CloseStatusCode code, string message)
	{
		_code = (ushort)code;
	}

		internal WebSocketException(CloseStatusCode code, string message, Exception innerException)
	{
		_code = (ushort)code;
	}
	}
}
