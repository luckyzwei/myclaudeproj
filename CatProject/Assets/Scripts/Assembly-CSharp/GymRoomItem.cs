using System.Collections.Generic;
using UnityEngine;

public class GymRoomItem : OfficeItem
{
	[SerializeField]
	public List<WaitingRoomItem> WaitingItems;

	public override void Init(int office, int type, int idx)
	{
	}

	private void UpdateItem()
	{
	}
}
