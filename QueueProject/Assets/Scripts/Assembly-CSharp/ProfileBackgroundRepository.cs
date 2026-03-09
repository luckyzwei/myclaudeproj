using System;
using System.Collections.Generic;
using KPFCore;
using UnityEngine;

public class ProfileBackgroundRepository : RepositoryBase
{
	private Lazy<IProfileBackgroundAdapter> m_defaultAdapter;

	private IProfileBackgroundAdapter m_serverAdapter;

	private Dictionary<string, Sprite> m_profileBackgroundsCache;

	private List<ProfileBackgroundData> m_allBackgroundsCache;

	private ProfileBackgroundConfig m_config;

	public ProfileBackgroundRepository(ProfileBackgroundConfig config)
	{
	}

	public void RegisterAdapter<T>() where T : IProfileBackgroundAdapter, new()
	{
	}

	public void GetProfileBackground(string profileBgUrl, Action<Sprite> callback)
	{
	}

	public List<ProfileBackgroundData> GetAll()
	{
		return null;
	}

	public ProfileBackgroundData GetProfileBackgroundDataByIndex(int index)
	{
		return null;
	}

	public ProfileBackgroundData GetProfileBackgroundDataByName(string name)
	{
		return null;
	}

	public ProfileBackgroundData GetDefaultProfileBackgroundData()
	{
		return null;
	}

	private bool TryGetProfileBackgroundFromCache(string profileBgUrl, out Sprite profileBgSprite)
	{
		profileBgSprite = null;
		return false;
	}

	public void CreateServerAdapter<T>() where T : IProfileBackgroundAdapter, new()
	{
	}
}
