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
		if (SkillLevelUpBtn != null) SkillLevelUpBtn.onClick.AddListener(OnClickSkillLevelUpBtn);
	}

	public void Set(int managerIdx)
	{
		ManagerIdx = managerIdx;
		IsMaxLevel = false;
		SetSkillLevelUpInfo();
		UpdateRedDot();
	}

	private void UpdateRedDot()
	{
		if (RedDot_SkillUp != null)
			RedDot_SkillUp.SetActive(!IsMaxLevel && SkillUpHasItemCount >= SkillUpNeedItemCount && SkillUpNeedItemCount > 0);
	}

	private void SetSkillInfo(ManagerCardData managerData, ManagerSkillData skillData)
	{
		if (managerData == null || skillData == null) return;
		if (SkillSimpleList != null)
		{
			for (int i = 0; i < SkillSimpleList.Count; i++)
			{
				if (SkillSimpleList[i] != null)
					SkillSimpleList[i].gameObject.SetActive(false);
			}
		}
	}

	public void SetSkillLevelUpInfo()
	{
		UpdateSkillLevelUpInfo();
	}

	private void UpdateSkillLevelUpInfo()
	{
		if (SkillLevelUpBtnObj != null) SkillLevelUpBtnObj.SetActive(!IsMaxLevel);
		if (SkillLevelUpCostObj != null) SkillLevelUpCostObj.SetActive(!IsMaxLevel);
		SetReinforceBtnText(IsMaxLevel);

		if (SkillLevelUpCostInfo != null && SkillUpNeedItemCount > 0)
			SkillLevelUpCostInfo.SetValue((float)SkillUpHasItemCount, (float)SkillUpNeedItemCount, false);
	}

	private void SetReinforceBtnText(bool isMaxLevel)
	{
		if (SkillLevelUpBtnText != null)
			SkillLevelUpBtnText.text = isMaxLevel ? "MAX" : "";
	}

	private void OnClickSkillLevelUpBtn()
	{
		if (IsMaxLevel) return;
		if (SkillUpHasItemCount < SkillUpNeedItemCount) return;
		PlaySkillLevelUpFx();
		SetSkillLevelUpInfo();
		UpdateRedDot();
	}

	private void PlaySkillLevelUpFx()
	{
		gameObject.SetActive(true);
	}

	public void Reset()
	{
		ManagerIdx = 0;
		IsMaxLevel = false;
		SkillUpNeedItemCount = 0;
		SkillUpHasItemCount = 0;
	}

	public void Refresh()
	{
		Set(ManagerIdx);
	}
}
