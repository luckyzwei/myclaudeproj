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
		// Update display
	}

	public void SetSkillInfo(int skillIdx, int skillLevel)
	{
		// Update display
	}

	private void SetSkillList(List<int> skillIdxList, int skillLevel)
	{
		if (SkillList == null) return;
		for (int i = 0; i < SkillList.Count; i++)
		{
			if (SkillList[i] == null) continue;
			if (i < skillIdxList.Count)
			{
				SkillList[i].gameObject.SetActive(true);
			}
			else
			{
				SkillList[i].gameObject.SetActive(false);
			}
		}
	}
}
