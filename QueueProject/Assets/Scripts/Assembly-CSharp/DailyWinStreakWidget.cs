using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using DG.Tweening;
using TMPro;
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
		}

		internal void _003CCountWinStreak_003Eb__1()
		{
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
	private TextMeshProUGUI m_winStreakTMP;

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
		return null;
	}

	public void Configure(PopupDailyWinStreak.StreakState streakState, Action callback = null)
	{
	}

	public void StartBreakFlow(Action callback = null)
	{
	}

	public void PlayPipAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CWinStreakBreakFlow_003Ed__38))]
	private IEnumerator WinStreakBreakFlow()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCountWinStreak_003Ed__39))]
	private IEnumerator CountWinStreak(int from, int to, float duration = 2f, bool waitForBreakFlowDelay = false, Action callback = null)
	{
		return null;
	}

	private void PlayCountdownSfx()
	{
	}

	private void SetWinStreakColor(Color color)
	{
	}

	private void ConfigurePriceWidget()
	{
	}

	private void OnRepairStreakButtonClicked()
	{
	}

	private void RepairStreak()
	{
	}

	private void BringInStreak()
	{
	}

	[IteratorStateMachine(typeof(_003CBringInStreakCoroutine_003Ed__46))]
	private IEnumerator BringInStreakCoroutine()
	{
		return null;
	}

	public void FadeOut()
	{
	}

	private void OnDestroy()
	{
	}
}
