using System;
using System.Collections.Generic;

namespace KWAttribution.Attribution
{
	public class AttributionManager
	{
		private ProviderBase m_providerBase;

		public void Initialise()
		{
		}

		private void CreateAttributionProvider()
		{
		}

		public void DoOnApplicationPause(bool pause)
		{
		}

		public void SendLevelAchievedEvent(int level, float? score)
		{
		}

		public void SendEvent(string eventName, Dictionary<string, string> parameters = null, int value = 0)
		{
		}

		public void AttributeCrossPromoClick(CrossPromoAttributionInfoBase crossPromoInfo, Action<bool, string> clickAttributionCallback)
		{
		}

		public void AttributeCrossPromoImpression(CrossPromoAttributionInfoBase crossPromoInfo)
		{
		}
	}
}
