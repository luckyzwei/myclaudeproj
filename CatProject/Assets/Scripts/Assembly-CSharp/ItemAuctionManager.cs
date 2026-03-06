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
		base.Set(managerIdx, managerCount, isNew, onHireObjDeactive, isAcquisition);
		if (EquipObj != null)
			EquipObj.SetActive(false);
	}

	public void HideEquipObj()
	{
		if (EquipObj != null)
			EquipObj.SetActive(false);
	}

	protected override void OnClickManager()
	{
		clickAction?.Invoke(curManagerIdx);
	}
}
