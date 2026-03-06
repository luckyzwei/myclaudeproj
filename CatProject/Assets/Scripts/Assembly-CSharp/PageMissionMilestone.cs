using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageMissionMilestone", false, false)]
public class PageMissionMilestone : UIBase
{
	[SerializeField]
	private Button LeftBtn;

	[SerializeField]
	private Button RightBtn;

	private int CurRegionIdx;

	private int MinRegionIdx;

	private int MaxRegionIdx;

	[SerializeField]
	private ItemMissionMilestoneBg PageBack;

	[SerializeField]
	private ItemMissionMilestoneBg PageFront;

	[SerializeField]
	private Animator PageFlipAnimator;

	[SerializeField]
	private float FlipDuration;

	private bool IsFlipping;

	private ItemMissionMilestoneBg PageNow;

	protected override void Awake()
	{
		base.Awake();
		if (LeftBtn != null) LeftBtn.onClick.AddListener(OnClickLeft);
		if (RightBtn != null) RightBtn.onClick.AddListener(OnClickRight);
	}

	public void Init(int regionIdx)
	{
		CurRegionIdx = regionIdx;
		MinRegionIdx = 0;
		InitRegionInfo();
		UpdateButtonState();
	}

	private void InitRegionInfo()
	{
		PageNow = PageFront;
		// Set region info on current page
	}

	private void UpdateButtonState()
	{
		if (LeftBtn != null) LeftBtn.gameObject.SetActive(CurRegionIdx > MinRegionIdx);
		if (RightBtn != null) RightBtn.gameObject.SetActive(CurRegionIdx < MaxRegionIdx);
	}

	private void OnClickLeft()
	{
		if (IsFlipping || CurRegionIdx <= MinRegionIdx) return;
		CurRegionIdx--;
		FlipPrevPage();
	}

	private void OnClickRight()
	{
		if (IsFlipping || CurRegionIdx >= MaxRegionIdx) return;
		CurRegionIdx++;
		FlipNextPage();
	}

	private void FlipNextPage()
	{
		IsFlipping = true;
		// Play flip animation forward
		InitRegionInfo();
		UpdateButtonState();
		IsFlipping = false;
	}

	private void FlipPrevPage()
	{
		IsFlipping = true;
		// Play flip animation backward
		InitRegionInfo();
		UpdateButtonState();
		IsFlipping = false;
	}
}
