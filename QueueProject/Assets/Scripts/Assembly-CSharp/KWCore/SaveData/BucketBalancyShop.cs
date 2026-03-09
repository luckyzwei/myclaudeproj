namespace KWCore.SaveData
{
	public class BucketBalancyShop : BucketBase
	{
		[KeyLong]
		public const string LAST_PURCHASE_TIME = "last_purchase_time";

		private static BucketBalancyShop s_bucketbalancyshop;

		public static long LastPurchaseTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override string GetBucketKey()
		{
			return null;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static BucketBalancyShop GetBucket()
		{
			return null;
		}

		public static long GetLastPurchaseTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetLastPurchaseTime(long value)
		{
		}
	}
}
