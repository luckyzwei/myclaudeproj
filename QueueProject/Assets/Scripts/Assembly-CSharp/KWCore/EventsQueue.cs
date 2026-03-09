using System.Collections.Generic;

namespace KWCore
{
	public class EventsQueue
	{
		public delegate void Event();

		private readonly SortedList<int, Event> m_priorityQueue;

		private bool m_isQueueActive;

		private Event m_activeEvent;

		private List<string> m_eventsOrder;

		private int m_unOrderedQueueIndex;

		private bool m_isEventSent;

		private SDKInitAnalyticsUtils m_sdkInitAnalyticsUtils;

		public EventsQueue(List<string> eventsOrder)
		{
		}

		public void Initialise()
		{
		}

		private void OnSdkLoaded()
		{
		}

		public void Subscribe(Event @event, string eventId)
		{
		}

		public void Unsubscribe(Event @event)
		{
		}

		private void TriggerQueue()
		{
		}
	}
}
