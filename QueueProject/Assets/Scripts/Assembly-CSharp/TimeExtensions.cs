public static class TimeExtensions
{
	private const string DECIMAL_FORMAT_1 = "D1";

	private const string DECIMAL_FORMAT_2 = "D2";

	private const string ABOVE_DAY_FORMAT = "{d}d {h}h";

	private const int HOURS_IN_DAY = 24;

	private const int MINUTES_IN_HOUR = 60;

	private const int SECONDS_IN_HOUR = 3600;

	public static string FormatTime(this int totalSeconds, string format = "{h}:{m}:{s}", bool allowDayOverride = true)
	{
		return null;
	}
}
