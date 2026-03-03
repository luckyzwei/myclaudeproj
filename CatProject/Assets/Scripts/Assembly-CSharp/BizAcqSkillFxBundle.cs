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
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}
}
