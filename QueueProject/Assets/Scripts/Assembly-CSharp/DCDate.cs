using System;
using System.Globalization;

public class DCDate
{
	public int year;

	public int month;

	public int day;

	public DCDate()
	{
	}

	public DCDate(DCDate dcDate)
	{
	}

	public DCDate(int year, int month, int day)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string GetMonthName(bool abbreviated = true, CultureInfo culture = null)
	{
		return null;
	}

	public bool IsSameDate(DCDate dcDate)
	{
		return false;
	}

	public static DCDate LatestDate()
	{
		return null;
	}

	public bool IsLatestMonth()
	{
		return false;
	}

	public bool IsLatestDate()
	{
		return false;
	}

	public int DaysInMonth()
	{
		return 0;
	}

	public static TimeSpan operator -(DCDate d1, DCDate d2)
	{
		return default(TimeSpan);
	}

	public static bool TryParse(string dateString, out DCDate dcDate)
	{
		dcDate = null;
		return false;
	}
}
