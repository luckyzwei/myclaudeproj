using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCostumeList : MonoBehaviour
{
	[SerializeField]
	private Transform CostumeRootTr;

	[SerializeField]
	private GameObject EquippedObj;

	[SerializeField]
	private Button SelectBtn;

	[SerializeField]
	private GameObject SelectedObj;

	[SerializeField]
	private GameObject LockedObj;

	[SerializeField]
	private GameObject RedDotObj;

	public Action<int> OnClickCb;

	private Dictionary<int, AddressableLoadGameObject> LoadObjMap;

	private Animator LoadObjAnimator;

	public int CostumeIdx { get; private set; }

	public bool IsLocked { get; private set; }

	public bool IsHasItem { get; private set; }

	public bool IsSelect { get; private set; }

	private void Awake()
	{
	}

	public void Set(int costumeIdx, bool isOpen, Action<GameObject> onLoadComplete)
	{
	}

	private void OnLoadComplete(GameObject loadObject, Action<GameObject> onLoadComplete)
	{
	}

	public void SetIsSelect(bool isSelect)
	{
	}

	public void SetIsLocked(bool isLocked)
	{
	}

	public void SetIsShowRedDot(bool isShowRedDot)
	{
	}

	public void SetIsEquipped(bool isEquipped)
	{
	}

	public void SetIsHasItem(bool isHasItem)
	{
	}

	public void SetActiveLoadObject(bool value)
	{
	}

	public void Release()
	{
	}

	public GameObject GetLoadObject()
	{
		return null;
	}

	private void OnClickItem()
	{
	}
}
