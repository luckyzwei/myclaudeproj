using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class BalancyInventory : MonoSingleton<BalancyInventory>
{
	public const string NO_ADS_ID = "no_ads";

	public const string NO_ADS_ID_TIMER = "no_ads_timer";

	private Dictionary<string, string> m_itemsDictionary;

	private List<string> m_itemsList;

	protected override void Init()
	{
	}

	private void OnEverythingLoaded()
	{
	}

	public void RegisterCustomItems(List<KwaleeItem> items)
	{
	}

	public KwaleeItem GetItemModel(string clientID)
	{
		return null;
	}

	public int GetItemCount(string clientID)
	{
		return 0;
	}

	public bool RemoveItems(string clientID, int count)
	{
		return false;
	}

	public bool RemoveItems(KwaleeItem item, int count)
	{
		return false;
	}

	public void AddItems(string clientID, int count)
	{
	}

	public void AddItems(KwaleeItem item, int count)
	{
	}

	public void ReplaceItems(string clientID, int count)
	{
	}

	public void ReplaceItems(KwaleeItem item, int count)
	{
	}

	public int GetItemCount(Item item)
	{
		return 0;
	}

	public string[] GetItemIds()
	{
		return null;
	}

	private void UpdateInventory(Item item, int count, int slotIndex)
	{
	}

	private void GiftAtRegistration()
	{
	}

	private void CheckIfAdWasPurchased()
	{
	}

	public bool HasPurchasedNoAds()
	{
		return false;
	}
}
