using System;
using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.UI;

public class RewardBoxPopup : RewardPopupBase
{
	private const float CHEST_LANDING_DELAY = 0.7833f;

	private const float CHEST_OPEN_BURST_DELAY = 0.4f;

	private const float CHEST_OPEN_TIME_BETWEEN_BURST = 0.1f;

	private const int CHEST_OPEN_BURST_AMOUNT = 4;

	private const float CHEST_OPEN_DELAY = 0.8667f;

	public const string PREFAB_NAME = "Prefabs/KWReward/Popup-RewardBox";

	[SerializeField]
	private GameObject m_buttonContainer;

	[SerializeField]
	private PlayableDirectorHelper m_introTimeLine;

	[SerializeField]
	private PlayableDirectorHelper m_idleTimeLine;

	[SerializeField]
	private PlayableDirectorHelper m_openTimeLine;

	[SerializeField]
	private PlayableDirectorHelper m_outroTimeLine;

	[SerializeField]
	private GameObject m_rewardParents;

	private Action m_rewardGivenCallback;

	private Button[] m_allButtons;

	private Reward m_reward;

	private ItemWithAmountCell[] m_itemsWithAmmount;

	private readonly int[][] rewardConfigurations;

	private void Awake()
	{
	}

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	public void OnOpenChestPressed()
	{
	}

	private void PlayOutro()
	{
	}

	private new void DisableAllButtons()
	{
	}

	public void ConfigureRewards()
	{
	}
}
