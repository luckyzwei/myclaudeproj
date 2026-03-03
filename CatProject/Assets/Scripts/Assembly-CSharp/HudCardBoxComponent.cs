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
	}

	public void CheckOpenBoxCount()
	{
	}

	private void OnChangeOpenBox()
	{
	}

	private void OnClickBox()
	{
	}

	public void ShowAdObj(bool value)
	{
	}

	private void OpenBox(Action CompCb = null)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void SetOpenNow()
	{
	}

	public void SetShow(bool show)
	{
	}
}
