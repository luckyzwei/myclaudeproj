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
	}

	public void SetSkillInfo(int managerIdx, Config.ManagerSkillContentsType skillContentsType, bool isSimpleDesc)
	{
	}

	public void UpdateSkillInfo()
	{
	}

	public void SetEnableSkillInfoBtn(bool bEnable)
	{
	}

	private void SetSkillIcon(string iconKey)
	{
	}

	private void SetSkillLevel(int skillLevel)
	{
	}

	private void SetSkillDesc(int skillIdx, int skillLevel, Config.ManagerSkillActivationType skillActivationType, bool isSimpleDesc)
	{
	}

	private void OnClickSkillInfoBtn()
	{
	}
}
