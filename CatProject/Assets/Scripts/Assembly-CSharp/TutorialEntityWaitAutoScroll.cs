using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class TutorialEntityWaitAutoScroll : TutorialEntity
{
	public enum popupType
	{

	}

	[CompilerGenerated]
	private sealed class _003CWaitPopup_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityWaitAutoScroll _003C_003E4__this;

		private UIBase _003CbasePopup_003E5__2;

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
		public _003CWaitPopup_003Ed__8(int _003C_003E1__state)
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

	public popupType popup;

	public float duration;

	public float delay;

	private ScrollRect scrollRect;

	private RectTransform TargetTr;

	private Vector3 DoctorInventoryPos;

	public override void StartEntity()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitPopup_003Ed__8))]
	private IEnumerator WaitPopup()
	{
		return null;
	}
}
