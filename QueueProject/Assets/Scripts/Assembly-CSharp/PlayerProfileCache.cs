public class PlayerProfileCache
{
	private readonly GenericDataCache<PublicProfile> m_cache;

	public PlayerProfileCache(string cacheId, long cacheDurationSeconds)
	{
	}

	public void SetProfile(PublicProfile profile)
	{
	}

	public PublicProfile GetProfile(string userId)
	{
		return null;
	}

	public PublicProfile UpdateDisplayName(string userId, string displayName)
	{
		return null;
	}

	public PublicProfile UpdateAvatarUrl(string userId, string avatarUrl)
	{
		return null;
	}

	public void ClearAll()
	{
	}
}
