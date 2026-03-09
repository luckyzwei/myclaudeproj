using System;

[Serializable]
public class TimeSpanSerializable
{
	public int days;

	public int hours;

	public int minutes;

	public int seconds;

	public TimeSpan GetTimeSpan()
	{
		return default(TimeSpan);
	}
}
