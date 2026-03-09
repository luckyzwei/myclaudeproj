using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimatedTabBarWidget : MonoBehaviour
{
	public const string SELECTED_PARAM = "Selected";

	[SerializeField]
	private Animator[] m_animators;

	[SerializeField]
	private GameObject[] m_panels;

	[SerializeField]
	private int m_defaultSelectedIndex;

	[SerializeField]
	private string m_selectedAnimation;

	[SerializeField]
	private string m_unselectedAnimation;

	private int m_selectedIndex;

	private bool m_defaultTabSet;

	public event Action<int> TabSelected
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public void SetDefaultTab(int index)
	{
	}

	public void SelectTab(int index)
	{
	}

	private void SelectTabSilently(int index)
	{
	}
}
