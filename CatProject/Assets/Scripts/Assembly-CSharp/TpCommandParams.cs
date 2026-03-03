using Newtonsoft.Json;

public class TpCommandParams
{
	public string messageId;

	public string commandName;

	public TpCommandParams()
	{
	}

	[JsonConstructor]
	public TpCommandParams(string commandName, string messageId)
	{
	}
}
