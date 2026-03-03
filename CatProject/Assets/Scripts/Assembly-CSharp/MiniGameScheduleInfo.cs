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
	}

	public bool IsEmpty()
	{
		return false;
	}
}
