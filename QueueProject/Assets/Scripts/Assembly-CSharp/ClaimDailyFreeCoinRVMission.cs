using Balancy.Models.SmartObjects;

public class ClaimDailyFreeCoinRVMission : ClaimDailyFreeCoinMission
{
	protected override bool DoesPriceMatch(Price price)
	{
		return false;
	}
}
