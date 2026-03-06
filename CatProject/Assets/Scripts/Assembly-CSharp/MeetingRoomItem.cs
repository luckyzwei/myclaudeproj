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
		base.Init(office, type, idx);
		open_disposables = new CompositeDisposable();
	}

	private void UpdateLevel(int level)
	{
		if (WaitingItems == null) return;
		for (int i = 0; i < WaitingItems.Count; i++)
		{
			if (WaitingItems[i] != null)
				WaitingItems[i].gameObject.SetActive(i < level);
		}
	}

	private void OnDestroy()
	{
		if (open_disposables != null)
		{
			open_disposables.Dispose();
			open_disposables = null;
		}
	}
}
