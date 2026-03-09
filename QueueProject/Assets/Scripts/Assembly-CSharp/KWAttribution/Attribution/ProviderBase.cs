using System;
using System.Collections.Generic;

namespace KWAttribution.Attribution
{
	public abstract class ProviderBase
	{
		public abstract void Initialise();

		public virtual void DoOnApplicationPause(bool pause)
		{
		}

		public virtual void SendPurchaseEvent(string productId, float price, bool isRestored, int quantity, string productCategory, string currencyCode)
		{
		}

		public virtual void SendLevelAchievedEvent(int level, float? score)
		{
		}

		public virtual void SendEvent(string eventName, Dictionary<string, string> parameters = null, int value = 0)
		{
		}

		public virtual void AttributeCrossPromoClick(CrossPromoAttributionInfoBase crossPromoInfo, Action<bool, string> clickAttributionCallback)
		{
		}

		public virtual void AttributeCrossPromoImpression(CrossPromoAttributionInfoBase crossPromoInfo)
		{
		}
	}
}
