using System;
using System.Collections.Generic;
using KPFCore;
using UnityEngine;

public class AvatarRepository : RepositoryBase
{
	private Lazy<IAvatarAdapter> m_defaultAdapter;

	private Dictionary<string, Sprite> m_avatarsCache;

	private List<AvatarData> m_allAvatarsCache;

	public void RegisterAdapter<T>() where T : IAvatarAdapter, new()
	{
	}

	public void GetAvatar(string avatarUrl, Action<Sprite> callback)
	{
	}

	public List<AvatarData> GetAll()
	{
		return null;
	}

	public AvatarData GetAvatarDataByIndex(int index)
	{
		return null;
	}

	public AvatarData GetDefaultAvatarData()
	{
		return null;
	}

	private bool TryGetAvatarFromCache(string avatarUrl, out Sprite avatarSprite)
	{
		avatarSprite = null;
		return false;
	}
}
