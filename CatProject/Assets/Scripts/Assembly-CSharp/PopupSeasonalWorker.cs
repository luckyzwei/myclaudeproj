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
		Disposables = new CompositeDisposable();
		SetInfo();
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void SetInfo()
	{
		SetWorkerCountText();
	}

	public void SetWorkerCountText()
	{
		if (text_working_count != null) text_working_count.text = "0";
		if (text_idle_count != null) text_idle_count.text = "0";
	}
}
