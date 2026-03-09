using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableDirectorHelper : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimationCallback_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayableDirectorHelper _003C_003E4__this;

		private double _003Cduration_003E5__2;

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
		public _003CAnimationCallback_003Ed__7(int _003C_003E1__state)
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
	private DirectorWrapMode m_animationMode;

	private PlayableDirector m_director;

	private Action m_doneCallback;

	private bool m_playing;

	private void Awake()
	{
	}

	public void Play(Action callback = null)
	{
	}

	public void Stop()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimationCallback_003Ed__7))]
	private IEnumerator AnimationCallback()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
