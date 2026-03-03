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
	}

	public override void OnShowBefore()
	{
	}

	public void DrawCollection()
	{
	}

	private void SetTotalReward()
	{
	}

	private void SetParkingSet()
	{
	}

	private void OnBrandClick(int brandIdx)
	{
	}

	private void OnClickTotalRewardBtn()
	{
	}
}
