using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HUDSpecialDaySurprise : MonoBehaviour
{
	[Header("HUDSpecialDaySurprise")]
	[SerializeField]
	private Button SurpriseBtn;

	[SerializeField]
	private Animator SurpriseAnimator;

	[Header("[Value]")]
	[SerializeField]
	private int WidthPadding;

	[SerializeField]
	private int HeightRange;

	[SerializeField]
	private float Duration;

	private int minWidth;

	private int maxWidth;

	private int minHeight;

	private int maxHeight;

	private bool isRight;

	private Sequence sequence;

	private void Awake()
	{
	}

	public void Show()
	{
	}

	private void SetPosition()
	{
	}

	private void SetMove()
	{
	}

	private Tween DoMove(float targetX)
	{
		return null;
	}

	public void Hide()
	{
	}

	public void HideByTutorial()
	{
	}
}
