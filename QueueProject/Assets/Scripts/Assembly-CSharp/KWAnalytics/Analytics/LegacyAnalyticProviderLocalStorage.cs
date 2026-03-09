using System.Collections;
using System.Collections.Generic;

namespace KWAnalytics.Analytics
{
	public class LegacyAnalyticProviderLocalStorage
	{
		public void Initialise()
		{
		}

		public void SaveEvent(Hashtable eventToSave)
		{
		}

		public void SaveEvent(List<Hashtable> eventQueue)
		{
		}

		public List<Hashtable> GetAllEvents(bool clear = true)
		{
			return null;
		}

		private List<Hashtable> GetAllEventsFromStorage(bool clear)
		{
			return null;
		}
	}
}
