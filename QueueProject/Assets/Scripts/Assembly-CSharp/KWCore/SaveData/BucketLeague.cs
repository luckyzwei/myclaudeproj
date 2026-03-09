using System.Collections.Generic;

namespace KWCore.SaveData
{
	public class BucketLeague : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_LEAGUE";

		[KeyInt]
		private const string MAX_RANKING = "MAX_RANKING";

		[KeyList(typeof(string))]
		private const string GLOBAL_BOTS = "GLOBAL_BOTS";

		[KeyLong]
		private const string BOT_TIME_BANK = "BOT_TIME_BANK";

		[KeyLong]
		private const string BOT_SCORE_TIME_STAMP = "BOT_SCORE_TIME_STAMP";

		private static BucketLeague s_bucketleague;

		public static int MaxRanking
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static List<string> GlobalBots
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static long BotTimeBank
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long BotScoreTimeStamp
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

		private static BucketLeague GetBucket()
		{
			return null;
		}

		public static int GetMaxRanking(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetMaxRanking(int value)
		{
		}

		public static int IncrementAndSetMaxRanking(int increment = 1)
		{
			return 0;
		}

		public static List<string> GetGlobalBots()
		{
			return null;
		}

		public static void SetGlobalBots(List<string> value)
		{
		}

		public static long GetBotTimeBank(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetBotTimeBank(long value)
		{
		}

		public static long GetBotScoreTimeStamp(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetBotScoreTimeStamp(long value)
		{
		}
	}
}
