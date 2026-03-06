using UnityEngine;
using UnityEngine.UI;

public class ItemManagerSkill : MonoBehaviour
{
	[SerializeField]
	private Image SkillIcon;

	[SerializeField]
	private Text SkillLevelText;

	[SerializeField]
	private Text SkillDescText;

	[SerializeField]
	private Button SkillInfoButton;

	private int ManagerIdx;

	private int SkillIdx;

	private int SkillLevel;

	private Config.ManagerSkillContentsType SkillContentsType;

	private void Awake()
	{
		if (SkillInfoButton != null)
			SkillInfoButton.onClick.AddListener(OnClickSkillInfoBtn);
	}

	public void SetSkillInfo(int managerIdx, Config.ManagerSkillContentsType skillContentsType, bool isSimpleDesc)
	{
		ManagerIdx = managerIdx;
		SkillContentsType = skillContentsType;
	}

	public void UpdateSkillInfo()
	{
		SetSkillLevel(SkillLevel);
	}

	public void SetEnableSkillInfoBtn(bool bEnable)
	{
		if (SkillInfoButton != null)
			SkillInfoButton.gameObject.SetActive(bEnable);
	}

	private void SetSkillIcon(string iconKey)
	{
		// Update display
	}

	private void SetSkillLevel(int skillLevel)
	{
		SkillLevel = skillLevel;
		if (SkillLevelText != null)
			SkillLevelText.text = "Lv." + skillLevel;
	}

	private void SetSkillDesc(int skillIdx, int skillLevel, Config.ManagerSkillActivationType skillActivationType, bool isSimpleDesc)
	{
		SkillIdx = skillIdx;
	}

	private void OnClickSkillInfoBtn()
	{
		// Handle click
	}
}
