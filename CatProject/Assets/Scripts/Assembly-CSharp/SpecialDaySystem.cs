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
		RemainEndTime = new ReactiveProperty<int>(0);
		RemainNextTime = new ReactiveProperty<int>(0);
		SpecialDayDecoIdxList = new List<int>();

		if (!INIT_DEFINE)
		{
			INIT_DEFINE = true;
			ROULETTE_PLAY_BONUS_NEED_COUNT = 10;
		}

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var specialDayData = gameRoot.UserData.SpecialDayData;
		if (specialDayData == null)
		{
			specialDayData = new SpecialDayData();
			gameRoot.UserData.SpecialDayData = specialDayData;
		}

		int beforeIdx = CurIdx;
		SetCurSpecialDayIdx();
		SetNextSpecialDay();

		if (CurIdx > 0)
		{
			bool opened = OpenSpecialDay();
			if (reset || !opened)
			{
				// On reset or fresh open, check if popup should be shown
			}
		}
		else if (beforeIdx > 0)
		{
			DoneSpecialDay(beforeIdx);
		}

		IsSystemInit = true;
		SubscribeContentOpen();
	}

	public void OnChangeScene()
	{
		if (CurIdx > 0)
		{
			UpdateSpecialTheme();
		}
	}

	private void SubscribeContentOpen()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.ContentsOpenSystem == null) return;

		gameRoot.ContentsOpenSystem.Subscribe(Config.ContentsOpenType.Level, () =>
		{
			if (CurIdx > 0 && !IsEnqueueOpenPopup)
			{
				ShowOpenPopup(false);
			}
		});
	}

	private bool OpenSpecialDay()
	{
		if (CurIdx <= 0) return false;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var specialDayData = gameRoot.UserData.SpecialDayData;
		if (specialDayData == null) return false;

		var (startTime, endTime) = GetSpecialDayTime();
		CurStartTime = startTime;
		CurEndTime = endTime;

		DateTime now = TimeSystem.GetCurTime();
		if (now < startTime || now > endTime)
			return false;

		int remainSec = (int)(endTime - now).TotalSeconds;
		if (remainSec < 0) remainSec = 0;
		RemainEndTime.Value = remainSec;

		if (specialDayData.SpecialDayIdx != CurIdx)
		{
			specialDayData.SpecialDayIdx = CurIdx;
			specialDayData.FirstGuideView = false;
			specialDayData.SpecialDayYear = GetStartTimeYear();

			if (specialDayData.SpecialDayDeco != null)
				specialDayData.SpecialDayDeco.Clear();
			else
				specialDayData.SpecialDayDeco = new List<ItemData>();

			CheckAndInitAnniversaryEventData();
			IsEnqueueOpenPopup = true;
		}

		EnterSpecialDay();
		return true;
	}

	private void DoneSpecialDay(int beforeIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		CurIdx = 0;
		CurEventType = Config.E_SpecialDayEventType.None;
		RemainEndTime.Value = 0;

		if (gameRoot.UserData.SpecialDayRouletteData != null)
		{
			gameRoot.UserData.SpecialDayRouletteData.LuckydrawCount = 0;
			gameRoot.UserData.SpecialDayRouletteData.Freespin = false;
		}

		if (gameRoot.RouletteSystem != null)
		{
			gameRoot.RouletteSystem.ResetSpecialDayRoulette();
		}

		IsEnqueueDonePopup = true;
	}

	private void CheckAndInitAnniversaryEventData()
	{
		if (CurEventType != Config.E_SpecialDayEventType.Anniversary) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var annivData = gameRoot.UserData.AnniversaryEventData;
		if (annivData == null)
		{
			annivData = new AnniversaryEventData();
			// AnniversaryEventData is read-only property, so just ensure it exists
		}
		else
		{
			int curYear = GetStartTimeYear();
			if (annivData.AnniversaryYear != curYear)
			{
				annivData.Reset();
				annivData.AnniversaryYear = curYear;
			}
		}
	}

	private void ShowOpenPopup(bool isSystemInit)
	{
		IsEnqueueOpenPopup = false;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		if (CurEventType == Config.E_SpecialDayEventType.Anniversary)
		{
			gameRoot.WaitAndOpenUICoroutine<PopupSpecialDayAnniversaryOpen>();
		}
		else
		{
			gameRoot.WaitAndOpenUICoroutine<PopupSpecialDayOpen>();
		}
	}

	private void ShowDonePopup()
	{
		IsEnqueueDonePopup = false;
	}

	public void OnHideDonePopup(Action cb = null)
	{
		IsEnqueueDonePopup = false;
		cb?.Invoke();
	}

	public void ShowEventPage(Action<UIBase> onOpenUI)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		gameRoot.WaitAndOpenUICoroutine<PageRewardSpecial>((page) =>
		{
			onOpenUI?.Invoke(page);
		});
	}

	private void EnterSpecialDay()
	{
		LoadSpecialTheme(() =>
		{
			// tile loaded
			OnLoadSpecialDayAtlas?.Invoke();
		}, () =>
		{
			// stage loaded
			UpdateStageTheme();
		});
	}

	public void GetSpecialDayIcon(string iconKey, Action<Sprite> onLoadCb)
	{
		if (string.IsNullOrEmpty(iconKey) || onLoadCb == null) return;

		var sprite = Resources.Load<Sprite>($"SpecialDay/{iconKey}");
		onLoadCb?.Invoke(sprite);
	}

	public void GetSpecialDayHUDIcon(Action<Sprite> onLoadCb)
	{
		if (onLoadCb == null) return;

		string iconKey = GetSpecialDayHUDIconString();
		if (string.IsNullOrEmpty(iconKey)) return;

		GetSpecialDayIcon(iconKey, onLoadCb);
	}

	public string GetSpecialDayHUDIconString()
	{
		if (CurIdx <= 0) return null;
		return $"specialday_hud_icon_{CurIdx}";
	}

	private (DateTime, DateTime) GetSpecialDayTime()
	{
		DateTime now = TimeSystem.GetCurTime();
		DateTime startTime = now.Date;
		DateTime endTime = startTime.AddDays(7);
		return (startTime, endTime);
	}

	public void SetCurSpecialDayIdx()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		DateTime now = TimeSystem.GetCurTime();

		int foundIdx = 0;
		int foundAtlasIdx = 0;
		Config.E_SpecialDayEventType foundType = Config.E_SpecialDayEventType.None;

		if (foundIdx > 0)
		{
			CurIdx = foundIdx;
			CurAtlasIdx = foundAtlasIdx;
			CurEventType = foundType;
		}
	}

	private void SetNextSpecialDay()
	{
		DateTime now = TimeSystem.GetCurTime();
		NextIdx = 0;
		NextStartTime = DateTime.MaxValue;

		if (NextIdx > 0)
		{
			int remainSec = (int)(NextStartTime - now).TotalSeconds;
			if (remainSec < 0) remainSec = 0;
			RemainNextTime.Value = remainSec;
		}
		else
		{
			RemainNextTime.Value = 0;
		}
	}

	public void UpdateOneSeconds()
	{
		if (CurIdx > 0 && RemainEndTime != null)
		{
			int remain = RemainEndTime.Value - 1;
			if (remain < 0) remain = 0;
			RemainEndTime.Value = remain;

			if (remain <= 0)
			{
				int beforeIdx = CurIdx;
				DoneSpecialDay(beforeIdx);
				SetCurSpecialDayIdx();
				SetNextSpecialDay();
			}
		}

		if (CurIdx <= 0 && NextIdx > 0 && RemainNextTime != null)
		{
			int remain = RemainNextTime.Value - 1;
			if (remain < 0) remain = 0;
			RemainNextTime.Value = remain;

			if (remain <= 0)
			{
				SetCurSpecialDayIdx();
				if (CurIdx > 0)
				{
					OpenSpecialDay();
				}
				SetNextSpecialDay();
			}
		}
	}

	private int GetStartTimeYear()
	{
		return CurStartTime.Year;
	}

	public bool IsSpecialDayEventType(Config.E_SpecialDayEventType eventType)
	{
		return CurIdx > 0 && CurEventType == eventType;
	}

	private void LoadSpecialTheme(Action tileLoadCb, Action stageLoadCb)
	{
		if (CurIdx <= 0)
		{
			tileLoadCb?.Invoke();
			stageLoadCb?.Invoke();
			return;
		}

		string tilePath = $"SpecialDay/bg_tile_{CurIdx}";
		var tileSprite = Resources.Load<Sprite>(tilePath);
		if (tileSprite != null)
		{
			BgTile = tileSprite;
		}
		tileLoadCb?.Invoke();

		stageLoadCb?.Invoke();
	}

	private void UpdateSpecialTheme()
	{
		if (CurIdx <= 0) return;

		UpdateLoadingTheme();
		UpdateStageTheme();
	}

	private void UpdateLoadingTheme()
	{
		UpdateLoadingThemeAfter();
	}

	private void UpdateLoadingThemeAfter()
	{
		if (CurIdx <= 0) return;
	}

	private void UpdateStageTheme()
	{
		if (CurIdx <= 0) return;
	}

	public int GetSpecialEmployeeViewIdx()
	{
		if (CurIdx <= 0) return 0;
		if (employeeMinIdx <= 0 || employeeMaxIdx <= 0) return 0;

		int range = employeeMaxIdx - employeeMinIdx + 1;
		if (range <= 0) return 0;

		int randomIdx = UnityEngine.Random.Range(0, range);
		return employeeMinIdx + randomIdx;
	}

	public bool CheckSpecialEmployeeViewIdx(int idx)
	{
		if (CurIdx <= 0) return false;
		return idx >= employeeMinIdx && idx <= employeeMaxIdx;
	}

	public int GetSpecialAddEmployeeViewIdx()
	{
		if (CurIdx <= 0) return 0;
		if (totalAddEmployeeRatio <= 0) return 0;

		int roll = UnityEngine.Random.Range(0, 100);
		if (roll < totalAddEmployeeRatio)
		{
			return GetSpecialEmployeeViewIdx();
		}
		return 0;
	}

	public bool CheckSpecialDayAtlas()
	{
		return CurIdx > 0 && CurAtlasIdx > 0;
	}

	public bool CheckSpecialDayDecoReward()
	{
		if (CurIdx <= 0) return false;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var specialDayData = gameRoot.UserData.SpecialDayData;
		if (specialDayData == null) return false;

		if (SpecialDayDecoIdxList == null || SpecialDayDecoIdxList.Count == 0) return false;

		if (specialDayData.SpecialDayDeco == null) return true;

		foreach (int decoIdx in SpecialDayDecoIdxList)
		{
			bool found = false;
			for (int i = 0; i < specialDayData.SpecialDayDeco.Count; i++)
			{
				if (specialDayData.SpecialDayDeco[i].ItemIdx == decoIdx)
				{
					found = true;
					break;
				}
			}
			if (!found) return true; // unclaimed deco exists
		}
		return false;
	}

	public void SetSpecialDayDecoReward(Action cb)
	{
		if (CurIdx <= 0)
		{
			cb?.Invoke();
			return;
		}

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null)
		{
			cb?.Invoke();
			return;
		}

		var specialDayData = gameRoot.UserData.SpecialDayData;
		if (specialDayData == null)
		{
			cb?.Invoke();
			return;
		}

		if (specialDayData.SpecialDayDeco == null)
			specialDayData.SpecialDayDeco = new List<ItemData>();

		if (SpecialDayDecoIdxList != null)
		{
			foreach (int decoIdx in SpecialDayDecoIdxList)
			{
				bool alreadyClaimed = false;
				for (int i = 0; i < specialDayData.SpecialDayDeco.Count; i++)
				{
					if (specialDayData.SpecialDayDeco[i].ItemIdx == decoIdx)
					{
						alreadyClaimed = true;
						break;
					}
				}

				if (!alreadyClaimed)
				{
					specialDayData.SpecialDayDeco.Add(new ItemData(decoIdx, 1));
				}
			}
		}

		LogSpecialDecoReward();
		cb?.Invoke();
	}

	private void LogSpecialDecoReward()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var specialDayData = gameRoot.UserData.SpecialDayData;
		if (specialDayData == null || specialDayData.SpecialDayDeco == null) return;

		Debug.Log($"[SpecialDay] Deco reward count: {specialDayData.SpecialDayDeco.Count}, CurIdx: {CurIdx}");
	}
}
