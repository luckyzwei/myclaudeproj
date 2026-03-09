namespace KWCore.SaveData
{
	public class BucketAudio : BucketBase
	{
		[KeyBool]
		private const string MUSIC_ENABLED = "MUSIC_ENABLED";

		[KeyBool]
		private const string SFX_ENABLED = "SFX_ENABLED";

		private static BucketAudio s_bucketaudio;

		public static bool MusicEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SfxEnabled
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

		private static BucketAudio GetBucket()
		{
			return null;
		}

		public static bool GetMusicEnabled(bool defaultValue = false)
		{
			return false;
		}

		public static void SetMusicEnabled(bool value)
		{
		}

		public static bool GetSfxEnabled(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSfxEnabled(bool value)
		{
		}
	}
}
