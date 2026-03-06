using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HudCardBoxComponent : MonoBehaviour
{
	[SerializeField]
	private Image BoxImg;

	[SerializeField]
	private GameObject keyCountObject;

	[SerializeField]
	private Text keyCountText;

	[SerializeField]
	private GameObject adObject;

	[SerializeField]
	private GameObject freeObject;

	private bool showUI;

	private int ShopBoxIdx;

	private int OpenBoxIdx;

	private string passSpriteName;

	private List<int> orderedIdList;

	private CompositeDisposable itemDispose;

	private ShopCardBoxData curBoxInfo;

	private bool isOpenNow;

	private void Awake()
	{
		itemDispose = new CompositeDisposable();
		orderedIdList = new List<int>();
		isOpenNow = false;
	}

	public void CheckOpenBoxCount()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.ShopData == null) return;
		OnChangeOpenBox();
	}

	private void OnChangeOpenBox()
	{
		// TODO
	}

	private void OnClickBox()
	{
		if (isOpenNow) return;
		OpenBox();
	}

	public void ShowAdObj(bool value)
	{
		if (adObject != null) adObject.SetActive(value);
		if (freeObject != null) freeObject.SetActive(!value);
	}

	private void OpenBox(Action CompCb = null)
	{
		isOpenNow = true;
		SetOpenNow();
		CompCb?.Invoke();
	}

	private void OnDestroy()
	{
		if (itemDispose != null)
		{
			itemDispose.Dispose();
			itemDispose = null;
		}
	}

	private void OnDisable()
	{
		isOpenNow = false;
	}

	private void SetOpenNow()
	{
		// Update display
	}

	public void SetShow(bool show)
	{
		showUI = show;
		gameObject.SetActive(show);
	}
}
