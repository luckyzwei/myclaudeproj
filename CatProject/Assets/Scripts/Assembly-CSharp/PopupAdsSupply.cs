using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAdsSupply", false, false)]
public class PopupAdsSupply : UIBase
{
	private enum E_RewardGetType
	{
		ViewAds = 0,
		UseGem = 1
	}

	[SerializeField]
	private Image CurrencyImg;

	[SerializeField]
	private Text RewardText;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Button MultipleRewardBtn;

	[SerializeField]
	private Text MultipleRewardBtnText;

	[SerializeField]
	private Text MultipleRewardCostText;

	[SerializeField]
	private Text RentalFee;

	[SerializeField]
	private GameObject AdsIcon;

	[SerializeField]
	private SuperStaffStatBtn superStaffBtn;

	[SerializeField]
	private Text textPiggyBankCollect;

	[SerializeField]
	private Text textDailyCnt;

	[SerializeField]
	private Text textGetBnt;

	[SerializeField]
	private Button btnGetBank;

	[SerializeField]
	private GameObject superStaffRoot;

	[SerializeField]
	private Transform trTargetAdsBank;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[Header("IAP")]
	[SerializeField]
	private ItemPopupNoAdsBanner NoAdsBanner;

	private AdSupplySystem.ShowType PopupShowType;

	private AdSupplySystem.AdsupplyType AdsupplyType;

	private CompositeDisposable disposables;

	private bool isShowAds;

	private bool OpenSeasonal;

	private int REWARD_MULTIPLY_VALUE;

	private int MULTIPLE_REWARD_COST;

	public BigInteger CurAdsupplyCollectMoney { get { return default(BigInteger); } }

	public int CurAdsupplySaveCnt
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();

		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
		if (MultipleRewardBtn != null) MultipleRewardBtn.onClick.AddListener(OnClickMultipleReward);
		if (btnGetBank != null) btnGetBank.onClick.AddListener(OnClickGetBank);
	}

	protected override void OnEnable()
	{
		base.OnEnable();
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnClickReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private void OnClickMultipleReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private void GetReward(bool isOpenSeasonal, E_RewardGetType getType, int type, int idx, int region, BigInteger value, int receiveAll)
	{
		if (isOpenSeasonal)
			GetReward_SuperStaffOpen(getType, type, idx, region, value, receiveAll);
		else
			GetReward_Normal(getType, type, idx, region, value, receiveAll);
	}

	private void GetReward_SuperStaffOpen(E_RewardGetType getType, int type, int idx, int region, BigInteger value, int receiveAll)
	{
		Hide();
	}

	private void GetReward_Normal(E_RewardGetType getType, int type, int idx, int region, BigInteger value, int receiveAll)
	{
		Hide();
	}

	public void UpdateSuperStaff()
	{
		if (superStaffBtn == null) return;
		if (superStaffRoot != null) superStaffRoot.SetActive(false);
	}

	public void Init(AdSupplySystem.ShowType type, AdSupplySystem.AdsupplyType rewardType)
	{
		PopupShowType = type;
		AdsupplyType = rewardType;
		isShowAds = false;

		UpdateSuperStaff();
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void OnClickGetBank()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
