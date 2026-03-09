using UnityEngine;

public class JigsawStoreProductCell : StoreProductCell
{
	[SerializeField]
	private WidgetPuzzleCollection m_widgetPuzzleCollection;

	[SerializeField]
	private PrefabReference m_rewardPopup;

	protected override void OnProductPurchased(bool wasSuccess)
	{
	}
}
