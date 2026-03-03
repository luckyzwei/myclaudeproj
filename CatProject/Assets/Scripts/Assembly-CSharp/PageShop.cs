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

	[IteratorStateMachine(typeof(_003CFocusCoroutine_003Ed__18))]
	private IEnumerator FocusCoroutine()
	{
		return null;
	}

	public void UpdateGem()
	{
	}

	public void SetFocus(ShopContentsType type)
	{
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

	private void OnClickCash()
	{
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID type)
	{
		return default(Vector3);
	}
}
