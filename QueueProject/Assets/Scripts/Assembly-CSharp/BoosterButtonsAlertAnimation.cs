using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoosterButtonsAlertAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayAlertAnimationCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public BoosterButtonsAlertAnimation _003C_003E4__this;
		private float _003Cdelay_003E5__2;
		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CPlayAlertAnimationCoroutine_003Ed__12(int _003C_003E1__state)
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
					_003Cdelay_003E5__2 = 0.15f;
					_003Ci_003E5__3 = 0;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.m_boosterButtons != null &&
						_003Ci_003E5__3 < _003C_003E4__this.m_boosterButtons.Count)
					{
						var btn = _003C_003E4__this.m_boosterButtons[_003Ci_003E5__3];
						if (btn != null) btn.PlayAlertAnimation();
						_003Ci_003E5__3++;
						_003C_003E2__current = new WaitForSeconds(_003Cdelay_003E5__2);
						_003C_003E1__state = 1;
						return true;
					}
					_003C_003E4__this.m_alertInProgress = false;
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext() { return this.MoveNext(); }

		[DebuggerHidden]
		void IEnumerator.Reset() { }
	}

	private List<BoosterButton> m_boosterButtons;

	private bool m_alertEnabled;

	private bool m_alertInProgress;

	private float m_lastTapTime;

	private void Awake()
	{
		m_boosterButtons = new List<BoosterButton>();
	}

	private void OnDestroy()
	{
		GameplayEvents.GridIntroDone -= OnLevelStart;
	}

	public void AddBoosterButton(BoosterButton button)
	{
		if (button != null && !m_boosterButtons.Contains(button))
			m_boosterButtons.Add(button);
	}

	private void OnLevelStart()
	{
		m_alertEnabled = true;
		m_lastTapTime = Time.time;
	}

	private void OnQueenMarked(int obj)
	{
		m_lastTapTime = Time.time;
	}

	private void OnLifeLost(int obj)
	{
		m_lastTapTime = Time.time;
		// Trigger alert after life lost
		PlayAlertAnimation();
	}

	private void Update()
	{
		if (!m_alertEnabled || m_alertInProgress) return;

		// Play alert if player hasn't interacted for a while
		if (Time.time - m_lastTapTime > 10f)
		{
			PlayAlertAnimation();
			m_lastTapTime = Time.time;
		}
	}

	private void PlayAlertAnimation()
	{
		if (m_alertInProgress) return;
		m_alertInProgress = true;
		StartCoroutine(PlayAlertAnimationCoroutine());
	}

	[IteratorStateMachine(typeof(_003CPlayAlertAnimationCoroutine_003Ed__12))]
	private IEnumerator PlayAlertAnimationCoroutine()
	{
		var d = new _003CPlayAlertAnimationCoroutine_003Ed__12(0);
		d._003C_003E4__this = this;
		return d;
	}
}
