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
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Set rental fee detail texts from user data
		if (OfficeFeeText != null) OfficeFeeText.text = "0";
		if (PlantFeeText != null) PlantFeeText.text = "0";
		if (BuffObjFeeText != null) BuffObjFeeText.text = "0";
		if (CarFeeText != null) CarFeeText.text = "0";
		if (CarCollectionFeeText != null) CarCollectionFeeText.text = "0";
		if (BoosterFeeText != null) BoosterFeeText.text = "0";
		if (IAPFeeText != null) IAPFeeText.text = "0";
	}

	private void SetBoosterItems()
	{
		if (BoosterItemScroll == null || BoosterItemPrefab == null) return;
		if (ItemBoosterGraph != null) ItemBoosterGraph.gameObject.SetActive(true);
	}

	private void OnActivateMultiRevenue(bool isActivate)
	{
		if (BoosterFeeText != null) BoosterFeeText.gameObject.SetActive(isActivate);
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
