using System;
using System.Collections.Generic;
using UnityEngine;

public interface IProfileBackgroundAdapter
{
	void GetProfileBackground(string profileBgUrl, Action<Sprite> callback);

	List<ProfileBackgroundData> GetAll();

	ProfileBackgroundData GetProfileBackgroundDataByIndex(int index);

	ProfileBackgroundData GetDefaultProfileBackgroundData();
}
