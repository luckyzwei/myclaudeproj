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
		if (btnStaff != null)
			btnStaff.onClick.AddListener(OnClickStaff);
		if (btnGet != null)
			btnGet.onClick.AddListener(OnClickInsideBtn);
	}

	private void UpdateData(SuperStaffCardData cardData)
	{
		if (cardData == null) return;
		HaveStaff = cardData.StaffLevel != null && cardData.StaffLevel.Value > 0;
		if (LockObj != null)
			LockObj.SetActive(!HaveStaff);
		if (Reddot != null)
			Reddot.SetActive(false);
	}

	public void SetStaffBtnInteractable(bool value)
	{
		if (btnStaff != null)
			btnStaff.interactable = value;
	}

	public void SetContextRootVisible(bool visible)
	{
		if (ContextRoot != null)
			ContextRoot.SetActive(visible);
	}

	public void SetGetBtnVisible(bool visible)
	{
		if (btnGet != null)
			btnGet.gameObject.SetActive(visible);
	}

	public void SetGetBtnInteractable(bool value)
	{
		if (btnGet != null)
			btnGet.interactable = value;
	}

	public void SetGetBtnText(string text)
	{
		if (textGetBtn != null)
			textGetBtn.text = text;
	}

	public void UnlockText(int lv, bool visible)
	{
		if (textUnlockLv != null)
		{
			textUnlockLv.gameObject.SetActive(visible);
			if (visible)
				textUnlockLv.text = "Lv." + lv;
		}
	}

	public void UnlockTex2(int lv, bool visible)
	{
		if (textUnlockLv2 != null)
		{
			textUnlockLv2.gameObject.SetActive(visible);
			if (visible)
				textUnlockLv2.text = "Lv." + lv;
		}
		if (LockObj2 != null)
			LockObj2.SetActive(visible);
	}

	public void SetNextTimeTextVisible(bool visible)
	{
		if (textNextTime != null)
			textNextTime.gameObject.SetActive(visible);
	}

	private void OnClickStaff()
	{
		OnClickBtn?.Invoke();
	}

	private void OnClickInsideBtn()
	{
		OnClickBtn?.Invoke();
	}
}
