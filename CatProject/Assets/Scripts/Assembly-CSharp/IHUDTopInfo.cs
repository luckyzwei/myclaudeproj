using UnityEngine;

public interface IHUDTopInfo
{
	HUDTopInfo GetHUDTopInfo();

	void UpdateCurrencyInfos()
	{
	}

	Transform FindTopInfoEndTransform(int index)
	{
		return null;
	}

	Transform FindTopInfoEndTransform(TopInfoData topInfoData, bool nullGetDefault)
	{
		return null;
	}
}
