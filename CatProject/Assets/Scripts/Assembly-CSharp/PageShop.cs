using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageShop", false, false)]
public class PageShop : FullScreenUI
{
	public enum ShopEnterPlace
	{
		hud = 0,
		plant = 1,
		supply = 2,
		gem = 3,
		mission = 4,
		fail = 5
	}

	public enum ShopContentsType
	{
		None = -1,
		Package1 = 0,
		Package2 = 1,
		Special = 2,
		Money = 3,
		Exp = 4,
		Tonic = 5,
		Gem = 6,
		ManagerBox = 101,
		ManagerKey_Normal = 102,
		ManagerKey_Premium = 103,
		Manager_ReinStone = 104,
		Manager_DailySkillStone = 105,
		Manager_SkillStone = 106
	}

	[CompilerGenerated]
	private sealed class _003CFocusCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageShop _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFocusCoroutine_003Ed__18(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const int ManagerTabStartIdx = 100;

	private const int MANAGER_FREE_BOX_IDX = 9001;

	public int SavedOneTimeCount;

	[SerializeField]
	private HUDTopInfo HudTopInfo;

	[SerializeField]
	private ScrollRect ShopScroll;

	[SerializeField]
	private GameObject TabRootObj;

	[SerializeField]
	private TabToggleGroup TabToggleGroup;

	[SerializeField]
	private ItemShopTabManager ManagerTab;

	[SerializeField]
	private List<IShopContents> contents;

	private ShopContentsType FocusContents;

	private bool IsReadyPage;

	private bool IsManagerTabOpen;

	public override void OnShowBefore()
	{
		IsReadyPage = true;
		RefreshItems();
		Focus();
	}

	public void RefreshItems()
	{
		if (contents == null) return;
		for (int i = 0; i < contents.Count; i++)
		{
			if (contents[i] != null)
				contents[i].Init();
		}
	}

	public void SetEnterPlace(ShopEnterPlace place)
	{
		// Set initial focus based on entry place
		switch (place)
		{
			case ShopEnterPlace.gem:
				FocusContents = ShopContentsType.Gem;
				break;
			case ShopEnterPlace.supply:
				FocusContents = ShopContentsType.Tonic;
				break;
			default:
				FocusContents = ShopContentsType.None;
				break;
		}
	}

	private void Focus()
	{
		if (FocusContents == ShopContentsType.None) return;
		StartCoroutine(FocusCoroutine());
	}

	[IteratorStateMachine(typeof(_003CFocusCoroutine_003Ed__18))]
	private IEnumerator FocusCoroutine()
	{
		yield return null;
		// Scroll to focused content section
		FocusContents = ShopContentsType.None;
	}

	public void UpdateGem()
	{
		if (HudTopInfo != null) HudTopInfo.UpdateCurrencyInfos();
	}

	public void SetFocus(ShopContentsType type)
	{
		FocusContents = type;
		Focus();
	}

	public void SetFocus(int rewardType, int rewardIdx)
	{
	}

	public void ShowArrow(ShopContentsType type)
	{
	}

	public void HideArrows()
	{
	}

	private void OnChangeTab(int tabIdx)
	{
		// Handle shop tab change
		bool isManagerTab = tabIdx >= ManagerTabStartIdx;
		IsManagerTabOpen = isManagerTab;
		if (ManagerTab != null) ManagerTab.gameObject.SetActive(isManagerTab);
	}

	private void OnDestroy()
	{
		IsReadyPage = false;
	}

	public override void OnHideAfter()
	{
		IsReadyPage = false;
	}

	public override void OnHideBefore()
	{
		HideArrows();
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void OnClickCash()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID type)
	{
		if (HudTopInfo != null) return HudTopInfo.transform.position;
		return default(Vector3);
	}
}
