using System;
using UnityEngine;

public abstract class ScrollItemVisibilityTracker<TItem> : MonoBehaviour where TItem : MonoBehaviour, IScrollItemRecyclable
{
	public Action<TItem> OnItemVisible;

	public Action OnItemInvisible;

	[SerializeField]
	private ScrollRectRecycler<TItem> m_scrollRectRecycler;

	[SerializeField]
	private Offset m_checkOffset;

	[SerializeField]
	private RectTransform m_borderRectTransform;

	private bool m_isItemInView;

	private long m_trackIndex;

	protected TItem m_scrollItem;

	private Vector4 m_cachedOffset;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetTrackIndex(int trackIndex)
	{
	}

	private void OnItemRecycled(int recycledDataIndex, int updatedDataIndex, TItem itemRecyclable)
	{
	}

	private void OnScroll(Vector2 _)
	{
	}

	private void CheckScrollItemVisibility()
	{
	}

	private bool IsRectTransformInsideBoundary(RectTransform rt)
	{
		return false;
	}

	protected abstract void OnScrollItemVisible();

	protected abstract void OnScrollItemInvisible();
}
