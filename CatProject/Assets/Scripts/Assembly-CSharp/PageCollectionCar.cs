using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageCollectionCar", false, false)]
public class PageCollectionCar : UIBase
{
	[SerializeField]
	private ScrollRect BrandScroll;

	[SerializeField]
	private GameObject BrandItem;

	[Header("Buff")]
	[SerializeField]
	private Image RevenueBuffIcon;

	[SerializeField]
	private Text RevenueBuffText;

	[SerializeField]
	private Text ExpUpBuffText;

	[Header("TotalReward")]
	[SerializeField]
	private Image TotalRewardIcon;

	[SerializeField]
	private Text TotalRewardValue;

	[SerializeField]
	private Button TotalRewardBtn;

	[SerializeField]
	private Slider TotalRewardProgress;

	[SerializeField]
	private Text TotalRewardCount;

	[SerializeField]
	private GameObject TotalRewardOnObj;

	[SerializeField]
	private GameObject TotalRewardRoot;

	[SerializeField]
	private GameObject TotalRewardOffRoot;

	protected override void Awake()
	{
		base.Awake();
		if (TotalRewardBtn != null) TotalRewardBtn.onClick.AddListener(OnClickTotalRewardBtn);
	}

	public override void OnShowBefore()
	{
		DrawCollection();
	}

	public void DrawCollection()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		SetTotalReward();
		SetParkingSet();
	}

	private void SetTotalReward()
	{
		if (TotalRewardRoot != null) TotalRewardRoot.SetActive(true);
		if (TotalRewardOffRoot != null) TotalRewardOffRoot.SetActive(false);
		if (TotalRewardOnObj != null) TotalRewardOnObj.SetActive(false);
		if (TotalRewardProgress != null) TotalRewardProgress.value = 0f;
		if (TotalRewardCount != null) TotalRewardCount.text = "0/0";
	}

	private void SetParkingSet()
	{
		// Setup parking lot collection display
	}

	private void OnBrandClick(int brandIdx)
	{
		// Show brand detail popup
	}

	private void OnClickTotalRewardBtn()
	{
		// Claim total collection reward
	}
}
