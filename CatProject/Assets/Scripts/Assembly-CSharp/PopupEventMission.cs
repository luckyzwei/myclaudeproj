using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupEventMission", false, false)]
public class PopupEventMission : UIBase, IHUDTopInfo
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private ScrollRect SlotScrollRect;

	[SerializeField]
	private GameObject MissionSlotPrefab;

	[SerializeField]
	private TimeComponent DailyResetTimer;

	[SerializeField]
	private TimeComponent EventEndTimer;

	[SerializeField]
	private GameObject EventPlayObj;

	[SerializeField]
	private GameObject EventEndObj;

	private CurrencyHUDComponent AnniversaryTicketHUDComponent;

	private E_ContentsMissionType MissionContentType;

	private List<ItemEventMission> MissionSlots;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		MissionSlots = new List<ItemEventMission>();
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void Init(E_ContentsMissionType contentType)
	{
		MissionContentType = contentType;
		if (HUDTopInfo != null) HUDTopInfo.UpdateCurrencyInfos();
		UpdateMissionSlots();
		SetDailyResetTimer();
		SetEventEndLayout();
	}

	private void UpdateMissionSlots()
	{
		if (SlotScrollRect == null || MissionSlotPrefab == null) return;
		MissionSlots.Clear();
		// Populate mission slots from event mission data
	}

	private void SetDailyResetTimer()
	{
		if (DailyResetTimer == null) return;
		// Set daily reset timer countdown
	}

	private void SetEventEndLayout()
	{
		if (EventPlayObj != null) EventPlayObj.SetActive(true);
		if (EventEndObj != null) EventEndObj.SetActive(false);
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return HUDTopInfo;
	}
}
