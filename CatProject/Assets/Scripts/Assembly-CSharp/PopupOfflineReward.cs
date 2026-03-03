using System;
using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOfflineReward", false, false)]
public class PopupOfflineReward : UIBase
{
	private enum E_RewardClaimType
	{
		Normal = 0,
		X8 = 1,
		GemUse = 2
	}

	[SerializeField]
	private Slider TimeProgress;

	[SerializeField]
	private Text RewardCount;

	[SerializeField]
	private Text NextRewardCount;

	[SerializeField]
	private Text NextBonusPerText;

	[SerializeField]
	private Text OfflineTime;

	[SerializeField]
	private Text InfinityOfflineTime;

	[SerializeField]
	private Text MaxOfflineTime;

	[SerializeField]
	private GameObject MaxObj;

	[SerializeField]
	private Text BonusBtnText;

	[SerializeField]
	private GameObject NormalState;

	[SerializeField]
	private GameObject InfinityState;

	[SerializeField]
	private Text MaxWarningText;

	[SerializeField]
	private GameObject benefitObj;

	[SerializeField]
	private Text benefitBuffText;

	[SerializeField]
	private Button GetBtn;

	[SerializeField]
	private Button Get3XBtn;

	[SerializeField]
	private Button GetGemUseBtn;

	[SerializeField]
	private Text GemUseBtnText;

	[SerializeField]
	private Text GemUseCostText;

	[SerializeField]
	private Button LaterBtn;

	[SerializeField]
	private Text AddTime;

	[SerializeField]
	private Text InfinityApplyText;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[Header("IAP")]
	[SerializeField]
	private ItemOfflineTimeBanner OfflineTimeBanner;

	[SerializeField]
	private ItemPopupNoAdsBanner NoAdsBanner;

	[Header("Strike")]
	[SerializeField]
	private GameObject StrikeObj;

	[SerializeField]
	private Text StrikeText;

	private BigInteger Reward;

	private BigInteger X8Reward;

	private BigInteger GemUseMultipleReward;

	private int GemUseCost;

	private int GEM_USE_REWARD_MULTIPLY;

	private int GEM_USE_COST_MULTIPLY;

	public OnetimeCurrencyComponent OneTimeComponent => null;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void GetReward(BigInteger value, E_RewardClaimType claimType, Action<bool> result)
	{
	}

	private void OnClickGetReward()
	{
	}

	private void OnClickGet3XReward()
	{
	}

	private void OnClickGetGemUse()
	{
	}

	private void OnClickMaxOfflineAdd(int idx)
	{
	}
}
