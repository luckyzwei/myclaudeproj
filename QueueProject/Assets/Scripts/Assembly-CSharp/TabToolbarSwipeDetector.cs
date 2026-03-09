using UnityEngine;

public class TabToolbarSwipeDetector : MonoBehaviour
{
	private enum SwipeState
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2
	}

	private Vector3 m_startPos;

	private Vector3 m_diff;

	private float m_swipeTime;

	private float m_normalizedSwipeLength;

	private bool m_isValidSwipe;

	private bool m_isSwiping;

	private bool m_isEnabled;

	private SwipeState m_swipeState;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void TabChangingEnabled(bool value)
	{
	}

	private void Update()
	{
	}
}
