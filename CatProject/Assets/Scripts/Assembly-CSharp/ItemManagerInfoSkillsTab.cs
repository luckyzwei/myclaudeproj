using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerInfoSkillsTab : MonoBehaviour, ITabToggleTab
{
	[Header("SkillInfo")]
	[SerializeField]
	private List<ItemManagerSkill> SkillSimpleList;

	[SerializeField]
	private List<ItemManagerSkillList> SkillDetailList;

	[Space(10f)]
	[Header("Skill Level Up")]
	[SerializeField]
	private GameObject SkillLevelUpBtnObj;

	[SerializeField]
	private GameObject SkillLevelUpCostObj;

	[SerializeField]
	private Button SkillLevelUpBtn;

	[SerializeField]
	private Text SkillLevelUpBtnText;

	[SerializeField]
	private Image SkillLevelUpCostIcon;

	[SerializeField]
	private SliderTextComponent SkillLevelUpCostInfo;

	[Header("Need Condition")]
	[SerializeField]
	private GameObject NeedConditionObj;

	[SerializeField]
	private GameObject CardLevelNeedObj;

	[SerializeField]
	private GameObject ReinforceLevelNeedObj;

	[SerializeField]
	private Text CardLevelNeedText;

	[SerializeField]
	private Text ReinforceLevelNeedText;

	[SerializeField]
	private GameObject RedDot_SkillUp;

	[Header("Other")]
	[SerializeField]
	private GameObject BtnRoot;

	private int ManagerIdx;

	private int SkillUpItemIdx;

	private BigInteger SkillUpNeedItemCount;

	private BigInteger SkillUpHasItemCount;

	private bool IsMaxLevel;

	private void Awake()
	{
	}

	public void Set(int managerIdx)
	{
	}

	private void UpdateRedDot()
	{
	}

	private void SetSkillInfo(ManagerCardData managerData, ManagerSkillData skillData)
	{
	}

	public void SetSkillLevelUpInfo()
	{
	}

	private void UpdateSkillLevelUpInfo()
	{
	}

	private void SetReinforceBtnText(bool isMaxLevel)
	{
	}

	private void OnClickSkillLevelUpBtn()
	{
	}

	private void PlaySkillLevelUpFx()
	{
	}

	public void Reset()
	{
	}

	public void Refresh()
	{
	}
}
