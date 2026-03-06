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
		if (RecontractBtn != null) RecontractBtn.onClick.AddListener(OnClickRecontract);
		if (OutBtn != null) OutBtn.onClick.AddListener(OnClickOut);
	}

	public void Set(int officeIdx)
	{
		OfficeIdx = officeIdx;
	}

	private void OnClickRecontract()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickOut()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupCompanyOut>();
	}
}
