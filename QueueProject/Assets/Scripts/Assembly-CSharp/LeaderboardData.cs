using System;
using System.Collections.Generic;

[Serializable]
public class LeaderboardData : CacheableData
{
	[Serializable]
	public class User
	{
		public string userId;

		public string username;

		public string avatarUrl;

		public string displayName;

		public int position;

		public int score;

		public Dictionary<string, object> metaData;

		public void SetMetaDataValue<T>(string key, T value)
		{
		}

		public T GetMetaDataValue<T>(string key, T defaultValue = default(T))
		{
			return default(T);
		}

		public override string ToString()
		{
			return null;
		}
	}

	public List<User> users;

	public User currentPlayer;

	public string leaderboardId;

	public string region;

	public long totalRanks;

	public bool aroundOwner;

	public override string ToString()
	{
		return null;
	}
}
