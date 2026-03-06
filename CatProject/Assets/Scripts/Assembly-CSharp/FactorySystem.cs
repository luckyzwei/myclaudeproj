using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;

public class FactorySystem
{
	private int FACTORY_NEW_ORDER_COOL_TIME;

	public static readonly int FACTORY_MISSION_COUNT;

	public IReactiveProperty<int> StorageUseCount;

	public IReactiveProperty<bool> IsStorageFull;

	public IReactiveProperty<int> RemainBatteryTime;

	public IReactiveProperty<int> RemainManagerKeyAddResetTime;

	public Subject<int> OnFactoryOrderComplete;

	public Config.E_FactoryEnterType UIEnterType;

	private int FACTORY_NEW_ORDER_EASY_MODE_COUNT;

	private bool isInit;

	public bool IsFactoryOpen { get; private set; }

	public int factory_ad_booster_max_count { get; private set; }

	public int FACTORY_ORDER_FREE_SKIP_COUNT { get; private set; }

	public int SLOT_PACKAGE_ORDER_COUNT { get; private set; }

	public int StorageFullCount { get; private set; }

	public bool ShowSlotPackagePopup { get; private set; }

	public void Init()
	{
		if (isInit) return;
		isInit = true;

		StorageUseCount = new ReactiveProperty<int>(0);
		IsStorageFull = new ReactiveProperty<bool>(false);
		RemainBatteryTime = new ReactiveProperty<int>(0);
		RemainManagerKeyAddResetTime = new ReactiveProperty<int>(0);
		OnFactoryOrderComplete = new Subject<int>();

		FACTORY_NEW_ORDER_COOL_TIME = 300;
		FACTORY_NEW_ORDER_EASY_MODE_COUNT = 3;
		factory_ad_booster_max_count = 5;
		FACTORY_ORDER_FREE_SKIP_COUNT = 3;
		SLOT_PACKAGE_ORDER_COUNT = 10;
		StorageFullCount = 50;

		UpdateStorage();
	}

	public void OpenFactoryBuilding()
	{
		IsFactoryOpen = true;
	}

	public void UpdateSlotCooltime()
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.OrderSlots == null)
			return;

		DateTime now = DateTime.UtcNow;
		foreach (var slot in factoryData.OrderSlots)
		{
			if (!slot.IsOpen) continue;
			if (slot.RemainRefreshTime == null) continue;

			int remain = (int)(slot.RefreshTime - now).TotalSeconds;
			slot.RemainRefreshTime.Value = Math.Max(0, remain);
		}
	}

	public void CalcOfflineProduct()
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.Factoris == null)
			return;

		DateTime now = DateTime.UtcNow;
		foreach (var building in factoryData.Factoris)
		{
			if (building.MakeProduct == null || building.MakeProduct.Value <= 0)
				continue;

			// Calculate how many products were produced while offline
			if (building.production_time > 0)
			{
				float elapsedSec = (float)(now - building.OpenEndTime).TotalSeconds;
				if (elapsedSec > 0)
				{
					int produced = (int)(elapsedSec / building.production_time);
					if (produced > 0)
					{
						AddProduct(building.MakeProduct.Value, produced);
					}
				}
			}
		}

		UpdateStorage();
	}

	private void UpdateMissionData()
	{
	}

	public void StartOpenFacility(int factoryIdx)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.Factoris == null)
			return;

		foreach (var building in factoryData.Factoris)
		{
			if (building.Idx == factoryIdx)
			{
				building.OpenEndTime = DateTime.UtcNow;
				if (building.OpenRemainTime != null)
					building.OpenRemainTime.Value = 0;
				break;
			}
		}
	}

	public void OpenFactoryFacility(int factoryIdx)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.Factoris == null)
			return;

		foreach (var building in factoryData.Factoris)
		{
			if (building.Idx == factoryIdx)
			{
				if (building.OpenRemainTime != null)
					building.OpenRemainTime.Value = 0;
				break;
			}
		}
	}

	public void UpdateStorageFull(bool isInit = false)
	{
		int useCount = 0;
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData != null && factoryData.FactoryItems != null)
		{
			foreach (var item in factoryData.FactoryItems.Values)
			{
				useCount += item.Count;
			}
		}

		StorageUseCount.Value = useCount;
		int fullCount = GetStorageFull();
		IsStorageFull.Value = useCount >= fullCount;

		foreach (var building in factoryData?.Factoris ?? new List<FactoryBuildingData>())
		{
			if (building.IsFull != null)
				building.IsFull.Value = IsStorageFull.Value;
		}
	}

	public void RestartFactoryMake()
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.Factoris == null)
			return;

		foreach (var building in factoryData.Factoris)
		{
			if (building.MakeProduct != null && building.MakeProduct.Value > 0)
			{
				building.UpdateProductionTime();
			}
		}
	}

	public void UseItem(int factory, int item)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.FactoryItems == null)
			return;

		if (factoryData.FactoryItems.TryGetValue(item, out var itemData))
		{
			if (itemData.Count > 0)
			{
				// Item consumed - handled by specific item logic
			}
		}
	}

	public bool IsFreeItem(int itemIdx)
	{
		return itemIdx <= 0;
	}

	public void OpenSlot(int slot)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.OrderSlots == null)
			return;

		if (slot >= 0 && slot < factoryData.OrderSlots.Count)
		{
			factoryData.OrderSlots[slot].IsOpen = true;
		}
	}

	public void CompleteOrder(int slotIdx, Action<bool> OnComplete, Action packageOpenCb)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.OrderSlots == null)
		{
			OnComplete?.Invoke(false);
			return;
		}

		if (slotIdx < 0 || slotIdx >= factoryData.OrderSlots.Count)
		{
			OnComplete?.Invoke(false);
			return;
		}

		var slot = factoryData.OrderSlots[slotIdx];
		if (!slot.IsOpen || slot.OrderProduct <= 0)
		{
			OnComplete?.Invoke(false);
			return;
		}

		// Check if player has enough products
		if (factoryData.FactoryItems != null &&
			factoryData.FactoryItems.TryGetValue(slot.OrderProduct, out var itemData))
		{
			if (itemData.Count >= slot.OrderCount)
			{
				// Deduct products - actual count management would be done here
				OnFactoryOrderComplete.OnNext(slotIdx);
				UpdateMissionData();
				UpdateStorage();
				OnComplete?.Invoke(true);

				// Reset slot for new order
				ResetOrderSlot(slotIdx);
				return;
			}
		}

		OnComplete?.Invoke(false);
	}

	public void RefreshOrder(int slot)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.OrderSlots == null)
			return;

		if (slot >= 0 && slot < factoryData.OrderSlots.Count)
		{
			var orderSlot = factoryData.OrderSlots[slot];
			orderSlot.RefreshTime = DateTime.UtcNow.AddSeconds(FACTORY_NEW_ORDER_COOL_TIME);
			if (orderSlot.RemainRefreshTime != null)
				orderSlot.RemainRefreshTime.Value = FACTORY_NEW_ORDER_COOL_TIME;
		}
	}

	public void ResetOrderSlot(int slot)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.OrderSlots == null)
			return;

		if (slot >= 0 && slot < factoryData.OrderSlots.Count)
		{
			var orderSlot = factoryData.OrderSlots[slot];
			orderSlot.OrderProduct = 0;
			orderSlot.OrderCount = 0;
			orderSlot.RefreshTime = DateTime.UtcNow.AddSeconds(FACTORY_NEW_ORDER_COOL_TIME);
			if (orderSlot.RemainRefreshTime != null)
				orderSlot.RemainRefreshTime.Value = FACTORY_NEW_ORDER_COOL_TIME;
		}
	}

	public void AddProduct(int productId, int count)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.FactoryItems == null)
			return;

		if (factoryData.FactoryItems.TryGetValue(productId, out var itemData))
		{
			// Update existing item count via property
			if (itemData.CountProperty != null)
				itemData.CountProperty.Value += count;
		}
		else
		{
			var newItem = new FactoryItemData(productId, count);
			newItem.Create();
			factoryData.FactoryItems[productId] = newItem;
		}

		UpdateStorageFull();
	}

	private int GetEnableMakeRandProduct()
	{
		// Would select a random product from available production list
		return 0;
	}

	private bool EnableMakeProduct(int idx)
	{
		if (IsStorageFull.Value)
			return false;

		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null)
			return false;

		return idx > 0;
	}

	public void Update()
	{
	}

	public void UpdateOneSeconds()
	{
		UpdateSlotCooltime();

		if (RemainBatteryTime != null && RemainBatteryTime.Value > 0)
		{
			RemainBatteryTime.Value--;
		}

		if (RemainManagerKeyAddResetTime != null && RemainManagerKeyAddResetTime.Value > 0)
		{
			RemainManagerKeyAddResetTime.Value--;
			if (RemainManagerKeyAddResetTime.Value <= 0)
			{
				ResetManagerKey();
			}
		}

		CheckDailyOrderFreeRefresh(DateTime.UtcNow);
	}

	public float GetProductionTime(int factory, int level, int product)
	{
		// Base production time in seconds, reduced by level
		float baseTime = 60f;
		float levelBonus = level * 0.05f;
		return baseTime * (1f - Math.Min(levelBonus, 0.8f));
	}

	public float GetProductionValue(int factory, int level)
	{
		// Production value increases with level
		return 1f + level * 0.1f;
	}

	public BigInteger GetLevelUpNeedCost(int factory, int level)
	{
		// Exponential cost scaling
		BigInteger baseCost = new BigInteger(1000);
		for (int i = 0; i < level; i++)
		{
			baseCost = baseCost * 15 / 10; // 1.5x per level
		}
		return baseCost;
	}

	public void UpdateStorage()
	{
		UpdateStorageFull();
	}

	public int GetStorageFull(int level = -1)
	{
		// Storage capacity increases with level
		if (level < 0)
			return StorageFullCount;

		return 50 + level * 10;
	}

	public void ResetManagerKey()
	{
		// Reset manager key daily timer
		RemainManagerKeyAddResetTime.Value = 0;
	}

	private void CheckDailyOrderFreeRefresh(DateTime curTime)
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null)
			return;

		if (curTime >= factoryData.DailyOrderFreeRefreshResetTime)
		{
			if (factoryData.DailyOrderFreeRefreshCount != null)
				factoryData.DailyOrderFreeRefreshCount.Value = 0;

			factoryData.DailyOrderFreeRefreshResetTime = curTime.Date.AddDays(1);
		}
	}

	public int GetRandomOrderCharacterIdx()
	{
		return UnityEngine.Random.Range(1, 10);
	}

	public int GetRandomOrderCharacterTalkIdx(int productIdx)
	{
		return UnityEngine.Random.Range(1, 5);
	}

	public Sprite GetOrderCharacterIcon(int characterIdx)
	{
		// Would load sprite from Resources
		return null;
	}

	public string GetOrderCharacterTalkText(int productIdx, int talkIdx)
	{
		// Would look up localized text
		return null;
	}

	public int FindProductionFactoryIdx(int productIdx, out bool isProduction)
	{
		isProduction = false;
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.Factoris == null)
			return -1;

		for (int i = 0; i < factoryData.Factoris.Count; i++)
		{
			var building = factoryData.Factoris[i];
			if (building.MakeProduct != null && building.MakeProduct.Value == productIdx)
			{
				isProduction = true;
				return i;
			}
		}

		// Return first available factory
		for (int i = 0; i < factoryData.Factoris.Count; i++)
		{
			if (factoryData.Factoris[i].MakeProduct == null || factoryData.Factoris[i].MakeProduct.Value <= 0)
			{
				return i;
			}
		}

		return -1;
	}

	public int FindHightestProductionFactoryIdx()
	{
		var factoryData = Singleton<GameRoot>.Instance.UserData?.FactoryData;
		if (factoryData == null || factoryData.Factoris == null || factoryData.Factoris.Count == 0)
			return -1;

		int bestIdx = 0;
		int bestLevel = 0;

		for (int i = 0; i < factoryData.Factoris.Count; i++)
		{
			if (factoryData.Factoris[i].Level > bestLevel)
			{
				bestLevel = factoryData.Factoris[i].Level;
				bestIdx = i;
			}
		}

		return bestIdx;
	}
}
