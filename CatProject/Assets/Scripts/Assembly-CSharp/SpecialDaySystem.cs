using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;

public class SpecialDaySystem
{
	public static bool INIT_DEFINE;

	public static int ROULETTE_PLAY_BONUS_NEED_COUNT;

	public IReactiveProperty<int> RemainEndTime;

	public IReactiveProperty<int> RemainNextTime;

	private int employeeMinIdx;

	private int employeeMaxIdx;

	private int totalAddEmployeeRatio;

	public Action OnLoadSpecialDayAtlas;

	public int CurIdx { get; private set; }

	public int CurAtlasIdx { get; private set; }

	public Config.E_SpecialDayEventType CurEventType { get; private set; }

	public DateTime CurEndTime { get; private set; }

	public DateTime CurStartTime { get; private set; }

	public int NextIdx { get; private set; }

	public DateTime NextStartTime { get; private set; }

	public bool IsSystemInit { get; private set; }

	public bool IsEnqueueOpenPopup { get; set; }

	public bool IsEnqueueDonePopup { get; set; }

	public Sprite BgTile { get; private set; }

	public Color BgColor { get; private set; }

	public List<int> SpecialDayDecoIdxList { get; private set; }

	public void Init(bool reset = false)
	{
	}

	public void OnChangeScene()
	{
	}

	private void SubscribeContentOpen()
	{
	}

	private bool OpenSpecialDay()
	{
		return false;
	}

	private void DoneSpecialDay(int beforeIdx)
	{
	}

	private void CheckAndInitAnniversaryEventData()
	{
	}

	private void ShowOpenPopup(bool isSystemInit)
	{
	}

	private void ShowDonePopup()
	{
	}

	public void OnHideDonePopup(Action cb = null)
	{
	}

	public void ShowEventPage(Action<UIBase> onOpenUI)
	{
	}

	private void EnterSpecialDay()
	{
	}

	public void GetSpecialDayIcon(string iconKey, Action<Sprite> onLoadCb)
	{
	}

	public void GetSpecialDayHUDIcon(Action<Sprite> onLoadCb)
	{
	}

	public string GetSpecialDayHUDIconString()
	{
		return null;
	}

	private (DateTime, DateTime) GetSpecialDayTime()
	{
		return default((DateTime, DateTime));
	}

	public void SetCurSpecialDayIdx()
	{
	}

	private void SetNextSpecialDay()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	private int GetStartTimeYear()
	{
		return 0;
	}

	public bool IsSpecialDayEventType(Config.E_SpecialDayEventType eventType)
	{
		return false;
	}

	private void LoadSpecialTheme(Action tileLoadCb, Action stageLoadCb)
	{
	}

	private void UpdateSpecialTheme()
	{
	}

	private void UpdateLoadingTheme()
	{
	}

	private void UpdateLoadingThemeAfter()
	{
	}

	private void UpdateStageTheme()
	{
	}

	public int GetSpecialEmployeeViewIdx()
	{
		return 0;
	}

	public bool CheckSpecialEmployeeViewIdx(int idx)
	{
		return false;
	}

	public int GetSpecialAddEmployeeViewIdx()
	{
		return 0;
	}

	public bool CheckSpecialDayAtlas()
	{
		return false;
	}

	public bool CheckSpecialDayDecoReward()
	{
		return false;
	}

	public void SetSpecialDayDecoReward(Action cb)
	{
	}

	private void LogSpecialDecoReward()
	{
	}
}
