using System;
using System.Collections.Generic;
using BizAcqDef;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Serializable]
public class BizAcqBuffEffect
{
	public SkillEffectType SkillEffectType;

	public AssetReference EffectObject;

	[HideInInspector]
	public AsyncOperationHandle<GameObject> EffectObjectHandle;

	[HideInInspector]
	public List<Action<GameObject>> OnLoadedList;
}
