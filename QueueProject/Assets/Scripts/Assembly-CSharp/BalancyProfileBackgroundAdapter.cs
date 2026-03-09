using System;
using System.Collections.Generic;
using Balancy.Models.KWPlayerProfile;
using UnityEngine;

public class BalancyProfileBackgroundAdapter : IProfileBackgroundAdapter
{
	public void GetProfileBackground(string avatrUrl, Action<Sprite> callback)
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

	public ProfileBackgroundData GetDefaultProfileBackgroundData()
	{
		return null;
	}

	private List<ProfileBackgrounds> GetAllProfileBackgrounds()
	{
		return null;
	}

	private void LoadSpriteAsync(ProfileBackgrounds profBg, Action<Sprite> callback)
	{
	}
}
