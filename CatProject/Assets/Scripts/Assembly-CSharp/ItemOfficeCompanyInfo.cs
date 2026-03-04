using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
	}

	private void OnDisable()
	{
	}

	private void Reset()
	{
	}

	public void Set(int officeIdx)
	{
	}

	public void SetActiveSelectedObj(bool isActive)
	{
	}

	private void SetOfficeInfo(int officeIdx)
	{
	}

	private void SetOfficeContractInfo(int companyIdx)
	{
	}

	private void UpdateCompanyContractRemainTime(int remainTimeSec)
	{
	}

	private void SetRecontractInfo()
	{
	}

	private void SetSlotState(E_SlotState slotState)
	{
	}

	private void OnClickRecontract()
	{
	}

	private void OnClickOfficeShortCutBtn()
	{
	}

	private void OnClickNeedDeskShortCurBtn()
	{
	}

	private void OnClickFindNewCompanyBtn()
	{
	}

	private void OnClickCompanyLevelUp()
	{
	}
}
