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
		Animator = GetComponent<Animator>();
		PlaySpeed = 1f;
		BubbleState = E_BubbleState.None;
		SHOW = "Show";
		HIDE = "Hide";
	}

	private void OnEnable()
	{
		ElapsedTime = 0f;
		bPlayAnim = false;
	}

	private void OnDisable()
	{
		bPlayAnim = false;
		BubbleState = E_BubbleState.None;
	}

	private void Update()
	{
		if (BubbleState != E_BubbleState.Show) return;
		ElapsedTime += Time.deltaTime * PlaySpeed;
		if (InactiveTime > 0f && ElapsedTime >= InactiveTime)
		{
			PlayHide();
		}
	}

	public void SetInactiveTime(float time)
	{
		InactiveTime = time;
	}

	public void SetPlaySpeed(float speed)
	{
		PlaySpeed = speed > 0f ? speed : 1f;
	}

	public void SetBubbleText(string text)
	{
		if (BubbleText != null)
			BubbleText.text = text;
	}

	public void PlayShowImmediately()
	{
		BubbleState = E_BubbleState.Show;
		ElapsedTime = 0f;
		bPlayAnim = true;
		gameObject.SetActive(true);
		if (Animator != null) Animator.Play(SHOW);
	}

	public void PlayHide()
	{
		BubbleState = E_BubbleState.Hide;
		bPlayAnim = true;
		if (Animator != null) Animator.Play(HIDE);
		OnHideComplete?.Invoke();
	}
}
