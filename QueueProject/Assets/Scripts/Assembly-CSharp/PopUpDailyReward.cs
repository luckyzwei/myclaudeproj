using System.Collections.Generic;
using Balancy;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpDailyReward : PopUpBase
{
	protected const string RV_DOUBLE_CLAIM_LOC = "daily_reward_claim_2x";

	protected const string RV_CLAIM_AGAIN_LOC = "daily_reward_claim_again";

	public const string PREFAB_NAME = "Prefabs/KWDailyReward/PopUp-DailyReward";

	[Header("Close")]
	[SerializeField]
	protected GameObject m_closeButton;

	[Header("Timer")]
	[SerializeField]
	private bool m_showTimer;

	[SerializeField]
	private DailyRewardTimer m_dailyRewardTimer;

	[Header("Prefabs")]
	[SerializeField]
	protected DailyRewardCell m_standardCell;

	[SerializeField]
	protected DailyRewardCell m_largeCell;

	[Header("Cell spawning")]
	[SerializeField]
	protected RectTransform m_standardCellParent;

	[SerializeField]
	protected RectTransform m_largeCellParent;

	[Header("Footer")]
	[SerializeField]
	protected GameObject m_rewardsClaimedText;

	[SerializeField]
	protected Button m_claimButton;

	[SerializeField]
	protected Button m_rvButton;

	[SerializeField]
	protected Button m_claimAgainButton;

	[Header("Reward")]
	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	protected PrefabReference m_rewardPopUp;

	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	protected PrefabReference m_rewardBoxPopUp;

	protected List<DailyRewardCell> m_spawnedCells;

	protected LiveOps.DailyBonus.RewardInfo[] m_activeDailyRewards;

	protected virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void Config(LiveOps.DailyBonus.RewardInfo[] dailyRewards)
	{
	}

	protected virtual void SetupButtons()
	{
	}

	protected virtual void HideAllButtons()
	{
	}

	private void ToggleTimer()
	{
	}

	protected virtual void SpawnStandardCells()
	{
	}

	protected virtual void SpawnLargeCell()
	{
	}

	protected virtual void RVDoubleClaim()
	{
	}

	protected virtual void RVClaimAgain()
	{
	}

	protected virtual void ClaimDailyReward(int multiplier, bool rv = false)
	{
	}

	protected virtual void OnRewardFlowComplete()
	{
	}

	public DailyRewardCell GetActiveCell()
	{
		return null;
	}
}
