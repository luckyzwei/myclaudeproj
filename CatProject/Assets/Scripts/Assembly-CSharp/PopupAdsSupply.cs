using System.Numerics;
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

	public BigInteger CurAdsupplyCollectMoney => default(BigInteger);

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
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClickReward()
	{
	}

	private void OnClickMultipleReward()
	{
	}

	private void GetReward(bool isOpenSeasonal, E_RewardGetType getType, int type, int idx, int region, BigInteger value, int receiveAll)
	{
	}

	private void GetReward_SuperStaffOpen(E_RewardGetType getType, int type, int idx, int region, BigInteger value, int receiveAll)
	{
	}

	private void GetReward_Normal(E_RewardGetType getType, int type, int idx, int region, BigInteger value, int receiveAll)
	{
	}

	public void UpdateSuperStaff()
	{
	}

	public void Init(AdSupplySystem.ShowType type, AdSupplySystem.AdsupplyType rewardType)
	{
	}

	public override void Hide()
	{
	}

	private void OnClickGetBank()
	{
	}
}
