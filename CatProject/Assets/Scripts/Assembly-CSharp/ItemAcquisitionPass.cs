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
		if (passItemData == null) return;
		OnRewarded = onRewarded;
		OnClickPremiumPurchaseBtn = onClickPremiumPurchaseBtn;

		if (StageText != null) StageText.text = PassIdx.ToString();
		if (NowStepObj != null) NowStepObj.SetActive(bNowStep);
		if (StageClearObj != null) StageClearObj.SetActive(false);

		if (NormalReward != null)
			NormalReward.SetBizAcqPassReward(PassIdx, false, (idx, isPremium) => OnClickGetBtn(idx, isPremium));
		if (PremiumReward != null)
			PremiumReward.SetBizAcqPassReward(PassIdx, true, (idx, isPremium) => OnClickGetBtn(idx, isPremium));

		UpdateRewardState(false);
	}

	public void UpdateRewardState(bool bPlayAni)
	{
		if (NormalReward != null) NormalReward.UpdateBizAcqStatus(bPlayAni);
		if (PremiumReward != null) PremiumReward.UpdateBizAcqStatus(bPlayAni);
	}

	public bool IsClaimable(bool isPremium, out bool isAdsReward)
	{
		var reward = isPremium ? PremiumReward : NormalReward;
		if (reward != null)
		{
			isAdsReward = reward.IsAdsReward;
			return reward.IsClaimable;
		}
		isAdsReward = false;
		return false;
	}

	private void OnClickGetBtn(int passIdx, bool isPremium)
	{
		if (isPremium && !bActivePremium)
		{
			OnClickPremiumPurchaseBtn?.Invoke();
			return;
		}
		bool isAds;
		if (!IsClaimable(isPremium, out isAds)) return;
		GetReward(passIdx, isPremium, isAds);
	}

	private void GetReward(int passStepIdx, bool isPremium, bool isAds)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		OnRewarded?.Invoke();
	}
}
