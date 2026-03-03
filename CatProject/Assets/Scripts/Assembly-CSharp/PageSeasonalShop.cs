using System.Collections.Generic;
using SeasonalDef;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageSeasonalShop", false, false)]
public class PageSeasonalShop : FullScreenUI
{
	public enum ShopEnterPlace
	{
		hud = 0,
		plant = 1,
		supply = 2,
		gem = 3,
		manager = 4
	}

	public enum ShopContentsType
	{
		None = -1,
		SlotMachineCoin = 0,
		Gem = 1
	}

	[SerializeField]
	private HudTopComponent hud;

	[SerializeField]
	private Text MachineCoinText;

	[SerializeField]
	private Transform MachineCoinTrans;

	[SerializeField]
	private ScrollRect ShopScroll;

	[SerializeField]
	private List<IShopContents> contents;

	private ShopContentsType FocusContents;

	[HideInInspector]
	public int SavedOneTimeCount;

	private CompositeDisposable disposables;

	public override void OnShowBefore()
	{
	}

	private void UpdateMachineCoin()
	{
	}

	public void RefreshItems()
	{
	}

	public void SetEnterPlace(ShopEnterPlace place)
	{
	}

	private void Focus()
	{
	}

	public void UpdateGem()
	{
	}

	public void SetFocusContents(ShopContentsType type)
	{
	}

	public void SetFocus(ShopContentsType type)
	{
	}

	private void OnDestroy()
	{
	}

	public override void OnHideAfter()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void Hide()
	{
	}

	public Vector3 GetHUDWorldPos(E_CurrencyType type)
	{
		return default(Vector3);
	}
}
