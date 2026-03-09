using System;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class DoubleWithAdsRewardPopup : BasicRewardPopup
{
	public new const string PREFAB_NAME = "Prefabs/KWReward/Popup-DoubleWithAdsReward";

	private const string AD_CONTEXT = "DoubleWithAdsPopup";

	[SerializeField]
	private GameObject m_buttonGroup;

	private static string s_analyticsPrefix;

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	public static void SetAnayticsName(string analyticsName)
	{
	}

	public void OnDoubleRewardAddButtonPressed()
	{
	}

	private void DoubleReward()
	{
	}

	private void HideButtons()
	{
	}

	public override void OnCollectButtonPressed()
	{
	}

	private new void GiveRewardActions()
	{
	}

	private void PlaySfx(Reward reward)
	{
	}

	private void PlayOnlyCoinSfx()
	{
	}

	private void PlayCoinSfx()
	{
	}

	private void PlayNoCoinRewardSfx(string otherItemsIds)
	{
	}
}
