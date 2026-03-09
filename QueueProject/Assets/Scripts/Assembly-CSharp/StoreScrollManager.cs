using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StoreScrollManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScroll_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float ratio;

		public StoreScrollManager _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CScroll_003Ed__6(int _003C_003E1__state)
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
	private float m_duration;

	[SerializeField]
	private Scrollbar m_scrollbar;

	[SerializeField]
	private RectTransform m_content;

	private float[] m_posses;

	internal void Initialise()
	{
	}

	internal void ScrollTo(int itemIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CScroll_003Ed__6))]
	private IEnumerator Scroll(float ratio)
	{
		return null;
	}
}
