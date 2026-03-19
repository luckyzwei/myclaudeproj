using System;
using Treeplla;
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

	private OfficeData GetOffice(int office)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return null;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Offices == null) return null;
		stageData.Offices.TryGetValue(office, out var officeData);
		return officeData;
	}

	public void Init()
	{
		activity_debuff_idx = 0;
		mood_critical_cooltime = 300;
		mood_critical_runtime = 30;
	}

	public void UpdateMoodCurStageOffices()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Offices == null) return;
		foreach (var kvp in stageData.Offices)
		{
			UpdateMood(kvp.Key);
		}
	}

	public void UpdateMood(int office)
	{
		var officeData = GetOffice(office);
		if (officeData == null || officeData.Employees == null) return;
		int companyGrade = 0;
		if (officeData.CompanyIdx != null)
			companyGrade = officeData.CompanyIdx.Value;
		int officeScore = CalcOfficeItemScore(office, officeData, companyGrade);
		bool onStrike = officeData.EnableStrike != null && officeData.EnableStrike.Value;
		for (int i = 0; i < officeData.Employees.Count; i++)
		{
			if (officeData.Employees[i] != null)
				UpdateMood(officeData.Employees[i], officeScore, onStrike);
		}
	}

	public void UpdateMood(int office, int seat)
	{
		var officeData = GetOffice(office);
		if (officeData == null || officeData.Employees == null) return;
		if (seat < 0 || seat >= officeData.Employees.Count) return;
		var employeeData = officeData.Employees[seat];
		if (employeeData == null) return;
		int companyGrade = 0;
		if (officeData.CompanyIdx != null)
			companyGrade = officeData.CompanyIdx.Value;
		int officeScore = CalcOfficeItemScore(office, officeData, companyGrade);
		bool onStrike = officeData.EnableStrike != null && officeData.EnableStrike.Value;
		UpdateMood(employeeData, officeScore, onStrike);
	}

	private void UpdateMood(EmployeeData employData, int officeScore, bool onStrike)
	{
		if (employData == null) return;
		Mood newMood;
		if (onStrike)
		{
			newMood = Mood.Strike;
		}
		else if (officeScore >= 20)
		{
			newMood = Mood.VeryGood;
		}
		else if (officeScore >= 12)
		{
			newMood = Mood.Good;
		}
		else if (officeScore >= 5)
		{
			newMood = Mood.Soso;
		}
		else
		{
			newMood = Mood.Bad;
		}
		employData.OriginMood = newMood;
		employData.NonStrikeMood = onStrike ? Mood.Bad : newMood;
		if (employData.MoodStatus != null)
			employData.MoodStatus.Value = newMood;
	}

	public void AddMoodBuff(int office, int seat, int buff)
	{
		var officeData = GetOffice(office);
		if (officeData == null || officeData.Employees == null) return;
		if (seat < 0 || seat >= officeData.Employees.Count) return;
		var employeeData = officeData.Employees[seat];
		if (employeeData == null) return;
		if (employeeData.MoodBuffs == null)
			employeeData.MoodBuffs = new System.Collections.Generic.List<MoodBuff>();
		var moodBuff = new MoodBuff { buffidx = buff, duration = mood_critical_runtime };
		employeeData.MoodBuffs.Add(moodBuff);
		// Raise mood by one tier
		Mood cur = employeeData.MoodStatus != null ? employeeData.MoodStatus.Value : Mood.Soso;
		if (cur < Mood.VeryGood && cur != Mood.Strike)
		{
			Mood raised = (Mood)((int)cur + 1);
			if (employeeData.MoodStatus != null)
				employeeData.MoodStatus.Value = raised;
		}
	}

	public void RemoveMoodbuff(int office, int seat, int buffidx = -1)
	{
		var officeData = GetOffice(office);
		if (officeData == null || officeData.Employees == null) return;
		if (seat < 0 || seat >= officeData.Employees.Count) return;
		var employeeData = officeData.Employees[seat];
		if (employeeData == null) return;
		if (employeeData.MoodBuffs != null)
		{
			if (buffidx >= 0)
				employeeData.MoodBuffs.RemoveAll(b => b.buffidx == buffidx);
			else
				employeeData.MoodBuffs.Clear();
		}
		// Re-evaluate mood without buff
		UpdateMood(office, seat);
	}

	public void UpdateOneSeconds()
	{
		// Update display
	}

	private int CalcOfficeItemScore(int officeIdx, OfficeData officeData, int companyGrade)
	{
		if (officeData == null || officeData.Items == null) return 0;
		int score = 0;
		for (int i = 0; i < officeData.Items.Count; i++)
		{
			var item = officeData.Items[i];
			if (item != null)
				score += item.Level;
		}
		return score;
	}
}
