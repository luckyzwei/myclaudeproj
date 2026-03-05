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
		base.Awake();
		ItemDistributorProductList = new List<ItemDistributorProduct>();
		if (GuideInfoBtn != null) GuideInfoBtn.onClick.AddListener(OnClickedGuideInfoBtn);
	}

	private void OnDestroy()
	{
		if (OnChangeSellingProductIdxDisposable != null)
		{
			OnChangeSellingProductIdxDisposable.Dispose();
			OnChangeSellingProductIdxDisposable = null;
		}
	}

	private void OnDisable()
	{
		if (OnChangeSellingProductIdxDisposable != null)
		{
			OnChangeSellingProductIdxDisposable.Dispose();
			OnChangeSellingProductIdxDisposable = null;
		}
	}

	public void Init()
	{
		// Initialize distributor menu with building data
		SetBuildingNameText("");
		SetEmptySellingProduct();
	}

	private void SetBuildingNameText(string nameKey)
	{
		if (BuildingNameText != null) BuildingNameText.text = nameKey;
	}

	private void SetSellingProductInfo(int productIdx, int distributeCoolTimeSec)
	{
		ProductDistributeCoolTimeSec = distributeCoolTimeSec;
		// Set current selling product icon and income text
		if (CurDistributeProductIncomeValueText != null)
			CurDistributeProductIncomeValueText.text = "0";
	}

	private void SetEmptySellingProduct()
	{
		if (CurDistributeProductIconImage != null) CurDistributeProductIconImage.gameObject.SetActive(false);
		if (CurDistributeProductIncomeValueText != null) CurDistributeProductIncomeValueText.text = "";
	}

	private void SetSaleProductList(Dictionary<int, SeasonalDistributorProductData> saleProductsMap)
	{
		if (saleProductsMap == null) return;
		ItemDistributorProductList.Clear();
		// Instantiate product items from prefab into scroll
	}

	public void FocusToObject(int productIdx)
	{
		FocusProductIdx = productIdx;
		StartCoroutine(CheckFocusAfterScrolled_Delayed());
	}

	[IteratorStateMachine(typeof(_003CCheckFocusAfterScrolled_Delayed_003Ed__20))]
	private IEnumerator CheckFocusAfterScrolled_Delayed()
	{
		yield return null;
		// Scroll to focus product after layout
		if (DistributorProductScrollRect != null)
		{
			DistributorProductScrollRect.normalizedPosition = Vector2.zero;
		}
	}

	private void OnFocusAfterScrolled(Vector2 value)
	{
		// Handle scroll position changes
	}

	private void OnClickedGuideInfoBtn()
	{
		// Show distributor guide info popup
	}
}
