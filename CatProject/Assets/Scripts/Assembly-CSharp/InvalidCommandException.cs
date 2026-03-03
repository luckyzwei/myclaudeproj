using System;

public class InvalidCommandException : TpAutomationException
{
	public InvalidCommandException(Exception innerException)
	{
	}

	public InvalidCommandException(string message)
	{
	}
}
