using System;

public class TpAutomationException : Exception
{
	public TpAutomationException()
	{
	}

	public TpAutomationException(string message) : base(message)
	{
	}

	public TpAutomationException(string message, Exception inner) : base(message, inner)
	{
	}
}
