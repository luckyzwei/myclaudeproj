using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class MeetingRoomItem : OfficeItem
{
	[SerializeField]
	public List<WaitingRoomItem> WaitingItems;

	private CompositeDisposable open_disposables;

	public override void Init(int office, int type, int idx)
	{
	}

	private void UpdateLevel(int level)
	{
	}

	private void OnDestroy()
	{
	}
}
