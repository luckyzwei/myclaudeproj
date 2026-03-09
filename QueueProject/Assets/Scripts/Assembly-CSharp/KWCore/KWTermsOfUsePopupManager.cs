using KWCore.UI;

namespace KWCore
{
	public class KWTermsOfUsePopupManager
	{
		private const string TERMS_OF_USE_POPUP_PRIORITY = "KWTermsOfUsePopupManager.TryShowTermsOfUsePopup";

		private CoreUI.IDelegate m_delegate;

		private EventsQueue m_eventsQueue;

		[EventsQueuePriority(QueueId = "KWTermsOfUsePopupManager.TryShowTermsOfUsePopup", Priority = 400)]
		public void Initialise(CoreUI.IDelegate del, EventsQueue eventsQueue)
		{
		}

		private void TryShowTermsOfUsePopup()
		{
		}

		public bool AreTermsOfUseAccepted()
		{
			return false;
		}
	}
}
