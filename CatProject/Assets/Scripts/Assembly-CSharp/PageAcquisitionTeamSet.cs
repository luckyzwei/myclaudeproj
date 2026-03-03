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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void SetCurStageInfo()
	{
	}

	private void SetTeamData()
	{
	}

	private void SetAllCeoList()
	{
	}

	private void OnClickedAutoSetBtn()
	{
	}

	private void OnClickedCeoSlot(int ceoIdx)
	{
	}

	private void OnClickedCeoListItem(int ceoIdx, int slotIdx)
	{
	}

	private void AddToTeam(int ceoIdx)
	{
	}

	private void RemoveFromTeam(int ceoIdx)
	{
	}
}
