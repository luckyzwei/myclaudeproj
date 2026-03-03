using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageRichAchieve", false, false)]
public class PageRichAchieve : UIBase
{
	[Header("HUD")]
	[SerializeField]
	private Text text_RichPoint;

	[SerializeField]
	private Button btn_info;

	[SerializeField]
	private Text text_Cash;

	[SerializeField]
	private Button btn_CashBtn;

	[Header("Title")]
	[SerializeField]
	private Text text_RegionName;

	[Header("Reward")]
	[SerializeField]
	private Transform area_reward;

	[SerializeField]
	private GameObject pf_reward;

	[SerializeField]
	private Text text_AchievementPoint_desc;

	[Header("Scroll")]
	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private GameObject pf_scroll_item;

	private List<ItemWorldMission> list_missionItems;

	private List<ItemWorldMissionReward> list_rewardItems;

	private int _activeRegionIdx;

	private int max_mission_count;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void SetPageInfoShow()
	{
	}

	private void SetTitle()
	{
	}

	private void SetRichPoint()
	{
	}

	private void SetCash()
	{
	}

	public void SetRewardPoint()
	{
	}

	private void SetRewards()
	{
	}

	private void SetShop()
	{
	}

	private void OnClickCashShop()
	{
	}

	public void RedrawRewardState()
	{
	}

	private void OnClickInfo()
	{
	}

	public void RedrawMissionUnlock(int missionIdx)
	{
	}

	private void InitScroll()
	{
	}

	private void SetFocusScroll()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
