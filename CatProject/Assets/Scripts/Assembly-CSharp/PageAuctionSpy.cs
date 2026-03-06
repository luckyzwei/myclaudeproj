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
		base.Awake();
		disposables = new CompositeDisposable();
		if (SpyBtn != null) SpyBtn.onClick.AddListener(OnClickSpyStart);
		if (MoreBtn != null) MoreBtn.onClick.AddListener(OnClickSpyStart);
		if (CashShopBtn != null) CashShopBtn.onClick.AddListener(OnClickCashShop);
	}

	public override void OnShowBefore()
	{
		UpdateInfo();
	}

	private void UpdateInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (Roots != null)
		{
			for (int i = 0; i < Roots.Count; i++)
			{
				if (Roots[i] != null) Roots[i].SetActive(false);
			}
		}
	}

	private void OnClickCashShop()
	{
	}

	private void OnClickSpyStart()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
