using KWCore.SaveData;

public class BucketDataSheets : BucketBase
{
	private const string BUCKET_KEY = "DATA_SHEETS";

	public const string CURRENT_VERSION = "current_version";

	public override string GetBucketKey()
	{
		return null;
	}

	public override bool IsStoredInCloud()
	{
		return false;
	}
}
