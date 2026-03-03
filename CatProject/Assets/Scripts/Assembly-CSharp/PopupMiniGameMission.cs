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
	}

	public void Init()
	{
	}

	private void SetMissionItems()
	{
	}

	private void SetRemainTimeText()
	{
	}

	private void InitHudTopInfo()
	{
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return null;
	}
}
