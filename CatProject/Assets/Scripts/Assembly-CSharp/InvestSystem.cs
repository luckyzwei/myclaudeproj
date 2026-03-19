using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UniRx;
using UnityEngine;

public class InvestSystem
{
	private int invest_amount_multiple_min;

	private int invest_amount_multiple_max;

	private int invest_duration;

	public IReactiveProperty<int> RemainResetTime;

	public IReactiveProperty<int> CurSelectViewIdx;

	public Subject<int> OnStartInvest;

	private Dictionary<int, InvestData> investDataMap;

	public int invest_recovery_money_multiple { get; private set; }

	public bool isOn { get; private set; }

	public void Init()
	{
		RemainResetTime = new ReactiveProperty<int>(0);
		CurSelectViewIdx = new ReactiveProperty<int>(0);
		OnStartInvest = new Subject<int>();
		investDataMap = new Dictionary<int, InvestData>();

		invest_amount_multiple_min = 1;
		invest_amount_multiple_max = 5;
		invest_duration = 3600;
		invest_recovery_money_multiple = 2;

		CheckIsOn();
	}

	private void OpenFirstPopup()
	{
		// TODO
	}

	private void CheckIsOn()
	{
		isOn = true;
	}

	public void ChangeCurViewInvestIdx(int idx)
	{
		if (CurSelectViewIdx != null)
			CurSelectViewIdx.Value = idx;
	}

	public void SelectCompany(InvestData investData)
	{
		if (investData == null) return;
		investDataMap[investData.CompanyIdx] = investData;
	}

	private void ResetInvestData(int Idx)
	{
		if (investDataMap != null && investDataMap.ContainsKey(Idx))
		{
			var data = investDataMap[Idx];
			data.CompanyIdx = 0;
			data.InvestMoney = BigInteger.Zero;
			data.MultipleValue = 0;
			data.InvestStartTime = DateTime.MinValue;
			data.NextResetTime = DateTime.UtcNow.AddSeconds(invest_duration);
		}
	}

	public InvestData GetSelectInvestData(int idx)
	{
		if (investDataMap != null && investDataMap.TryGetValue(idx, out var data))
			return data;
		return null;
	}

	public void GetReward(int idx, Action<BigInteger> Cb)
	{
		var data = GetSelectInvestData(idx);
		if (data == null || data.InvestMoney <= 0)
		{
			Cb?.Invoke(BigInteger.Zero);
			return;
		}

		// Check if investment duration has elapsed
		if (data.InvestStartTime != DateTime.MinValue)
		{
			double elapsed = (DateTime.UtcNow - data.InvestStartTime).TotalSeconds;
			if (elapsed < invest_duration)
			{
				// Not ready yet
				Cb?.Invoke(BigInteger.Zero);
				return;
			}
		}

		BigInteger reward = data.InvestMoney * data.MultipleValue * invest_recovery_money_multiple;
		ResetInvestData(idx);
		Cb?.Invoke(reward);
	}

	public BigInteger GetInitialInvestMoney(int idx)
	{
		var data = GetSelectInvestData(idx);
		if (data != null)
			return data.InvestMoney;
		return BigInteger.Zero;
	}

	public void StartInvest(GameObject obj, int idx, Action Cb)
	{
		var data = GetSelectInvestData(idx);
		if (data == null || data.CompanyIdx <= 0)
		{
			Cb?.Invoke();
			return;
		}

		data.MultipleValue = UnityEngine.Random.Range(invest_amount_multiple_min, invest_amount_multiple_max + 1);
		data.InvestStartTime = DateTime.UtcNow;

		OnStartInvest.OnNext(idx);
		Cb?.Invoke();
	}

	public void UpdateOneSeconds()
	{
		if (RemainResetTime != null && RemainResetTime.Value > 0)
		{
			RemainResetTime.Value--;
		}
	}
}
