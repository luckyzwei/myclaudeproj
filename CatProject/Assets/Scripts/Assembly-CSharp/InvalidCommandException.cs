using System;

public class InvalidCommandException : TpAutomationException
{
	public InvalidCommandException(Exception innerException) : base(innerException.Message, innerException)
	{
	}

	public InvalidCommandException(string message) : base(message)
	{
	}
}
