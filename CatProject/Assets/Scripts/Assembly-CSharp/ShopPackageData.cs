using System;
using System.Collections.Generic;

public class ShopPackageData
{
	public int Idx;
	public int PackageGroup;
	public int PackageShowType;
	public int PackageShowGameType;
	public string ProductId;
	public int Price;
	public int ContentsOpen;
	public int LimitCount;
	public int BuyCount;
	public bool IsOpen;
	public DateTime ExpireTime;
	public DateTime StartTime;
	public List<Config.RewardItemData> RewardList;
}
