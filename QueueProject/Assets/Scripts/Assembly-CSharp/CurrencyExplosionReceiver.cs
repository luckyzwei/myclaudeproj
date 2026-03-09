using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWHaptics.Haptics;
using KWUserInterface;
using UnityEngine;
using UnityEngine.Events;

public class CurrencyExplosionReceiver : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPunchTarget_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyExplosionReceiver _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private float _003CpunchTimer_003E5__3;

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
		public _003CPunchTarget_003Ed__26(int _003C_003E1__state)
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

	[SerializeField]
	private string m_assignedClientId;

	[Header("Optional - Coin Widget")]
	[SerializeField]
	private CoinWidget m_referencedCoinWidget;

	[Header("Punch values")]
	[SerializeField]
	private Transform m_punchTransform;

	[SerializeField]
	private float m_totalPunchDuration;

	[SerializeField]
	private float m_punchEveryX;

	[SerializeField]
	private float m_singlePunchDuration;

	[SerializeField]
	private bool m_useUnscaledTime;

	[SerializeField]
	private float m_punchMulti;

	[SerializeField]
	private UnityEvent m_startReceivingEvent;

	[SerializeField]
	private UnityEvent m_finishReceivingEvent;

	private int m_pauseBankStack;

	private HapticsTickerComponent m_hapticsTickerComponent;

	[SerializeField]
	private bool m_allowReparenting;

	public string ClientID => null;

	public bool AllowReparenting => false;

	public UnityEvent StartReceivingEvent => null;

	public UnityEvent FinishReceivingEvent => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetClientID(string clientID)
	{
	}

	public void OnFirstElementReached()
	{
	}

	public void ToggleBankPauseState(bool pauseState)
	{
	}

	[IteratorStateMachine(typeof(_003CPunchTarget_003Ed__26))]
	public IEnumerator PunchTarget()
	{
		return null;
	}

	private void ResetPunchScale()
	{
	}
}
