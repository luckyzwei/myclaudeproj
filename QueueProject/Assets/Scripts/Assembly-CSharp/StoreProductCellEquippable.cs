using Balancy.Models.LiveOps.Store;
using Balancy.Models.Store;
using UnityEngine;

public class StoreProductCellEquippable : StoreProductCell
{
	private const string ANIM_CANNOTAFFORD = "CannotAfford";

	private const string ANIM_EQUIPPABLE = "Equippable";

	private const string ANIM_EQUIPPED = "Equipped";

	private const string ANIM_PURCHASABLE = "Purchasable";

	private const string ANIM_REWARDVIDEO = "RewardVideo";

	private const string ANIM_LOCKED = "Locked";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	protected override void SetupWidgets(Slot slot)
	{
	}

	private void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	protected override void UpdateVisuals()
	{
	}

	protected void SetLocked()
	{
	}

	public void OnEquipPressed()
	{
	}

	private void OnItemEquipped(string clientId, Category category)
	{
	}

	protected override void OnProductPurchased(bool success)
	{
	}
}
