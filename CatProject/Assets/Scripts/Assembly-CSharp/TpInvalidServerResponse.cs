public class TpInvalidServerResponse : TpAutomationException
{
	public TpInvalidServerResponse(string expected, string received)
		: base($"Expected: {expected}, Received: {received}")
	{
	}
}
