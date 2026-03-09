using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class FakeOnlineDisconectionPopup : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CReconnectLoop_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FakeOnlineDisconectionPopup _003C_003E4__this;

		private float _003Celapsed_003E5__2;

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
		public _003CReconnectLoop_003Ed__11(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-FakeOnlineDisconection";

	private const float RECONNECT_DELAY = 10f;

	private const float CHECK_INTERVAL = 0.5f;

	private Action m_internetRecovered;

	private Action m_cancelledRetry;

	[SerializeField]
	private Button m_cancelButton;

	public static bool TryShow(Action internetRecovered, Action cancelledRetry)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Configure(Action internetRecovered, Action cancelledRetry)
	{
	}

	public void OnCancelPressed()
	{
	}

	private void SetCancelButtonVisible(bool visible)
	{
	}

	[IteratorStateMachine(typeof(_003CReconnectLoop_003Ed__11))]
	private IEnumerator ReconnectLoop()
	{
		return null;
	}
}
