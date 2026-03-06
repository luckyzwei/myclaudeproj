using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupMiniGameMission", false, false)]
public class PopupMiniGameMission : UIBase, IHUDTopInfo
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private ScrollRect MissionScrollRect;

	[SerializeField]
	private GameObject MissionItemPrefab;

	private List<ItemEventMission> MissionItems;

	private CompositeDisposable Disposables;

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void Init()
	{
		Disposables = new CompositeDisposable();
		MissionItems = new List<ItemEventMission>();
		InitHudTopInfo();
		SetMissionItems();
		SetRemainTimeText();
	}

	private void SetMissionItems()
	{
		if (MissionScrollRect == null || MissionItemPrefab == null) return;
		MissionItems.Clear();
		// Populate mission items from mini game mission data
	}

	private void SetRemainTimeText()
	{
		if (RemainTimeText == null) return;
		RemainTimeText.text = "";
	}

	private void InitHudTopInfo()
	{
		if (HUDTopInfo != null) HUDTopInfo.UpdateCurrencyInfos();
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return HUDTopInfo;
	}
}
