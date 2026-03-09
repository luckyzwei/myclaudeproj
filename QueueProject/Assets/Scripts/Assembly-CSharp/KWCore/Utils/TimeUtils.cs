using System;

namespace KWCore.Utils
{
	public static class TimeUtils
	{
		public const int SECOND = 1000;

		public const int MINUTE = 60000;

		public const int HOUR = 3600000;

		public const int DAY = 86400000;

		public const long MS_IN_DAYS = 86400000L;

		public static long GetEpochTimeMills()
		{
			return 0L;
		}

		public static long? GetEpochTimeMillsNTP()
		{
			return null;
		}

		public static long GetEpochTimeServerOrLocalUtcSeconds()
		{
			return 0L;
		}

		public static TimeSpan GetEpochTimeSpanNtpOrLocalUtc()
		{
			return default(TimeSpan);
		}

		public static long GetTimeMills(int year, int month, int day)
		{
			return 0L;
		}

		public static DateTime? GetDateTimeNTP()
		{
			return null;
		}

		public static int GetUTCOffsetHours()
		{
			return 0;
		}

		public static int GetUTCOffsetMills()
		{
			return 0;
		}

		public static long GetEpochTimeSeconds()
		{
			return 0L;
		}

		public static string GetDateStringFromEpochTime(long eventTime)
		{
			return null;
		}

		public static string GetDateStringAsNumberFormatFromEpochTime(long eventTime)
		{
			return null;
		}

		public static DateTime GetDateTimeFromEpochTime(long eventTime)
		{
			return default(DateTime);
		}

		public static DayOfWeek GetDayOfTheWeek(int offset = 0)
		{
			return default(DayOfWeek);
		}

		public static long ConvertDateTimeToEpochTime(DateTime date)
		{
			return 0L;
		}

		public static double MillisecondsToSeconds(long ms)
		{
			return 0.0;
		}
	}
}
