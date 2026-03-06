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
		base.Awake();
		if (StartButton != null) StartButton.onClick.AddListener(OnClickedStartButton);
		if (TeamSetButton != null) TeamSetButton.onClick.AddListener(OnClickedTeamSetButton);
		if (AutoPlayButton != null) AutoPlayButton.onClick.AddListener(OnClickedAutoPlayButton);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		SetEnemyCeoList();
		SetPlyerTeamHpText();

		if (ItemTeamSet != null)
		{
			ItemTeamSet.SetTeamData();
			ItemTeamSet.SetAllCeoList();
			ItemTeamSet.OnHideCallback = OnHideTeamSet;
		}

		bool hasCeos = EnemyCeoList != null && EnemyCeoList.Count > 0;
		if (EmptyCeoListObj != null) EmptyCeoListObj.SetActive(!hasCeos);
	}

	private void OnHideTeamSet()
	{
		SetPlyerTeamHpText();
	}

	public override void OnShowAfter()
	{
		SetAutoPlayGuide(false);
	}

	public override void OnRefresh()
	{
		SetEnemyCeoList();
		SetPlyerTeamHpText();
	}

	private void SetPlyerTeamHpText()
	{
		if (PlayerTeamHpText != null) PlayerTeamHpText.text = "0";
	}

	private void SetEnemyCeoList()
	{
		if (EnemyCeoList == null) return;
		// Set enemy CEO data from BizAcqSystem stage info
		if (EnemyTeamHpText != null) EnemyTeamHpText.text = "0";

		for (int i = 0; i < EnemyCeoList.Count; i++)
		{
			if (EnemyCeoList[i] != null)
			{
				int idx = i;
				EnemyCeoList[i].OnClickedSlotButtonEvent = (ceoIdx, slotIdx) => OnClickedEnemyCeoItem(ceoIdx, slotIdx);
			}
		}

		if (BossStageDecoObj != null) BossStageDecoObj.SetActive(false);
	}

	private void OnClickedStartButton()
	{
		// Start acquisition battle
	}

	private void OnClickedTeamSetButton()
	{
		if (ItemTeamSet != null)
			ItemTeamSet.SetTeamSetMode(true);
	}

	private void OnClickedAutoPlayButton()
	{
		bool isAutoPlay = AutoPlayCheckObj != null && AutoPlayCheckObj.activeSelf;
		isAutoPlay = !isAutoPlay;
		if (AutoPlayCheckObj != null) AutoPlayCheckObj.SetActive(isAutoPlay);
	}

	private void OnClickedEnemyCeoItem(int ceoIdx, int slotIdx)
	{
		// Show enemy CEO info
	}

	private void SetAutoPlayGuide(bool isSet)
	{
		SetActiveAutoPlayGuideBubble(isSet);
	}

	private void SetActiveAutoPlayGuideBubble(bool isSet)
	{
		if (AutoPlayGuideBubbleObj == null) return;
		if (isSet)
			AutoPlayGuideBubbleObj.PlayShowImmediately();
		else
			AutoPlayGuideBubbleObj.PlayHide();
	}
}
