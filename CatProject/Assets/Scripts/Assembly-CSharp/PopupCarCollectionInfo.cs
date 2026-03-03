using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCarCollectionInfo", false, false)]
public class PopupCarCollectionInfo : UIBase
{
	[SerializeField]
	private Image BrandIcon;

	[SerializeField]
	private Image BrandIcon2;

	[SerializeField]
	private Text BrandName;

	[SerializeField]
	private Slider OwnProgress;

	[SerializeField]
	private Text OwnCount;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardCount;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private GameObject RewardOnObj;

	[SerializeField]
	private Image BuffIcon;

	[SerializeField]
	private Text BuffText;

	[SerializeField]
	private Text BuffDesc;

	[SerializeField]
	private GameObject BuffOnObj;

	[SerializeField]
	private GameObject BuffRoot;

	[SerializeField]
	private ScrollRect CarScroll;

	[SerializeField]
	private GameObject CarItem;

	[SerializeField]
	private Button PrevBtn;

	[SerializeField]
	private Button NextBtn;

	private int CurBrandIdx;

	protected override void Awake()
	{
	}

	public void SetBrand(int brandIdx)
	{
	}

	private void UpdateProgress()
	{
	}

	private void OnPrevBtnClick()
	{
	}

	private void OnNextBtnClick()
	{
	}

	private void OnRewardBtnClick()
	{
	}
}
