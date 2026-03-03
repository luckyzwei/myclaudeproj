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
	}

	public override void Reset()
	{
	}

	private void SetPurchaseItem()
	{
	}

	private void OnPurchaseItem()
	{
	}
}
