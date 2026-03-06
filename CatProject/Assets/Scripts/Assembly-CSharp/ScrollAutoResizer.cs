using UnityEngine;
using UnityEngine.UI;

public class ScrollAutoResizer : MonoBehaviour
{
	[SerializeField]
	private ScrollRect ScrollRect;

	[SerializeField]
	private float MaxHeight;

	[SerializeField]
	private float MinHeight;

	[SerializeField]
	private bool NoOverScroll;

	[SerializeField]
	private GameObject ScrollPrevGuideArrow;

	[SerializeField]
	private GameObject ScrollNextGuideArrow;

	private RectTransform ScrollRectTransform;

	private RectTransform ContentRectTransform;

	private Vector2 PreviousSize;

	private bool VerticalScroll;

	private bool HorizontalScroll;

	private void Start()
	{
		if (ScrollRect != null)
		{
			ScrollRectTransform = ScrollRect.GetComponent<RectTransform>();
			ContentRectTransform = ScrollRect.content;
			VerticalScroll = ScrollRect.vertical;
			HorizontalScroll = ScrollRect.horizontal;
			ScrollRect.onValueChanged.AddListener(OnScrollValueChanged);
		}
		UpdateLayout();
	}

	private void LateUpdate()
	{
		if (ContentRectTransform == null) return;
		Vector2 contentSize = ContentRectTransform.sizeDelta;
		if (contentSize != PreviousSize)
		{
			PreviousSize = contentSize;
			UpdateLayout();
		}
	}

	private void UpdateLayout()
	{
		if (ScrollRectTransform == null || ContentRectTransform == null) return;
		Vector2 size = ScrollRectTransform.sizeDelta;
		float contentHeight = ContentRectTransform.sizeDelta.y;
		float clampedHeight = Mathf.Clamp(contentHeight, MinHeight, MaxHeight);
		size.y = clampedHeight;
		ScrollRectTransform.sizeDelta = size;
		bool needScroll = contentHeight > clampedHeight;
		if (NoOverScroll) ScrollRect.vertical = needScroll;
		if (ScrollPrevGuideArrow != null) ScrollPrevGuideArrow.SetActive(false);
		if (ScrollNextGuideArrow != null) ScrollNextGuideArrow.SetActive(needScroll);
	}

	private void OnScrollValueChanged(Vector2 value)
	{
		if (ScrollPrevGuideArrow != null) ScrollPrevGuideArrow.SetActive(value.y < 0.99f);
		if (ScrollNextGuideArrow != null) ScrollNextGuideArrow.SetActive(value.y > 0.01f);
	}
}
