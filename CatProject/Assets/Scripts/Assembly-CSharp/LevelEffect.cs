using System;
using UnityEngine;

public class LevelEffect : MonoBehaviour
{
	[SerializeField]
	private GameObject EffectObj;

	public void Set(Vector3 worldStartPos, Action endCb = null)
	{
		transform.position = worldStartPos;
		if (EffectObj != null) EffectObj.SetActive(true);
	}

	private void InitPos(GameObject targetObj)
	{
		if (targetObj != null) transform.position = targetObj.transform.position;
	}
}
