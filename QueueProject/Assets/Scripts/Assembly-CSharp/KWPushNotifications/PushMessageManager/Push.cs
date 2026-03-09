using System;

namespace KWPushNotifications.PushMessageManager
{
	[Serializable]
	public class Push
	{
		public PushTriggerData TriggerData { get; set; }

		public DateTime QueuedTime { get; set; }

		public DateTime ScheduledTime { get; set; }

		public string RejectionReason { get; set; }

		public int PlatformNotificationId { get; set; }

		public Push(PushTriggerData triggerData)
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
