using System;
using System.Collections.Generic;
using UnityEngine;

public interface IAvatarAdapter
{
	void GetAvatar(string avatrUrl, Action<Sprite> callback);

	List<AvatarData> GetAll();

	AvatarData GetAvatarDataByIndex(int index);

	AvatarData GetDefaultAvatarData();
}
