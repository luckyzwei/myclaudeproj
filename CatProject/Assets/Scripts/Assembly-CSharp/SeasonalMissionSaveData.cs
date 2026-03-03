using System.Collections.Generic;
using System.Numerics;

public class SeasonalMissionSaveData
{
	public int MissionIdx;

	public List<BigInteger> MissionValueList;

	public List<BigInteger> MissionNeedValueList;

	public List<bool> MissionCompleteList;

	public List<bool> bNeedUpdateTargetRequireValueList;
}
