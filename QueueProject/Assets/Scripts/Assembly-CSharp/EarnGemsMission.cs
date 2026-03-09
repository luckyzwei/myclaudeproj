using Balancy.Models.SmartObjects;

public class EarnGemsMission : BaseMission
{
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

	private void OnCurrencyEarned(Item item, int count, int slotIndex)
	{
	}
}
