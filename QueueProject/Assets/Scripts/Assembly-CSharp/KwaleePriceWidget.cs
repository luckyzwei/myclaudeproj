using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Serialization;

public class KwaleePriceWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckProductPrice_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KwaleePriceWidget _003C_003E4__this;

		public Action finish;

		private Product _003Cproduct_003E5__2;

		private float _003CstartTime_003E5__3;

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
		public _003CCheckProductPrice_003Ed__20(int _003C_003E1__state)
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

	private const float TIMEOUT = 1f;

	[FormerlySerializedAs("m_name")]
	[SerializeField]
	private TMP_Text m_nameText;

	[SerializeField]
	private GameObject m_loader;

	[Header("Free")]
	[SerializeField]
	private GameObject m_freeGroup;

	[FormerlySerializedAs("m_iapPrice")]
	[Header("IAP")]
	[SerializeField]
	private TMP_Text m_iapPriceText;

	[FormerlySerializedAs("m_appPurchaseGroup")]
	[SerializeField]
	private GameObject m_iapGroup;

	[Header("Ads")]
	[SerializeField]
	private GameObject m_adsGroup;

	[Header("Soft Currency")]
	[SerializeField]
	private Transform m_layout;

	[SerializeField]
	private ItemWithAmountCell m_itemWithAmountCell;

	[SerializeField]
	private GameObject m_plusPrefab;

	private bool m_productNotFound;

	private KwaleePrice m_price;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Configure(KwaleePrice price, string localisedName = null)
	{
	}

	public void Configure(Item item, int price, string localisedName = null)
	{
	}

	public void Clear()
	{
	}

	private void ConfigurePriceType(KwaleePrice price)
	{
	}

	private void ConfigureItemPrice(Item item, int price)
	{
	}

	private void DisableLoader()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckProductPrice_003Ed__20))]
	private IEnumerator CheckProductPrice(Action finish)
	{
		return null;
	}

	private void ShowLoader(bool show)
	{
	}

	private void UpdatePrice()
	{
	}

	private void ConfigureLocalisedName(string localisedName)
	{
	}

	private bool IsFree(KwaleePrice price)
	{
		return false;
	}
}
