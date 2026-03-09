using System;

[Serializable]
public class PublicProfile : CacheableData
{
	private const string DEFAULT_NAME_KEY = "PlayerProfile.DefaultPlayerName";

	private string m_avatarUrl;

	private string m_displayName;

	private string m_username;

	public string AppleId { get; }

	public string AvatarUrl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CreateTime { get; }

	public string DisplayName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int EdgeCount { get; }

	public string FacebookId { get; }

	public string FacebookInstantGameId { get; }

	public string GamecenterId { get; }

	public string GoogleId { get; }

	public string UserId { get; set; }

	public string LangTag { get; }

	public string Location { get; }

	public string Metadata { get; }

	public bool Online { get; }

	public string SteamId { get; }

	public string Timezone { get; }

	public string UpdateTime { get; }

	public string Username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PublicProfile()
	{
	}

	public PublicProfile(string userId, string displayName, string avatarUrl)
	{
	}

	public PublicProfile(string appleId, string avatarUrl, string createTime, string displayName, int edgeCount, string facebookId, string facebookInstantGameId, string gamecenterId, string googleId, string userId, string langTag, string location, string metadata, bool online, string steamId, string timezone, string updateTime, string username)
	{
	}
}
