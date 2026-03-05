using System;
using System.Collections.Generic;

public class ShopSaleItemData
{
	public int Idx;
	public int SaleIdx;
	public int SaleType;
	public string ProductId;
	public int Price;
	public int LimitCount;
	public int BuyCount;
	public int ResetType;
	public DateTime ResetTime;
	public List<Config.RewardItemData> RewardList;
}
