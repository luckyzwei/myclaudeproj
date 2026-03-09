using System;
using System.Collections.Generic;

namespace KWPushNotifications.PushMessageManager
{
	[Serializable]
	public class PushTriggerData
	{
		public string PushLocationId { get; set; }

		public PushPriority Priority { get; set; }

		public string Title { get; set; }

		public string Body { get; set; }

		public int MinMinutesToDeliver { get; set; }

		public int MaxMinutesToDeliver { get; set; }

		public bool AbsoluteTime { get; set; }

		public string DeepLinkReference { get; set; }

		public string ImageUrl { get; set; }

		public Dictionary<string, object> CustomData { get; set; }

		public PushTriggerData(string pushLocationId, string title, string body, int minMinutes, int maxMinutes, bool absoluteTime = false)
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
