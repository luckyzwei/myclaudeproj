using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class PackageComponentBlackFriday : PackageComponent
{
	[Header("[PackageComponentBlackFriday]")]
	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private GameObject CashRootObj;

	[SerializeField]
	private Button CashBtn;

	[SerializeField]
	private Text CashCount;

	[Space(5f)]
	[SerializeField]
	private GameObject Page1Row1Root;

	[SerializeField]
	private GameObject Page1Row2Root;

	[Space(5f)]
	[SerializeField]
	private GameObject Page2Root;

	[Space(10f)]
	[SerializeField]
	private GameObject NoExpObj;

	[Header("Toggle")]
	[SerializeField]
	private GameObject ToggleRoot;

	[SerializeField]
	private List<Toggle> PageToggles;

	private List<int> onToggles;

	private List<ItemPackageGroup> Page1ItemPackageGroups;

	private List<ItemPackageGroup> Page2ItemPackageGroups;

	private int remainDay;

	private int CurPage;

	private int Page1PackagesCount;

	private CompositeDisposable disposables;

	private void Awake()
	{
	}

	public override void SetSaleList(int packageIdx)
	{
	}

	private void SetPage1()
	{
	}

	private void SetPage2()
	{
	}

	private void SetPage(int page)
	{
	}

	private void UpdatePage1Layout()
	{
	}

	private void OnEnable()
	{
	}

	private void SubscribeCash()
	{
	}

	private void OnClickCashShop()
	{
	}

	public override void OnBuySuccess(int idx)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
