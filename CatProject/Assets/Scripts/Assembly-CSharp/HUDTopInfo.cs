using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;

public class HUDTopInfo : MonoBehaviour
{
	[SerializeField]
	private List<CurrencyHUDComponent> CurrencyObject;

	[Header("Option Priority 1 - Currency")]
	[SerializeField]
	private List<Config.CurrencyID> TopCurrencyList;

	[Header("Option Priority 2 - Reward")]
	[SerializeField]
	private List<TopInfoData> TopRewardList;

	private List<TopInfoData> TopInfoList;

	private Dictionary<int, IDisposable> RewardUpdateDisposables;

	private Dictionary<int, IDisposable> ItemAddDisposables;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Reset()
	{
	}

	public void SetCurrencyInfo(TopInfoData topInfoData)
	{
	}

	public void SetCurrencyInfo(List<TopInfoData> topInfoDataList)
	{
	}

	public void UpdateCurrencyInfos()
	{
	}

	public void ChangeCurrencyInfo(int index, TopInfoData topInfoData)
	{
	}

	private void SubscribeSlotEvent(int index)
	{
	}

	public void SetCurrencySlotInfo(int index, TopInfoData topInfoData)
	{
	}

	public void UpdateValue(int index, string valueText)
	{
	}

	private void UpdateSeasonalValue(int currencyIdx, BigInteger value_PerMile)
	{
	}

	public List<TopInfoData> GetTopInfoList()
	{
		return null;
	}

	public CurrencyHUDComponent GetCurrencyHUDComponent(int index)
	{
		return null;
	}

	public CurrencyHUDComponent FindHUDComponent(TopInfoData topInfoData)
	{
		return null;
	}

	public Transform FindTopInfoEndTransform(int index)
	{
		return null;
	}

	public Transform FindTopInfoEndTransform(TopInfoData topInfoData)
	{
		return null;
	}

	private void SubscribeCurrencyValue(int index, Config.CurrencyID currencyIdx, Config.RegionType regionType)
	{
	}

	private void SubscribeItemValue(int index, int itemIdx)
	{
	}

	private void AddRewardUpdateDisposable(int index, IDisposable disposable)
	{
	}

	private void RemoveRewardUpdateDisposable(int index)
	{
	}

	private void AddItemAddDisposable(int itemIdx, IDisposable disposable)
	{
	}

	private void RemoveItemAddDisposable(int itemIdx)
	{
	}
}
