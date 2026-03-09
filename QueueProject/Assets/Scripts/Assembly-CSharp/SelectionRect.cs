using UnityEngine;

public class SelectionRect : MonoBehaviour
{
	private RectTransform m_rectTransform;

	private RectTransform m_parentTransform;

	private int m_selectedTabIndex;

	private float m_unselectedWidth;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTabChange(int tabIndex, bool immediately)
	{
	}

	private void SwipeCancelled()
	{
	}

	private void OnDrag(float amount)
	{
	}

	public void Config(RectTransform parent, float unselectedWidth, float selectedWidth)
	{
	}

	public void MoveTo(float position, bool immediately = false)
	{
	}

	private Vector2 CalculatePosition(float position)
	{
		return default(Vector2);
	}
}
