using KWCore;
using KWCore.SaveData;

public class BucketPVP : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_PVP";

	[KeyInt]
	public const string LAST_CHALLENGE_RECIEVED_LEVEL = "LAST_CHALLENGE_RECIEVED_LEVEL";

	[KeyInt]
	public const string LAST_CHALLENGE_ACCEPTED_LEVEL = "LAST_CHALLENGE_ACCEPTED_LEVEL";

	[KeyInt]
	public const string LAST_CHALLENGE_REFUSED_LEVEL = "LAST_CHALLENGE_REFUSED_LEVEL";

	[KeyInt]
	public const string REFUSED_CHALLENGES_COUNT = "REFUSED_CHALLENGES_COUNT";

	[KeyInt]
	public const string ACCEPTED_CHALLENGES_COUNT = "ACCEPTEDD_CHALLENGES_COUNT";

	[KeyInt]
	public const string CHALLENGE_COOLDOWN_LEVEL = "CHALLENGE_COOLDOWN_LEVEL";

	[KeyInt]
	public const string AUTO_X_FOR_CHALLENGE_NUMBER = "AUTO_X_FOR_CHALLENGE_NUMBER";

	[KeyBool]
	public const string UNFINISHED_CHALLENGE = "UNFINISHED_CHALLENGE";

	[KeyInt]
	public const string CHALLENGE_INITIATION_TYPE = "CHALLENGE_INITIATION_TYPE";

	[KeyString]
	public const string LAST_OPPONENT_NAME = "LAST_OPPONENT_NAME";

	[KeyString]
	public const string LAST_OPPONENT_AVATAR = "LAST_OPPONENT_AVATAR";

	[KeyLong]
	public const string LAST_OPPONENT_BADGE = "LAST_OPPONENT_BADGE";

	private static BucketPVP s_bucketpvp;

	public static int LastChallengeRecievedLevel
	{
		get
		{
			return GetBucket()?.GetInt(LAST_CHALLENGE_RECIEVED_LEVEL, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LAST_CHALLENGE_RECIEVED_LEVEL, value);
		}
	}

	public static int LastChallengeAcceptedLevel
	{
		get
		{
			return GetBucket()?.GetInt(LAST_CHALLENGE_ACCEPTED_LEVEL, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LAST_CHALLENGE_ACCEPTED_LEVEL, value);
		}
	}

	public static int LastChallengeRefusedLevel
	{
		get
		{
			return GetBucket()?.GetInt(LAST_CHALLENGE_REFUSED_LEVEL, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LAST_CHALLENGE_REFUSED_LEVEL, value);
		}
	}

	public static int RefusedChallengesCount
	{
		get
		{
			return GetBucket()?.GetInt(REFUSED_CHALLENGES_COUNT, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(REFUSED_CHALLENGES_COUNT, value);
		}
	}

	public static int AcceptedChallengesCount
	{
		get
		{
			return GetBucket()?.GetInt(ACCEPTED_CHALLENGES_COUNT, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(ACCEPTED_CHALLENGES_COUNT, value);
		}
	}

	public static int ChallengeCooldownLevel
	{
		get
		{
			return GetBucket()?.GetInt(CHALLENGE_COOLDOWN_LEVEL, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(CHALLENGE_COOLDOWN_LEVEL, value);
		}
	}

	public static int AutoXForChallengeNumber
	{
		get
		{
			return GetBucket()?.GetInt(AUTO_X_FOR_CHALLENGE_NUMBER, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(AUTO_X_FOR_CHALLENGE_NUMBER, value);
		}
	}

	public static bool UnfinishedChallenge
	{
		get
		{
			return GetBucket()?.GetBool(UNFINISHED_CHALLENGE, false) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(UNFINISHED_CHALLENGE, value);
		}
	}

	public static int ChallengeInitiationType
	{
		get
		{
			return GetBucket()?.GetInt(CHALLENGE_INITIATION_TYPE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(CHALLENGE_INITIATION_TYPE, value);
		}
	}

	public static string LastOpponentName
	{
		get
		{
			return GetBucket()?.GetString(LAST_OPPONENT_NAME, null);
		}
		set
		{
			GetBucket()?.SetString(LAST_OPPONENT_NAME, value);
		}
	}

	public static string LastOpponentAvatar
	{
		get
		{
			return GetBucket()?.GetString(LAST_OPPONENT_AVATAR, null);
		}
		set
		{
			GetBucket()?.SetString(LAST_OPPONENT_AVATAR, value);
		}
	}

	public static long LastOpponentBadge
	{
		get
		{
			return GetBucket()?.GetLong(LAST_OPPONENT_BADGE, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LAST_OPPONENT_BADGE, value);
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

	private static BucketPVP GetBucket()
	{
		if (s_bucketpvp == null)
		{
			s_bucketpvp = new BucketPVP();
			s_bucketpvp.LoadFromDisk();
		}
		return s_bucketpvp;
	}

	public static int GetLastChallengeRecievedLevel(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LAST_CHALLENGE_RECIEVED_LEVEL, defaultValue) ?? defaultValue;
	}

	public static void SetLastChallengeRecievedLevel(int value)
	{
		GetBucket()?.SetInt(LAST_CHALLENGE_RECIEVED_LEVEL, value);
	}

	public static int IncrementAndSetLastChallengeRecievedLevel(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LAST_CHALLENGE_RECIEVED_LEVEL, increment) ?? 0;
	}

	public static int GetLastChallengeAcceptedLevel(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LAST_CHALLENGE_ACCEPTED_LEVEL, defaultValue) ?? defaultValue;
	}

	public static void SetLastChallengeAcceptedLevel(int value)
	{
		GetBucket()?.SetInt(LAST_CHALLENGE_ACCEPTED_LEVEL, value);
	}

	public static int IncrementAndSetLastChallengeAcceptedLevel(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LAST_CHALLENGE_ACCEPTED_LEVEL, increment) ?? 0;
	}

	public static int GetLastChallengeRefusedLevel(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LAST_CHALLENGE_REFUSED_LEVEL, defaultValue) ?? defaultValue;
	}

	public static void SetLastChallengeRefusedLevel(int value)
	{
		GetBucket()?.SetInt(LAST_CHALLENGE_REFUSED_LEVEL, value);
	}

	public static int IncrementAndSetLastChallengeRefusedLevel(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LAST_CHALLENGE_REFUSED_LEVEL, increment) ?? 0;
	}

	public static int GetRefusedChallengesCount(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(REFUSED_CHALLENGES_COUNT, defaultValue) ?? defaultValue;
	}

	public static void SetRefusedChallengesCount(int value)
	{
		GetBucket()?.SetInt(REFUSED_CHALLENGES_COUNT, value);
	}

	public static int IncrementAndSetRefusedChallengesCount(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(REFUSED_CHALLENGES_COUNT, increment) ?? 0;
	}

	public static int GetAcceptedChallengesCount(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(ACCEPTED_CHALLENGES_COUNT, defaultValue) ?? defaultValue;
	}

	public static void SetAcceptedChallengesCount(int value)
	{
		GetBucket()?.SetInt(ACCEPTED_CHALLENGES_COUNT, value);
	}

	public static int IncrementAndSetAcceptedChallengesCount(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(ACCEPTED_CHALLENGES_COUNT, increment) ?? 0;
	}

	public static int GetChallengeCooldownLevel(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(CHALLENGE_COOLDOWN_LEVEL, defaultValue) ?? defaultValue;
	}

	public static void SetChallengeCooldownLevel(int value)
	{
		GetBucket()?.SetInt(CHALLENGE_COOLDOWN_LEVEL, value);
	}

	public static int IncrementAndSetChallengeCooldownLevel(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(CHALLENGE_COOLDOWN_LEVEL, increment) ?? 0;
	}

	public static int GetAutoXForChallengeNumber(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(AUTO_X_FOR_CHALLENGE_NUMBER, defaultValue) ?? defaultValue;
	}

	public static void SetAutoXForChallengeNumber(int value)
	{
		GetBucket()?.SetInt(AUTO_X_FOR_CHALLENGE_NUMBER, value);
	}

	public static int IncrementAndSetAutoXForChallengeNumber(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(AUTO_X_FOR_CHALLENGE_NUMBER, increment) ?? 0;
	}

	public static bool GetUnfinishedChallenge(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(UNFINISHED_CHALLENGE, defaultValue) ?? defaultValue;
	}

	public static void SetUnfinishedChallenge(bool value)
	{
		GetBucket()?.SetBool(UNFINISHED_CHALLENGE, value);
	}

	public static int GetChallengeInitiationType(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(CHALLENGE_INITIATION_TYPE, defaultValue) ?? defaultValue;
	}

	public static void SetChallengeInitiationType(int value)
	{
		GetBucket()?.SetInt(CHALLENGE_INITIATION_TYPE, value);
	}

	public static int IncrementAndSetChallengeInitiationType(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(CHALLENGE_INITIATION_TYPE, increment) ?? 0;
	}

	public static string GetLastOpponentName(string defaultValue = null)
	{
		return GetBucket()?.GetString(LAST_OPPONENT_NAME, defaultValue) ?? defaultValue;
	}

	public static void SetLastOpponentName(string value)
	{
		GetBucket()?.SetString(LAST_OPPONENT_NAME, value);
	}

	public static string GetLastOpponentAvatar(string defaultValue = null)
	{
		return GetBucket()?.GetString(LAST_OPPONENT_AVATAR, defaultValue) ?? defaultValue;
	}

	public static void SetLastOpponentAvatar(string value)
	{
		GetBucket()?.SetString(LAST_OPPONENT_AVATAR, value);
	}

	public static long GetLastOpponentBadge(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LAST_OPPONENT_BADGE, defaultValue) ?? defaultValue;
	}

	public static void SetLastOpponentBadge(long value)
	{
		GetBucket()?.SetLong(LAST_OPPONENT_BADGE, value);
	}
}
