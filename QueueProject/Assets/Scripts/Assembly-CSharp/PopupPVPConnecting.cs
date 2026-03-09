using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;

public class PopupPVPConnecting : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CChangeTexts_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupPVPConnecting _003C_003E4__this;

		private ConfigParams.FakePVP _003Csettings_003E5__2;

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
		public _003CChangeTexts_003Ed__5(int _003C_003E1__state)
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

	public const string PREFAB_NAME = "Prefabs/PopUps/Popup-PVP-Connecting";

	[SerializeField]
	private WidgetChallengePVP m_challengeWidget;

	[SerializeField]
	private GameObject m_connectingText;

	[SerializeField]
	private GameObject m_startingGameText;

	protected void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeTexts_003Ed__5))]
	protected IEnumerator ChangeTexts()
	{
		return null;
	}
}
