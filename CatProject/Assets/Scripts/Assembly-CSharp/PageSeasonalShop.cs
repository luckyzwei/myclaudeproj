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
		disposables = new CompositeDisposable();
		UpdateMachineCoin();
		RefreshItems();
		Focus();
	}

	private void UpdateMachineCoin()
	{
		if (MachineCoinText != null) MachineCoinText.text = "0";
	}

	public void RefreshItems()
	{
		// Refresh all shop content items
	}

	public void SetEnterPlace(ShopEnterPlace place)
	{
		switch (place)
		{
			case ShopEnterPlace.gem:
				SetFocusContents(ShopContentsType.Gem);
				break;
			default:
				SetFocusContents(ShopContentsType.SlotMachineCoin);
				break;
		}
	}

	private void Focus()
	{
		if (FocusContents == ShopContentsType.None) return;
		SetFocus(FocusContents);
	}

	public void UpdateGem()
	{
		// Update gem display in HUD
	}

	public void SetFocusContents(ShopContentsType type)
	{
		FocusContents = type;
	}

	public void SetFocus(ShopContentsType type)
	{
		FocusContents = type;
		// Scroll to focused content section
		if (ShopScroll != null)
			ShopScroll.normalizedPosition = new UnityEngine.Vector2(0f, 1f);
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	public override void OnHideAfter()
	{
	}

	public override void OnHideBefore()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	public override void Hide()
	{
		base.Hide();
	}

	public Vector3 GetHUDWorldPos(E_CurrencyType type)
	{
		if (MachineCoinTrans != null && type == E_CurrencyType.SlotMachineCoin)
			return MachineCoinTrans.position;
		return default(Vector3);
	}
}
