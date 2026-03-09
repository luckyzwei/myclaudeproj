namespace KWCore.SaveData
{
	public class BucketHaptic : BucketBase
	{
		[KeyBool]
		private const string HAPTIC_ENABLED = "haptic_enabled";

		private static BucketHaptic s_buckethaptic;

		public static bool HapticEnabled
		{
			get
			{
				return false;
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

		private static BucketHaptic GetBucket()
		{
			return null;
		}

		public static bool GetHapticEnabled(bool defaultValue = false)
		{
			return false;
		}

		public static void SetHapticEnabled(bool value)
		{
		}
	}
}
