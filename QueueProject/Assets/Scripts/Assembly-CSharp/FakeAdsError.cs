public class FakeAdsError
{
	private string description;

	private int code;

	public int GetErrorCode()
	{
		return 0;
	}

	public string GetDescription()
	{
		return null;
	}

	public int GetCode()
	{
		return 0;
	}

	public FakeAdsError(int errorCode, string errorDescription)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
