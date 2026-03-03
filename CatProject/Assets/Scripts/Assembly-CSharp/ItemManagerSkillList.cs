using UnityEngine;
using UnityEngine.UI;

public class ItemManagerSkillList : MonoBehaviour
{
	[SerializeField]
	private Image SkillIcon;

	[SerializeField]
	private Text SkillContentsTypeText;

	[SerializeField]
	private Text SkillDescriptionText;

	[SerializeField]
	private Text SkillLevelText;

	[SerializeField]
	private Text SkillAbilityText;

	[SerializeField]
	private Text SkillTriggerChanceText;

	[SerializeField]
	private GameObject SkillLevelUpFxObj;

	private void OnEnable()
	{
	}

	public void SetSkillInfo(Config.ManagerSkillContentsType skillContentsType, int skillIdx, int skillLevel)
	{
	}

	public void PlaySkillLevelUpFx()
	{
	}

	public string GetSkillContentsNameKey(Config.ManagerSkillContentsType skillContentsType)
	{
		return null;
	}
}
