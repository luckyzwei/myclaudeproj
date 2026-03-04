using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageReward", false, false)]
public class PageReward : UIBase
{
	[Serializable]
	private class RewardObj
	{
		[SerializeField]
		public GameObject Root;

		[SerializeField]
		public Image Icon;

		[SerializeField]
		public Text Count;
	}

	[SerializeField]
	private Text Title;

	[SerializeField]
	private Image RewardImg;

	[SerializeField]
	private Text RewardName;

	[SerializeField]
	private List<RewardObj> Rewards;

	[SerializeField]
	private GameObject AddPointObj;

	[SerializeField]
	private Text AddPointText;

	[SerializeField]
	private Button TextBtn;

	private Queue<IRewardItemData> RemainRewards;

	private int PlantRewardIdx;

	private int BuffObjectRewardIdx;

	private int NormalKeyRewardCount;

	private int PremiumKeyRewardCount;

	private int CarRewardIdx;

	private bool WaitShow;

	protected override void Awake()
	{
	}

	public override void OnShowAfter()
	{
	}

	private void ShowInOrder()
	{
	}

	private void Show(IRewardItemData rewardItemData)
	{
	}

	private void Show(RewardItemData reward)
	{
	}

	private void Show(RewardItemData_Seasonal itemData)
	{
	}

	public void Show(int type, int idx, Config.RegionType region, int value, string img, bool getReward = true)
	{
	}

	public void Show(int type, int idx, int region, int value, string img, bool getReward = true)
	{
	}

	public void ShowReward(IRewardItemData rewardItemData)
	{
	}

	public void ShowRewards(List<IRewardItemData> rewardItemDataList)
	{
	}

	public void ShowShopReward(int shopgoodsIdx)
	{
	}

	public void ShowRouletteReward(int rouletteIdx, bool isreplaceReward = false)
	{
	}

	public void SetQuestReward(int order, bool isreplaceReward)
	{
	}

	public void ShowList(List<IRewardItemData> listReward)
	{
	}

	public void ShowHousePurchase(int houseIdx)
	{
	}

	public void ShowPackageReward(int packageIdx, List<BigInteger> bigValues)
	{
	}

	public void ShowSalePackageReward(int packageIdx, List<BigInteger> bigValues)
	{
	}

	public void ShowFactoryOrderReward(int slot)
	{
	}

	public void ShowFactoryProductReward(int product, int count)
	{
	}

	public void ShowFactoryItem(int item)
	{
	}

	public void ShowOneTimeReward(int onetimeIdx)
	{
	}

	public void ShowInviteReward(int inviteIdx)
	{
	}

	public void ShowTarotReward(int tarotIdx, bool isOwn = false)
	{
	}

	private void InitHideData()
	{
	}

	public override void Hide()
	{
	}
}
