using KWCore.SaveData;

public class BucketServerShop : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_SERVER_SHOP";

	public const string EQUIPPED_ITEM = "equipped_item_";

	public override string GetBucketKey()
	{
		return null;
	}

	public override bool IsStoredInCloud()
	{
		return false;
	}
}
