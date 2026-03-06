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
		base.Awake();
		if (PrevBtn != null) PrevBtn.onClick.AddListener(OnPrevBtnClick);
		if (NextBtn != null) NextBtn.onClick.AddListener(OnNextBtnClick);
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnRewardBtnClick);
	}

	public void SetBrand(int brandIdx)
	{
		CurBrandIdx = brandIdx;
		UpdateProgress();
	}

	private void UpdateProgress()
	{
		// Update display
	}

	private void OnPrevBtnClick()
	{
		if (CurBrandIdx > 0)
			SetBrand(CurBrandIdx - 1);
	}

	private void OnNextBtnClick()
	{
		SetBrand(CurBrandIdx + 1);
	}

	private void OnRewardBtnClick()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
