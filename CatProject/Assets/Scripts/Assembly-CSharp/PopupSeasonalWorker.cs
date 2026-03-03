using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalWorker", false, false)]
public class PopupSeasonalWorker : UIBase
{
	[Header("WorkShops")]
	[SerializeField]
	private ScrollRect scroll_workshops;

	[SerializeField]
	private List<GameObject> list_workshopItems;

	[Header("WorkerCount")]
	[SerializeField]
	private Text text_working_count;

	[SerializeField]
	private Text text_idle_count;

	private CompositeDisposable Disposables;

	public override void OnShowBefore()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetInfo()
	{
	}

	public void SetWorkerCountText()
	{
	}
}
