using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAuctionSpy", false, false)]
public class PageAuctionSpy : UIBase
{
	private enum SpyStatus
	{
		Default = 0,
		Find = 1,
		Search = 2
	}

	[SerializeField]
	private Button SpyBtn;

	[SerializeField]
	private Button MoreBtn;

	[SerializeField]
	private Text SpyPriceText;

	[SerializeField]
	private Text SpyMorePriceText;

	[SerializeField]
	private Text CashText;

	[SerializeField]
	private Button CashShopBtn;

	[SerializeField]
	private List<ItemAuctionSpy> FindNpcs;

	[SerializeField]
	private List<GameObject> Roots;

	private CompositeDisposable disposables;

	private int Price;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void UpdateInfo()
	{
	}

	private void OnClickCashShop()
	{
	}

	private void OnClickSpyStart()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
