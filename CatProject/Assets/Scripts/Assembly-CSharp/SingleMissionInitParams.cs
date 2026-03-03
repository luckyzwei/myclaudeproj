using System.Numerics;

public struct SingleMissionInitParams
{
	public E_ContentsMissionType ContentType { get; set; }

	public int SlotId { get; set; }

	public int MissionIdx { get; set; }

	public MissionSystem.E_MissionType MissionType { get; set; }

	public int TargetValue { get; set; }

	public BigInteger CurrentValue { get; set; }

	public bool IsCompleted { get; set; }

	public bool IsRewarded { get; set; }

	public IRewardItemData RewardItem { get; set; }

	public object[] Args { get; set; }
}
