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
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CWaitPopup_003Ed__8(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					// Wait for delay
					if (_003C_003E4__this.delay > 0f)
					{
						_003C_003E2__current = new WaitForSeconds(_003C_003E4__this.delay);
						_003C_003E1__state = 1;
						return true;
					}
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					// Auto scroll to target
					if (_003C_003E4__this.scrollRect != null && _003C_003E4__this.TargetTr != null)
					{
						// Scroll to target position
					}
					_003C_003E2__current = new WaitForSeconds(_003C_003E4__this.duration);
					_003C_003E1__state = 2;
					return true;
				case 2:
					_003C_003E1__state = -1;
					_003C_003E4__this.Done();
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
		base.StartEntity();
		StartCoroutine(WaitPopup());
	}

	[IteratorStateMachine(typeof(_003CWaitPopup_003Ed__8))]
	private IEnumerator WaitPopup()
	{
		var d = new _003CWaitPopup_003Ed__8(0);
		d._003C_003E4__this = this;
		return d;
	}
}
