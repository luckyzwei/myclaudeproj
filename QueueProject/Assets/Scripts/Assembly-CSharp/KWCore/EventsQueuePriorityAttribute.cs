using System;

namespace KWCore
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class EventsQueuePriorityAttribute : Attribute
	{
		public string QueueId;

		public int Priority;
	}
}
