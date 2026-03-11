using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using DG.Tweening;
using KWAudio;
using UnityEngine;
using UnityEngine.UI;

public class DailyWinStreakWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public DailyWinStreakWidget _003C_003E4__this;

		public int from;

		public int to;

		public Action callback;

		internal void _003CCountWinStreak_003Eb__0(int v)
		{
			if (_003C_003E4__this.m_winStreakTMP != null)
			{
				_003C_003E4__this.m_winStreakTMP.text = v.ToString();
			}
			_003C_003E4__this.PlayCountdownSfx();
		}

		internal void _003CCountWinStreak_003Eb__1()
		{
			callback?.Invoke();
		}
	}

	[CompilerGenerated]
	private sealed class _003CBringInStreakCoroutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyWinStreakWidget _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CBringInStreakCoroutine_003Ed__46(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
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

	[CompilerGenerated]
	private sealed class _003CCountWinStreak_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyWinStreakWidget _003C_003E4__this;

		public int from;

		public int to;

		public Action callback;

		public bool waitForBreakFlowDelay;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		public float duration;

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
		public _003CCountWinStreak_003Ed__39(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
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

	[CompilerGenerated]
	private sealed class _003CWinStreakBreakFlow_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyWinStreakWidget _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CWinStreakBreakFlow_003Ed__38(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
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

	private Tween m_winStreakTween;

	private const string ANIM_ANIM_DAYSTREAK_PROGRESS = "Anim-DayStreak-Progress";

	private const string ANIM_ANIM_DAYSTREAK_DEFAULT = "Anim-DayStreak-Default";

	private const string ANIM_ANIM_DAYSTREAK_STREAKLOST = "Anim-DayStreak-StreakLost";

	private const string ANIM_ANIM_REPAIRBUTTON_FADEIN = "Anim-RepairButton-FadeIn";

	private const string ANIM_ANIM_REPAIRBUTTON_FADEOUT = "Anim-RepairButton-FadeOut";

	private const string ANIM_ANIM_DAYSTREAK_FADEOUT = "Anim-DayStreak-FadeOut";

	private const string ANIM_ANIM_DAYSTREAK_FADEIN = "Anim-DayStreak-FadeIn";

	private const string MONDAY_KEY = "WeekDay.Monday";

	private const string TUESDAY_KEY = "WeekDay.Tuesday";

	private const string WEDNESDAY_KEY = "WeekDay.Wednesday";

	private const string THURSDAY_KEY = "WeekDay.Thursday";

	private const string FRIDAY_KEY = "WeekDay.Friday";

	private const string SATURDAY_KEY = "WeekDay.Saturday";

	private const string SUNDAY_KEY = "WeekDay.Sunday";

	private const float WIN_STREAK_BREAK_FLOW_DELAY = 0f;

	[SerializeField]
	private DailyWinStreakPip[] m_pips;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private AnimatorHelper m_streakRepairButtonAnimatorHelper;

	[SerializeField]
	private KwaleePriceWidget m_priceWidget;

	[SerializeField]
	private Button m_repairStreakButton;

	[SerializeField]
	private Text m_winStreakTMP;

	[SerializeField]
	private Color m_redColor;

	[SerializeField]
	private GameObject m_vfx;

	[SerializeField]
	private DailyWinStreakVisuals m_dailyWinStreakVisuals;

	private DailyWinStreakPip m_centrePip;

	private bool m_canAnimateTodayProgress;

	private KwaleePrice m_price;

	private int m_finalAmount;

	private int m_winStreak;

	private long m_lastWinTimestamp;

	private List<int> m_winStreakHistory;

	private Color m_defaultColor;

	private bool m_isStreakBroken;

	private string GetLocalisedDayName(DayOfWeek day)
	{
		switch (day)
		{
			case DayOfWeek.Monday: return Kwalee.GetLocalisedText(MONDAY_KEY);
			case DayOfWeek.Tuesday: return Kwalee.GetLocalisedText(TUESDAY_KEY);
			case DayOfWeek.Wednesday: return Kwalee.GetLocalisedText(WEDNESDAY_KEY);
			case DayOfWeek.Thursday: return Kwalee.GetLocalisedText(THURSDAY_KEY);
			case DayOfWeek.Friday: return Kwalee.GetLocalisedText(FRIDAY_KEY);
			case DayOfWeek.Saturday: return Kwalee.GetLocalisedText(SATURDAY_KEY);
			case DayOfWeek.Sunday: return Kwalee.GetLocalisedText(SUNDAY_KEY);
			default: return day.ToString();
		}
	}

	public void Configure(PopupDailyWinStreak.StreakState streakState, Action callback = null)
	{
		m_winStreak = BucketDailyWinStreak.WinStreak;
		m_lastWinTimestamp = BucketDailyWinStreak.LastWinTimestamp;
		m_winStreakHistory = BucketDailyWinStreak.WinStreakHistory ?? new List<int>();
		m_finalAmount = m_winStreak;
		m_isStreakBroken = false;

		if (m_winStreakTMP != null)
		{
			m_defaultColor = m_winStreakTMP.color;
			m_winStreakTMP.text = m_winStreak.ToString();
		}

		// Configure pips for each day of the week
		if (m_pips != null)
		{
			DayOfWeek today = DateTime.Now.DayOfWeek;
			// Start from Monday (index 0)
			DayOfWeek startDay = DayOfWeek.Monday;
			for (int i = 0; i < m_pips.Length; i++)
			{
				DayOfWeek pipDay = (DayOfWeek)(((int)startDay + i) % 7);
				string dayName = GetLocalisedDayName(pipDay);
				bool isToday = pipDay == today;
				DailyWinStreakPip.StreakPipState pipState = DailyWinStreakPip.StreakPipState.DEFAULT;

				if (i < m_winStreakHistory.Count)
				{
					pipState = m_winStreakHistory[i] > 0 ? DailyWinStreakPip.StreakPipState.COMPLETE : DailyWinStreakPip.StreakPipState.FAILED;
				}

				bool showProgress = isToday && streakState == PopupDailyWinStreak.StreakState.ANIMATE;
				m_pips[i].Configure(dayName, pipState, isToday, streakState, showProgress, null);

				if (isToday)
				{
					m_centrePip = m_pips[i];
				}
			}
		}

		if (m_dailyWinStreakVisuals != null)
		{
			m_dailyWinStreakVisuals.PlayStreakAnimation(m_winStreak);
		}

		if (streakState == PopupDailyWinStreak.StreakState.ANIMATE)
		{
			m_canAnimateTodayProgress = true;
			if (m_animatorHelper != null)
			{
				m_animatorHelper.Play(ANIM_ANIM_DAYSTREAK_PROGRESS);
			}
		}
		else if (streakState == PopupDailyWinStreak.StreakState.BREAK)
		{
			m_isStreakBroken = true;
			ConfigurePriceWidget();
		}
		else
		{
			if (m_animatorHelper != null)
			{
				m_animatorHelper.Play(ANIM_ANIM_DAYSTREAK_DEFAULT);
			}
		}

		if (m_vfx != null)
		{
			m_vfx.SetActive(streakState == PopupDailyWinStreak.StreakState.ANIMATE);
		}

		callback?.Invoke();
	}

	public void StartBreakFlow(Action callback = null)
	{
		m_isStreakBroken = true;
		StartCoroutine(WinStreakBreakFlow());
	}

	public void PlayPipAnimation()
	{
		if (m_centrePip != null)
		{
			m_centrePip.PlayProgressAnimation(m_canAnimateTodayProgress);
		}
	}

	[IteratorStateMachine(typeof(_003CWinStreakBreakFlow_003Ed__38))]
	private IEnumerator WinStreakBreakFlow()
	{
		if (WIN_STREAK_BREAK_FLOW_DELAY > 0f)
		{
			yield return new WaitForSeconds(WIN_STREAK_BREAK_FLOW_DELAY);
		}

		// Play streak lost animation
		if (m_animatorHelper != null)
		{
			m_animatorHelper.Play(ANIM_ANIM_DAYSTREAK_STREAKLOST);
		}

		SetWinStreakColor(m_redColor);

		// Count down from current streak to 0
		int previousStreak = m_winStreak;
		yield return CountWinStreak(previousStreak, 0, 2f, true, null);

		// Mark pips as failed
		if (m_pips != null)
		{
			for (int i = 0; i < m_pips.Length; i++)
			{
				if (m_pips[i].StreakPipCurrentState == DailyWinStreakPip.StreakPipState.COMPLETE)
				{
					m_pips[i].DepleteProgressBar();
				}
				yield return new WaitForSeconds(0.1f);
			}
		}

		// Show repair button
		ConfigurePriceWidget();

		if (m_streakRepairButtonAnimatorHelper != null)
		{
			m_streakRepairButtonAnimatorHelper.Play(ANIM_ANIM_REPAIRBUTTON_FADEIN);
		}

		if (m_repairStreakButton != null)
		{
			m_repairStreakButton.gameObject.SetActive(true);
		}
	}

	[IteratorStateMachine(typeof(_003CCountWinStreak_003Ed__39))]
	private IEnumerator CountWinStreak(int from, int to, float duration = 2f, bool waitForBreakFlowDelay = false, Action callback = null)
	{
		if (waitForBreakFlowDelay && WIN_STREAK_BREAK_FLOW_DELAY > 0f)
		{
			yield return new WaitForSeconds(WIN_STREAK_BREAK_FLOW_DELAY);
		}

		int steps = Mathf.Abs(to - from);
		if (steps == 0)
		{
			callback?.Invoke();
			yield break;
		}

		float stepDuration = duration / steps;
		int current = from;
		int direction = to > from ? 1 : -1;

		m_winStreakTween?.Kill();
		m_winStreakTween = DOTween.To(
			() => current,
			(int v) =>
			{
				current = v;
				if (m_winStreakTMP != null)
				{
					m_winStreakTMP.text = v.ToString();
				}
				PlayCountdownSfx();
			},
			to,
			duration
		).SetEase(Ease.Linear);

		yield return new WaitForSeconds(duration);

		if (m_winStreakTMP != null)
		{
			m_winStreakTMP.text = to.ToString();
		}
		m_finalAmount = to;
		callback?.Invoke();
	}

	private void PlayCountdownSfx()
	{
		var soundList = Resources.Load<AudioSoundList>("AudioSoundList");
		if (soundList != null && soundList.dailyStreakDown != null && soundList.dailyStreakDown.audioClip != null)
		{
			var cam = Camera.main;
			Vector3 pos = cam != null ? cam.transform.position : Vector3.zero;
			AudioSource.PlayClipAtPoint(soundList.dailyStreakDown.audioClip, pos);
		}
	}

	private void SetWinStreakColor(Color color)
	{
		if (m_winStreakTMP != null)
		{
			m_winStreakTMP.color = color;
		}
	}

	private void ConfigurePriceWidget()
	{
		if (m_priceWidget != null && m_price != null)
		{
			string label = Kwalee.GetLocalisedText(LocalisationKeys.DailyWinStreak_WinStreakRepair);
			m_priceWidget.Configure(m_price, label);
		}
	}

	private void OnRepairStreakButtonClicked()
	{
		if (m_repairStreakButton != null)
		{
			m_repairStreakButton.interactable = false;
		}
		RepairStreak();
	}

	private void RepairStreak()
	{
		// Restore the win streak to its previous value
		BucketDailyWinStreak.WinStreak = m_winStreak;
		DailyWinStreakHelper.MarkRepairedNow();

		m_isStreakBroken = false;

		// Hide repair button
		if (m_streakRepairButtonAnimatorHelper != null)
		{
			m_streakRepairButtonAnimatorHelper.Play(ANIM_ANIM_REPAIRBUTTON_FADEOUT);
		}

		BringInStreak();

		GameplayEvents.SendWinStreakUpdated();
	}

	private void BringInStreak()
	{
		StartCoroutine(BringInStreakCoroutine());
	}

	[IteratorStateMachine(typeof(_003CBringInStreakCoroutine_003Ed__46))]
	private IEnumerator BringInStreakCoroutine()
	{
		// Fade in the streak display
		if (m_animatorHelper != null)
		{
			m_animatorHelper.Play(ANIM_ANIM_DAYSTREAK_FADEIN);
		}

		yield return new WaitForSeconds(0.5f);

		// Restore pips with shield animation
		if (m_pips != null)
		{
			for (int i = 0; i < m_pips.Length; i++)
			{
				if (i < m_winStreakHistory.Count && m_winStreakHistory[i] > 0)
				{
					m_pips[i].FillProgressBar();
					m_pips[i].PlayShieldAnimation();
					yield return new WaitForSeconds(0.1f);
				}
			}
		}

		// Count back up to the restored streak
		SetWinStreakColor(m_defaultColor);
		yield return CountWinStreak(0, m_winStreak, 1.5f, false, null);

		if (m_dailyWinStreakVisuals != null)
		{
			m_dailyWinStreakVisuals.PlayStreakAnimation(m_winStreak);
		}
	}

	public void FadeOut()
	{
		if (m_animatorHelper != null)
		{
			m_animatorHelper.Play(ANIM_ANIM_DAYSTREAK_FADEOUT);
		}
	}

	private void OnDestroy()
	{
		m_winStreakTween?.Kill();
		m_winStreakTween = null;
	}
}
