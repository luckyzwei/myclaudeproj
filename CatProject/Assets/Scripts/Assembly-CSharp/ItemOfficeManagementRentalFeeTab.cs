using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemOfficeManagementRentalFeeTab : MonoBehaviour
{
	[SerializeField]
	private ItemBoosterGraph ItemBoosterGraph;

	[Header("RentalFee")]
	[SerializeField]
	private Button RevenueDetailBtn;

	[SerializeField]
	private GameObject RevenueDetailObj;

	[Header("RentalFeeDetail")]
	[SerializeField]
	private Text OfficeFeeText;

	[SerializeField]
	private Text PlantFeeText;

	[SerializeField]
	private Text BuffObjFeeText;

	[SerializeField]
	private Text CarFeeText;

	[SerializeField]
	private Text CarCollectionFeeText;

	[SerializeField]
	private Text BoosterFeeText;

	[SerializeField]
	private Text IAPFeeText;

	[SerializeField]
	private GameObject BoosterItemPrefab;

	[SerializeField]
	private ScrollRect BoosterItemScroll;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void Init()
	{
	}

	private void SetRentalFeeInfos()
	{
	}

	private void SetBoosterItems()
	{
	}

	private void OnActivateMultiRevenue(bool isActivate)
	{
	}

	private void OnClickRevenueDetail()
	{
	}

	public GameObject GetRentalFeeBoostBtn()
	{
		return null;
	}
}
