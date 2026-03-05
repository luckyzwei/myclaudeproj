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
		if (SurpriseBtn != null)
			SurpriseBtn.onClick.AddListener(() =>
			{
				Hide();
				// Open surprise reward popup
			});

		var rt = GetComponent<RectTransform>();
		if (rt != null)
		{
			minWidth = WidthPadding;
			maxWidth = (int)Screen.width - WidthPadding;
			minHeight = HeightRange;
			maxHeight = (int)Screen.height - HeightRange;
		}
	}

	public void Show()
	{
		gameObject.SetActive(true);
		SetPosition();
		SetMove();
		if (SurpriseAnimator != null)
			SurpriseAnimator.SetTrigger("Show");
	}

	private void SetPosition()
	{
		isRight = Random.value > 0.5f;
		float x = isRight ? maxWidth : minWidth;
		float y = Random.Range(minHeight, maxHeight);
		transform.position = new Vector3(x, y, 0f);
	}

	private void SetMove()
	{
		if (sequence != null)
		{
			sequence.Kill();
			sequence = null;
		}
		float targetX = isRight ? minWidth : maxWidth;
		sequence = DOTween.Sequence();
		sequence.Append(DoMove(targetX));
		sequence.OnComplete(() => Hide());
	}

	private Tween DoMove(float targetX)
	{
		return transform.DOMoveX(targetX, Duration).SetEase(Ease.Linear);
	}

	public void Hide()
	{
		if (sequence != null)
		{
			sequence.Kill();
			sequence = null;
		}
		gameObject.SetActive(false);
	}

	public void HideByTutorial()
	{
		Hide();
	}
}
