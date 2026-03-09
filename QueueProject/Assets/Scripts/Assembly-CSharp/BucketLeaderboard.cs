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
			return null;
		}
		set
		{
		}
	}

	public static int GlobalPlayerScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int GlobalPlayerScoreLastSeen
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int GlobalPlayerMaxRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static List<string> GlobalBotsScore
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static long GlobalBotTimeBank
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static long GlobalBotScoreTimestamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static List<string> LeagueBotsScore
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static long LeagueBotTimeBank
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static long LeagueBotScoreTimestamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static int LeaguePlayerRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LeaguePlayerScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LeaguePlayerNewscore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LeaguePlayerMaxRanking
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LeaguePlayerMaxLeague
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LeagueCurrentIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long LeagueCurrentTimestamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static bool Migrated
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

	public void MigrateFromBalancy()
	{
	}

	private static BucketLeaderboard GetBucket()
	{
		return null;
	}

	public static string GetStoreCountryIso(string defaultValue = null)
	{
		return null;
	}

	public static void SetStoreCountryIso(string value)
	{
	}

	public static int GetPreviousRank(string subkey, int defaultValue = 0)
	{
		return 0;
	}

	public static void SetPreviousRank(string subkey, int value)
	{
	}

	public static int IncrementAndSetPreviousRank(string subkey, int increment = 1)
	{
		return 0;
	}

	public static long GetCurrentRank(string subkey, long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetCurrentRank(string subkey, long value)
	{
	}

	public static long GetPreviousScore(string subkey, long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetPreviousScore(string subkey, long value)
	{
	}

	public static int GetGlobalPlayerScore(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetGlobalPlayerScore(int value)
	{
	}

	public static int IncrementAndSetGlobalPlayerScore(int increment = 1)
	{
		return 0;
	}

	public static int GetGlobalPlayerScoreLastSeen(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetGlobalPlayerScoreLastSeen(int value)
	{
	}

	public static int IncrementAndSetGlobalPlayerScoreLastSeen(int increment = 1)
	{
		return 0;
	}

	public static int GetGlobalPlayerMaxRank(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetGlobalPlayerMaxRank(int value)
	{
	}

	public static int IncrementAndSetGlobalPlayerMaxRank(int increment = 1)
	{
		return 0;
	}

	public static List<string> GetGlobalBotsScore()
	{
		return null;
	}

	public static void SetGlobalBotsScore(List<string> value)
	{
	}

	public static long GetGlobalBotTimeBank(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetGlobalBotTimeBank(long value)
	{
	}

	public static long GetGlobalBotScoreTimestamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetGlobalBotScoreTimestamp(long value)
	{
	}

	public static List<string> GetLeagueBotsScore()
	{
		return null;
	}

	public static void SetLeagueBotsScore(List<string> value)
	{
	}

	public static long GetLeagueBotTimeBank(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLeagueBotTimeBank(long value)
	{
	}

	public static long GetLeagueBotScoreTimestamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLeagueBotScoreTimestamp(long value)
	{
	}

	public static int GetLeaguePlayerRank(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLeaguePlayerRank(int value)
	{
	}

	public static int IncrementAndSetLeaguePlayerRank(int increment = 1)
	{
		return 0;
	}

	public static int GetLeaguePlayerScore(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLeaguePlayerScore(int value)
	{
	}

	public static int IncrementAndSetLeaguePlayerScore(int increment = 1)
	{
		return 0;
	}

	public static int GetLeaguePlayerNewscore(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLeaguePlayerNewscore(int value)
	{
	}

	public static int IncrementAndSetLeaguePlayerNewscore(int increment = 1)
	{
		return 0;
	}

	public static int GetLeaguePlayerMaxRanking(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLeaguePlayerMaxRanking(int value)
	{
	}

	public static int IncrementAndSetLeaguePlayerMaxRanking(int increment = 1)
	{
		return 0;
	}

	public static int GetLeaguePlayerMaxLeague(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLeaguePlayerMaxLeague(int value)
	{
	}

	public static int IncrementAndSetLeaguePlayerMaxLeague(int increment = 1)
	{
		return 0;
	}

	public static int GetLeagueCurrentIndex(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLeagueCurrentIndex(int value)
	{
	}

	public static int IncrementAndSetLeagueCurrentIndex(int increment = 1)
	{
		return 0;
	}

	public static long GetLeagueCurrentTimestamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLeagueCurrentTimestamp(long value)
	{
	}

	public static bool GetMigrated(bool defaultValue = false)
	{
		return false;
	}

	public static void SetMigrated(bool value)
	{
	}
}
