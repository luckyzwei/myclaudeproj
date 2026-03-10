using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine;

public class LifeSystemManager : MonoSingleton<LifeSystemManager>
{
	public delegate void LifeDelegate(int newLifeCount);

	[CompilerGenerated]
	private sealed class _003CGiveLives_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public LifeSystemManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CGiveLives_003Ed__24(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = new WaitForSeconds(1f);
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E4__this.CheckLivesToGive();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset() { }
	}

	[CompilerGenerated]
	private sealed class _003CInfiniteLivesCountdown_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public LifeSystemManager _003C_003E4__this;
		private long _003CinfiniteLivesRemainingSeconds_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CInfiniteLivesCountdown_003Ed__50(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003CinfiniteLivesRemainingSeconds_003E5__2 = _003C_003E4__this.GetInfiniteLivesRemainingSeconds();
					goto case 1;
				case 1:
					if (_003CinfiniteLivesRemainingSeconds_003E5__2 > 0)
					{
						_003C_003E2__current = new WaitForSeconds(1f);
						_003C_003E1__state = 1;
						_003CinfiniteLivesRemainingSeconds_003E5__2--;
						return true;
					}
					_003C_003E1__state = -1;
					SendInfiniteLivesExpired();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset() { }
	}

	public const string LIFE_ITEM_ID = "life";

	public const string INFINITE_LIVES_ID = "infinite_lives";

	private const int MAX_LIVES = 5;
	private const int LIFE_REGEN_SECONDS = 1800; // 30 minutes

	private Coroutine m_giveLivesCoroutine;

	private Coroutine m_infiniteLivesCoroutine;

	private bool m_initialCheckComplete;

	private static LifeDelegate _LivesValueChanged;
	public static event LifeDelegate LivesValueChanged
	{
		add { _LivesValueChanged += value; }
		remove { _LivesValueChanged -= value; }
	}

	private static GameplayEvents.BasicDelegate _InfiniteLivesExpired;
	public static event GameplayEvents.BasicDelegate InfiniteLivesExpired
	{
		add { _InfiniteLivesExpired += value; }
		remove { _InfiniteLivesExpired -= value; }
	}

	private static GameplayEvents.BasicDelegate _InfiniteLivesStarted;
	public static event GameplayEvents.BasicDelegate InfiniteLivesStarted
	{
		add { _InfiniteLivesStarted += value; }
		remove { _InfiniteLivesStarted -= value; }
	}

	public static void SendLivesValueChanged(int newLifeCount)
	{
		_LivesValueChanged?.Invoke(newLifeCount);
	}

	public static void SendInfiniteLivesExpired()
	{
		_InfiniteLivesExpired?.Invoke();
	}

	public static void SendInfiniteLivesStarted()
	{
		_InfiniteLivesStarted?.Invoke();
	}

	private void UnSubscribe()
	{
		KWCore.Events.CoreEvents.OnSplashScreenCompleted -= CoreEventsOnOnSplashScreenCompleted;
	}

	protected override void Init()
	{
		KWCore.Events.CoreEvents.OnSplashScreenCompleted += CoreEventsOnOnSplashScreenCompleted;
	}

	private void CoreEventsOnOnSplashScreenCompleted()
	{
		TryInitialCheck();
	}

	private void TryInitialCheck()
	{
		if (m_initialCheckComplete) return;
		m_initialCheckComplete = true;

		// Initialize lives if not set
		if (!PlayerPrefs.HasKey("lives_count"))
		{
			PlayerPrefs.SetInt("lives_count", MAX_LIVES);
			PlayerPrefs.Save();
		}

		CheckInfiniteLives();
		TryGiveLives();
	}

	public void OnProfileLoaded()
	{
		TryInitialCheck();
	}

	private void TryGiveLives()
	{
		if (!CanAutoRegenerateLives()) return;
		if (NumLives() >= MAX_LIVES) return;

		if (m_giveLivesCoroutine != null)
			StopCoroutine(m_giveLivesCoroutine);
		m_giveLivesCoroutine = StartCoroutine(GiveLives());
	}

	[IteratorStateMachine(typeof(_003CGiveLives_003Ed__24))]
	private IEnumerator GiveLives()
	{
		var d = new _003CGiveLives_003Ed__24(0);
		d._003C_003E4__this = this;
		return d;
	}

	private void OnSmartObjectsInitializedEvent()
	{
		TryInitialCheck();
	}

	private void OnBalancyProfileReset()
	{
		SetFullLives();
	}

	private void CheckLivesToGive()
	{
		if (!IsEnabled()) return;
		if (DoesHaveInfiniteLives()) return;

		long lastLossTime = PlayerPrefs.GetInt("last_life_loss_time", 0);
		long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		long elapsed = now - lastLossTime;

		int currentLives = NumLives();
		if (currentLives < MAX_LIVES && elapsed >= LIFE_REGEN_SECONDS)
		{
			int livesToAdd = (int)(elapsed / LIFE_REGEN_SECONDS);
			livesToAdd = Math.Min(livesToAdd, MAX_LIVES - currentLives);
			if (livesToAdd > 0)
			{
				AddLives(livesToAdd);
				SetGameLossTime(now);
			}
		}
	}

	public long GetSecondsUntilNextLife()
	{
		if (NumLives() >= MAX_LIVES) return 0;
		long lastLossTime = PlayerPrefs.GetInt("last_life_loss_time", 0);
		long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		long elapsed = now - lastLossTime;
		long remaining = LIFE_REGEN_SECONDS - (elapsed % LIFE_REGEN_SECONDS);
		return remaining;
	}

	private void OnNewLifeAdded(Item item, int count, int slotindex)
	{
		AddLives(count);
	}

	public void AddInfiniteLives(long seconds)
	{
		long expiry = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + seconds;
		PlayerPrefs.SetString("infinite_lives_expiry", expiry.ToString());
		PlayerPrefs.Save();
		SendInfiniteLivesStarted();
		CountdownInfiniteLivesTime();
	}

	private void OnInfiniteLivesAdded(Item item, int count, int slotindex)
	{
		AddInfiniteLives(count * 3600); // count in hours
	}

	private void SetFullLives()
	{
		PlayerPrefs.SetInt("lives_count", MAX_LIVES);
		PlayerPrefs.Save();
		SendLivesValueChanged(MAX_LIVES);
	}

	private void OnItemWasRemoved(Item item, int count, int slotindex)
	{
		if (item != null && item.UnnyId == LIFE_ITEM_ID)
			RemoveLives(count);
	}

	public bool IsEnabled()
	{
		return true;
	}

	public bool DoesHaveLives()
	{
		return DoesHaveInfiniteLives() || NumLives() > 0;
	}

	public bool CheckCanPlay(bool showPopUp = true, Action onPopUpClosed = null)
	{
		if (DoesHaveInfiniteLives()) return true;
		if (NumLives() > 0) return true;

		if (showPopUp)
		{
			GameplayEvents.SendRanOutOfHearts();
		}
		return false;
	}

	public int NumLives()
	{
		return PlayerPrefs.GetInt("lives_count", MAX_LIVES);
	}

	public bool CanAutoRegenerateLives()
	{
		return IsEnabled() && NumLives() < MAX_LIVES && !DoesHaveInfiniteLives();
	}

	public void AddLives(int amountToAdd = 1)
	{
		int current = NumLives();
		int newCount = Math.Min(current + amountToAdd, MAX_LIVES);
		PlayerPrefs.SetInt("lives_count", newCount);
		PlayerPrefs.Save();
		SendLivesValueChanged(newCount);
	}

	public void RemoveLives(int amountToRemove = 1)
	{
		int current = NumLives();
		int newCount = Math.Max(current - amountToRemove, 0);
		PlayerPrefs.SetInt("lives_count", newCount);
		PlayerPrefs.Save();
		SendLivesValueChanged(newCount);

		if (newCount <= 0)
			IncreaseSequentialLivesLost(amountToRemove);
	}

	private void IncreaseSequentialLivesLost(int numLost)
	{
		int current = PlayerPrefs.GetInt("sequential_lives_lost", 0);
		PlayerPrefs.SetInt("sequential_lives_lost", current + numLost);
		PlayerPrefs.Save();
	}

	public void ResetSequentialLivesLost()
	{
		PlayerPrefs.SetInt("sequential_lives_lost", 0);
		PlayerPrefs.Save();
	}

	private void SetGameLossTime(long time)
	{
		PlayerPrefs.SetString("last_life_loss_time", time.ToString());
		PlayerPrefs.Save();
	}

	public void ShowLifeLossWarningPopUp(Action onPopUpDismissed, Action onReplayPressed, Action onHomePressed)
	{
		// Show warning popup - simplified
		onPopUpDismissed?.Invoke();
	}

	public void ShowLifeLostPopUp(Action onReplayPressed, Action onHomePressed)
	{
		// Show life lost popup - simplified
		onHomePressed?.Invoke();
	}

	private void CheckInfiniteLives()
	{
		if (DoesHaveInfiniteLives())
			CountdownInfiniteLivesTime();
	}

	public bool DoesHaveInfiniteLives()
	{
		string expiryStr = PlayerPrefs.GetString("infinite_lives_expiry", "0");
		if (long.TryParse(expiryStr, out long expiry))
		{
			long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			return now < expiry;
		}
		return false;
	}

	public long GetInfiniteLivesRemainingSeconds()
	{
		string expiryStr = PlayerPrefs.GetString("infinite_lives_expiry", "0");
		if (long.TryParse(expiryStr, out long expiry))
		{
			long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			long remaining = expiry - now;
			return remaining > 0 ? remaining : 0;
		}
		return 0;
	}

	private void CountdownInfiniteLivesTime()
	{
		if (m_infiniteLivesCoroutine != null)
			StopCoroutine(m_infiniteLivesCoroutine);
		m_infiniteLivesCoroutine = StartCoroutine(InfiniteLivesCountdown());
	}

	[IteratorStateMachine(typeof(_003CInfiniteLivesCountdown_003Ed__50))]
	private IEnumerator InfiniteLivesCountdown()
	{
		var d = new _003CInfiniteLivesCountdown_003Ed__50(0);
		d._003C_003E4__this = this;
		return d;
	}

	public void SetGameLost()
	{
		RemoveLives(1);
		SetGameLossTime(DateTimeOffset.UtcNow.ToUnixTimeSeconds());
		TryGiveLives();
	}
}
