using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.KWDailyChallenge;
using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyChallengeTrophySection : MonoBehaviour, IQueueableEntity
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public DailyChallengeTrophySection _003C_003E4__this;

		public int lastSeenDaysCompleted;

		public int daysCompleted;

		public Action _003C_003E9__0;

		internal void _003CFlyEffectsCoroutine_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFlyEffectsCoroutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyChallengeTrophySection _003C_003E4__this;

		public int lastSeenDaysCompleted;

		public int daysCompleted;

		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		private int _003Ccount_003E5__2;

		private float _003Cdelay_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CFlyEffectsCoroutine_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CUpdateProgressBar_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int trophyIndex;

		public DailyChallengeTrophySection _003C_003E4__this;

		public int startValue;

		public int finalValue;

		public float duration;

		private float _003CstartProgressValue_003E5__2;

		private float _003CfinalProgressValue_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CUpdateProgressBar_003Ed__37(int _003C_003E1__state)
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

	public static bool s_isAutomatic;

	private const string ANIM_ANIM_TROPHYACTIVE_SILVER = "Anim-TrophyActive-Silver";

	private const string ANIM_ANIM_TROPHYACTIVE_BRONZE = "Anim-TrophyActive-Bronze";

	private const string ANIM_ANIM_TROPHYACTIVE_GOLD = "Anim-TrophyActive-Gold";

	private const string ANIM_ANIM_TROPHYCOMPLETE_BRONZE = "Anim-TrophyComplete-Bronze";

	private const string ANIM_ANIM_TROPHYCOMPLETE_SILVER = "Anim-TrophyComplete-Silver";

	private const string ANIM_ANIM_TROPHYCOMPLETE_GOLD = "Anim-TrophyComplete-Gold";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Image[] m_trophyBackgroundImages;

	[SerializeField]
	private Image[] m_trophyFillImages;

	[SerializeField]
	private Transform m_effectsLandingPoint;

	[SerializeField]
	private QueensDailyChallenge m_queensDailyChallenge;

	[SerializeField]
	private GameObject m_progressBarGameObject;

	[SerializeField]
	private Image m_progressBar;

	[SerializeField]
	private TMP_Text m_progressBarText;

	[SerializeField]
	private Image m_miniTrophyIcon;

	private int[] m_daysNeededForTrophies;

	private bool m_isShowingProgress;

	private int m_minForCurrentTrophy;

	private int m_maxForCurrentTrophy;

	private List<int> m_days;

	private QueensDailyChallenge.MonthTrophies m_monthTrophySprites;

	private bool m_isFirstTime;

	private int m_daysCompleted;

	private int m_lastSeenDaysCompleted;

	private Action m_flyEffectsFinishCallback;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnMonthChanged(int integer)
	{
	}

	private void Start()
	{
	}

	private void Config()
	{
	}

	private void SetMiniTrophyIcon(int trophyIndex)
	{
	}

	private void SetProgressBar(float fillValue, int value)
	{
	}

	private void FlyEffects(int lastSeenDaysCompleted, int daysCompleted)
	{
	}

	[IteratorStateMachine(typeof(_003CFlyEffectsCoroutine_003Ed__34))]
	private IEnumerator FlyEffectsCoroutine(int lastSeenDaysCompleted, int daysCompleted)
	{
		return null;
	}

	private bool ShowProgress(int lastValue, int finalValue)
	{
		return false;
	}

	private void SendFlyEffectsCallback()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateProgressBar_003Ed__37))]
	private IEnumerator UpdateProgressBar(int startValue, int finalValue, float duration, int trophyIndex)
	{
		return null;
	}

	private void GiveReward(int trophyIndex, int nextValue, int nextFinalValue, Action<int, int> callback)
	{
	}

	private void SetSprites(Sprite bronzeTrophy, Sprite silverTrophy, Sprite goldTrophy, Sprite empty)
	{
	}

	private void PlayActiveTrophyAnimation(int trophyIndex)
	{
	}

	private void PlayCompletedTrophyAnimation(int trophyIndex, Action callback = null)
	{
	}

	private float GetCurrentTrophyFillValue(int daysCompleted)
	{
		return 0f;
	}

	public void RefreshWidget()
	{
	}

	public Vector3 GetCurrentWorldPositionOnFillBar()
	{
		return default(Vector3);
	}

	public static Reward GetRewardForMonth(int month, int trophyIndex)
	{
		return null;
	}

	private static Reward GetTrophyReward(TrophyRewardData rewardSet, int trophyIndex)
	{
		return null;
	}

	public void StartProcess(Action finishCallback)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}
}
