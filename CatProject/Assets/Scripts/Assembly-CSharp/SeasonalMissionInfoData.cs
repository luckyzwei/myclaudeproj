using System.Collections.Generic;
using SeasonalDef;

public class SeasonalMissionInfoData
{
	public int MissionIdx;
	public int SeasonThemeIdx;
	public int SlotIdx;
	public int ShowPriority;
	public E_MissionType MissionType;
	public E_MissionOpenCondition OpenCondition;
	public int OpenConditionValue;
	public bool IsRepeat;
	public int TargetIdx;
	public List<long> TargetRequireValueList;
	public E_CurrencyType RewardCurrencyType;
	public List<int> RewardValueList;
	public string DescriptionKey;

	public override string ToString()
	{
		return DescriptionKey ?? string.Empty;
	}
}
