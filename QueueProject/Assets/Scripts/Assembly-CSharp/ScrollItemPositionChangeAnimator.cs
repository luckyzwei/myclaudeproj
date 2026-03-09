using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScrollItemPositionChangeAnimator<TItem> : MonoBehaviour where TItem : MonoBehaviour, IScrollItemRecyclable
{
	[CompilerGenerated]
	private sealed class _003CAnimateItemCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollItemPositionChangeAnimator<TItem> _003C_003E4__this;

		public int fromIndex;

		public int toIndex;

		public Action onComplete;

		public float scrollDuration;

		public float delay;

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
		public _003CAnimateItemCoroutine_003Ed__35(int _003C_003E1__state)
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

	public UnityEvent<TItem> OnOverlayItemInitialised;

	public UnityEvent OnOverlayItemDisabled;

	[Header("Dependencies")]
	[SerializeField]
	protected ScrollRectRecycler<TItem> m_recycler;

	[SerializeField]
	protected TItem m_overlayItem;

	[Header("Settings")]
	[SerializeField]
	private float m_cellsPerSecond;

	[SerializeField]
	private float m_minScrollDuration;

	[SerializeField]
	private float m_maxScrollDuration;

	[Header("OverlayMovement Settings")]
	[SerializeField]
	private float m_startDelay;

	[SerializeField]
	protected float m_scrollDelay;

	[SerializeField]
	private Ease m_overlayMovementEase;

	[SerializeField]
	private float m_settleToTargetDurationMin;

	[SerializeField]
	private float m_settleToTargetDurationMax;

	[SerializeField]
	private float m_snapThresholdDistance;

	[SerializeField]
	private bool m_checkForNoMovement;

	[Header("Jump Settings")]
	[Tooltip("The difference in ranks beyond which an animation is considered a 'big jump'.")]
	[SerializeField]
	private int m_indexDifferenceThreshold;

	[SerializeField]
	private int m_forwardOffsetForViewBy;

	[SerializeField]
	private int m_backOffsetForViewBy;

	protected int m_fromIndex;

	protected int m_toIndex;

	protected int m_startIndex;

	protected float m_scrollDuration;

	protected Action m_onCompleteCallback;

	protected TItem m_hiddenTargetCell;

	protected bool m_isAnimating;

	protected TItem m_followTarget;

	public TItem OverlayItem => null;

	public int IndexDifferenceThreshold => 0;

	public bool IsMovingTowardsStart => false;

	protected virtual void OnDisable()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	public void SetIndexDifferenceThreshold(int indexDifferenceThreshold)
	{
	}

	public void AnimateItem(int fromIndex, int toIndex, float scrollDuration = -1f, float delay = -1f, Action onComplete = null)
	{
	}

	[IteratorStateMachine(typeof(ScrollItemPositionChangeAnimator<>._003CAnimateItemCoroutine_003Ed__35))]
	private IEnumerator AnimateItemCoroutine(int fromIndex, int toIndex, float scrollDuration, float delay, Action onComplete)
	{
		return null;
	}

	protected virtual void OnIntroFinished()
	{
	}

	private void MoveOverlayToTargetIndex()
	{
	}

	protected virtual void Cleanup()
	{
	}

	private void PrepareOverlayItem(TItem sourceItem)
	{
	}

	private void RepositionOverlayTo(TItem sourceItem)
	{
	}

	private int GetStartIndex()
	{
		return 0;
	}

	private int GetOffsetForStartIndexViewPosition()
	{
		return 0;
	}

	protected void TryAssignHiddenTargetCell(int index)
	{
	}

	protected virtual void ScrollStart()
	{
	}

	protected virtual void OnScrollInProgress(float progress)
	{
	}

	protected virtual void ScrollEnd()
	{
	}

	private void OnMoveOverlayToTargetFinished()
	{
	}

	private void OnOutroFinished()
	{
	}

	private void OnTargetCellRecycled(int recycledDataIndex, int updatedDataIndex, TItem cell)
	{
	}

	private float CalculateScrollDuration(int from, int to)
	{
		return 0f;
	}

	protected abstract void InitialiseOverlayItem(TItem sourceItem);

	protected abstract void AnimateIntro(Action onComplete = null);

	protected abstract void AnimateOutro(Action onComplete = null);

	protected abstract void HideTargetCell(TItem cell);

	protected abstract void ShowTargetCell(TItem cell);
}
