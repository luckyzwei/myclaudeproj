using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StoreContentAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateIn_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool hideFirst;

		public StoreContentAnimator _003C_003E4__this;

		public float normalisedTime;

		public float delay;

		private int _003Ci_003E5__2;

		private int _003Cj_003E5__3;

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
		public _003CAnimateIn_003Ed__8(int _003C_003E1__state)
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

	private const string ANIM_IN = "Intro";

	private const string ANIM_HIDDEN = "Hidden";

	private const float IN_DELAY = 0.005f;

	private List<List<Animator>> m_animators;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void CacheAndAnimateIn(bool hideFirst, float normalisedTime = 0f, float delay = 0.005f)
	{
	}

	private void CacheAnimators()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateIn_003Ed__8))]
	private IEnumerator AnimateIn(bool hideFirst = false, float normalisedTime = 0f, float delay = 0.005f)
	{
		return null;
	}
}
