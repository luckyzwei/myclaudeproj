using System;

public class MiniGameScheduleInfo
{
	public int ScheduleIndex;

	public int EventIdx;

	public E_MiniGameType MiniGameType;

	public DateTime StartTime;

	public DateTime Endtime;

	public void SetEmpty()
	{
		ScheduleIndex = 0;
		EventIdx = 0;
		MiniGameType = 0;
		StartTime = DateTime.MinValue;
		Endtime = DateTime.MinValue;
	}

	public bool IsEmpty()
	{
		return ScheduleIndex <= 0;
	}
}
