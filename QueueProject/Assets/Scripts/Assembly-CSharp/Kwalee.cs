using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWAudio;
using KWCore.SaveData;
using KWGameSettings;
using KWHaptics.Haptics;
using UnityEngine;

public class Kwalee
{
	[CompilerGenerated]
	private sealed class _003CInvokeRepeatingCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Action action;

		public int repetitions;

		public bool ignoreTimeScale;

		public float repeatRate;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CInvokeRepeatingCoroutine_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static int CurrentLevel => 0;

	public static int CurrentStage => 0;

	[Conditional("ADS")]
	public static void EnableBannerAds(bool enabled)
	{
	}

	public static void ShowRewardAd(string location, Action success, Action fail = null)
	{
	}

	public static long GetServerTimeUtcSeconds()
	{
		return 0L;
	}

	public static void ShowInterstitialAd(string location, Action finished = null, bool skipCoolDown = false)
	{
	}

	public static GameSettings GetGameSettings()
	{
		return null;
	}

	public static bool CheckCanPlay(Action closeCallback = null)
	{
		return false;
	}

	public static bool IsInAirplaneMode()
	{
		return false;
	}

	public static bool GetSubscribed()
	{
		return false;
	}

	public static bool ShowIAPS()
	{
		return false;
	}

	public static bool HasPurchasedNoAds()
	{
		return false;
	}

	public static string GetLocalisedText(string key, params object[] formatting)
	{
		var loc = KWCore.Umbrella.Localisation;
		if (loc == null) return key;
		string text = loc.GetLocalisedString(key);
		if (formatting != null && formatting.Length > 0)
		{
			try { text = string.Format(text, formatting); }
			catch { }
		}
		return text;
	}

	public static string GetLocalisedText(string key)
	{
		var loc = KWCore.Umbrella.Localisation;
		if (loc == null) return key;
		return loc.GetLocalisedString(key);
	}

	[Conditional("ANALYTICS")]
	public static void IncreaseRewardAdOfferedCount()
	{
	}

	[Conditional("AUDIO")]
	public static void PlaySFX(AudioClipReference clipRef, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, int channel = 2, float pitch = 1f)
	{
	}

	[Conditional("AUDIO")]
	public static void StopSFX(int channel = 2)
	{
	}

	public static AudioChannel GetChannel(int channel)
	{
		return null;
	}

	[Conditional("AUDIO")]
	public static void PlayMusic(AudioClipReference clipRef, ulong delay = 0uL, bool force = true, bool looping = false, Action callback = null, int channel = 1, float pitch = 1f)
	{
	}

	[Conditional("AUDIO")]
	public static void PlayOneShotSFX(AudioClipReference clip, float volume = 1f, int channel = 2, float pitch = 1f)
	{
	}

	[Conditional("AUDIO")]
	public static void PlayRandomOneShotSFX(AudioClipReference[] clips, float volume = 1f, int channel = 2, float pitch = 1f)
	{
	}

	[Conditional("AUDIO")]
	public static void PlayRandomOneShotSFX(AudioClipReference[] clips, float volumeMin = 0.5f, float volumeMax = 1f, int channel = 2, float pitchMin = 0.5f, float pitchMax = 1f)
	{
	}

	[Conditional("AUDIO")]
	public static void SetChannelVolume(int channel, float volume)
	{
	}

	[Conditional("AUDIO")]
	public static void SetChannelVolumeInTime(int channel, float volume, float time)
	{
	}

	public static void TriggerHaptics(HapticsManager.HapticType type)
	{
	}

	public static void TriggerHapticsBurst(int hapticBurstAmount = 15, float timeBetweenHapticsBurst = 0.1f, HapticsManager.HapticType hapticType = HapticsManager.HapticType.MEDIUM, bool useRealTime = false, Action onComplete = null)
	{
	}

	public static void RecordNewPlay()
	{
	}

	[Conditional("RATING")]
	public static void ShowRateUs()
	{
	}

	public static void ShowPopUpInfo(Action closedCallback, string overrideBodyText = null)
	{
	}

	public static void Save()
	{
	}

	public static T GetBucket<T>() where T : BucketBase
	{
		return null;
	}

	public static Coroutine Invoke(Action action, float delay, bool ignoreTimeScale = false)
	{
		return null;
	}

	public static Coroutine InvokeRepeating(Action action, float delay, float repeatRate, int repetitions = -1, bool ignoreTimeScale = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInvokeRepeatingCoroutine_003Ed__31))]
	private static IEnumerator InvokeRepeatingCoroutine(Action action, float delay, float repeatRate, int repetitions, bool ignoreTimeScale)
	{
		return null;
	}

	public static void StartStage(int stageNumber = -1, int levelNumber = -1, string levelId = "")
	{
	}

	public static void FailStage(int score = -1, int stageNumber = -1)
	{
	}

	public static bool CompleteStage(int levelSize = 1, int score = -1, int stageNumber = -1)
	{
		return false;
	}
}
