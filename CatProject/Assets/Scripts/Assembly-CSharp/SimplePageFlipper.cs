using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SimplePageFlipper : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField]
	private float flipDuration;

	[SerializeField]
	private Ease openEase;

	[SerializeField]
	private Ease closeEase;

	[SerializeField]
	private float zSpaceOffset;

	[Header("Juice Settings (부드러운 연출)")]
	[SerializeField]
	private float bendStrength;

	[SerializeField]
	private float tiltAngle;

	[Header("References")]
	[SerializeField]
	private GameObject frontPage;

	[SerializeField]
	private GameObject backPage;

	[Header("Shadow Options")]
	[SerializeField]
	private Image frontPageShadow;

	[SerializeField]
	private Image backPageShadow;

	public bool IsFlipping { get; private set; }

	private void Start()
	{
		IsFlipping = false;
		ResetShadows();
		if (backPage != null)
			backPage.SetActive(false);
	}

	public void TurnToNextPage(Action onComplete = null)
	{
		if (IsFlipping || frontPage == null) return;
		IsFlipping = true;

		var frontRect = frontPage.GetComponent<RectTransform>();
		if (frontRect == null) { IsFlipping = false; return; }

		SetPivot(frontRect, new Vector2(1f, 0.5f));

		var seq = DOTween.Sequence();
		seq.Append(frontRect.DORotate(new Vector3(0f, -90f + tiltAngle, 0f), flipDuration * 0.5f).SetEase(closeEase));
		seq.AppendCallback(() =>
		{
			frontPage.SetActive(false);
			if (backPage != null) backPage.SetActive(true);
			SwapReferences();
		});
		var backRect = frontPage.GetComponent<RectTransform>();
		if (backRect != null)
		{
			seq.Append(backRect.DORotate(Vector3.zero, flipDuration * 0.5f).SetEase(openEase));
		}
		seq.OnComplete(() =>
		{
			IsFlipping = false;
			ResetShadows();
			onComplete?.Invoke();
		});
	}

	public void TurnToPrevPage(Action onComplete = null)
	{
		if (IsFlipping || frontPage == null) return;
		IsFlipping = true;

		var frontRect = frontPage.GetComponent<RectTransform>();
		if (frontRect == null) { IsFlipping = false; return; }

		SetPivot(frontRect, new Vector2(0f, 0.5f));

		var seq = DOTween.Sequence();
		seq.Append(frontRect.DORotate(new Vector3(0f, 90f - tiltAngle, 0f), flipDuration * 0.5f).SetEase(closeEase));
		seq.AppendCallback(() =>
		{
			frontPage.SetActive(false);
			if (backPage != null) backPage.SetActive(true);
			SwapReferences();
		});
		var backRect = frontPage.GetComponent<RectTransform>();
		if (backRect != null)
		{
			seq.Append(backRect.DORotate(Vector3.zero, flipDuration * 0.5f).SetEase(openEase));
		}
		seq.OnComplete(() =>
		{
			IsFlipping = false;
			ResetShadows();
			onComplete?.Invoke();
		});
	}

	public GameObject GetFrontViewPage()
	{
		return frontPage;
	}

	public GameObject GetNextViewPage()
	{
		return backPage;
	}

	private void SwapReferences()
	{
		var temp = frontPage;
		frontPage = backPage;
		backPage = temp;

		var tempShadow = frontPageShadow;
		frontPageShadow = backPageShadow;
		backPageShadow = tempShadow;
	}

	private void ResetShadows()
	{
		if (frontPageShadow != null)
		{
			var c = frontPageShadow.color;
			c.a = 0f;
			frontPageShadow.color = c;
		}
		if (backPageShadow != null)
		{
			var c = backPageShadow.color;
			c.a = 0f;
			backPageShadow.color = c;
		}
	}

	private void ResetZPosition(GameObject page)
	{
		if (page == null) return;
		var rt = page.GetComponent<RectTransform>();
		if (rt != null)
		{
			var pos = rt.localPosition;
			pos.z = 0f;
			rt.localPosition = pos;
		}
	}

	private void SetPivot(RectTransform rectTransform, Vector2 pivot)
	{
		if (rectTransform == null) return;
		Vector2 size = rectTransform.rect.size;
		Vector2 deltaPivot = pivot - rectTransform.pivot;
		Vector3 deltaPosition = new Vector3(deltaPivot.x * size.x, deltaPivot.y * size.y, 0f);
		rectTransform.pivot = pivot;
		rectTransform.localPosition += deltaPosition;
	}
}
