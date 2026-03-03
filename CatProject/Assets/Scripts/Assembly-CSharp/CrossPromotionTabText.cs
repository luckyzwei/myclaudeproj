using UnityEngine;

public class CrossPromotionTabText : MonoBehaviour
{
	private readonly Color toggleHoverColor;

	private readonly Color toggleWhiteColor;

	[SerializeField]
	private bool isNormal;

	[SerializeField]
	private PageCrossPromotion.CPTab tab;

	private void Start()
	{
	}

	public void Set(PageCrossPromotion.CPTab tab, bool isNormal)
	{
	}

	private void OnValidate()
	{
	}

	private void ApplySettings()
	{
	}
}
