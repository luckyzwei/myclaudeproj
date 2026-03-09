using System;
using System.Collections.Generic;
using KWPlayerProfile.Avatar;
using UnityEngine;

public class LocalAvatarAdapter : IAvatarAdapter
{
	private AvatarScriptable m_avatarScriptable;

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
}
