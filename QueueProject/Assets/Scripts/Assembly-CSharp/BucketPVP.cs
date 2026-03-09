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
			return 0;
		}
		set
		{
		}
	}

	public static int LastChallengeAcceptedLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LastChallengeRefusedLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int RefusedChallengesCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int AcceptedChallengesCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int ChallengeCooldownLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int AutoXForChallengeNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool UnfinishedChallenge
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int ChallengeInitiationType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static string LastOpponentName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string LastOpponentAvatar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static long LastOpponentBadge
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

	private static BucketPVP GetBucket()
	{
		return null;
	}

	public static int GetLastChallengeRecievedLevel(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLastChallengeRecievedLevel(int value)
	{
	}

	public static int IncrementAndSetLastChallengeRecievedLevel(int increment = 1)
	{
		return 0;
	}

	public static int GetLastChallengeAcceptedLevel(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLastChallengeAcceptedLevel(int value)
	{
	}

	public static int IncrementAndSetLastChallengeAcceptedLevel(int increment = 1)
	{
		return 0;
	}

	public static int GetLastChallengeRefusedLevel(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLastChallengeRefusedLevel(int value)
	{
	}

	public static int IncrementAndSetLastChallengeRefusedLevel(int increment = 1)
	{
		return 0;
	}

	public static int GetRefusedChallengesCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetRefusedChallengesCount(int value)
	{
	}

	public static int IncrementAndSetRefusedChallengesCount(int increment = 1)
	{
		return 0;
	}

	public static int GetAcceptedChallengesCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetAcceptedChallengesCount(int value)
	{
	}

	public static int IncrementAndSetAcceptedChallengesCount(int increment = 1)
	{
		return 0;
	}

	public static int GetChallengeCooldownLevel(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetChallengeCooldownLevel(int value)
	{
	}

	public static int IncrementAndSetChallengeCooldownLevel(int increment = 1)
	{
		return 0;
	}

	public static int GetAutoXForChallengeNumber(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetAutoXForChallengeNumber(int value)
	{
	}

	public static int IncrementAndSetAutoXForChallengeNumber(int increment = 1)
	{
		return 0;
	}

	public static bool GetUnfinishedChallenge(bool defaultValue = false)
	{
		return false;
	}

	public static void SetUnfinishedChallenge(bool value)
	{
	}

	public static int GetChallengeInitiationType(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetChallengeInitiationType(int value)
	{
	}

	public static int IncrementAndSetChallengeInitiationType(int increment = 1)
	{
		return 0;
	}

	public static string GetLastOpponentName(string defaultValue = null)
	{
		return null;
	}

	public static void SetLastOpponentName(string value)
	{
	}

	public static string GetLastOpponentAvatar(string defaultValue = null)
	{
		return null;
	}

	public static void SetLastOpponentAvatar(string value)
	{
	}

	public static long GetLastOpponentBadge(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLastOpponentBadge(long value)
	{
	}
}
