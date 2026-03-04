public class ManagerSkillData
{
	public int SkillIdx;

	public Config.ManagerSkillContentsType SkillContentsType;

	public Config.ManagerSkillType SkillType;

	public Config.ManagerSkillActivationType SkillActivationType;

	public ManagerSkillData(int skillIdx, Config.ManagerSkillContentsType skillContentsType)
	{
		SkillIdx = skillIdx;
		SkillContentsType = skillContentsType;
	}
}
