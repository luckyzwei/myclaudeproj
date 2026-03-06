using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ShopContentsSkillStoneBox : IShopContents
{
	[SerializeField]
	private GameObject RootObj;

	[SerializeField]
	private GameObject PurchaseBtnObj;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private TimeComponent RemainTimeComponent;

	[Header("SoldOut")]
	[SerializeField]
	private GameObject SoldOutObj;

	[SerializeField]
	private Image SoldOutImage;

	[SerializeField]
	private Text SoldOutText;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private GameObject RedDotObj;

	private ItemShopProduct ItemProductSlot;

	private List<int> SkillStoneProductIdxList;

	private int TargetShopGoodsIdx;

	private CompositeDisposable Disposables;

	private IDisposable TimeUpdateDisposable;

	public IReactiveProperty<int> CostMoneyRegionIdx;

	public override void Init()
	{
		base.Init();
		Disposables = new CompositeDisposable();
		SkillStoneProductIdxList = new List<int>();
		if (PurchaseBtn != null) PurchaseBtn.onClick.AddListener(OnPurchaseItem);
		SetPurchaseItem();
	}

	public override void Reset()
	{
		base.Reset();
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
		if (TimeUpdateDisposable != null) { TimeUpdateDisposable.Dispose(); TimeUpdateDisposable = null; }
		SetPurchaseItem();
	}

	private void SetPurchaseItem()
	{
		if (RootObj != null) RootObj.SetActive(true);
		if (SoldOutObj != null) SoldOutObj.SetActive(false);
		if (PurchaseBtnObj != null) PurchaseBtnObj.SetActive(true);
		if (RedDotObj != null) RedDotObj.SetActive(false);
	}

	private void OnPurchaseItem()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
