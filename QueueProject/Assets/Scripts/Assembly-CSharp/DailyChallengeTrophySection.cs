using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.KWDailyChallenge;
using Balancy.Models.SmartObjects;
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
	private Text m_progressBarText;

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
		GameplayEvents.DailyChallengeMonthChanged += OnMonthChanged;
	}

	private void OnDestroy()
	{
		GameplayEvents.DailyChallengeMonthChanged -= OnMonthChanged;
	}

	private void OnMonthChanged(int integer)
	{
		Config();
	}

	private void Start()
	{
		Config();
	}

	private void Config()
	{
		if (!DailyChallengeManager.Exist) return;

		DCDate selectedDate = DailyChallengeManager.Instance.SelectedDate;
		if (selectedDate == null) return;

		string clientId = QueensDailyChallenge.CLIENT_ID;
		m_daysCompleted = DailyChallengeManager.Instance.TotalDatesPlayedInMonthCount(clientId, selectedDate, true);
		m_lastSeenDaysCompleted = DailyChallengeManager.Instance.TotalDatesPlayedInMonthCount(clientId, selectedDate, false);

		m_monthTrophySprites = m_queensDailyChallenge != null
			? m_queensDailyChallenge.GetTrophySprites(selectedDate.year, selectedDate.month)
			: null;

		if (m_monthTrophySprites != null)
		{
			SetSprites(m_monthTrophySprites.bronze, m_monthTrophySprites.silver, m_monthTrophySprites.gold, m_monthTrophySprites.empty);
		}

		int currentTrophyIndex = DailyChallengeManager.Instance.GetCurrentTrophyIndex(clientId, m_daysCompleted, selectedDate);
		DailyChallengeManager.Instance.GetMinMaxForTrophy(clientId, selectedDate, currentTrophyIndex, out m_minForCurrentTrophy, out m_maxForCurrentTrophy);

		SetMiniTrophyIcon(currentTrophyIndex);

		float fillValue = GetCurrentTrophyFillValue(m_daysCompleted);
		SetProgressBar(fillValue, m_daysCompleted);

		if (currentTrophyIndex > 0)
		{
			for (int i = 0; i < currentTrophyIndex && i < 3; i++)
			{
				PlayCompletedTrophyAnimation(i);
			}
		}
		if (currentTrophyIndex < 3)
		{
			PlayActiveTrophyAnimation(currentTrophyIndex);
		}
	}

	private void SetMiniTrophyIcon(int trophyIndex)
	{
		if (m_miniTrophyIcon == null || m_monthTrophySprites == null) return;

		Sprite sprite;
		switch (trophyIndex)
		{
			case 0: sprite = m_monthTrophySprites.bronze; break;
			case 1: sprite = m_monthTrophySprites.silver; break;
			case 2: sprite = m_monthTrophySprites.gold; break;
			default: sprite = m_monthTrophySprites.gold; break;
		}
		if (sprite != null)
			m_miniTrophyIcon.sprite = sprite;
	}

	private void SetProgressBar(float fillValue, int value)
	{
		if (m_progressBar != null)
			m_progressBar.fillAmount = fillValue;
		if (m_progressBarText != null)
			m_progressBarText.text = value + "/" + m_maxForCurrentTrophy;
	}

	private void FlyEffects(int lastSeenDaysCompleted, int daysCompleted)
	{
		StartCoroutine(FlyEffectsCoroutine(lastSeenDaysCompleted, daysCompleted));
	}

	[IteratorStateMachine(typeof(_003CFlyEffectsCoroutine_003Ed__34))]
	private IEnumerator FlyEffectsCoroutine(int lastSeenDaysCompleted, int daysCompleted)
	{
		int count = daysCompleted - lastSeenDaysCompleted;
		float delay = 0.3f;

		for (int i = 0; i < count; i++)
		{
			int currentValue = lastSeenDaysCompleted + i + 1;
			string clientId = QueensDailyChallenge.CLIENT_ID;
			DCDate selectedDate = DailyChallengeManager.Instance.SelectedDate;
			int trophyIndex = DailyChallengeManager.Instance.GetCurrentTrophyIndex(clientId, currentValue, selectedDate);

			if (ShowProgress(lastSeenDaysCompleted + i, currentValue))
			{
				yield return StartCoroutine(UpdateProgressBar(lastSeenDaysCompleted + i, currentValue, 0.5f, trophyIndex));
			}

			yield return new WaitForSeconds(delay);
		}

		SendFlyEffectsCallback();
	}

	private bool ShowProgress(int lastValue, int finalValue)
	{
		if (m_progressBarGameObject == null) return false;

		if (!m_isShowingProgress)
		{
			m_isShowingProgress = true;
			m_progressBarGameObject.SetActive(true);
		}

		return lastValue != finalValue;
	}

	private void SendFlyEffectsCallback()
	{
		m_isShowingProgress = false;
		if (m_flyEffectsFinishCallback != null)
		{
			Action callback = m_flyEffectsFinishCallback;
			m_flyEffectsFinishCallback = null;
			callback.Invoke();
		}
	}

	[IteratorStateMachine(typeof(_003CUpdateProgressBar_003Ed__37))]
	private IEnumerator UpdateProgressBar(int startValue, int finalValue, float duration, int trophyIndex)
	{
		float startProgressValue = GetCurrentTrophyFillValue(startValue);
		float finalProgressValue = GetCurrentTrophyFillValue(finalValue);
		float time = 0f;

		while (time < duration)
		{
			time += Time.deltaTime;
			float t = Mathf.Clamp01(time / duration);
			float currentFill = Mathf.Lerp(startProgressValue, finalProgressValue, t);
			int currentDisplayValue = Mathf.RoundToInt(Mathf.Lerp(startValue, finalValue, t));
			SetProgressBar(currentFill, currentDisplayValue);
			yield return null;
		}

		SetProgressBar(finalProgressValue, finalValue);

		// Check if we reached a trophy milestone
		string clientId = QueensDailyChallenge.CLIENT_ID;
		DCDate selectedDate = DailyChallengeManager.Instance.SelectedDate;
		int prevTrophy = DailyChallengeManager.Instance.GetCurrentTrophyIndex(clientId, startValue, selectedDate);
		int newTrophy = DailyChallengeManager.Instance.GetCurrentTrophyIndex(clientId, finalValue, selectedDate);

		if (newTrophy > prevTrophy)
		{
			PlayCompletedTrophyAnimation(prevTrophy);
			if (newTrophy < 3)
			{
				PlayActiveTrophyAnimation(newTrophy);
			}
			DailyChallengeManager.Instance.GetMinMaxForTrophy(clientId, selectedDate, newTrophy, out m_minForCurrentTrophy, out m_maxForCurrentTrophy);
			SetMiniTrophyIcon(newTrophy);
		}
	}

	private void GiveReward(int trophyIndex, int nextValue, int nextFinalValue, Action<int, int> callback)
	{
		Reward reward = GetRewardForMonth(DailyChallengeManager.Instance.SelectedDate.month, trophyIndex);
		if (reward != null && RewardManager.Exist)
		{
			RewardManager.Instance.GiveRewards(reward, default(RewardManager.RewardOptions));
		}
		callback?.Invoke(nextValue, nextFinalValue);
	}

	private void SetSprites(Sprite bronzeTrophy, Sprite silverTrophy, Sprite goldTrophy, Sprite empty)
	{
		if (m_trophyBackgroundImages != null)
		{
			for (int i = 0; i < m_trophyBackgroundImages.Length; i++)
			{
				if (m_trophyBackgroundImages[i] != null && empty != null)
					m_trophyBackgroundImages[i].sprite = empty;
			}
		}

		if (m_trophyFillImages != null)
		{
			if (m_trophyFillImages.Length > 0 && m_trophyFillImages[0] != null && bronzeTrophy != null)
				m_trophyFillImages[0].sprite = bronzeTrophy;
			if (m_trophyFillImages.Length > 1 && m_trophyFillImages[1] != null && silverTrophy != null)
				m_trophyFillImages[1].sprite = silverTrophy;
			if (m_trophyFillImages.Length > 2 && m_trophyFillImages[2] != null && goldTrophy != null)
				m_trophyFillImages[2].sprite = goldTrophy;
		}
	}

	private void PlayActiveTrophyAnimation(int trophyIndex)
	{
		if (m_animatorHelper == null) return;

		string animName;
		switch (trophyIndex)
		{
			case 0: animName = ANIM_ANIM_TROPHYACTIVE_BRONZE; break;
			case 1: animName = ANIM_ANIM_TROPHYACTIVE_SILVER; break;
			case 2: animName = ANIM_ANIM_TROPHYACTIVE_GOLD; break;
			default: return;
		}
		m_animatorHelper.Play(animName);
	}

	private void PlayCompletedTrophyAnimation(int trophyIndex, Action callback = null)
	{
		if (m_animatorHelper == null)
		{
			callback?.Invoke();
			return;
		}

		string animName;
		switch (trophyIndex)
		{
			case 0: animName = ANIM_ANIM_TROPHYCOMPLETE_BRONZE; break;
			case 1: animName = ANIM_ANIM_TROPHYCOMPLETE_SILVER; break;
			case 2: animName = ANIM_ANIM_TROPHYCOMPLETE_GOLD; break;
			default:
				callback?.Invoke();
				return;
		}
		m_animatorHelper.Play(animName, callback);
	}

	private float GetCurrentTrophyFillValue(int daysCompleted)
	{
		if (m_maxForCurrentTrophy <= m_minForCurrentTrophy) return 1f;

		float progress = (float)(daysCompleted - m_minForCurrentTrophy) / (m_maxForCurrentTrophy - m_minForCurrentTrophy);
		progress = Mathf.Clamp01(progress);

		if (m_monthTrophySprites != null)
		{
			return Mathf.Lerp(m_monthTrophySprites.startFillValue, m_monthTrophySprites.completeFillValue, progress);
		}

		return progress;
	}

	public void RefreshWidget()
	{
		Config();
	}

	public Vector3 GetCurrentWorldPositionOnFillBar()
	{
		if (m_effectsLandingPoint != null)
			return m_effectsLandingPoint.position;
		if (m_progressBar != null)
			return m_progressBar.transform.position;
		return transform.position;
	}

	public static Reward GetRewardForMonth(int month, int trophyIndex)
	{
		// TrophyRewardData is from Balancy DLL - cannot resolve at compile time
		return null;
	}

	private static Reward GetTrophyReward(TrophyRewardData rewardSet, int trophyIndex)
	{
		if (rewardSet == null) return null;
		// TrophyRewardData is a Balancy type; access reward by trophy index
		return null;
	}

	public void StartProcess(Action finishCallback)
	{
		m_flyEffectsFinishCallback = finishCallback;

		if (m_daysCompleted > m_lastSeenDaysCompleted)
		{
			FlyEffects(m_lastSeenDaysCompleted, m_daysCompleted);
		}
		else
		{
			SendFlyEffectsCallback();
		}
	}

	public int GetPriority()
	{
		return 50;
	}

	public int GetUnlockLocationMask()
	{
		return 0xFFFF;
	}
}
