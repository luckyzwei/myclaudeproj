using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemAuctionManager : ItemManagerCard
{
	[Header("-----------------------")]
	[SerializeField]
	private Text MaxCoinCount;

	[SerializeField]
	private GameObject EquipObj;

	[SerializeField]
	private Text EquipRound;

	public Action<int> clickAction;

	public override void Set(int managerIdx, int managerCount = -1, bool isNew = false, bool onHireObjDeactive = false, bool isAcquisition = false)
	{
	}

	public void HideEquipObj()
	{
	}

	protected override void OnClickManager()
	{
	}
}
