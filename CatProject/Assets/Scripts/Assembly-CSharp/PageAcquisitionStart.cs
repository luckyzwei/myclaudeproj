using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionStart", false, false)]
public class PageAcquisitionStart : FullScreenUI
{
	[SerializeField]
	private Button StartButton;

	[SerializeField]
	private Button TeamSetButton;

	[SerializeField]
	private Button AutoPlayButton;

	[SerializeField]
	private GameObject AutoPlayCheckObj;

	[SerializeField]
	private AutoPlayBubble AutoPlayGuideBubbleObj;

	[SerializeField]
	private Text EnemyTeamHpText;

	[SerializeField]
	private Text PlayerTeamHpText;

	[SerializeField]
	private List<ItemAcquisitionCEO> EnemyCeoList;

	[SerializeField]
	private ItemAcquisitionStageBox StageBox;

	[SerializeField]
	private ItemAcquisitionTeamSet ItemTeamSet;

	[SerializeField]
	private GameObject BossStageDecoObj;

	[SerializeField]
	private GameObject EmptyCeoListObj;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void OnHideTeamSet()
	{
	}

	public override void OnShowAfter()
	{
	}

	public override void OnRefresh()
	{
	}

	private void SetPlyerTeamHpText()
	{
	}

	private void SetEnemyCeoList()
	{
	}

	private void OnClickedStartButton()
	{
	}

	private void OnClickedTeamSetButton()
	{
	}

	private void OnClickedAutoPlayButton()
	{
	}

	private void OnClickedEnemyCeoItem(int ceoIdx, int slotIdx)
	{
	}

	private void SetAutoPlayGuide(bool isSet)
	{
	}

	private void SetActiveAutoPlayGuideBubble(bool isSet)
	{
	}
}
