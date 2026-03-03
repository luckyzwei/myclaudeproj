using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCompanyRecontract", false, false)]
public class PopupCompanyRecontract : UIBase
{
	[Header("CompanyInfo")]
	[SerializeField]
	private ItemCompanyBase CompanyBase;

	[SerializeField]
	private GameObject RecontractRecommandObj;

	[SerializeField]
	private GameObject OutRecommandObj;

	[Header("RentalInfo")]
	[SerializeField]
	private Text CurRentalFee;

	[SerializeField]
	private Text NextRentalFee;

	[Header("ContractInfo")]
	[SerializeField]
	private Text RecontractPricteText;

	[SerializeField]
	private Button RecontractBtn;

	[SerializeField]
	private Button OutBtn;

	private int OfficeIdx;

	private BigInteger RecontractPrice;

	protected override void Awake()
	{
	}

	public void Set(int office)
	{
	}

	private void OnClickRecontract()
	{
	}

	private void OnClickOut()
	{
	}
}
