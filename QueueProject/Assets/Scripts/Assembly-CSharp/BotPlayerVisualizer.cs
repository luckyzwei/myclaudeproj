using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class BotPlayerVisualizer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BotPlayerVisualizer _003C_003E4__this;

		private Vector3 _003ChandOriginalScale_003E5__2;

		private Vector3 _003ChandClickedScale_003E5__3;

		private int _003CloopCount_003E5__4;

		private HintsManager.HintResult _003Cresult_003E5__5;

		private bool _003CisDragging_003E5__6;

		private int _003Ci_003E5__7;

		private int _003CcellIndex_003E5__8;

		private float _003Cduration_003E5__9;

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
		public _003CPlayCoroutine_003Ed__24(int _003C_003E1__state)
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

	private const int MAX_LOOP_COUNT = 1000;

	[SerializeField]
	private Transform m_handTransform;

	[SerializeField]
	private float m_handMovementDuration;

	[SerializeField]
	private float m_handDragMovementDuration;

	[SerializeField]
	private float m_handStayDuration;

	[SerializeField]
	private Ease m_handMoveEase;

	[SerializeField]
	private float m_tapDuration;

	[SerializeField]
	private float m_doubleTapDuration;

	[SerializeField]
	private float m_delayBetween;

	[SerializeField]
	private float m_timeMultiplier;

	[SerializeField]
	private bool m_stopOnMistake;

	private GridState m_gridState;

	private Coroutine m_coroutine;

	private bool m_isPlaying;

	public bool IsPlaying => false;

	public bool StopOnMistake
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelSolved()
	{
	}

	public void StartPlay()
	{
	}

	public void StopPlay()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCoroutine_003Ed__24))]
	private IEnumerator PlayCoroutine()
	{
		return null;
	}

	private bool IsNeighbour(int cell1, int cell2)
	{
		return false;
	}

	public float GetTimeScale()
	{
		return 0f;
	}

	public void SetTimeScale(float botSpeed)
	{
	}
}
