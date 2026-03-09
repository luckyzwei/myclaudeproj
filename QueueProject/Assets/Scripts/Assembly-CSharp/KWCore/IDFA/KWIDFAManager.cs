using System;
using KWCore.Utils;

namespace KWCore.IDFA
{
	public class KWIDFAManager
	{
		private const string IDFA_EVENTS_QUEUE_ID = "IDFAManager.TryShowIDFAPopUp";

		private const string POPUP_TYPE = "PopUpIDFA";

		private DeviceSettingsManager m_deviceSettingsManager;

		private EventsQueue m_eventsQueue;

		private Action m_popupFinishedCallback;

		private EventsQueue.Event m_idfaEventCallback;

		[EventsQueuePriority(QueueId = "IDFAManager.TryShowIDFAPopUp", Priority = 200)]
		public void Initialise(DeviceSettingsManager deviceSettingsManager, EventsQueue eventsQueue)
		{
		}

		public bool IsIDFAAnswered()
		{
			return false;
		}

		public bool IsIDFARejected()
		{
			return false;
		}

		public void SetExistingTrackingEnabled()
		{
		}
	}
}
