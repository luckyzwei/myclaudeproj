using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemMiniGameExchangeShop : MonoBehaviour
{
	[SerializeField]
	private Image ItemMainImage;

	[SerializeField]
	private Text ItemNameText;

	[SerializeField]
	private Text ItemRewardCountText;

	[SerializeField]
	private Text ItemRemainCountText;

	[SerializeField]
	private Text ItemCostValueText;

	[SerializeField]
	private Image ItemCostIconImage;

	[SerializeField]
	private Text StageConditionText;

	[Header("Buy")]
	[SerializeField]
	private GameObject BuyObj;

	[SerializeField]
	private Button BuyButton;

	[Header("Ads Reward")]
	[SerializeField]
	private GameObject AdsRewardObj;

	[SerializeField]
	private Button AdsRewardButton;

	[Header("Sold Out")]
	[SerializeField]
	private GameObject SoldOutObj;

	[Header("Buy Locked")]
	[SerializeField]
	private GameObject BuyLockedObj;

	[SerializeField]
	private Button BuyLockedButton;

	[Header("Info")]
	[SerializeField]
	private Button InfoButton;

	private int ShopItemIdx;

	private bool IsAdsReward;

	private bool IsBuyLocked;

	private int OpenConditionStage;

	private string LockedMessage;

	private int ItemExchangeCount;

	public int ItemRemainCount { get; private set; }

	public RewardItemData ItemRewardData { get; private set; }

	public RewardItemData ItemCostData { get; private set; }

	private void Awake()
	{
	}

	public void SetItem(MiniGameExchangeShopData shopItemData)
	{
	}

	private void UpdateBuyBoxLayout()
	{
	}

	private void SetItemMainImage(int rewardType, int rewardIdx, int rewardRegion, string iconKey)
	{
	}

	private void SetItemRemainCountText(int count)
	{
	}

	private void SetItemCostValueText(int value)
	{
	}

	private void SetItemCostIconImage(int type, int idx, int region)
	{
	}

	private void OnItemBuyButtonClick()
	{
	}

	private void OnAdsRewardButtonClick()
	{
	}

	private void OnBuyLockedButtonClick()
	{
	}

	private void OnItemInfoButtonClick()
	{
	}

	private void BuyItem(int buyCount, bool isAdsReward)
	{
	}
}
