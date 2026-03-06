using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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

	public OnetimeCurrencyComponent OneTimeComponent { get { return oneTimeComponent; } }

	protected override void Awake()
	{
		base.Awake();
		GEM_USE_REWARD_MULTIPLY = 5;
		GEM_USE_COST_MULTIPLY = 50;
		if (GetBtn != null) GetBtn.onClick.AddListener(OnClickGetReward);
		if (Get3XBtn != null) Get3XBtn.onClick.AddListener(OnClickGet3XReward);
		if (GetGemUseBtn != null) GetGemUseBtn.onClick.AddListener(OnClickGetGemUse);
		if (LaterBtn != null) LaterBtn.onClick.AddListener(() => Hide());
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void GetReward(BigInteger value, E_RewardClaimType claimType, Action<bool> result)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) { result?.Invoke(false); return; }
		result?.Invoke(true);
		Hide();
	}

	private void OnClickGetReward()
	{
		GetReward(Reward, E_RewardClaimType.Normal, null);
	}

	private void OnClickGet3XReward()
	{
		GetReward(X8Reward, E_RewardClaimType.X8, null);
	}

	private void OnClickGetGemUse()
	{
		GetReward(GemUseMultipleReward, E_RewardClaimType.GemUse, null);
	}

	private void OnClickMaxOfflineAdd(int idx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
