using System;
using Balancy.Data.SmartObjects;
using Balancy.Models.SmartObjects;
using Balancy.SmartObjects;

namespace Balancy
{
	public class MySmartObjectsEvents : ISmartObjectsEvents
	{
		private const string SEGMENTED_SESSION_BUCKET = "SEGMENTED_SESSION_ID";

		public static string SEGMENTED_SESSION_ID;

		public static Action<OfferInfo> OnNewOfferActivatedEvent;

		public static Action<OfferGroupInfo> OnNewOfferGroupActivatedEvent;

		public static Action<OfferGroupInfo> OnOfferGroupDeactivatedEvent;

		public static Action<OfferInfo, bool> OnOfferDeactivatedEvent;

		public static Action OnSmartObjectsInitializedEvent;

		public static Action<SegmentInfo> OnSegmentUpdatedEvent;

		public void OnSystemProfileConflictAppeared()
		{
		}

		public void OnNewOfferActivated(OfferInfo offerInfo)
		{
		}

		public void OnNewOfferGroupActivated(OfferGroupInfo offerInfo)
		{
		}

		public void OnOfferDeactivated(OfferInfo offerInfo, bool wasPurchased)
		{
		}

		public void OnOfferGroupDeactivated(OfferGroupInfo offerInfo, bool wasPurchased)
		{
		}

		public void OnNewEventActivated(EventInfo eventInfo)
		{
		}

		public void OnEventDeactivated(EventInfo eventInfo)
		{
		}

		public void OnOfferPurchased(OfferInfo offerInfo)
		{
		}

		public void OnOfferGroupPurchased(OfferGroupInfo offerInfo, StoreItem storeItem)
		{
		}

		public void OnOfferFailedToPurchase(OfferInfo offerInfo, string error)
		{
		}

		public void OnStoreItemFailedToPurchase(StoreItem storeItem, string error)
		{
		}

		public void OnSegmentUpdated(SegmentInfo segmentInfo)
		{
		}

		private void TrySendGameSettingsUpdatedEvent()
		{
		}

		public void OnUserProfilesLoaded()
		{
		}

		public void OnSmartObjectsInitialized()
		{
		}

		public void OnAbTestStarted(LiveOps.ABTests.TestData abTestInfo)
		{
		}

		public void OnAbTestEnded(LiveOps.ABTests.TestData abTestInfo)
		{
		}
	}
}
