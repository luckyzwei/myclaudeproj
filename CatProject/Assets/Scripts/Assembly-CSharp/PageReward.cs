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
		base.Awake();
		RemainRewards = new Queue<IRewardItemData>();
		WaitShow = false;

		if (TextBtn != null) TextBtn.onClick.AddListener(OnClickConfirm);
	}

	public override void OnShowAfter()
	{
		ShowInOrder();
	}

	private void ShowInOrder()
	{
		if (RemainRewards == null || RemainRewards.Count == 0)
		{
			WaitShow = false;
			return;
		}
		WaitShow = true;
		var rewardData = RemainRewards.Dequeue();
		Show(rewardData);
	}

	private void Show(IRewardItemData rewardItemData)
	{
		if (rewardItemData == null) return;
		if (rewardItemData is RewardItemData reward)
			Show(reward);
		else if (rewardItemData is RewardItemData_Seasonal seasonal)
			Show(seasonal);
	}

	private void Show(RewardItemData reward)
	{
		if (reward == null) return;
		InitHideData();

		if (RewardImg != null)
		{
			var sprite = ProjectUtility.GetRewardIconImg(reward.rewardType, reward.rewardIdx, reward.rewardRegion);
			if (sprite != null) RewardImg.sprite = sprite;
		}

		if (RewardName != null)
			RewardName.text = ProjectUtility.GetThousandCommaText(reward.rewardValue);

		if (Rewards != null)
		{
			for (int i = 0; i < Rewards.Count; i++)
			{
				if (Rewards[i] == null || Rewards[i].Root == null) continue;
				Rewards[i].Root.SetActive(i == 0);
				if (i == 0)
				{
					if (Rewards[i].Icon != null)
					{
						var sprite = ProjectUtility.GetRewardIconImg(reward.rewardType, reward.rewardIdx, reward.rewardRegion);
						if (sprite != null) Rewards[i].Icon.sprite = sprite;
					}
					if (Rewards[i].Count != null)
						Rewards[i].Count.text = ProjectUtility.GetThousandCommaText(reward.rewardValue);
				}
			}
		}
	}

	private void Show(RewardItemData_Seasonal itemData)
	{
		if (itemData == null) return;
		InitHideData();

		if (RewardName != null)
			RewardName.text = ProjectUtility.GetThousandCommaText(itemData.CurrencyValue_PerMile);

		if (Rewards != null && Rewards.Count > 0 && Rewards[0] != null && Rewards[0].Root != null)
		{
			Rewards[0].Root.SetActive(true);
			if (Rewards[0].Count != null)
				Rewards[0].Count.text = ProjectUtility.GetThousandCommaText(itemData.CurrencyValue_PerMile);
		}
	}

	public void Show(int type, int idx, Config.RegionType region, int value, string img, bool getReward = true)
	{
		Show(type, idx, (int)region, value, img, getReward);
	}

	public void Show(int type, int idx, int region, int value, string img, bool getReward = true)
	{
		InitHideData();

		if (RewardImg != null)
		{
			var sprite = ProjectUtility.GetRewardIconImg(type, idx, region);
			if (sprite != null) RewardImg.sprite = sprite;
		}

		if (RewardName != null)
			RewardName.text = ProjectUtility.GetThousandCommaText(value);

		if (Rewards != null && Rewards.Count > 0 && Rewards[0] != null && Rewards[0].Root != null)
		{
			Rewards[0].Root.SetActive(true);
			if (Rewards[0].Icon != null)
			{
				var sprite = ProjectUtility.GetRewardIconImg(type, idx, region);
				if (sprite != null) Rewards[0].Icon.sprite = sprite;
			}
			if (Rewards[0].Count != null)
				Rewards[0].Count.text = ProjectUtility.GetThousandCommaText(value);
		}
	}

	public void ShowReward(IRewardItemData rewardItemData)
	{
		if (rewardItemData == null) return;
		RemainRewards.Clear();
		RemainRewards.Enqueue(rewardItemData);
	}

	public void ShowRewards(List<IRewardItemData> rewardItemDataList)
	{
		if (rewardItemDataList == null) return;
		RemainRewards.Clear();
		for (int i = 0; i < rewardItemDataList.Count; i++)
		{
			if (rewardItemDataList[i] != null)
				RemainRewards.Enqueue(rewardItemDataList[i]);
		}
	}

	public void ShowShopReward(int shopgoodsIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowRouletteReward(int rouletteIdx, bool isreplaceReward = false)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void SetQuestReward(int order, bool isreplaceReward)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowList(List<IRewardItemData> listReward)
	{
		if (listReward == null || listReward.Count == 0) return;
		InitHideData();

		for (int i = 0; i < listReward.Count && i < Rewards.Count; i++)
		{
			if (listReward[i] == null || Rewards[i] == null || Rewards[i].Root == null) continue;
			Rewards[i].Root.SetActive(true);

			if (listReward[i] is RewardItemData reward)
			{
				if (Rewards[i].Icon != null)
				{
					var sprite = ProjectUtility.GetRewardIconImg(reward.rewardType, reward.rewardIdx, reward.rewardRegion);
					if (sprite != null) Rewards[i].Icon.sprite = sprite;
				}
				if (Rewards[i].Count != null)
					Rewards[i].Count.text = ProjectUtility.GetThousandCommaText(reward.rewardValue);
			}
		}
	}

	public void ShowHousePurchase(int houseIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowPackageReward(int packageIdx, List<BigInteger> bigValues)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowSalePackageReward(int packageIdx, List<BigInteger> bigValues)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowFactoryOrderReward(int slot)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
	}

	public void ShowFactoryProductReward(int product, int count)
	{
		InitHideData();
		if (Rewards != null && Rewards.Count > 0 && Rewards[0] != null && Rewards[0].Root != null)
		{
			Rewards[0].Root.SetActive(true);
			if (Rewards[0].Count != null)
				Rewards[0].Count.text = ProjectUtility.GetThousandCommaText(count);
		}
	}

	public void ShowFactoryItem(int item)
	{
		InitHideData();
		if (Rewards != null && Rewards.Count > 0 && Rewards[0] != null && Rewards[0].Root != null)
			Rewards[0].Root.SetActive(true);
	}

	public void ShowOneTimeReward(int onetimeIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowInviteReward(int inviteIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void ShowTarotReward(int tarotIdx, bool isOwn = false)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void InitHideData()
	{
		PlantRewardIdx = -1;
		BuffObjectRewardIdx = -1;
		NormalKeyRewardCount = 0;
		PremiumKeyRewardCount = 0;
		CarRewardIdx = -1;

		if (AddPointObj != null) AddPointObj.SetActive(false);

		if (Rewards != null)
		{
			for (int i = 0; i < Rewards.Count; i++)
			{
				if (Rewards[i] != null && Rewards[i].Root != null)
					Rewards[i].Root.SetActive(false);
			}
		}
	}

	private void OnClickConfirm()
	{
		if (WaitShow && RemainRewards != null && RemainRewards.Count > 0)
		{
			ShowInOrder();
			return;
		}
		Hide();
	}

	public override void Hide()
	{
		if (WaitShow && RemainRewards != null && RemainRewards.Count > 0)
		{
			ShowInOrder();
			return;
		}
		WaitShow = false;
		base.Hide();
	}
}
