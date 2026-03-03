using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperStaffStatBtn : MonoBehaviour
{
	[SerializeField]
	private int SuperStaffIdx;

	[SerializeField]
	private List<Image> scaleImgs;

	[SerializeField]
	private GameObject ContextRoot;

	[SerializeField]
	private Text textUnlockLv;

	[SerializeField]
	private Text textUnlockLv2;

	[SerializeField]
	private Button btnStaff;

	[SerializeField]
	private GameObject Reddot;

	[SerializeField]
	private Image imgIcon;

	[SerializeField]
	private Button btnGet;

	[SerializeField]
	private Text textNextTime;

	[SerializeField]
	private Text textGetBtn;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject LockObj2;

	private bool isMax;

	private int requireItemCnt;

	public Action OnClickBtn;

	public Action OnClosePopup;

	public bool HaveStaff;

	private void Awake()
	{
	}

	private void UpdateData(SuperStaffCardData cardData)
	{
	}

	public void SetStaffBtnInteractable(bool value)
	{
	}

	public void SetContextRootVisible(bool visible)
	{
	}

	public void SetGetBtnVisible(bool visible)
	{
	}

	public void SetGetBtnInteractable(bool value)
	{
	}

	public void SetGetBtnText(string text)
	{
	}

	public void UnlockText(int lv, bool visible)
	{
	}

	public void UnlockTex2(int lv, bool visible)
	{
	}

	public void SetNextTimeTextVisible(bool visible)
	{
	}

	private void OnClickStaff()
	{
	}

	private void OnClickInsideBtn()
	{
	}
}
