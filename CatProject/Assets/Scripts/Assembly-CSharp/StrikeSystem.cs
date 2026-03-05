using System;
using System.Collections.Generic;
using System.Numerics;
using UniRx;

public class StrikeSystem
{
	private int NegotiationGemCount_Origin;

	private bool IsSystemInit;

	private bool IsStrikeOpen;

	private CompositeDisposable Disposables;

	private Dictionary<int, IDisposable> ManagerLevelDisposables;

	public int StrikeAlertTime { get; private set; }

	public int StrikeStartTime { get; private set; }

	public int StrikeEndTime { get; private set; }

	public int StrikeOfflineDebuff { get; private set; }

	public int StrikeRatio_Origin { get; private set; }

	public IReactiveProperty<bool> OnStrikeAlertTime { get; private set; }

	public IReactiveProperty<bool> OnStrikeEnable { get; private set; }

	public IReactiveProperty<bool> OnStrikeTime { get; private set; }

	public bool HasSeenPopupToastmessageStrike { get; set; }

	public void Init()
	{
		Disposables = new CompositeDisposable();
		ManagerLevelDisposables = new Dictionary<int, IDisposable>();
		OnStrikeAlertTime = new ReactiveProperty<bool>(false);
		OnStrikeEnable = new ReactiveProperty<bool>(false);
		OnStrikeTime = new ReactiveProperty<bool>(false);
		StrikeAlertTime = 3600;
		StrikeStartTime = 0;
		StrikeEndTime = 7200;
		StrikeOfflineDebuff = 50;
		StrikeRatio_Origin = 100;
		NegotiationGemCount_Origin = 10;
		HasSeenPopupToastmessageStrike = false;
		IsStrikeOpen = false;
		IsSystemInit = true;
	}

	public void UpdateStrike()
	{
		if (!IsSystemInit || !IsStrikeOpen) return;
		SetStrike();
	}

	private void SetStrike()
	{
		// Evaluate each office for strike eligibility based on manager levels
	}

	private void SetOfficeStrikeEnable(int officeIdx, int regionIdx, OfficeData officeData)
	{
		if (officeData == null) return;
		int levelGap = GetRequiredLevelGap(officeIdx);
		bool enable = levelGap > 0 && !officeData.StrikeAvoid;
		officeData.EnableStrike.Value = enable;
	}

	public void UpdateStrikeTime(int dayTime)
	{
		bool alertTime = dayTime >= StrikeAlertTime && dayTime < StrikeStartTime;
		bool strikeTime = dayTime >= StrikeStartTime && dayTime < StrikeEndTime;
		OnStrikeAlertTime.Value = alertTime;
		OnStrikeTime.Value = strikeTime;
		if (strikeTime && !HasSeenPopupToastmessageStrike)
			ShowPopupToastmessageStrike();
	}

	public int GetRemainStrikeAlertSecond()
	{
		return StrikeStartTime - StrikeAlertTime;
	}

	public int GetRequiredLevelGap(int officeKey)
	{
		return 0;
	}

	private void ShowPopupToastmessageStrike()
	{
		HasSeenPopupToastmessageStrike = true;
	}

	private void FocusStrikeOffice()
	{
		// Focus camera on first striking office
	}

	public int GetStrikeRatio(int officeIdx, int regionIdx)
	{
		return StrikeRatio_Origin;
	}

	public void SetNegotiation(int officeIdx)
	{
		// Mark office as negotiated to resolve strike
	}

	public BigInteger GetNegotiationGemCount(int officeIdx, int regionIdx)
	{
		return new BigInteger(NegotiationGemCount_Origin);
	}

	private void OnDisable()
	{
		if (Disposables != null) Disposables.Clear();
	}

	private void OnDestroy()
	{
		if (Disposables != null) Disposables.Dispose();
		if (ManagerLevelDisposables != null)
		{
			foreach (var d in ManagerLevelDisposables.Values)
				d?.Dispose();
			ManagerLevelDisposables.Clear();
		}
	}

	public void LogStrikeResolve(int officeIdx, int companyGrade, int needValue, int type)
	{
	}

	public void LogStrikeStart(int officeIdx, int companyGrade, int needValue)
	{
	}
}
