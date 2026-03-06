using System.Collections.Generic;
using Treeplla;
using UnityEngine;

public class PackageComponentOnePlusSix : PackageComponent
{
	[SerializeField]
	private List<ItemPackageOnePlusSix> itemList;

	private OnePlusSixInfo table;

	public override void SetSpecial(int packageIdx)
	{
		if (itemList == null) return;
		for (int i = 0; i < itemList.Count; i++)
		{
			if (itemList[i] != null)
				itemList[i].gameObject.SetActive(true);
		}
	}

	private void OnOpenNextReward()
	{
		// TODO
	}

	private void OnRewardStart()
	{
		// TODO
	}

	private void Hide()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}
}
