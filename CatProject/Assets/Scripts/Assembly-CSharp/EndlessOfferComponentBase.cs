using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using EndlessOfferRewardData = Treeplla.Data.EndlessOfferRewardData;

public class EndlessOfferComponentBase : MonoBehaviour
{
	public Action<bool> OnPlayAnimationEvent;

	public Action OnTimeEndEvent;

	public int EndlessPackageIdx { get; protected set; }

	public ShopSystem.InAppPurchaseLocation EnterPlace { get; protected set; }

	public virtual void Set(int endlessIdx, ShopSystem.InAppPurchaseLocation enterPlace)
	{
	}

	public virtual void Reset()
	{
	}

	protected virtual EndlessOfferRewardData GetTargetRewardTable(int orderIdx)
	{
		return default;
	}

	protected virtual void UpdateOfferPurchaseData()
	{
	}

	protected virtual void OnPurchaseSuccess(List<IRewardItemData> rewardItemDataList, Action callback)
	{
	}
}
