using System;
using System.Globalization;

public class DCDate
{
	public int year;

	public int month;

	public int day;

	public DCDate()
	{
		var now = DateTime.UtcNow;
		year = now.Year;
		month = now.Month;
		day = now.Day;
	}

	public DCDate(DCDate dcDate)
	{
		year = dcDate.year;
		month = dcDate.month;
		day = dcDate.day;
	}

	public DCDate(int year, int month, int day)
	{
		this.year = year;
		this.month = month;
		this.day = day;
	}

	public override string ToString()
	{
		return $"{year}-{month:D2}-{day:D2}";
	}

	public string GetMonthName(bool abbreviated = true, CultureInfo culture = null)
	{
		if (culture == null) culture = CultureInfo.InvariantCulture;
		var date = new DateTime(year, month, 1);
		return abbreviated ? date.ToString("MMM", culture) : date.ToString("MMMM", culture);
	}

	public bool IsSameDate(DCDate dcDate)
	{
		if (dcDate == null) return false;
		return year == dcDate.year && month == dcDate.month && day == dcDate.day;
	}

	public static DCDate LatestDate()
	{
		var now = DateTime.UtcNow;
		return new DCDate(now.Year, now.Month, now.Day);
	}

	public bool IsLatestMonth()
	{
		var now = DateTime.UtcNow;
		return year == now.Year && month == now.Month;
	}

	public bool IsLatestDate()
	{
		var now = DateTime.UtcNow;
		return year == now.Year && month == now.Month && day == now.Day;
	}

	public int DaysInMonth()
	{
		return DateTime.DaysInMonth(year, month);
	}

	public static TimeSpan operator -(DCDate d1, DCDate d2)
	{
		var dt1 = new DateTime(d1.year, d1.month, d1.day);
		var dt2 = new DateTime(d2.year, d2.month, d2.day);
		return dt1 - dt2;
	}

	public static bool TryParse(string dateString, out DCDate dcDate)
	{
		dcDate = null;
		if (string.IsNullOrEmpty(dateString)) return false;
		DateTime dt;
		if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
		{
			dcDate = new DCDate(dt.Year, dt.Month, dt.Day);
			return true;
		}
		return false;
	}
}
