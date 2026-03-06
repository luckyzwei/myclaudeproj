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
		ApplySettings();
	}

	public void Set(PageCrossPromotion.CPTab tab, bool isNormal)
	{
		this.tab = tab;
		this.isNormal = isNormal;
		ApplySettings();
	}

	private void OnValidate()
	{
		ApplySettings();
	}

	private void ApplySettings()
	{
	}
}
