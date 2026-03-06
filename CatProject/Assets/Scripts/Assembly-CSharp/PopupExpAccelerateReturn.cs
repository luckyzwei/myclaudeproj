using System.Collections.Generic;
using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupExpAccelerateReturn", false, false)]
public class PopupExpAccelerateReturn : UIBase
{
	[SerializeField]
	private Transform ExpTicketRootTr;

	[SerializeField]
	private GameObject ItemExpTicketObj;

	public void SetReturnItems(Dictionary<Config.ItemIdx, int> returnItemList)
	{
		// Update display
	}
}
