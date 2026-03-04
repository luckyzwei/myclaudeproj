using System;

public class TpInnerException : TpAutomationException
{
	public TpInnerException(Exception inner) : base(inner.Message, inner)
	{
	}
}
