using System;
using System.Collections.Generic;
using KWGameSettings;

namespace KWPushNotifications.PushMessageManager
{
	public class PushRuleEngine
	{
		private readonly PushNotifications m_settings;

		private readonly PushStorage m_storage;

		public PushRuleEngine(PushNotifications settings, PushStorage storage)
		{
		}

		public List<Push> ApplyAllRules(List<Push> pushes)
		{
			return null;
		}

		private List<Push> ApplyTimeRestrictions(List<Push> pushes)
		{
			return null;
		}

		private List<Push> ApplySpamPreventionWithOptimalTiming(List<Push> pushes)
		{
			return null;
		}

		private DateTime FindNextValidTime(DateTime minTime, DateTime maxTime, List<DateTime> occupiedTimes, List<Push> validPushes)
		{
			return default(DateTime);
		}

		private DateTime GetNextTimeOutsideQuietHours(DateTime time)
		{
			return default(DateTime);
		}

		private List<Push> SortByPriority(List<Push> pushes)
		{
			return null;
		}

		private bool IsWithinQuietHours(DateTime time)
		{
			return false;
		}

		private List<Push> ApplyDailyCapLimit(List<Push> pushes)
		{
			return null;
		}

		private (int, int) ParseHourMinute(int value)
		{
			return default((int, int));
		}
	}
}
