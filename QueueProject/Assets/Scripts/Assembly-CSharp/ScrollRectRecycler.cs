using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class ScrollRectRecycler<TItem> : MonoBehaviour where TItem : MonoBehaviour, IScrollItemRecyclable
{
	[Header("Events")]
	public UnityEvent<int, int, TItem> OnScrollItemRecycledEvent;

	public RecyclerScrollEvents ScrollEvents;

	[Header("Required Components")]
	[SerializeField]
	protected ScrollRect m_scrollRect;

	[SerializeField]
	protected ScrollRectUserInput m_scrollRectUserInput;

	[Header("Animation Settings")]
	[SerializeField]
	protected Ease m_autoScrollEase;

	private bool m_isAutoScrolling;

	private bool m_isUserScrolling;

	private int m_recyclableItemCount;

	private float m_offset;

	private bool m_isScrollVertical;

	private readonly SortedDictionary<int, float> m_gaps;

	protected readonly List<TItem> m_recyclerItems;

	private int m_visibleStartIndex;

	private Tween m_autoScrollTween;

	private bool m_isScrollRectInitialised;

	private ContentSizeFitter m_contentSizeFitter;

	private VerticalLayoutGroup m_verticalLayoutGroup;

	private HorizontalLayoutGroup m_horizontalLayoutGroup;

	public int TotalItemCount { get; private set; }

	public bool isScrollRectInitialised => false;

	public bool IsAutoScrolling => false;

	public bool IsUserScrolling => false;

	public bool IsScrollVertical => false;

	public int VisibleStartIndex => 0;

	public int VisibleItemCountOnScreen => 0;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Config(int totalItemCount, int initialJumpToIndex = 0)
	{
	}

	public void JumpToIndex(int dataIndex, int offsetPositionInViewBy = 0)
	{
	}

	private void RefreshVisibleItemsData()
	{
	}

	private void RepositionAllVisibleItems()
	{
	}

	public void ScrollToTop(float duration = 1f, Action onScrollFinished = null)
	{
	}

	public void ScrollToBottom(float duration = 1f, Action onScrollFinished = null)
	{
	}

	public void ScrollTo(int dataIndex, float duration = 1f, float delay = 0f, Action onScrollStarted = null, Action onScrollFinished = null, Action<float> onScrollInProgress = null)
	{
	}

	public TItem GetItemWithIndex(int index)
	{
		return null;
	}

	public void AddGap(int gapAfterIndex, float gapSizeInPixels)
	{
	}

	public void RemoveGap(int gapAfterIndex)
	{
	}

	public void ClearAllGaps()
	{
	}

	private void GapUpdated()
	{
	}

	private void SetupInputProxy()
	{
	}

	private void PopulateRecyclerItemListFromHierarchy()
	{
	}

	private void RepositionAndPopulateFromIndex(int startIndex)
	{
	}

	private void TryRegisterComponents()
	{
	}

	private void TryInitaliseScrolling()
	{
	}

	private void UpdateParams()
	{
	}

	private void DisableLayoutComponents()
	{
	}

	private void NotifyBeginDrag()
	{
	}

	private void NotifyEndDrag()
	{
	}

	private Vector2 GetNormalizedPositionForIndex(int index)
	{
		return default(Vector2);
	}

	private void AutoScrolling(Vector2 targetPosition, float duration, float delay = 0f, Action onScrollStarted = null, Action onScrollFinished = null, Action<float> onScrollInProgress = null)
	{
	}

	private void OnAutoScrollTweenStarted()
	{
	}

	private void OnAutoScrollTweenInProgress(float progress)
	{
	}

	private void OnAutoScrollTweenEnded()
	{
	}

	protected void ForceStopAutoScrolling()
	{
	}

	private void OnScroll(Vector2 scrollPosition)
	{
	}

	private void HandleScroll()
	{
	}

	private void ItemRecycled(int recycledDataIndex, int updatedDataIndex, TItem item)
	{
	}

	private float GetCumulativeGapOffset(int dataIndex)
	{
		return 0f;
	}

	private float GetTotalGapsSize()
	{
		return 0f;
	}

	protected abstract void OnItemRecycled(int recycledDataIndex, int newDataIndex, TItem item);

	protected virtual void OnUserScrollStarted()
	{
	}

	protected virtual void OnUserScrollEnded()
	{
	}

	protected virtual void OnAutoScrollStarted()
	{
	}

	protected virtual void OnAutoScrollInProgress(float progress)
	{
	}

	protected virtual void OnAutoScrollEnded()
	{
	}
}
