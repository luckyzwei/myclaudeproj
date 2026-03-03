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
	}

	public void Set(int officeIdx)
	{
	}

	public void UpdateStrike()
	{
	}

	private void UpdateCompany()
	{
	}

	public void UpdateBuff()
	{
	}

	private void UpdateManager()
	{
	}

	public void Refresh()
	{
	}

	public void SetActiveSelectedObj(bool isActive)
	{
	}

	private void OnClickCeoHire()
	{
	}

	private void OnClickStartNego()
	{
	}

	private void OnClickInNego()
	{
	}
}
