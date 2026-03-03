using System;
using UnityEngine;

public class EmployeeMoodSystem : MonoBehaviour
{
	public enum Mood
	{
		Bad = 1,
		Soso = 2,
		Good = 3,
		VeryGood = 4,
		Strike = 5
	}

	public class MoodBuff
	{
		public int buffidx;

		public int effectvalue;

		public DateTime endTime;

		public int duration;

		public float d_time;
	}

	public int activity_debuff_idx { get; private set; }

	public int mood_critical_cooltime { get; private set; }

	public int mood_critical_runtime { get; private set; }

	public void Init()
	{
	}

	public void UpdateMoodCurStageOffices()
	{
	}

	public void UpdateMood(int office)
	{
	}

	public void UpdateMood(int office, int seat)
	{
	}

	private void UpdateMood(EmployeeData employData, int officeScore, bool onStrike)
	{
	}

	public void AddMoodBuff(int office, int seat, int buff)
	{
	}

	public void RemoveMoodbuff(int office, int seat, int buffidx = -1)
	{
	}

	public void UpdateOneSeconds()
	{
	}

	private int CalcOfficeItemScore(int officeIdx, OfficeData officeData, int companyGrade)
	{
		return 0;
	}
}
