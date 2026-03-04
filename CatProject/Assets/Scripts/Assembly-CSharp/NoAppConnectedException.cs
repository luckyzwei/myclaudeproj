public class NoAppConnectedException : ConnectionException
{
	public NoAppConnectedException()
	{
	}

	public NoAppConnectedException(string message) : base(message)
	{
	}
}
