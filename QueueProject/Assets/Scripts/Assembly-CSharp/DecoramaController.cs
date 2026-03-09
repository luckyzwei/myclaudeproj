using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DecoramaController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public DecoramaController _003C_003E4__this;

		public Decorama currentDecorama;
	}

	[CompilerGenerated]
	private sealed class _003CDecoramaCompleteFlow_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoramaController _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CDecoramaCompleteFlow_003Ed__32(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPaintDecorama_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoramaController _003C_003E4__this;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

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
		public _003CPaintDecorama_003Ed__30(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPaintableCompleteFlow_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoramaController _003C_003E4__this;

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
		public _003CPaintableCompleteFlow_003Ed__31(int _003C_003E1__state)
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

	private const float NEXT_PAINTABLE_CELEBRATION_DELAY = 1.5f;

	private const float NEXT_PAINTABLE_PAINT_DELAY = 0.5f;

	[SerializeField]
	private Camera m_decoramaRenderCamera;

	[SerializeField]
	private DecoramaProgressDisplay m_decoramaProgressDisplay;

	[Header("Filling")]
	[SerializeField]
	private int m_minFillAmount;

	[SerializeField]
	private int m_maxFillAmount;

	[SerializeField]
	private float m_fillDelay;

	[SerializeField]
	private float m_hapticDelay;

	[Header("Next Decorama Transition")]
	[SerializeField]
	private float m_nextPaintableDelay;

	[SerializeField]
	private float m_nextDecoramaDelay;

	[SerializeField]
	private bool m_autoSpendPoints;

	private DecoramaQueue m_decoramaQueue;

	private PaintObjectSpawner m_paintObjectSpawner;

	private Coroutine m_paintCoroutine;

	private bool m_nonPaintingFlowActive;

	private Decorama m_visibleDecorama;

	private DecoramaPaintable m_activePaintable;

	private DecoramaState m_decoramaControllerState;

	private float m_hapticTimer;

	private int m_remainingPaintPoints;

	private bool m_buildButtonPressed;

	private long m_pointsAmount;

	private int m_fillAmount;

	public int RemainingPaintPoints => 0;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void PopulateProfileData(long amount)
	{
	}

	private void OnPaintStarted()
	{
	}

	private void OnPaintStopped()
	{
	}

	[IteratorStateMachine(typeof(_003CPaintDecorama_003Ed__30))]
	private IEnumerator PaintDecorama()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPaintableCompleteFlow_003Ed__31))]
	private IEnumerator PaintableCompleteFlow()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDecoramaCompleteFlow_003Ed__32))]
	private IEnumerator DecoramaCompleteFlow()
	{
		return null;
	}

	private void UpdateProgressDisplay()
	{
	}

	private void AllPaintPointsUsed()
	{
	}

	private int PreSpawnNextAmount()
	{
		return 0;
	}

	private void DecoramaEvents_OnDecoramaBuildEvent(bool pointerDown)
	{
	}

	private void DecoramaEvents_OnDecoramaQueuePreviewEvent(bool leftPreview)
	{
	}

	private void DecoramaEvents_OnDecoramaUpdatedEvent(Decorama visibleDecorama)
	{
	}

	public void ForceState(DecoramaState stateToForce)
	{
	}

	private void DecoramaEventsOnDecoramaSceneLoadedEvent(DecoramaState decoramaState)
	{
	}
}
