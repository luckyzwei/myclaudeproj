using System.Collections.Generic;
using Treeplla;
using UnityEngine;

[UIPath("Popup/PopupManagerSkills", false, false)]
public class PopupManagerSkills : UIBase
{
	[Header("Skill List")]
	[SerializeField]
	private List<ItemManagerSkillList> SkillList;

	public void SetSkillInfo(int managerIdx)
	{
	}

	public void SetSkillInfo(int skillIdx, int skillLevel)
	{
	}

	private void SetSkillList(List<int> skillIdxList, int skillLevel)
	{
	}
}
