using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LifeCounterWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartingSequence_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LifeCounterWidget _003C_003E4__this;

		private int _003CalreadyLostLives_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CStartingSequence_003Ed__14(int _003C_003E1__state)
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

	private const string ANIM_LOST = "Lost";

	private const string ANIM_DEFAULT = "Default";

	[SerializeField]
	private HeartWidget m_heartPrefab;

	[SerializeField]
	private Transform m_heartContainer;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private bool m_configLostHeartsWithLoseAnimation;

	private List<HeartWidget> m_hearts;

	private int m_lifeIndex;

	private AnimatorHelper m_animatorHelper;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void LifeLostEvent()
	{
	}

	public void Configure(int nLifes)
	{
	}

	[IteratorStateMachine(typeof(_003CStartingSequence_003Ed__14))]
	private IEnumerator StartingSequence()
	{
		return null;
	}

	public void Disable()
	{
	}

	public void Hide(float duration = 0f)
	{
	}

	public void Show(float duration)
	{
	}
}
