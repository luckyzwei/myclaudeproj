using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemOfficeCompanyInfo : MonoBehaviour
{
	private enum E_SlotState
	{
		None = 0,
		NotContract = 1,
		NotContract_NeedDesk = 2,
		Contract_RemainTime = 3,
		Contract_EnableLvUp = 4,
		Contract_MaxLv = 5,
		Contract_ExpireTime = 6
	}

	[Header("Office")]
	[SerializeField]
	private Text OfficeNameText;

	[SerializeField]
	private Button OfficeShortCutBtn;

	[Header("CompanyInfo")]
	[SerializeField]
	private ItemCompanyBase ItemCompanyBase;

	[Header("ContractInfo")]
	[SerializeField]
	private Text ContractRemainTimeText_NotMaxLv;

	[SerializeField]
	private Text ContractRemainTimeText_MaxLv;

	[SerializeField]
	private Button NeedDeskButton;

	[SerializeField]
	private Text NeedDeskCountText;

	[SerializeField]
	private Button ContractBtn;

	[Header("ReContractInfo")]
	[SerializeField]
	private Text RecontractPriceText;

	[SerializeField]
	private Button RecontractBtn;

	[SerializeField]
	private Button FindNewCompanyBtn;

	[SerializeField]
	private Button LevelUpButton;

	[Header("StateObj")]
	[SerializeField]
	private GameObject CompanyInfoObj;

	[SerializeField]
	private GameObject ContractTimeObj_NotMaxLv;

	[SerializeField]
	private GameObject ContractTimeObj_MaxLv;

	[SerializeField]
	private GameObject ReContractInfoObj;

	[SerializeField]
	private GameObject NotContractObj;

	[SerializeField]
	private GameObject LevelUpObj;

	[SerializeField]
	private GameObject SelectedObj;

	private int OfficeIdx;

	private BigInteger NeedCompanyExp;

	private BigInteger RecontractPrice;

	private bool IsMaxLevelCompany;

	private IDisposable Disposable_RemainTime;

	private IDisposable Disposable_CompanyContract;

	private IDisposable Disposable_CompanyExp;

	private List<GameObject> ActiveObjectList;

	private int NeedDeskCount;

	private void Awake()
	{
		ActiveObjectList = new List<GameObject>
		{
			CompanyInfoObj, ContractTimeObj_NotMaxLv, ContractTimeObj_MaxLv,
			ReContractInfoObj, NotContractObj, LevelUpObj
		};

		if (OfficeShortCutBtn != null) OfficeShortCutBtn.onClick.AddListener(OnClickOfficeShortCutBtn);
		if (ContractBtn != null) ContractBtn.onClick.AddListener(OnClickFindNewCompanyBtn);
		if (RecontractBtn != null) RecontractBtn.onClick.AddListener(OnClickRecontract);
		if (FindNewCompanyBtn != null) FindNewCompanyBtn.onClick.AddListener(OnClickFindNewCompanyBtn);
		if (NeedDeskButton != null) NeedDeskButton.onClick.AddListener(OnClickNeedDeskShortCurBtn);
		if (LevelUpButton != null) LevelUpButton.onClick.AddListener(OnClickCompanyLevelUp);
	}

	private void OnDisable()
	{
		if (Disposable_RemainTime != null) { Disposable_RemainTime.Dispose(); Disposable_RemainTime = null; }
		if (Disposable_CompanyContract != null) { Disposable_CompanyContract.Dispose(); Disposable_CompanyContract = null; }
		if (Disposable_CompanyExp != null) { Disposable_CompanyExp.Dispose(); Disposable_CompanyExp = null; }
	}

	private void Reset()
	{
		OnDisable();
		IsMaxLevelCompany = false;
		NeedCompanyExp = BigInteger.Zero;
		RecontractPrice = BigInteger.Zero;
		NeedDeskCount = 0;
	}

	public void Set(int officeIdx)
	{
		Reset();
		OfficeIdx = officeIdx;
		SetOfficeInfo(officeIdx);
	}

	public void SetActiveSelectedObj(bool isActive)
	{
		if (SelectedObj != null) SelectedObj.SetActive(isActive);
	}

	private void SetOfficeInfo(int officeIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (OfficeNameText != null) OfficeNameText.text = "";
		// Determine slot state based on office data
		SetSlotState(E_SlotState.NotContract);
	}

	private void SetOfficeContractInfo(int companyIdx)
	{
		if (ItemCompanyBase != null)
		{
			// Set company info display
		}
		if (CompanyInfoObj != null) CompanyInfoObj.SetActive(true);
	}

	private void UpdateCompanyContractRemainTime(int remainTimeSec)
	{
		string timeText = ProjectUtility.GetTimeStringFormattingShort(remainTimeSec);
		if (!IsMaxLevelCompany)
		{
			if (ContractRemainTimeText_NotMaxLv != null) ContractRemainTimeText_NotMaxLv.text = timeText;
		}
		else
		{
			if (ContractRemainTimeText_MaxLv != null) ContractRemainTimeText_MaxLv.text = timeText;
		}
	}

	private void SetRecontractInfo()
	{
		if (RecontractPriceText != null)
			RecontractPriceText.text = ProjectUtility.GetThousandCommaText(RecontractPrice);
	}

	private void SetSlotState(E_SlotState slotState)
	{
		// Hide all state objects
		if (ActiveObjectList != null)
		{
			for (int i = 0; i < ActiveObjectList.Count; i++)
			{
				if (ActiveObjectList[i] != null) ActiveObjectList[i].SetActive(false);
			}
		}

		switch (slotState)
		{
			case E_SlotState.NotContract:
				if (NotContractObj != null) NotContractObj.SetActive(true);
				break;
			case E_SlotState.NotContract_NeedDesk:
				if (NotContractObj != null) NotContractObj.SetActive(true);
				if (NeedDeskCountText != null) NeedDeskCountText.text = NeedDeskCount.ToString();
				break;
			case E_SlotState.Contract_RemainTime:
				if (CompanyInfoObj != null) CompanyInfoObj.SetActive(true);
				if (ContractTimeObj_NotMaxLv != null) ContractTimeObj_NotMaxLv.SetActive(true);
				break;
			case E_SlotState.Contract_EnableLvUp:
				if (CompanyInfoObj != null) CompanyInfoObj.SetActive(true);
				if (LevelUpObj != null) LevelUpObj.SetActive(true);
				break;
			case E_SlotState.Contract_MaxLv:
				if (CompanyInfoObj != null) CompanyInfoObj.SetActive(true);
				if (ContractTimeObj_MaxLv != null) ContractTimeObj_MaxLv.SetActive(true);
				break;
			case E_SlotState.Contract_ExpireTime:
				if (ReContractInfoObj != null) ReContractInfoObj.SetActive(true);
				SetRecontractInfo();
				break;
		}
	}

	private void OnClickRecontract()
	{
		// Recontract with current company
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickOfficeShortCutBtn()
	{
		// Navigate to this office
	}

	private void OnClickNeedDeskShortCurBtn()
	{
		// Navigate to desk purchase/upgrade
	}

	private void OnClickFindNewCompanyBtn()
	{
		// Open company list popup for this office
	}

	private void OnClickCompanyLevelUp()
	{
		// Level up company in this office
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
