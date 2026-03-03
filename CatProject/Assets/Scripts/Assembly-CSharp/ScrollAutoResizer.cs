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
	}

	private void LateUpdate()
	{
	}

	private void UpdateLayout()
	{
	}

	private void OnScrollValueChanged(Vector2 value)
	{
	}
}
