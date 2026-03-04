public class AppDisconnectedException : ConnectionException
{
	public AppDisconnectedException()
	{
	}

	public AppDisconnectedException(string message) : base(message)
	{
	}
}
