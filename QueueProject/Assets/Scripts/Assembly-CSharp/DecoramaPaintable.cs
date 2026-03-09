using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Data.KWDecorama;
using Balancy.Models.KWDecorama;
using UnityEngine;

[RequireComponent(typeof(DecoramaPaintableTweener))]
public class DecoramaPaintable : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFillCoroutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoramaPaintable _003C_003E4__this;

		public float value;

		public float time;

		private float _003CoriginalFill_003E5__2;

		private float _003Ctarget_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CFillCoroutine_003Ed__50(int _003C_003E1__state)
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

	private static readonly int FILL_VALUE;

	private static readonly int COMPLETE_VALUE;

	[Header("Identifiers")]
	[SerializeField]
	private string m_paintableID;

	[Header("Rendering")]
	[SerializeField]
	private Renderer[] m_paintableRenderers;

	[SerializeField]
	private Animator[] m_paintableAnimators;

	[SerializeField]
	private ParticleSystem[] m_paintableParticleSystems;

	[SerializeField]
	private Transform m_paintablePointerPositionTransform;

	[SerializeField]
	private Transform paintablePaintPaintDestinationTransform;

	private Vector3[] m_rendererScales;

	private float m_paintedPercentage;

	private int m_paintableRequirement;

	private int m_currentPaintedAmount;

	private int m_recievedPaintPoints;

	private bool m_isComplete;

	private bool m_decoramaTweenPlayed;

	private bool m_paintableTweenPlayed;

	private string m_parentDecoramaID;

	private float m_lastPunchTime;

	private bool m_introPlayed;

	private DecoramaPaintableTweener m_decoramaPaintableTweener;

	public Transform PaintablePointerPositionTransform => null;

	public Transform PaintablePaintDestinationTransform => null;

	public bool IsComplete => false;

	public string PaintableID => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void ConfigPaintable(string decoramaID, PaintableData paintableData)
	{
	}

	public void TryShowWithIntro()
	{
	}

	private PaintableProfileData GetPaintableProfileData()
	{
		return null;
	}

	private void SetupRequirement(PaintableData paintableData)
	{
	}

	public int RequiredAmount()
	{
		return 0;
	}

	public int PaintPointsNeededToCompleteVisuals()
	{
		return 0;
	}

	public void SetupPaintablePointerPositionTransform(float yOffset)
	{
	}

	public void SetupPaintableDestinationTransform()
	{
	}

	public bool Paint(int amount)
	{
		return false;
	}

	public void OnParticleReached()
	{
	}

	private void SetOriginalScale()
	{
	}

	private void SetComplete()
	{
	}

	public void PlayDecoramaComplete()
	{
	}

	public void PlayPaintableComplete()
	{
	}

	private void PlayCompleteTween(Action onTweenComplete = null)
	{
	}

	private void UpdateVisuals()
	{
	}

	private void ToggleAnimators(bool toggle)
	{
	}

	private void ToggleParticleSystems(bool toggle)
	{
	}

	private bool HasMadeProgress()
	{
		return false;
	}

	private void UpdateRenderersFill(float newFillValue, float time = 0f, float complete = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003CFillCoroutine_003Ed__50))]
	private IEnumerator FillCoroutine(float value, float time)
	{
		return null;
	}

	private void SetMaterialFloat(int floatID, float value)
	{
	}

	private float GetMaterialFloat(int floatID)
	{
		return 0f;
	}

	private Bounds GetBounds()
	{
		return default(Bounds);
	}

	public void SetPaintableRenderers()
	{
	}

	public void SetPaintableAnimators()
	{
	}

	public void SetPaintableParticleSystem()
	{
	}
}
