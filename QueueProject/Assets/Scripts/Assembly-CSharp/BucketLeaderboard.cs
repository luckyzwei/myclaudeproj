using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketLeaderboard : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_LEADERBOARD";

	[KeyString]
	private const string STORE_COUNTRY_ISO = "STORE_COUNTRY_ISO";

	[SubkeyInt]
	private const string PREVIOUS_RANK = "PREVIOUS_RANK_INT";

	[SubkeyLong]
	private const string CURRENT_RANK = "CURRENT_RANK";

	[SubkeyLong]
	private const string PREVIOUS_SCORE = "PREVIOUS_SCORE";

	[KeyInt]
	private const string GLOBAL_PLAYER_SCORE = "global_player_score";

	[KeyInt]
	private const string GLOBAL_PLAYER_SCORE_LAST_SEEN = "global_player_score_last_seen";

	[KeyInt]
	private const string GLOBAL_PLAYER_MAX_RANK = "global_player_max_rank";

	[KeyList(typeof(string))]
	private const string GLOBAL_BOTS_SCORE = "global_bots_score";

	[KeyLong]
	private const string GLOBAL_BOT_TIME_BANK = "global_bot_timebank";

	[KeyLong]
	private const string GLOBAL_BOT_SCORE_TIMESTAMP = "global_bot_score_timestamp";

	[KeyList(typeof(string))]
	private const string LEAGUE_BOTS_SCORE = "league_bots_score";

	[KeyLong]
	private const string LEAGUE_BOT_TIME_BANK = "league_bot_timebank";

	[KeyLong]
	private const string LEAGUE_BOT_SCORE_TIMESTAMP = "league_bot_score_timestamp";

	[KeyInt]
	private const string LEAGUE_PLAYER_RANK = "league_player_rank";

	[KeyInt]
	private const string LEAGUE_PLAYER_SCORE = "league_player_score";

	[KeyInt]
	private const string LEAGUE_PLAYER_NEWSCORE = "league_player_newscore";

	[KeyInt]
	private const string LEAGUE_PLAYER_MAX_RANKING = "league_player_max_ranking";

	[KeyInt]
	private const string LEAGUE_PLAYER_MAX_LEAGUE = "league_player_max_league";

	[KeyInt]
	private const string LEAGUE_CURRENT_INDEX = "league_current_intdex";

	[KeyLong]
	private const string LEAGUE_CURRENT_TIMESTAMP = "league_current_timestamp";

	[KeyBool]
	private const string MIGRATED = "migrated";

	private static BucketLeaderboard s_bucketleaderboard;

	public static string StoreCountryIso
	{
		get
		{
			return GetBucket()?.GetString(STORE_COUNTRY_ISO);
		}
		set
		{
			GetBucket()?.SetString(STORE_COUNTRY_ISO, value);
		}
	}

	public static int GlobalPlayerScore
	{
		get
		{
			return GetBucket()?.GetInt(GLOBAL_PLAYER_SCORE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(GLOBAL_PLAYER_SCORE, value);
		}
	}

	public static int GlobalPlayerScoreLastSeen
	{
		get
		{
			return GetBucket()?.GetInt(GLOBAL_PLAYER_SCORE_LAST_SEEN, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(GLOBAL_PLAYER_SCORE_LAST_SEEN, value);
		}
	}

	public static int GlobalPlayerMaxRank
	{
		get
		{
			return GetBucket()?.GetInt(GLOBAL_PLAYER_MAX_RANK, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(GLOBAL_PLAYER_MAX_RANK, value);
		}
	}

	public static List<string> GlobalBotsScore
	{
		get
		{
			return GetBucket()?.GetList<string>(GLOBAL_BOTS_SCORE);
		}
		set
		{
			GetBucket()?.SetList(GLOBAL_BOTS_SCORE, value);
		}
	}

	public static long GlobalBotTimeBank
	{
		get
		{
			return GetBucket()?.GetLong(GLOBAL_BOT_TIME_BANK, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(GLOBAL_BOT_TIME_BANK, value);
		}
	}

	public static long GlobalBotScoreTimestamp
	{
		get
		{
			return GetBucket()?.GetLong(GLOBAL_BOT_SCORE_TIMESTAMP, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(GLOBAL_BOT_SCORE_TIMESTAMP, value);
		}
	}

	public static List<string> LeagueBotsScore
	{
		get
		{
			return GetBucket()?.GetList<string>(LEAGUE_BOTS_SCORE);
		}
		set
		{
			GetBucket()?.SetList(LEAGUE_BOTS_SCORE, value);
		}
	}

	public static long LeagueBotTimeBank
	{
		get
		{
			return GetBucket()?.GetLong(LEAGUE_BOT_TIME_BANK, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LEAGUE_BOT_TIME_BANK, value);
		}
	}

	public static long LeagueBotScoreTimestamp
	{
		get
		{
			return GetBucket()?.GetLong(LEAGUE_BOT_SCORE_TIMESTAMP, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LEAGUE_BOT_SCORE_TIMESTAMP, value);
		}
	}

	public static int LeaguePlayerRank
	{
		get
		{
			return GetBucket()?.GetInt(LEAGUE_PLAYER_RANK, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LEAGUE_PLAYER_RANK, value);
		}
	}

	public static int LeaguePlayerScore
	{
		get
		{
			return GetBucket()?.GetInt(LEAGUE_PLAYER_SCORE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LEAGUE_PLAYER_SCORE, value);
		}
	}

	public static int LeaguePlayerNewscore
	{
		get
		{
			return GetBucket()?.GetInt(LEAGUE_PLAYER_NEWSCORE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LEAGUE_PLAYER_NEWSCORE, value);
		}
	}

	public static int LeaguePlayerMaxRanking
	{
		get
		{
			return GetBucket()?.GetInt(LEAGUE_PLAYER_MAX_RANKING, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LEAGUE_PLAYER_MAX_RANKING, value);
		}
	}

	public static int LeaguePlayerMaxLeague
	{
		get
		{
			return GetBucket()?.GetInt(LEAGUE_PLAYER_MAX_LEAGUE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LEAGUE_PLAYER_MAX_LEAGUE, value);
		}
	}

	public static int LeagueCurrentIndex
	{
		get
		{
			return GetBucket()?.GetInt(LEAGUE_CURRENT_INDEX, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LEAGUE_CURRENT_INDEX, value);
		}
	}

	public static long LeagueCurrentTimestamp
	{
		get
		{
			return GetBucket()?.GetLong(LEAGUE_CURRENT_TIMESTAMP, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LEAGUE_CURRENT_TIMESTAMP, value);
		}
	}

	public static bool Migrated
	{
		get
		{
			return GetBucket()?.GetBool(MIGRATED) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(MIGRATED, value);
		}
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	public void MigrateFromBalancy()
	{
	}

	private static BucketLeaderboard GetBucket()
	{
		if (s_bucketleaderboard == null)
		{
			s_bucketleaderboard = new BucketLeaderboard();
			s_bucketleaderboard.LoadFromDisk();
		}
		return s_bucketleaderboard;
	}

	public static string GetStoreCountryIso(string defaultValue = null)
	{
		return GetBucket()?.GetString(STORE_COUNTRY_ISO, defaultValue) ?? defaultValue;
	}

	public static void SetStoreCountryIso(string value)
	{
		GetBucket()?.SetString(STORE_COUNTRY_ISO, value);
	}

	public static int GetPreviousRank(string subkey, int defaultValue = 0)
	{
		return GetBucket()?.GetInt(PREVIOUS_RANK, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetPreviousRank(string subkey, int value)
	{
		GetBucket()?.SetInt(PREVIOUS_RANK, value, subkey);
	}

	public static int IncrementAndSetPreviousRank(string subkey, int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(PREVIOUS_RANK, increment, subkey) ?? 0;
	}

	public static long GetCurrentRank(string subkey, long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(CURRENT_RANK, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetCurrentRank(string subkey, long value)
	{
		GetBucket()?.SetLong(CURRENT_RANK, value, subkey);
	}

	public static long GetPreviousScore(string subkey, long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(PREVIOUS_SCORE, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetPreviousScore(string subkey, long value)
	{
		GetBucket()?.SetLong(PREVIOUS_SCORE, value, subkey);
	}

	public static int GetGlobalPlayerScore(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(GLOBAL_PLAYER_SCORE, defaultValue) ?? defaultValue;
	}

	public static void SetGlobalPlayerScore(int value)
	{
		GetBucket()?.SetInt(GLOBAL_PLAYER_SCORE, value);
	}

	public static int IncrementAndSetGlobalPlayerScore(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(GLOBAL_PLAYER_SCORE, increment) ?? 0;
	}

	public static int GetGlobalPlayerScoreLastSeen(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(GLOBAL_PLAYER_SCORE_LAST_SEEN, defaultValue) ?? defaultValue;
	}

	public static void SetGlobalPlayerScoreLastSeen(int value)
	{
		GetBucket()?.SetInt(GLOBAL_PLAYER_SCORE_LAST_SEEN, value);
	}

	public static int IncrementAndSetGlobalPlayerScoreLastSeen(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(GLOBAL_PLAYER_SCORE_LAST_SEEN, increment) ?? 0;
	}

	public static int GetGlobalPlayerMaxRank(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(GLOBAL_PLAYER_MAX_RANK, defaultValue) ?? defaultValue;
	}

	public static void SetGlobalPlayerMaxRank(int value)
	{
		GetBucket()?.SetInt(GLOBAL_PLAYER_MAX_RANK, value);
	}

	public static int IncrementAndSetGlobalPlayerMaxRank(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(GLOBAL_PLAYER_MAX_RANK, increment) ?? 0;
	}

	public static List<string> GetGlobalBotsScore()
	{
		return GetBucket()?.GetList<string>(GLOBAL_BOTS_SCORE);
	}

	public static void SetGlobalBotsScore(List<string> value)
	{
		GetBucket()?.SetList(GLOBAL_BOTS_SCORE, value);
	}

	public static long GetGlobalBotTimeBank(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(GLOBAL_BOT_TIME_BANK, defaultValue) ?? defaultValue;
	}

	public static void SetGlobalBotTimeBank(long value)
	{
		GetBucket()?.SetLong(GLOBAL_BOT_TIME_BANK, value);
	}

	public static long GetGlobalBotScoreTimestamp(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(GLOBAL_BOT_SCORE_TIMESTAMP, defaultValue) ?? defaultValue;
	}

	public static void SetGlobalBotScoreTimestamp(long value)
	{
		GetBucket()?.SetLong(GLOBAL_BOT_SCORE_TIMESTAMP, value);
	}

	public static List<string> GetLeagueBotsScore()
	{
		return GetBucket()?.GetList<string>(LEAGUE_BOTS_SCORE);
	}

	public static void SetLeagueBotsScore(List<string> value)
	{
		GetBucket()?.SetList(LEAGUE_BOTS_SCORE, value);
	}

	public static long GetLeagueBotTimeBank(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LEAGUE_BOT_TIME_BANK, defaultValue) ?? defaultValue;
	}

	public static void SetLeagueBotTimeBank(long value)
	{
		GetBucket()?.SetLong(LEAGUE_BOT_TIME_BANK, value);
	}

	public static long GetLeagueBotScoreTimestamp(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LEAGUE_BOT_SCORE_TIMESTAMP, defaultValue) ?? defaultValue;
	}

	public static void SetLeagueBotScoreTimestamp(long value)
	{
		GetBucket()?.SetLong(LEAGUE_BOT_SCORE_TIMESTAMP, value);
	}

	public static int GetLeaguePlayerRank(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LEAGUE_PLAYER_RANK, defaultValue) ?? defaultValue;
	}

	public static void SetLeaguePlayerRank(int value)
	{
		GetBucket()?.SetInt(LEAGUE_PLAYER_RANK, value);
	}

	public static int IncrementAndSetLeaguePlayerRank(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LEAGUE_PLAYER_RANK, increment) ?? 0;
	}

	public static int GetLeaguePlayerScore(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LEAGUE_PLAYER_SCORE, defaultValue) ?? defaultValue;
	}

	public static void SetLeaguePlayerScore(int value)
	{
		GetBucket()?.SetInt(LEAGUE_PLAYER_SCORE, value);
	}

	public static int IncrementAndSetLeaguePlayerScore(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LEAGUE_PLAYER_SCORE, increment) ?? 0;
	}

	public static int GetLeaguePlayerNewscore(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LEAGUE_PLAYER_NEWSCORE, defaultValue) ?? defaultValue;
	}

	public static void SetLeaguePlayerNewscore(int value)
	{
		GetBucket()?.SetInt(LEAGUE_PLAYER_NEWSCORE, value);
	}

	public static int IncrementAndSetLeaguePlayerNewscore(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LEAGUE_PLAYER_NEWSCORE, increment) ?? 0;
	}

	public static int GetLeaguePlayerMaxRanking(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LEAGUE_PLAYER_MAX_RANKING, defaultValue) ?? defaultValue;
	}

	public static void SetLeaguePlayerMaxRanking(int value)
	{
		GetBucket()?.SetInt(LEAGUE_PLAYER_MAX_RANKING, value);
	}

	public static int IncrementAndSetLeaguePlayerMaxRanking(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LEAGUE_PLAYER_MAX_RANKING, increment) ?? 0;
	}

	public static int GetLeaguePlayerMaxLeague(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LEAGUE_PLAYER_MAX_LEAGUE, defaultValue) ?? defaultValue;
	}

	public static void SetLeaguePlayerMaxLeague(int value)
	{
		GetBucket()?.SetInt(LEAGUE_PLAYER_MAX_LEAGUE, value);
	}

	public static int IncrementAndSetLeaguePlayerMaxLeague(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LEAGUE_PLAYER_MAX_LEAGUE, increment) ?? 0;
	}

	public static int GetLeagueCurrentIndex(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LEAGUE_CURRENT_INDEX, defaultValue) ?? defaultValue;
	}

	public static void SetLeagueCurrentIndex(int value)
	{
		GetBucket()?.SetInt(LEAGUE_CURRENT_INDEX, value);
	}

	public static int IncrementAndSetLeagueCurrentIndex(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LEAGUE_CURRENT_INDEX, increment) ?? 0;
	}

	public static long GetLeagueCurrentTimestamp(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LEAGUE_CURRENT_TIMESTAMP, defaultValue) ?? defaultValue;
	}

	public static void SetLeagueCurrentTimestamp(long value)
	{
		GetBucket()?.SetLong(LEAGUE_CURRENT_TIMESTAMP, value);
	}

	public static bool GetMigrated(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(MIGRATED, defaultValue) ?? defaultValue;
	}

	public static void SetMigrated(bool value)
	{
		GetBucket()?.SetBool(MIGRATED, value);
	}
}
