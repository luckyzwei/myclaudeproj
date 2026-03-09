namespace KWCore.SaveData
{
	public class BucketQuests : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_QUESTS";

		[KeyBool]
		public const string QUEST_COMPLETE = "questComplete";

		[KeyBool]
		public const string QUEST_ACTIVE = "questActive";

		[KeyBool]
		public const string SUBQUEST_COMPLETE = "subQuestComplete";

		[KeyInt]
		public const string SUBQUEST_STEP = "subQuestStep";

		[KeyInt]
		public const string OBJECTIVE_ACCUMULATION = "objectiveAccumulation";

		private static BucketQuests s_bucketquests;

		public static bool QuestComplete
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool QuestActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SubquestComplete
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int SubquestStep
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int ObjectiveAccumulation
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

		private static BucketQuests GetBucket()
		{
			return null;
		}

		public static bool GetQuestComplete(bool defaultValue = false)
		{
			return false;
		}

		public static void SetQuestComplete(bool value)
		{
		}

		public static bool GetQuestActive(bool defaultValue = false)
		{
			return false;
		}

		public static void SetQuestActive(bool value)
		{
		}

		public static bool GetSubquestComplete(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSubquestComplete(bool value)
		{
		}

		public static int GetSubquestStep(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetSubquestStep(int value)
		{
		}

		public static int IncrementAndSetSubquestStep(int increment = 1)
		{
			return 0;
		}

		public static int GetObjectiveAccumulation(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetObjectiveAccumulation(int value)
		{
		}

		public static int IncrementAndSetObjectiveAccumulation(int increment = 1)
		{
			return 0;
		}
	}
}
