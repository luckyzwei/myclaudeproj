using System;
using System.Numerics;
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

	public int invest_recovery_money_multiple { get; private set; }

	public bool isOn { get; private set; }

	public void Init()
	{
	}

	private void OpenFirstPopup()
	{
	}

	private void CheckIsOn()
	{
	}

	public void ChangeCurViewInvestIdx(int idx)
	{
	}

	public void SelectCompany(InvestData investData)
	{
	}

	private void ResetInvestData(int Idx)
	{
	}

	public InvestData GetSelectInvestData(int idx)
	{
		return null;
	}

	public void GetReward(int idx, Action<BigInteger> Cb)
	{
	}

	public BigInteger GetInitialInvestMoney(int idx)
	{
		return default(BigInteger);
	}

	public void StartInvest(GameObject obj, int idx, Action Cb)
	{
	}

	public void UpdateOneSeconds()
	{
	}
}
