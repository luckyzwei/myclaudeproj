using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		if (RecontractBtn != null) RecontractBtn.onClick.AddListener(OnClickRecontract);
		if (OutBtn != null) OutBtn.onClick.AddListener(OnClickOut);
	}

	public void Set(int office)
	{
		OfficeIdx = office;
	}

	private void OnClickRecontract()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private void OnClickOut()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupCompanyOut>();
	}
}
