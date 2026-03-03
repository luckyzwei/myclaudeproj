using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupDockList", false, false)]
public class PopupDistributorMenu : UIBase
{
	[CompilerGenerated]
	private sealed class _003CCheckFocusAfterScrolled_Delayed_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupDistributorMenu _003C_003E4__this;

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
		public _003CCheckFocusAfterScrolled_Delayed_003Ed__20(int _003C_003E1__state)
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

	[SerializeField]
	private Text BuildingNameText;

	[SerializeField]
	private Image CurDistributeProductIconImage;

	[SerializeField]
	private Text CurDistributeProductIncomeValueText;

	[SerializeField]
	private ScrollRect DistributorProductScrollRect;

	[SerializeField]
	private GameObject ItemDistributorProductPrefab;

	[SerializeField]
	private Button GuideInfoBtn;

	private int BuildingIdx;

	private int FocusProductIdx;

	private int ProductDistributeCoolTimeSec;

	private List<ItemDistributorProduct> ItemDistributorProductList;

	private IDisposable OnChangeSellingProductIdxDisposable;

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void Init()
	{
	}

	private void SetBuildingNameText(string nameKey)
	{
	}

	private void SetSellingProductInfo(int productIdx, int distributeCoolTimeSec)
	{
	}

	private void SetEmptySellingProduct()
	{
	}

	private void SetSaleProductList(Dictionary<int, SeasonalDistributorProductData> saleProductsMap)
	{
	}

	public void FocusToObject(int productIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckFocusAfterScrolled_Delayed_003Ed__20))]
	private IEnumerator CheckFocusAfterScrolled_Delayed()
	{
		return null;
	}

	private void OnFocusAfterScrolled(Vector2 value)
	{
	}

	private void OnClickedGuideInfoBtn()
	{
	}
}
