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
	}

	public void Init(int regionIdx)
	{
	}

	private void InitRegionInfo()
	{
	}

	private void UpdateButtonState()
	{
	}

	private void OnClickLeft()
	{
	}

	private void OnClickRight()
	{
	}

	private void FlipNextPage()
	{
	}

	private void FlipPrevPage()
	{
	}
}
