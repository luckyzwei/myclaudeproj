using Nakama;

public class CachedUser
{
	private readonly IApiUser m_user;

	private readonly long m_entryTimestamp;

	public IApiUser User => null;

	public CachedUser(IApiUser user)
	{
	}

	public bool IsValid(long validDuration)
	{
		return false;
	}
}
