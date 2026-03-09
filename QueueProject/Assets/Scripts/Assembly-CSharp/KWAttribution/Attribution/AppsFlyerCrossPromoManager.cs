using System;

namespace KWAttribution.Attribution
{
	public class AppsFlyerCrossPromoManager
	{
		private Action<bool, string> m_clickAttributionCallback;

		public void AttributeClick(CrossPromoAttributionInfoBase crossPromoInfo, Action<bool, string> clickAttributionCallback)
		{
		}

		public void AttributeImpression(CrossPromoAttributionInfoBase crossPromoInfo)
		{
		}

		private void OnOpenStoreLinkGenerated(string link)
		{
		}

		private void CallClickAttributionCallback(bool success, string link)
		{
		}
	}
}
