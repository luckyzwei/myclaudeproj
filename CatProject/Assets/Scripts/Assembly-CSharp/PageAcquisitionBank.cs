using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionBank", false, false)]
public class PageAcquisitionBank : UIBase, IHUDTopInfo
{
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private GameObject JewelryBoxRoot;

	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private SliderTextComponent SliderComp;

	[SerializeField]
	private Text CurCountText;

	[SerializeField]
	private Text MaxCountText;

	[Header("Purchase")]
	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private GameObject SaleObj;

	[SerializeField]
	private Text SaleText;

	[Header("LevelInfo")]
	[SerializeField]
	private Text CurLevelText;

	[SerializeField]
	private GameObject NextLevelRoot;

	[SerializeField]
	private Text CurMaxFullCountText;

	[SerializeField]
	private Text NextMaxFullCountText;

	[SerializeField]
	private Button LevelInfoBtn;

	private BigInteger CurMaxCount;

	private bool IsEnablePurchase;

	private int ShopSpecialIdx;

	private GameObject LoadedJewelryBoxObj;

	private int LoadedStageStep;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return null;
	}

	private void Init()
	{
	}

	private void LoadJewelryBoxPrefab(int stageStep, bool isFull)
	{
	}

	private void PlayJewelryBoxAnimation(bool isFull)
	{
	}

	private void CheckAndOpenStepUpPage()
	{
	}

	private void SetPurchaseInfo(int shopSpecialIdx)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickLevelInfo()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
