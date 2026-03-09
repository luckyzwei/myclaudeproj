namespace KWCore.SaveData
{
	public class BucketDevice : BucketBase
	{
		[KeyString]
		private const string VENDOR_ID = "vendor_id";

		private static BucketDevice s_bucketdevice;

		public static string VendorId
		{
			get
			{
				return null;
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

		private static BucketDevice GetBucket()
		{
			return null;
		}

		public static string GetVendorId(string defaultValue = null)
		{
			return null;
		}

		public static void SetVendorId(string value)
		{
		}
	}
}
