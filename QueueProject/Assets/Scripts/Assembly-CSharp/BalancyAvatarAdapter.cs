using System;
using System.Collections.Generic;
using Balancy.Models.KWPlayerProfile;
using UnityEngine;

public class BalancyAvatarAdapter : IAvatarAdapter
{
	public void GetAvatar(string avatrUrl, Action<Sprite> callback)
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

	private List<AvatarIcon> GetAllAvatars()
	{
		return null;
	}

	private void LoadSpriteAsync(AvatarIcon avatarIcon, Action<Sprite> callback)
	{
	}
}
