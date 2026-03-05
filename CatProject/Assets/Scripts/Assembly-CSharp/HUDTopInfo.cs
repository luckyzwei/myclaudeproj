using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
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
		UpdateCurrencyInfos();
	}

	private void OnDisable()
	{
		if (RewardUpdateDisposables != null)
		{
			foreach (var kvp in RewardUpdateDisposables)
				kvp.Value?.Dispose();
			RewardUpdateDisposables.Clear();
		}
		if (ItemAddDisposables != null)
		{
			foreach (var kvp in ItemAddDisposables)
				kvp.Value?.Dispose();
			ItemAddDisposables.Clear();
		}
	}

	private void OnDestroy()
	{
		if (RewardUpdateDisposables != null)
		{
			foreach (var kvp in RewardUpdateDisposables)
				kvp.Value?.Dispose();
			RewardUpdateDisposables.Clear();
		}
		if (ItemAddDisposables != null)
		{
			foreach (var kvp in ItemAddDisposables)
				kvp.Value?.Dispose();
			ItemAddDisposables.Clear();
		}
	}

	public void Reset()
	{
		TopInfoList = null;
		if (RewardUpdateDisposables != null)
		{
			foreach (var kvp in RewardUpdateDisposables)
				kvp.Value?.Dispose();
			RewardUpdateDisposables.Clear();
		}
		if (ItemAddDisposables != null)
		{
			foreach (var kvp in ItemAddDisposables)
				kvp.Value?.Dispose();
			ItemAddDisposables.Clear();
		}
		if (CurrencyObject != null)
		{
			for (int i = 0; i < CurrencyObject.Count; i++)
			{
				if (CurrencyObject[i] != null)
					CurrencyObject[i].gameObject.SetActive(false);
			}
		}
	}

	public void SetCurrencyInfo(TopInfoData topInfoData)
	{
		var list = new List<TopInfoData>();
		list.Add(topInfoData);
		SetCurrencyInfo(list);
	}

	public void SetCurrencyInfo(List<TopInfoData> topInfoDataList)
	{
		Reset();
		TopInfoList = new List<TopInfoData>();
		RewardUpdateDisposables = new Dictionary<int, IDisposable>();
		ItemAddDisposables = new Dictionary<int, IDisposable>();

		// Priority 1: Use TopCurrencyList if available
		if (TopCurrencyList != null && TopCurrencyList.Count > 0)
		{
			for (int i = 0; i < TopCurrencyList.Count && i < CurrencyObject.Count; i++)
			{
				var currencyId = TopCurrencyList[i];
				var data = TopInfoData.MakeCommonData(Config.CurrencyGameType.Main, (int)Config.RewardType.Currency, (int)currencyId, 0);
				TopInfoList.Add(data);
			}
		}

		// Priority 2: Use TopRewardList if available
		if (TopRewardList != null && TopRewardList.Count > 0)
		{
			for (int i = 0; i < TopRewardList.Count; i++)
			{
				if (TopInfoList.Count < CurrencyObject.Count)
					TopInfoList.Add(TopRewardList[i]);
			}
		}

		// Add from parameter list
		if (topInfoDataList != null)
		{
			for (int i = 0; i < topInfoDataList.Count; i++)
			{
				if (TopInfoList.Count < CurrencyObject.Count)
					TopInfoList.Add(topInfoDataList[i]);
			}
		}

		// Set each slot
		for (int i = 0; i < TopInfoList.Count && i < CurrencyObject.Count; i++)
		{
			SetCurrencySlotInfo(i, TopInfoList[i]);
			SubscribeSlotEvent(i);
		}
	}

	public void UpdateCurrencyInfos()
	{
		if (TopInfoList == null || CurrencyObject == null)
			return;

		for (int i = 0; i < TopInfoList.Count && i < CurrencyObject.Count; i++)
		{
			SetCurrencySlotInfo(i, TopInfoList[i]);
		}
	}

	public void ChangeCurrencyInfo(int index, TopInfoData topInfoData)
	{
		if (TopInfoList == null || index < 0 || index >= TopInfoList.Count)
			return;

		RemoveRewardUpdateDisposable(index);
		TopInfoList[index] = topInfoData;
		SetCurrencySlotInfo(index, topInfoData);
		SubscribeSlotEvent(index);
	}

	private void SubscribeSlotEvent(int index)
	{
		if (TopInfoList == null || index < 0 || index >= TopInfoList.Count)
			return;

		var topInfoData = TopInfoList[index];
		var rewardType = (Config.RewardType)topInfoData.RewardType;

		if (rewardType == Config.RewardType.Currency)
		{
			var currencyIdx = (Config.CurrencyID)topInfoData.RewardIdx;
			var regionType = (Config.RegionType)topInfoData.RegionType;
			SubscribeCurrencyValue(index, currencyIdx, regionType);
		}
		else if (rewardType == Config.RewardType.Item)
		{
			SubscribeItemValue(index, topInfoData.RewardIdx);
		}
	}

	public void SetCurrencySlotInfo(int index, TopInfoData topInfoData)
	{
		if (CurrencyObject == null || index < 0 || index >= CurrencyObject.Count)
			return;

		var comp = CurrencyObject[index];
		if (comp == null)
			return;

		comp.gameObject.SetActive(true);

		var rewardType = (Config.RewardType)topInfoData.RewardType;
		string valueText = "0";

		var userDataSystem = Singleton<GameRoot>.Instance.UserData;
		if (rewardType == Config.RewardType.Currency)
		{
			var currencyIdx = (Config.CurrencyID)topInfoData.RewardIdx;
			if (currencyIdx == Config.CurrencyID.Gold)
				valueText = ProjectUtility.GetThousandCommaText(userDataSystem.HUDMoney.Value);
			else if (currencyIdx == Config.CurrencyID.Cash)
				valueText = userDataSystem.HUDCash.Value.ToString();
			else if (currencyIdx == Config.CurrencyID.Gem)
				valueText = userDataSystem.Cash.Value.ToString();

			var icon = ProjectUtility.GetCurrencyImg((int)currencyIdx, topInfoData.RegionType, 0);
			if (icon != null)
				comp.SetCurrencyIcon(icon);
		}
		else if (rewardType == Config.RewardType.Item)
		{
			int itemIdx = topInfoData.RewardIdx;
			var itemDataList = userDataSystem.ItemData;
			if (itemDataList != null)
			{
				for (int i = 0; i < itemDataList.Count; i++)
				{
					if (itemDataList[i].ItemIdx == itemIdx)
					{
						valueText = itemDataList[i].ItemCount.ToString();
						break;
					}
				}
			}

			var icon = ProjectUtility.GetItemImg(itemIdx);
			if (icon != null)
				comp.SetCurrencyIcon(icon);
		}

		comp.SetValueText(valueText);
	}

	public void UpdateValue(int index, string valueText)
	{
		if (CurrencyObject == null || index < 0 || index >= CurrencyObject.Count)
			return;

		var comp = CurrencyObject[index];
		if (comp != null)
			comp.SetValueText(valueText);
	}

	private void UpdateSeasonalValue(int currencyIdx, BigInteger value_PerMile)
	{
		if (TopInfoList == null)
			return;

		for (int i = 0; i < TopInfoList.Count; i++)
		{
			var data = TopInfoList[i];
			if (data.GameType == Config.CurrencyGameType.Event && data.RewardIdx == currencyIdx)
			{
				string valueText = ProjectUtility.GetThousandCommaText(value_PerMile);
				UpdateValue(i, valueText);
				break;
			}
		}
	}

	public List<TopInfoData> GetTopInfoList()
	{
		return TopInfoList;
	}

	public CurrencyHUDComponent GetCurrencyHUDComponent(int index)
	{
		if (CurrencyObject == null || index < 0 || index >= CurrencyObject.Count)
			return null;
		return CurrencyObject[index];
	}

	public CurrencyHUDComponent FindHUDComponent(TopInfoData topInfoData)
	{
		if (TopInfoList == null || CurrencyObject == null)
			return null;

		for (int i = 0; i < TopInfoList.Count && i < CurrencyObject.Count; i++)
		{
			var data = TopInfoList[i];
			if (data.RewardType == topInfoData.RewardType &&
				data.RewardIdx == topInfoData.RewardIdx &&
				data.RegionType == topInfoData.RegionType &&
				data.GameType == topInfoData.GameType)
			{
				return CurrencyObject[i];
			}
		}
		return null;
	}

	public Transform FindTopInfoEndTransform(int index)
	{
		var comp = GetCurrencyHUDComponent(index);
		if (comp != null)
			return comp.GetCurrencyEffectEndTransform();
		return null;
	}

	public Transform FindTopInfoEndTransform(TopInfoData topInfoData)
	{
		var comp = FindHUDComponent(topInfoData);
		if (comp != null)
			return comp.GetCurrencyEffectEndTransform();
		return null;
	}

	private void SubscribeCurrencyValue(int index, Config.CurrencyID currencyIdx, Config.RegionType regionType)
	{
		RemoveRewardUpdateDisposable(index);

		var userDataSystem = Singleton<GameRoot>.Instance.UserData;
		IDisposable disposable = null;

		if (currencyIdx == Config.CurrencyID.Gold)
		{
			disposable = userDataSystem.HUDMoney.Subscribe(value =>
			{
				UpdateValue(index, ProjectUtility.GetThousandCommaText(value));
			});
		}
		else if (currencyIdx == Config.CurrencyID.Cash)
		{
			disposable = userDataSystem.HUDCash.Subscribe(value =>
			{
				UpdateValue(index, value.ToString());
			});
		}
		else if (currencyIdx == Config.CurrencyID.Gem)
		{
			disposable = userDataSystem.Cash.Subscribe(value =>
			{
				UpdateValue(index, value.ToString());
			});
		}

		if (disposable != null)
			AddRewardUpdateDisposable(index, disposable);
	}

	private void SubscribeItemValue(int index, int itemIdx)
	{
		RemoveRewardUpdateDisposable(index);

		var userDataSystem = Singleton<GameRoot>.Instance.UserData;
		var itemDataList = userDataSystem.ItemData;
		if (itemDataList == null)
			return;

		for (int i = 0; i < itemDataList.Count; i++)
		{
			if (itemDataList[i].ItemIdx == itemIdx)
			{
				var capturedIndex = index;
				var disposable = itemDataList[i].CountProperty.Subscribe(count =>
				{
					UpdateValue(capturedIndex, count.ToString());
				});
				AddRewardUpdateDisposable(index, disposable);
				break;
			}
		}

		// Also subscribe to collection changes in case item is added later
		var itemDisposable = itemDataList.ObserveAdd().Subscribe(addEvent =>
		{
			if (addEvent.Value.ItemIdx == itemIdx)
			{
				var capturedIndex = index;
				UpdateValue(capturedIndex, addEvent.Value.ItemCount.ToString());
				var countDisposable = addEvent.Value.CountProperty.Subscribe(count =>
				{
					UpdateValue(capturedIndex, count.ToString());
				});
				AddRewardUpdateDisposable(capturedIndex, countDisposable);
			}
		});
		AddItemAddDisposable(itemIdx, itemDisposable);
	}

	private void AddRewardUpdateDisposable(int index, IDisposable disposable)
	{
		if (RewardUpdateDisposables == null)
			RewardUpdateDisposables = new Dictionary<int, IDisposable>();

		RemoveRewardUpdateDisposable(index);
		RewardUpdateDisposables[index] = disposable;
	}

	private void RemoveRewardUpdateDisposable(int index)
	{
		if (RewardUpdateDisposables == null)
			return;

		if (RewardUpdateDisposables.TryGetValue(index, out var disposable))
		{
			disposable?.Dispose();
			RewardUpdateDisposables.Remove(index);
		}
	}

	private void AddItemAddDisposable(int itemIdx, IDisposable disposable)
	{
		if (ItemAddDisposables == null)
			ItemAddDisposables = new Dictionary<int, IDisposable>();

		RemoveItemAddDisposable(itemIdx);
		ItemAddDisposables[itemIdx] = disposable;
	}

	private void RemoveItemAddDisposable(int itemIdx)
	{
		if (ItemAddDisposables == null)
			return;

		if (ItemAddDisposables.TryGetValue(itemIdx, out var disposable))
		{
			disposable?.Dispose();
			ItemAddDisposables.Remove(itemIdx);
		}
	}
}
