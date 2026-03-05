using System;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

public class CompanyListRefreshUserData
{
	public Subject<int> OnChangeRemainCnt;

	public int RemainCnt { get; private set; }

	public int MaxChargeCnt { get; private set; }

	public DateTime LastChargeTime { get; private set; }

	public int ChargeCoolTime { get; private set; }

	public CompanyListRefreshUserData()
	{
		OnChangeRemainCnt = new Subject<int>();
	}

	public CompanyListRefreshUserData(int remainCnt, DateTime lastChargeTime)
	{
		OnChangeRemainCnt = new Subject<int>();
		RemainCnt = remainCnt;
		LastChargeTime = lastChargeTime;
	}

	public void SetDefine()
	{
		MaxChargeCnt = 5;
		ChargeCoolTime = 600;
	}

	public void UseRefresh()
	{
		if (RemainCnt > 0)
		{
			RemainCnt--;
			OnChangeRemainCnt?.OnNext(RemainCnt);
		}
	}

	public void FullCharge()
	{
		RemainCnt = MaxChargeCnt;
		LastChargeTime = DateTime.UtcNow;
		OnChangeRemainCnt?.OnNext(RemainCnt);
	}

	public DateTime GetNextChargeTime()
	{
		if (IsFullCharge()) return DateTime.UtcNow;
		return LastChargeTime.AddSeconds(ChargeCoolTime);
	}

	public void UpdateAutoCharge(DateTime currentTime)
	{
		if (IsFullCharge()) return;
		if (ChargeCoolTime <= 0) return;

		while (RemainCnt < MaxChargeCnt)
		{
			DateTime nextCharge = LastChargeTime.AddSeconds(ChargeCoolTime);
			if (currentTime < nextCharge) break;

			RemainCnt++;
			LastChargeTime = nextCharge;
		}

		if (RemainCnt >= MaxChargeCnt)
		{
			RemainCnt = MaxChargeCnt;
		}

		OnChangeRemainCnt?.OnNext(RemainCnt);
	}

	public bool IsFullCharge()
	{
		return RemainCnt >= MaxChargeCnt;
	}

	public static CompanyListRefreshUserData FromFlatBuffer(CompanyListRefreshData? fbData)
	{
		if (!fbData.HasValue) return null;
		var d = fbData.Value;
		var result = new CompanyListRefreshUserData();
		result.SetDefine();
		return result;
	}

	public static Offset<CompanyListRefreshData> ToFlatBuffer(FlatBufferBuilder builder, CompanyListRefreshUserData data)
	{
		if (data == null) return default(Offset<CompanyListRefreshData>);
		return default(Offset<CompanyListRefreshData>);
	}
}
