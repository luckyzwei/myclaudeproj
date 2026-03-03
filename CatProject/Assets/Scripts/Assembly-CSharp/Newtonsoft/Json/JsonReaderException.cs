using System;

namespace Newtonsoft.Json
{
	public class JsonReaderException : Exception
	{
		public int LineNumber { get; private set; }

		public int LinePosition { get; private set; }

		public JsonReaderException()
		{
		}

		public JsonReaderException(string message)
		{
		}

		public JsonReaderException(string message, Exception innerException)
		{
		}

		internal JsonReaderException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}
	}
}
