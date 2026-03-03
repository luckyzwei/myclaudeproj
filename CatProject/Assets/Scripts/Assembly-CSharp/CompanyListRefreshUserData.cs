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
	}

	public CompanyListRefreshUserData(int remainCnt, DateTime lastChargeTime)
	{
	}

	public void SetDefine()
	{
	}

	public void UseRefresh()
	{
	}

	public void FullCharge()
	{
	}

	public DateTime GetNextChargeTime()
	{
		return default(DateTime);
	}

	public void UpdateAutoCharge(DateTime currentTime)
	{
	}

	public bool IsFullCharge()
	{
		return false;
	}

	public static CompanyListRefreshUserData FromFlatBuffer(CompanyListRefreshData? fbData)
	{
		return null;
	}

	public static Offset<CompanyListRefreshData> ToFlatBuffer(FlatBufferBuilder builder, CompanyListRefreshUserData data)
	{
		return default(Offset<CompanyListRefreshData>);
	}
}
