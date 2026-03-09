using UnityEngine;
using UnityEngine.Events;

public class StoreProductCellCurrencyExplosion : StoreProductCell
{
	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	private PrefabReference m_rewardPopup;

	[SerializeField]
	private UnityEvent m_event;

	protected override void OnProductPurchased(bool wasSuccess)
	{
	}
}
