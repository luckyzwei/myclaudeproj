using UnityEngine;

public class SubScreenManager : MonoBehaviour
{
	[SerializeField]
	private RectTransform[] m_subScreens;

	[SerializeField]
	private bool m_dontShowLockedScreens;

	[SerializeField]
	private bool m_animateScreens;

	[Space]
	[Header("Optional, Just for show")]
	[SerializeField]
	private RectTransform m_extraScreenLeft;

	[SerializeField]
	private RectTransform m_extraScreenRight;

	private RectTransform m_screenContainer;

	private float m_areaWidth;

	private float m_minX;

	private float m_maxX;

	private int m_selectedTabIndex;

	private bool[] m_tabsLockStatus;

	private int m_screensCount;

	private int m_previousIndex;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Config()
	{
	}

	private void SetScreenPositions()
	{
	}

	private float CalculatePageOffset(int i, int pageCount, float screenWidth)
	{
		return 0f;
	}

	private void MoveTo(int index, bool immediately = false)
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

	private void TabLocked(int tabIndex)
	{
	}

	private void TabUnlocked(int tabIndex)
	{
	}
}
