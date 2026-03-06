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
		LoadObjMap = new Dictionary<int, AddressableLoadGameObject>();
		if (SelectBtn != null) SelectBtn.onClick.AddListener(OnClickItem);
	}

	public void Set(int costumeIdx, bool isOpen, Action<GameObject> onLoadComplete)
	{
		CostumeIdx = costumeIdx;
		IsLocked = !isOpen;

		SetIsLocked(!isOpen);
	}

	private void OnLoadComplete(GameObject loadObject, Action<GameObject> onLoadComplete)
	{
		if (loadObject != null)
		{
			loadObject.transform.SetParent(CostumeRootTr, false);
			LoadObjAnimator = loadObject.GetComponent<Animator>();
		}
		onLoadComplete?.Invoke(loadObject);
	}

	public void SetIsSelect(bool isSelect)
	{
		IsSelect = isSelect;
		if (SelectedObj != null) SelectedObj.SetActive(isSelect);
	}

	public void SetIsLocked(bool isLocked)
	{
		IsLocked = isLocked;
		if (LockedObj != null) LockedObj.SetActive(isLocked);
	}

	public void SetIsShowRedDot(bool isShowRedDot)
	{
		if (RedDotObj != null) RedDotObj.SetActive(isShowRedDot);
	}

	public void SetIsEquipped(bool isEquipped)
	{
		if (EquippedObj != null) EquippedObj.SetActive(isEquipped);
	}

	public void SetIsHasItem(bool isHasItem)
	{
		IsHasItem = isHasItem;
	}

	public void SetActiveLoadObject(bool value)
	{
		if (CostumeRootTr != null) CostumeRootTr.gameObject.SetActive(value);
	}

	public void Release()
	{
		if (LoadObjMap != null)
		{
			foreach (var kvp in LoadObjMap)
			{
				// Release addressable handles
			}
			LoadObjMap.Clear();
		}
		LoadObjAnimator = null;
	}

	public GameObject GetLoadObject()
	{
		if (CostumeRootTr != null && CostumeRootTr.childCount > 0)
			return CostumeRootTr.GetChild(0).gameObject;
		return null;
	}

	private void OnClickItem()
	{
		OnClickCb?.Invoke(CostumeIdx);
	}
}
