using System;
using UnityEngine;
using UnityEngine.UI;

public class AutoPlayBubble : MonoBehaviour
{
	private enum E_BubbleState
	{
		None = 0,
		Show = 1,
		Hide = 2
	}

	private static string SHOW;

	private static string HIDE;

	[SerializeField]
	private Text BubbleText;

	[SerializeField]
	private float InactiveTime;

	private Animator Animator;

	private float ElapsedTime;

	private bool bPlayAnim;

	private float PlaySpeed;

	private E_BubbleState BubbleState;

	public Action OnHideComplete;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void SetInactiveTime(float time)
	{
	}

	public void SetPlaySpeed(float speed)
	{
	}

	public void SetBubbleText(string text)
	{
	}

	public void PlayShowImmediately()
	{
	}

	public void PlayHide()
	{
	}
}
