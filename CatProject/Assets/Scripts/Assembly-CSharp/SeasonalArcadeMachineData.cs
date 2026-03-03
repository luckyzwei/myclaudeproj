public class SeasonalArcadeMachineData
{
	public int Level;

	public int MaxLevel;

	public int BettingMultipleValue;

	public bool bReceivedFirstFixedReward;

	public int RouletteCount;

	public bool bFreeChance;

	public bool bUseFirstFreeChance;

	public int FirstFreeChanceCheckCount;

	public bool IsMaxLevel => false;

	public void AddRouletteCount(int value)
	{
	}
}
