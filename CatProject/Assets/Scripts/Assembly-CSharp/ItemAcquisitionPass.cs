using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionPass : MonoBehaviour
{
	[SerializeField]
	private ItemPassReward NormalReward;

	[SerializeField]
	private ItemPassReward PremiumReward;

	[SerializeField]
	private Text StageText;

	[SerializeField]
	private GameObject NowStepObj;

	[SerializeField]
	private GameObject StageClearObj;

	private int PassIdx;

	private int PassGroupIdx;

	private bool bActivePremium;

	private RewardItemData NormalRewardItemData;

	private RewardItemData PremiumRewardItemData;

	private Action OnRewarded;

	private Action OnClickPremiumPurchaseBtn;

	public void SetItem(AcquisitionPassData passItemData, bool bNowStep, Action onRewarded, Action onClickPremiumPurchaseBtn)
	{
	}

	public void UpdateRewardState(bool bPlayAni)
	{
	}

	public bool IsClaimable(bool isPremium, out bool isAdsReward)
	{
		isAdsReward = default(bool);
		return false;
	}

	private void OnClickGetBtn(int passIdx, bool isPremium)
	{
	}

	private void GetReward(int passStepIdx, bool isPremium, bool isAds)
	{
	}
}
