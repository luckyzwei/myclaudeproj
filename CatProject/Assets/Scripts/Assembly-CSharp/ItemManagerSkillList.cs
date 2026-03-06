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
		if (SkillLevelUpFxObj != null)
			SkillLevelUpFxObj.SetActive(false);
	}

	public void SetSkillInfo(Config.ManagerSkillContentsType skillContentsType, int skillIdx, int skillLevel)
	{
		if (SkillLevelText != null)
			SkillLevelText.text = "Lv." + skillLevel;
		if (SkillContentsTypeText != null)
			SkillContentsTypeText.text = GetSkillContentsNameKey(skillContentsType);
	}

	public void PlaySkillLevelUpFx()
	{
		if (SkillLevelUpFxObj != null)
			SkillLevelUpFxObj.SetActive(true);
	}

	public string GetSkillContentsNameKey(Config.ManagerSkillContentsType skillContentsType)
	{
		return skillContentsType.ToString();
	}
}
