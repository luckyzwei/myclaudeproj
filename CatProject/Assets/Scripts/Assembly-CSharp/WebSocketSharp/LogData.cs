using System;
using System.Diagnostics;

namespace WebSocketSharp
{
	public class LogData
	{
		private StackFrame _caller;

		private DateTime _date;

		private LogLevel _level;

		private string _message;

		public StackFrame Caller => null;

		public DateTime Date => default(DateTime);

		public LogLevel Level => default(LogLevel);

		public string Message => null;

		internal LogData(LogLevel level, StackFrame caller, string message)
	{
		_level = level;
	}

		public override string ToString()
		{
			return null;
		}
	}
}
