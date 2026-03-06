using System;
using System.Collections.Generic;
using BizAcqDef;
using UnityEngine;

[CreateAssetMenu(fileName = "BizAcqSkillFxBundle", menuName = "ScriptableObjects/BizAcqSkillFxBundle", order = 1)]
public class BizAcqSkillFxBundle : ScriptableObject
{
	[SerializeField]
	private List<BizAcqBuffEffect> BuffEffectList;

	public void LoadBuffEffectObject(SkillEffectType skillEffectType, Action<GameObject> onLoaded)
	{
		if (BuffEffectList == null) return;
		for (int i = 0; i < BuffEffectList.Count; i++)
		{
			if (BuffEffectList[i] != null && BuffEffectList[i].SkillEffectType == skillEffectType)
			{
				if (BuffEffectList[i].OnLoadedList == null)
					BuffEffectList[i].OnLoadedList = new List<Action<GameObject>>();
				if (onLoaded != null)
					BuffEffectList[i].OnLoadedList.Add(onLoaded);
				return;
			}
		}
	}

	public void Reset()
	{
		if (BuffEffectList == null) return;
		for (int i = 0; i < BuffEffectList.Count; i++)
		{
			if (BuffEffectList[i] != null && BuffEffectList[i].OnLoadedList != null)
				BuffEffectList[i].OnLoadedList.Clear();
		}
	}

	private void OnDestroy()
	{
		Reset();
	}
}
