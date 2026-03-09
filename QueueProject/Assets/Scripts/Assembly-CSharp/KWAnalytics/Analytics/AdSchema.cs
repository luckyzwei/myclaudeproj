using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public abstract class AdSchema : ClosedSchema
	{
		public void SetInteractionClicked()
		{
		}

		public void SetInteractionShown()
		{
		}

		public void SetInteractionCompleted()
		{
		}

		public void SetInteractionSkipped()
		{
		}

		public void SetInteractionFailed()
		{
		}

		public void SetInteractionRewarded()
		{
		}

		public void SetInteractionRequested()
		{
		}

		public void SetInteractionDownloaded()
		{
		}

		public void SetInteractionTriggered()
		{
		}

		public void SetBidUSD(float bid)
		{
		}

		public void SetAdProvider(string adProvider)
		{
		}

		public void SetAdUniqueID(string id)
		{
		}

		public void SetSimulated(bool simulated)
		{
		}

		public void SetImpressionsCount(int count)
		{
		}

		public void SetStackCount(int count)
		{
		}

		public void SetAdData(string format)
		{
		}

		public void SetRequestId(string requestId)
		{
		}

		public void SetAdOpportunityId(string opportunityId)
		{
		}

		public void SetLoadTime(long loadTimeMs)
		{
		}

		public void SetAdFormat(string format)
		{
		}

		public void SetRejectionCauses(string systemCause, string mediatorCause)
		{
		}

		public void SetNoFill(bool isNoFill)
		{
		}

		public void SetAppAdPlacementFormat(string placementFormat)
		{
		}
	}
}
