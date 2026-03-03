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
	}

	public void UpdateStrike()
	{
	}

	private void SetStrike()
	{
	}

	private void SetOfficeStrikeEnable(int officeIdx, int regionIdx, OfficeData officeData)
	{
	}

	public void UpdateStrikeTime(int dayTime)
	{
	}

	public int GetRemainStrikeAlertSecond()
	{
		return 0;
	}

	public int GetRequiredLevelGap(int officeKey)
	{
		return 0;
	}

	private void ShowPopupToastmessageStrike()
	{
	}

	private void FocusStrikeOffice()
	{
	}

	public int GetStrikeRatio(int officeIdx, int regionIdx)
	{
		return 0;
	}

	public void SetNegotiation(int officeIdx)
	{
	}

	public BigInteger GetNegotiationGemCount(int officeIdx, int regionIdx)
	{
		return default(BigInteger);
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void LogStrikeResolve(int officeIdx, int companyGrade, int needValue, int type)
	{
	}

	public void LogStrikeStart(int officeIdx, int companyGrade, int needValue)
	{
	}
}
