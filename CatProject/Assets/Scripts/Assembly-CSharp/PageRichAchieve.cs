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
		base.Awake();
		disposables = new CompositeDisposable();
		list_missionItems = new List<ItemWorldMission>();
		list_rewardItems = new List<ItemWorldMissionReward>();

		if (btn_info != null) btn_info.onClick.AddListener(OnClickInfo);
		if (btn_CashBtn != null) btn_CashBtn.onClick.AddListener(OnClickCashShop);
	}

	public override void OnShowBefore()
	{
		SetPageInfoShow();
	}

	public override void OnHideAfter()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	public void SetPageInfoShow()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		SetTitle();
		SetRichPoint();
		SetCash();
		SetRewards();
		InitScroll();
		SetFocusScroll();
	}

	private void SetTitle()
	{
		if (text_RegionName != null) text_RegionName.text = "";
	}

	private void SetRichPoint()
	{
		if (text_RichPoint != null) text_RichPoint.text = "0";
	}

	private void SetCash()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (text_Cash != null) text_Cash.text = "0";
	}

	public void SetRewardPoint()
	{
		if (text_AchievementPoint_desc != null) text_AchievementPoint_desc.text = "";
	}

	private void SetRewards()
	{
		list_rewardItems.Clear();
		if (area_reward == null || pf_reward == null) return;
	}

	private void SetShop()
	{
		if (btn_CashBtn != null) btn_CashBtn.gameObject.SetActive(true);
	}

	private void OnClickCashShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void RedrawRewardState()
	{
		for (int i = 0; i < list_rewardItems.Count; i++)
		{
			if (list_rewardItems[i] != null)
				list_rewardItems[i].SetState();
		}
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void RedrawMissionUnlock(int missionIdx)
	{
		if (list_missionItems == null) return;
		for (int i = 0; i < list_missionItems.Count; i++)
		{
			if (list_missionItems[i] != null)
				list_missionItems[i].PlayUnlockAni();
		}
	}

	private void InitScroll()
	{
		list_missionItems.Clear();
		if (scroll == null || pf_scroll_item == null) return;
	}

	private void SetFocusScroll()
	{
		// Scroll to current active mission
		if (scroll != null) scroll.normalizedPosition = new Vector2(0f, 1f);
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
