using System;

namespace WebSocketSharp
{
	public class ErrorEventArgs : EventArgs
	{
		private Exception _exception;

		private string _message;

		public Exception Exception => null;

		public string Message => null;

		internal ErrorEventArgs(string message)
	{
		_message = message;
	}

		internal ErrorEventArgs(string message, Exception exception)
	{
		_message = message;
		_exception = Exception;
	}
	}
}
