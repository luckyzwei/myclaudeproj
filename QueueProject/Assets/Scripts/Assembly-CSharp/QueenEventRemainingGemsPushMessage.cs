using Balancy.Models.SmartObjects;

public class QueenEventRemainingGemsPushMessage : BasePushMessage
{
	private const string ID = "0000";

	public override string GetPushMessageID()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void ReCheck()
	{
	}

	private void OnItemCountChange(Item item, int count, int slotIndex)
	{
	}

	private int HowManyGemsNeededForNextReward()
	{
		return 0;
	}
}
