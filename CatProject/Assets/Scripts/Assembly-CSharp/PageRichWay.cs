using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageRichWay", false, false)]
public class PageRichWay : UIBase
{
	[Header("HUD")]
	[SerializeField]
	private Text richPointText;

	[SerializeField]
	private Button richPointinfoBtn;

	[Header("Title")]
	[SerializeField]
	private Text RegionNameText;

	[Header("Scroll")]
	[SerializeField]
	private ScrollRect missionScroll;

	[SerializeField]
	private GameObject missionItem;

	protected override void Awake()
	{
		base.Awake();
		if (richPointinfoBtn != null) richPointinfoBtn.onClick.AddListener(OnClickRichPointInfo);
	}

	public override void OnShowBefore()
	{
		UpdateMissions();
		FocusCurMission();
	}

	private void UpdateMissions()
	{
		// Refresh mission list
	}

	private void FocusCurMission()
	{
		// Scroll to current mission
	}

	private void OnClickRichPointInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
