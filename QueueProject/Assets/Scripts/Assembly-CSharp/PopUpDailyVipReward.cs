using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;

public class PopUpDailyVipReward : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-WeeklyVIPRewards";

	private const string REWARD_POPUP = "Prefabs/KWReward/Popup-StoreReward";

	[SerializeField]
	private Transform m_container;

	[SerializeField]
	private ItemWithAmountCell m_itemWithAmountPrefab;

	private Reward m_reward;

	private bool m_claimedButtonPressed;

	public void Config(Reward reward)
	{
	}

	public void OnClaimButtonPressed()
	{
	}
}
