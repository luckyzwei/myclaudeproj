using System;

public class ReversePortForwardingException : TpAutomationException
{
	public ReversePortForwardingException()
	{
	}

	public ReversePortForwardingException(string message) : base(message)
	{
	}

	public ReversePortForwardingException(string message, Exception inner) : base(message, inner)
	{
	}
}
