using System;
using Balancy.Models.SmartObjects;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public class StorePurchaseButton : MonoBehaviour
{
	private const string RV_LOCATION_PURCHASE = "RV_store_{0}_purchase";

	[SerializeField]
	[Autohook]
	protected Button m_button;

	protected Product m_referencedProduct;

	protected Action<bool> m_productPurchasedCallback;

	private void Start()
	{
	}

	public void Initialise(Product product, Action<bool> productPurchasedCallback)
	{
	}

	private void CheckForProductIssues()
	{
	}

	private void CheckPriceIssues(Price price)
	{
	}

	public virtual void OnPurchasePressed()
	{
	}

	private void TryToBuy()
	{
	}

	protected virtual void OnPurchaseCallback(bool didPurchase)
	{
	}
}
