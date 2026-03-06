using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemListOfficeCEO : MonoBehaviour
{
	[SerializeField]
	private Text OfficeNameText;

	[SerializeField]
	private GameObject FocusObj;

	[Header("Empty")]
	[SerializeField]
	private GameObject EmptyObj;

	[Header("Strike")]
	[SerializeField]
	private GameObject InStrikeObj;

	[SerializeField]
	private GameObject NegoObj;

	[SerializeField]
	private Button StartNegoBtn;

	[SerializeField]
	private Button InNegoBtn;

	[Header("Company")]
	[SerializeField]
	private GameObject CompanyObj;

	[SerializeField]
	private Text CompanyNameText;

	[SerializeField]
	private Image CompanyLogoImage;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private GameObject CompanySpecialObj;

	[Header("CEO")]
	[SerializeField]
	private GameObject EmptyCeoObj;

	[SerializeField]
	private Button CeoHireBtn;

	[SerializeField]
	private GameObject HaveCeoObj;

	[SerializeField]
	private ItemManagerCardMin CeoItem;

	[SerializeField]
	private Text CeoLevelText;

	[Header("Buff")]
	[SerializeField]
	private GameObject BuffObj;

	[SerializeField]
	private Text GetMoneyText;

	[SerializeField]
	private GameObject MoneyPauseObj;

	[SerializeField]
	private GameObject MoneyBuffObj;

	[SerializeField]
	private Text GetExpText;

	[SerializeField]
	private GameObject ExpPauseObj;

	[SerializeField]
	private GameObject ExpBuffObj;

	public Action RefreshList;

	private int OfficeIdx;

	private void Awake()
	{
		if (CeoHireBtn != null) CeoHireBtn.onClick.AddListener(OnClickCeoHire);
		if (StartNegoBtn != null) StartNegoBtn.onClick.AddListener(OnClickStartNego);
		if (InNegoBtn != null) InNegoBtn.onClick.AddListener(OnClickInNego);
	}

	public void Set(int officeIdx)
	{
		OfficeIdx = officeIdx;
		Refresh();
	}

	public void UpdateStrike()
	{
		if (InStrikeObj != null) InStrikeObj.SetActive(false);
		if (NegoObj != null) NegoObj.SetActive(false);
	}

	private void UpdateCompany()
	{
		if (CompanyObj != null) CompanyObj.SetActive(false);
		if (EmptyObj != null) EmptyObj.SetActive(true);
		// Load company data from office index and set name/logo/grade
	}

	public void UpdateBuff()
	{
		if (BuffObj != null) BuffObj.SetActive(false);
		if (MoneyPauseObj != null) MoneyPauseObj.SetActive(false);
		if (ExpPauseObj != null) ExpPauseObj.SetActive(false);
		if (MoneyBuffObj != null) MoneyBuffObj.SetActive(false);
		if (ExpBuffObj != null) ExpBuffObj.SetActive(false);
	}

	private void UpdateManager()
	{
		if (EmptyCeoObj != null) EmptyCeoObj.SetActive(true);
		if (HaveCeoObj != null) HaveCeoObj.SetActive(false);
		// Check if CEO is assigned to this office
	}

	public void Refresh()
	{
		UpdateCompany();
		UpdateManager();
		UpdateBuff();
		UpdateStrike();
	}

	public void SetActiveSelectedObj(bool isActive)
	{
		if (FocusObj != null) FocusObj.SetActive(isActive);
	}

	private void OnClickCeoHire()
	{
		// Open CEO hire popup for this office
	}

	private void OnClickStartNego()
	{
		// Start negotiation for strike resolution
	}

	private void OnClickInNego()
	{
		// Continue in-progress negotiation
	}
}
