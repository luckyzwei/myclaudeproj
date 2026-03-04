using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
	}

	public void OpenFactoryBuilding()
	{
	}

	public void UpdateSlotCooltime()
	{
	}

	public void CalcOfflineProduct()
	{
	}

	private void UpdateMissionData()
	{
	}

	public void StartOpenFacility(int factoryIdx)
	{
	}

	public void OpenFactoryFacility(int factoryIdx)
	{
	}

	public void UpdateStorageFull(bool isInit = false)
	{
	}

	public void RestartFactoryMake()
	{
	}

	public void UseItem(int factory, int item)
	{
	}

	public bool IsFreeItem(int itemIdx)
	{
		return false;
	}

	public void OpenSlot(int slot)
	{
	}

	public void CompleteOrder(int slotIdx, Action<bool> OnComplete, Action packageOpenCb)
	{
	}

	public void RefreshOrder(int slot)
	{
	}

	public void ResetOrderSlot(int slot)
	{
	}

	public void AddProduct(int productId, int count)
	{
	}

	private int GetEnableMakeRandProduct()
	{
		return 0;
	}

	private bool EnableMakeProduct(int idx)
	{
		return false;
	}

	public void Update()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public float GetProductionTime(int factory, int level, int product)
	{
		return 0f;
	}

	public float GetProductionValue(int factory, int level)
	{
		return 0f;
	}

	public BigInteger GetLevelUpNeedCost(int factory, int level)
	{
		return default(BigInteger);
	}

	public void UpdateStorage()
	{
	}

	public int GetStorageFull(int level = -1)
	{
		return 0;
	}

	public void ResetManagerKey()
	{
	}

	private void CheckDailyOrderFreeRefresh(DateTime curTime)
	{
	}

	public int GetRandomOrderCharacterIdx()
	{
		return 0;
	}

	public int GetRandomOrderCharacterTalkIdx(int productIdx)
	{
		return 0;
	}

	public Sprite GetOrderCharacterIcon(int characterIdx)
	{
		return null;
	}

	public string GetOrderCharacterTalkText(int productIdx, int talkIdx)
	{
		return null;
	}

	public int FindProductionFactoryIdx(int productIdx, out bool isProduction)
	{
		isProduction = default(bool);
		return 0;
	}

	public int FindHightestProductionFactoryIdx()
	{
		return 0;
	}
}
