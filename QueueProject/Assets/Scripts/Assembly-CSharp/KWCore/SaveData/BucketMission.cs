namespace KWCore.SaveData
{
	public class BucketMission : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_MISSION";

		[KeyInt]
		public const string CURRENT_QUEST_INDEX = "current_quest_index";

		private static BucketMission s_bucketmission;

		public static int CurrentQuestIndex
		{
			get
			{
				return 0;
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

		private static BucketMission GetBucket()
		{
			return null;
		}

		public static int GetCurrentQuestIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetCurrentQuestIndex(int value)
		{
		}

		public static int IncrementAndSetCurrentQuestIndex(int increment = 1)
		{
			return 0;
		}
	}
}
