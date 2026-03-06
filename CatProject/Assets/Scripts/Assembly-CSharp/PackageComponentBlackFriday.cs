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
		disposables = new CompositeDisposable();
		onToggles = new List<int>();
		Page1ItemPackageGroups = new List<ItemPackageGroup>();
		Page2ItemPackageGroups = new List<ItemPackageGroup>();
		CurPage = 0;

		if (CashBtn != null)
			CashBtn.onClick.AddListener(OnClickCashShop);

		if (PageToggles != null)
		{
			for (int i = 0; i < PageToggles.Count; i++)
			{
				int pageIdx = i;
				if (PageToggles[i] != null)
					PageToggles[i].onValueChanged.AddListener((isOn) => { if (isOn) SetPage(pageIdx); });
			}
		}
	}

	public override void SetSaleList(int packageIdx)
	{
		SetPage1();
		SetPage(0);
		if (ToggleRoot != null)
			ToggleRoot.SetActive(Page2ItemPackageGroups != null && Page2ItemPackageGroups.Count > 0);
	}

	private void SetPage1()
	{
		UpdatePage1Layout();
	}

	private void SetPage2()
	{
		if (Page2Root != null)
			Page2Root.SetActive(true);
	}

	private void SetPage(int page)
	{
		CurPage = page;
		bool isPage1 = page == 0;
		if (Page1Row1Root != null) Page1Row1Root.SetActive(isPage1);
		if (Page1Row2Root != null) Page1Row2Root.SetActive(isPage1);
		if (Page2Root != null) Page2Root.SetActive(!isPage1);
	}

	private void UpdatePage1Layout()
	{
		if (Page1Row1Root != null)
			Page1Row1Root.SetActive(true);
		if (Page1Row2Root != null)
			Page1Row2Root.SetActive(Page1PackagesCount > 3);
	}

	private void OnEnable()
	{
		SubscribeCash();
	}

	private void SubscribeCash()
	{
	}

	private void OnClickCashShop()
	{
	}

	public override void OnBuySuccess(int idx)
	{
		SetSaleList(idx);
	}

	private void OnDisable()
	{
		if (disposables != null)
			disposables.Clear();
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}
}
