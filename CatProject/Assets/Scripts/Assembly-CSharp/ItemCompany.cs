using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCompany : MonoBehaviour
{
	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private Text CompanyDesc;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private GameObject CompanySpecialObj;

	[SerializeField]
	private List<Image> LevelObjs;

	[SerializeField]
	private GameObject LevelRoot;

	[SerializeField]
	private GameObject InContractObj;

	[SerializeField]
	private Button ContractsBtn;

	[Header("NeedDesk")]
	[SerializeField]
	private GameObject NeedDeskObj;

	[SerializeField]
	private Text NeedDeskDescText;

	[SerializeField]
	private Text NeedDeskCountText;

	[SerializeField]
	private GameObject NeedDeskShortCutBtnObj;

	[SerializeField]
	private Button NeedDeskShortCutBtn;

	[SerializeField]
	private Image NeedDeskShortCutBtnImage;

	[Header("NeedCompany")]
	[SerializeField]
	private GameObject NeedCompanyObj;

	[SerializeField]
	private Text NeedCompanyDescText;

	[SerializeField]
	private Text NeedCompanyCountText;

	[Header("RecommandObj")]
	[SerializeField]
	private GameObject RecommandObj;

	public Action<int> onContracts;

	private bool inRecommend;

	private int NeedDeskCount;

	public int OfficeIdx { get; private set; }

	public int CompanyIdx { get; private set; }

	public int CompanyLevel { get; private set; }

	private void Awake()
	{
	}

	public void Set(int companyIdx)
	{
	}

	public void Set(int office, int companyIdx, int recommendGrade, int recommendLv)
	{
	}

	public void SetIsOpenCompany(bool isOpen)
	{
	}

	public void AddTutorialRegister(TutorialIdent id)
	{
	}

	private void OnClickContracts()
	{
	}

	private void OnClickNeedDeskShortCutBtn()
	{
	}
}
