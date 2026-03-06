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
		if (ContractsBtn != null) ContractsBtn.onClick.AddListener(OnClickContracts);
		if (NeedDeskShortCutBtn != null) NeedDeskShortCutBtn.onClick.AddListener(OnClickNeedDeskShortCutBtn);
	}

	public void Set(int companyIdx)
	{
		CompanyIdx = companyIdx;
		CompanyLevel = 0;

		if (NeedDeskObj != null) NeedDeskObj.SetActive(false);
		if (NeedCompanyObj != null) NeedCompanyObj.SetActive(false);
		if (InContractObj != null) InContractObj.SetActive(false);
		if (RecommandObj != null) RecommandObj.SetActive(false);
		if (CompanySpecialObj != null) CompanySpecialObj.SetActive(false);
	}

	public void Set(int office, int companyIdx, int recommendGrade, int recommendLv)
	{
		OfficeIdx = office;
		CompanyIdx = companyIdx;
		CompanyLevel = 0;
		inRecommend = recommendGrade > 0 || recommendLv > 0;

		if (RecommandObj != null) RecommandObj.SetActive(inRecommend);
		if (NeedDeskObj != null) NeedDeskObj.SetActive(false);
		if (NeedCompanyObj != null) NeedCompanyObj.SetActive(false);
		if (InContractObj != null) InContractObj.SetActive(false);
	}

	public void SetIsOpenCompany(bool isOpen)
	{
		if (ContractsBtn != null) ContractsBtn.interactable = isOpen;
	}

	public void AddTutorialRegister(TutorialIdent id)
	{
		// TODO
	}

	private void OnClickContracts()
	{
		onContracts?.Invoke(CompanyIdx);
	}

	private void OnClickNeedDeskShortCutBtn()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOfficeUpgrade>();
	}
}
