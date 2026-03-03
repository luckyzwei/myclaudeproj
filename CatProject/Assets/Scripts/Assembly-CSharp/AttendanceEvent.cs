using System;

public class AttendanceEvent
{
	public int EventIdx { get; set; }

	public E_AttendanceEventType AttendanceEventType { get; set; }

	public DateTime AttendanceStartTime { get; set; }

	public DateTime AttendanceEndTime { get; set; }
}
