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
	}

	public override void OnShowBefore()
	{
	}

	private void UpdateMissions()
	{
	}

	private void FocusCurMission()
	{
	}

	private void OnClickRichPointInfo()
	{
	}
}
