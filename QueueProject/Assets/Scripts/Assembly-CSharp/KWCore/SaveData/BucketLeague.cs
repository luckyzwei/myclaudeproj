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
			get { return GetBucket().GetInt(MAX_RANKING); }
			set { GetBucket().SetInt(MAX_RANKING, value); }
		}

		public static List<string> GlobalBots
		{
			get { return GetBucket().GetList<string>(GLOBAL_BOTS); }
			set { GetBucket().SetList(GLOBAL_BOTS, value); }
		}

		public static long BotTimeBank
		{
			get { return GetBucket().GetLong(BOT_TIME_BANK); }
			set { GetBucket().SetLong(BOT_TIME_BANK, value); }
		}

		public static long BotScoreTimeStamp
		{
			get { return GetBucket().GetLong(BOT_SCORE_TIME_STAMP); }
			set { GetBucket().SetLong(BOT_SCORE_TIME_STAMP, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketLeague GetBucket()
		{
			if (s_bucketleague == null)
			{
				s_bucketleague = new BucketLeague();
				s_bucketleague.LoadFromDisk();
			}
			return s_bucketleague;
		}

		public static int GetMaxRanking(int defaultValue = 0)
		{
			return GetBucket().GetInt(MAX_RANKING, defaultValue);
		}

		public static void SetMaxRanking(int value)
		{
			GetBucket().SetInt(MAX_RANKING, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetMaxRanking(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(MAX_RANKING, increment);
			GetBucket().SaveToDisk();
			return result;
		}

		public static List<string> GetGlobalBots()
		{
			return GetBucket().GetList<string>(GLOBAL_BOTS);
		}

		public static void SetGlobalBots(List<string> value)
		{
			GetBucket().SetList(GLOBAL_BOTS, value);
			GetBucket().SaveToDisk();
		}

		public static long GetBotTimeBank(long defaultValue = 0L)
		{
			return GetBucket().GetLong(BOT_TIME_BANK, defaultValue);
		}

		public static void SetBotTimeBank(long value)
		{
			GetBucket().SetLong(BOT_TIME_BANK, value);
			GetBucket().SaveToDisk();
		}

		public static long GetBotScoreTimeStamp(long defaultValue = 0L)
		{
			return GetBucket().GetLong(BOT_SCORE_TIME_STAMP, defaultValue);
		}

		public static void SetBotScoreTimeStamp(long value)
		{
			GetBucket().SetLong(BOT_SCORE_TIME_STAMP, value);
			GetBucket().SaveToDisk();
		}
	}
}
