using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AnimationButtonHandler : MonoBehaviour
{
	[SerializeField]
	private UnityEvent m_onClickComplete;

	[SerializeField]
	[HideInInspector]
	public string animationStateName;

	[SerializeField]
	[HideInInspector]
	public int selectedIndex;

	[SerializeField]
	[HideInInspector]
	private Button m_button;

	[SerializeField]
	[HideInInspector]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private bool m_fireEventBeforeAnimation;

	public AnimatorHelper AnimatorHelper => null;

	private void Awake()
	{
	}

	private void Click()
	{
	}
}
