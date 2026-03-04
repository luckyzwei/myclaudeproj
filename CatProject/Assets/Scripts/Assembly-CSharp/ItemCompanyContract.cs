using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;
using UnityEngine.UI;

public class ItemCompanyContract : MonoBehaviour
{
	[Header("CompanyInfo")]
	[SerializeField]
	private ItemCompanyBase ItemCompanyBase;

	[Header("ContractInfo")]
	[SerializeField]
	private Text RecontractPricteText;

	[SerializeField]
	private Button RecontractBtn;

	[SerializeField]
	private Button OutBtn;

	private int OfficeIdx;

	private BigInteger RecontractPrice;

	private void Awake()
	{
	}

	public void Set(int officeIdx)
	{
	}

	private void OnClickRecontract()
	{
	}

	private void OnClickOut()
	{
	}
}
