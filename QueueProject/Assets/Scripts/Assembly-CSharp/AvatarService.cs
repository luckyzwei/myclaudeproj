using System;
using System.Collections.Generic;
using KPFCore;
using UnityEngine;

public class AvatarService : ServiceBase<AvatarService>
{
	private AvatarRepository m_avatarDataRepository;

	protected override void InitialiseLocal(IRepository dataRepository, IConfig config)
	{
	}

	public void GetAvatar(string avatarUrl, Action<Sprite> callback)
	{
	}

	public List<AvatarData> GetAll()
	{
		return null;
	}

	public AvatarData GetRandom()
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

	public int GetRandomIndex()
	{
		return 0;
	}
}
