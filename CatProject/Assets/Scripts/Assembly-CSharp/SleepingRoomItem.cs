using System.Collections.Generic;
using UnityEngine;

public class SleepingRoomItem : OfficeItem
{
	[SerializeField]
	public List<WaitingRoomItem> WaitingItems;

	public override void Init(int office, int type, int idx)
	{
		base.Init(office, type, idx);
	}

	private void UpdateItem()
	{
		// Update display
	}
}
