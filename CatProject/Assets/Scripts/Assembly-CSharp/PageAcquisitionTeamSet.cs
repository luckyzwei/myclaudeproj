using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionTeamSet", false, false)]
public class PageAcquisitionTeamSet : UIBase
{
	[SerializeField]
	private Button AutoSetButton;

	[SerializeField]
	private Text PlayerTeamTotalHpValueText;

	[SerializeField]
	private Text EnemyTeamTotalHpValueText;

	[SerializeField]
	private Text StageIdxText;

	[SerializeField]
	private List<ItemAcquisitionTeamSetSlot> TeamSetSlotList;

	[SerializeField]
	private ScrollRect CeoScrollRect;

	[SerializeField]
	private GameObject ItemAcqCeoObj;

	private List<ItemAcquisitionCEO> ItemAcqCeoList;

	protected override void Awake()
	{
		base.Awake();
		ItemAcqCeoList = new List<ItemAcquisitionCEO>();
		if (AutoSetButton != null) AutoSetButton.onClick.AddListener(OnClickedAutoSetBtn);
	}

	public override void OnShowBefore()
	{
		SetCurStageInfo();
		SetTeamData();
		SetAllCeoList();
	}

	public override void OnHideBefore()
	{
	}

	private void SetCurStageInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (StageIdxText != null) StageIdxText.text = "";
	}

	private void SetTeamData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		var playerTeam = root.BizAcqBattleSystem.GetTeam(BizAcqDef.TeamType.Player);
		var enemyTeam = root.BizAcqBattleSystem.GetTeam(BizAcqDef.TeamType.Enemy);

		if (playerTeam != null && PlayerTeamTotalHpValueText != null)
		{
			var hpInfo = playerTeam.GetTeamHpInfo();
			PlayerTeamTotalHpValueText.text = hpInfo.Item1 + "/" + hpInfo.Item2;
		}
		if (enemyTeam != null && EnemyTeamTotalHpValueText != null)
		{
			var hpInfo = enemyTeam.GetTeamHpInfo();
			EnemyTeamTotalHpValueText.text = hpInfo.Item1 + "/" + hpInfo.Item2;
		}

		if (TeamSetSlotList != null && playerTeam != null)
		{
			var characters = playerTeam.Characters;
			for (int i = 0; i < TeamSetSlotList.Count; i++)
			{
				if (TeamSetSlotList[i] == null) continue;
				if (characters != null && i < characters.Count && characters[i] != null)
					TeamSetSlotList[i].SetData(characters[i], i + 1);
				else
					TeamSetSlotList[i].SetEmpty();
			}
		}
	}

	private void SetAllCeoList()
	{
		if (ItemAcqCeoList == null) ItemAcqCeoList = new List<ItemAcquisitionCEO>();
	}

	private void OnClickedAutoSetBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		root.BizAcqBattleSystem.TryMakeBestPlayerTeam(null, true);
		SetTeamData();
		SetAllCeoList();
	}

	private void OnClickedCeoSlot(int ceoIdx)
	{
		if (ceoIdx > 0)
			RemoveFromTeam(ceoIdx);
	}

	private void OnClickedCeoListItem(int ceoIdx, int slotIdx)
	{
		AddToTeam(ceoIdx);
	}

	private void AddToTeam(int ceoIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		SetTeamData();
		SetAllCeoList();
	}

	private void RemoveFromTeam(int ceoIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		SetTeamData();
		SetAllCeoList();
	}
}
