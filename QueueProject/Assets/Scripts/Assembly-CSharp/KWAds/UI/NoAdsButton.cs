using KWCore.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KWAds.UI
{
	public class NoAdsButton : BaseBehaviour
	{
		[SerializeField]
		private Text m_productCost;

		[SerializeField]
		private TextMeshProUGUI m_productCostTMP;

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		public void OnNoAdsPurchasePress()
		{
		}

		private void ConfigButton()
		{
		}

		private void HandleProductPurchased()
		{
		}

		private void UpdatePriceText(string priceText)
		{
		}
	}
}
