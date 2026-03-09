using Balancy.Models.LiveOps.Store;
using Balancy.Models.SmartObjects;
using Balancy.Models.Store;

public class ClaimDailyFreeCoinMission : BaseMission
{
	private int m_slotUnnyId;

	public override void StartTracking()
	{
	}

	public override void StopTracking()
	{
	}

	public override bool IsEligible()
	{
		return false;
	}

	private void OnSlotPurchased(Slot slot)
	{
	}

	private void OnItemPurchased(Product product, bool wasSuccess)
	{
	}

	private bool ContainOnlyCoins(StoreItem storeItem)
	{
		return false;
	}

	protected virtual bool DoesPriceMatch(Price price)
	{
		return false;
	}
}
