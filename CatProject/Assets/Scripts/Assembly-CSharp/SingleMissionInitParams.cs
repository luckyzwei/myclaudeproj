using System.Numerics;

public class SingleMissionInitParams
{
	public int SlotIdx;
	public int MissionIdx;
	public MissionSystem.E_MissionType MissionType;
	public int TargetValue;
	public E_ContentsMissionType ContentType;
	public string DescriptionKey;
	public IRewardItemData RewardItem;
	public object[] Args;
	public BigInteger CurrentValue;
	public bool IsCompleted;
	public bool IsRewarded;
}
