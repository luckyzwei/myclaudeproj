public class BoosterData
{
	public int Idx;
	public int BoosterType;
	public int AbilityType;
	public int AbilityValue;
	public int Duration;
	public int CostType;
	public int CostValue;
	public bool IsFree;

	public BoosterData()
	{
	}

	public BoosterData(int idx, int boosterType, int abilityType, int abilityValue, int duration, int costType, int costValue, bool isFree)
	{
		Idx = idx;
		BoosterType = boosterType;
		AbilityType = abilityType;
		AbilityValue = abilityValue;
		Duration = duration;
		CostType = costType;
		CostValue = costValue;
		IsFree = isFree;
	}

	public BoosterData Clone()
	{
		return (BoosterData)MemberwiseClone();
	}
}
