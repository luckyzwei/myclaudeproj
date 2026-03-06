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
		Disposables = new CompositeDisposable();
		if (RevenueDetailBtn != null) RevenueDetailBtn.onClick.AddListener(OnClickRevenueDetail);
	}

	private void OnDisable()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	public void Init()
	{
		SetRentalFeeInfos();
		SetBoosterItems();
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
		if (RevenueDetailObj != null) RevenueDetailObj.SetActive(!RevenueDetailObj.activeSelf);
	}

	public GameObject GetRentalFeeBoostBtn()
	{
		return RevenueDetailBtn != null ? RevenueDetailBtn.gameObject : null;
	}
}
