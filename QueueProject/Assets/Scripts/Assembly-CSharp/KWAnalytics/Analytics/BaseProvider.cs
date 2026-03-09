using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KWAnalytics.Analytics
{
	public abstract class BaseProvider : MonoBehaviour
	{
		public abstract void StartSession();

		public abstract void FlushSession();

		public void LogEvent(BaseSchema baseSchema)
		{
		}

		public void LogEvent(AnalyticEvent analyticEvent)
		{
		}

		public virtual void LogEventImmediate(AnalyticEvent analyticEvent)
		{
		}

		public void ProductPurchased(decimal price, string currencyCode, string productCode, string transactionID, string receipt)
		{
		}

		protected abstract void LogEventInternal(BaseSchema baseSchema);

		protected abstract void LogEventInternal(AnalyticEvent analyticEvent);

		public virtual List<Hashtable> GetAllEventsFromStorage()
		{
			return null;
		}

		protected virtual void ProductPurchasedInternal(decimal price, string currencyCode, string productCode, string transactionID, string receipt)
		{
		}

		public virtual void AppSuspendHasBegun(bool suspend)
		{
		}

		public virtual void AddProviderParameters(BaseSchema schema)
		{
		}
	}
}
