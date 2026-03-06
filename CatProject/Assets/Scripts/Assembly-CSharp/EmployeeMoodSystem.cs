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
		if (onStrike)
		{
			// Set mood to Strike when on strike
			return;
		}
	}

	public void AddMoodBuff(int office, int seat, int buff)
	{
		var officeData = GetOffice(office);
		if (officeData == null || officeData.Employees == null) return;
		if (seat < 0 || seat >= officeData.Employees.Count) return;
		var employeeData = officeData.Employees[seat];
		if (employeeData == null) return;
	}

	public void RemoveMoodbuff(int office, int seat, int buffidx = -1)
	{
		var officeData = GetOffice(office);
		if (officeData == null || officeData.Employees == null) return;
		if (seat < 0 || seat >= officeData.Employees.Count) return;
		var employeeData = officeData.Employees[seat];
		if (employeeData == null) return;
	}

	public void UpdateOneSeconds()
	{
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
