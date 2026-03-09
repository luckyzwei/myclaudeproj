using System;
using UnityEngine;

public class RatingStarWidget : MonoBehaviour
{
	private const string ANIM_EMPTY = "Empty";

	private const string ANIM_FILLEDIN = "FilledIn";

	private const string ANIM_FILLEDLOOP = "FilledLoop";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	private Action<int> m_touchCallback;

	private bool m_currentValue;

	private int m_index;

	private bool m_isOnAnimationOnGoing;

	public bool CurrentValue => false;

	public void SetValue(bool isOn, bool animate = true)
	{
	}

	public void Config(int index, Action<int> touchCallback)
	{
	}

	public void Touched()
	{
	}
}
