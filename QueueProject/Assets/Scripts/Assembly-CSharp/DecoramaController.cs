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

	public int RemainingPaintPoints => m_remainingPaintPoints;

	private void Awake()
	{
		DecoramaEvents.DecoramaBuildEvent += DecoramaEvents_OnDecoramaBuildEvent;
		DecoramaEvents.DecoramaQueuePreviewEvent += DecoramaEvents_OnDecoramaQueuePreviewEvent;
		DecoramaEvents.DecoramaUpdatedEvent += DecoramaEvents_OnDecoramaUpdatedEvent;
		DecoramaEvents.DecoramaSceneLoadedEvent += DecoramaEventsOnDecoramaSceneLoadedEvent;
	}

	private void OnDestroy()
	{
		DecoramaEvents.DecoramaBuildEvent -= DecoramaEvents_OnDecoramaBuildEvent;
		DecoramaEvents.DecoramaQueuePreviewEvent -= DecoramaEvents_OnDecoramaQueuePreviewEvent;
		DecoramaEvents.DecoramaUpdatedEvent -= DecoramaEvents_OnDecoramaUpdatedEvent;
		DecoramaEvents.DecoramaSceneLoadedEvent -= DecoramaEventsOnDecoramaSceneLoadedEvent;
	}

	private void PopulateProfileData(long amount)
	{
		m_pointsAmount = amount;
		m_remainingPaintPoints = (int)amount;
	}

	private void OnPaintStarted()
	{
		m_buildButtonPressed = true;
		if (m_paintCoroutine == null && m_remainingPaintPoints > 0 && m_activePaintable != null)
		{
			m_paintCoroutine = StartCoroutine(PaintDecorama());
		}
	}

	private void OnPaintStopped()
	{
		m_buildButtonPressed = false;
	}

	[IteratorStateMachine(typeof(_003CPaintDecorama_003Ed__30))]
	private IEnumerator PaintDecorama()
	{
		while (m_buildButtonPressed && m_remainingPaintPoints > 0 && m_activePaintable != null)
		{
			m_fillAmount = Mathf.Clamp(UnityEngine.Random.Range(m_minFillAmount, m_maxFillAmount + 1), 1, m_remainingPaintPoints);
			m_remainingPaintPoints -= m_fillAmount;

			bool completed = m_activePaintable.Paint(m_fillAmount);
			UpdateProgressDisplay();

			if (m_paintObjectSpawner != null)
			{
				var destination = m_activePaintable.PaintablePaintDestinationTransform;
				if (destination != null)
					m_paintObjectSpawner.SpawnPaintObject(destination.position, () => m_activePaintable?.OnParticleReached());
			}

			m_hapticTimer += Time.deltaTime;
			if (m_hapticTimer >= m_hapticDelay)
			{
				m_hapticTimer = 0f;
			}

			if (completed)
			{
				m_paintCoroutine = null;
				yield return StartCoroutine(PaintableCompleteFlow());
				yield break;
			}

			yield return new WaitForSeconds(m_fillDelay);
		}

		m_paintCoroutine = null;

		if (m_remainingPaintPoints <= 0)
			AllPaintPointsUsed();
	}

	[IteratorStateMachine(typeof(_003CPaintableCompleteFlow_003Ed__31))]
	private IEnumerator PaintableCompleteFlow()
	{
		m_nonPaintingFlowActive = true;

		if (m_activePaintable != null)
		{
			m_activePaintable.PlayPaintableComplete();
			if (DecoramaManager.Exist)
				DecoramaManager.Instance.SpawnPaintableCompleteVFX(m_activePaintable.transform.position);
		}

		yield return new WaitForSeconds(NEXT_PAINTABLE_CELEBRATION_DELAY);

		// Check if decorama is complete
		if (m_visibleDecorama != null && m_visibleDecorama.IsComplete())
		{
			yield return StartCoroutine(DecoramaCompleteFlow());
		}
		else
		{
			// Move to next paintable
			if (m_visibleDecorama != null)
				m_activePaintable = m_visibleDecorama.GetActivePaintable();

			yield return new WaitForSeconds(NEXT_PAINTABLE_PAINT_DELAY);

			if (m_activePaintable != null)
				m_activePaintable.TryShowWithIntro();
		}

		m_nonPaintingFlowActive = false;

		if (m_remainingPaintPoints <= 0)
			AllPaintPointsUsed();
	}

	[IteratorStateMachine(typeof(_003CDecoramaCompleteFlow_003Ed__32))]
	private IEnumerator DecoramaCompleteFlow()
	{
		if (m_visibleDecorama != null)
		{
			int decoramaIndex = m_visibleDecorama.DecoramaIndex;
			string decoramaID = m_visibleDecorama.DecoramaID;
			DecoramaEvents.SendDecoramaCompletedEvent(decoramaIndex, decoramaID);

			// Play completion animation on all paintables
			for (int i = 0; i < m_visibleDecorama.Paintables.Length; i++)
			{
				if (m_visibleDecorama.Paintables[i] != null)
					m_visibleDecorama.Paintables[i].PlayDecoramaComplete();
			}
		}

		yield return new WaitForSeconds(m_nextDecoramaDelay > 0 ? m_nextDecoramaDelay : 2f);

		// Move to next decorama
		if (m_decoramaQueue != null)
		{
			int nextAmount = PreSpawnNextAmount();
			m_decoramaQueue.RefocusDecoramas(nextAmount);
		}
	}

	private void UpdateProgressDisplay()
	{
		if (m_decoramaProgressDisplay != null && m_activePaintable != null)
			m_decoramaProgressDisplay.UpdateProgressDisplay(m_activePaintable);
	}

	private void AllPaintPointsUsed()
	{
		if (DecoramaManager.Exist)
			DecoramaManager.Instance.AllPaintPointsUsed();
	}

	private int PreSpawnNextAmount()
	{
		if (DecoramaManager.Exist)
			return DecoramaManager.Instance.DecoramaCount;
		return 0;
	}

	private void DecoramaEvents_OnDecoramaBuildEvent(bool pointerDown)
	{
		if (pointerDown)
			OnPaintStarted();
		else
			OnPaintStopped();
	}

	private void DecoramaEvents_OnDecoramaQueuePreviewEvent(bool leftPreview)
	{
		if (m_decoramaQueue == null) return;
		if (leftPreview)
			m_decoramaQueue.PreviewPrevious();
		else
			m_decoramaQueue.PreviewNext();
	}

	private void DecoramaEvents_OnDecoramaUpdatedEvent(Decorama visibleDecorama)
	{
		m_visibleDecorama = visibleDecorama;
		if (visibleDecorama != null)
			m_activePaintable = visibleDecorama.GetActivePaintable();
	}

	public void ForceState(DecoramaState stateToForce)
	{
		m_decoramaControllerState = stateToForce;
		DecoramaEvents.SendDecoramaUIStateChangedEvent(stateToForce);
	}

	private void DecoramaEventsOnDecoramaSceneLoadedEvent(DecoramaState decoramaState)
	{
		m_decoramaControllerState = decoramaState;
		if (decoramaState == DecoramaState.BUILD)
		{
			long points = DecoramaManager.Exist ? DecoramaManager.Instance.GetCachedDecoramaPoints() : 0;
			PopulateProfileData(points);
		}

		if (m_decoramaQueue != null)
			m_decoramaQueue.Config();

		if (m_paintObjectSpawner != null)
			m_paintObjectSpawner.CacheBuildButtonPosition();
	}
}
