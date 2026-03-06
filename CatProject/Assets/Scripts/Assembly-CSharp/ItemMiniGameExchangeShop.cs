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
		if (BuyButton != null) BuyButton.onClick.AddListener(OnItemBuyButtonClick);
		if (AdsRewardButton != null) AdsRewardButton.onClick.AddListener(OnAdsRewardButtonClick);
		if (BuyLockedButton != null) BuyLockedButton.onClick.AddListener(OnBuyLockedButtonClick);
		if (InfoButton != null) InfoButton.onClick.AddListener(OnItemInfoButtonClick);
	}

	public void SetItem(MiniGameExchangeShopData shopItemData)
	{
		if (shopItemData == null) return;
		UpdateBuyBoxLayout();
	}

	private void UpdateBuyBoxLayout()
	{
		bool isSoldOut = ItemRemainCount <= 0;

		if (BuyObj != null) BuyObj.SetActive(!isSoldOut && !IsAdsReward && !IsBuyLocked);
		if (AdsRewardObj != null) AdsRewardObj.SetActive(!isSoldOut && IsAdsReward);
		if (SoldOutObj != null) SoldOutObj.SetActive(isSoldOut);
		if (BuyLockedObj != null) BuyLockedObj.SetActive(!isSoldOut && IsBuyLocked);
	}

	private void SetItemMainImage(int rewardType, int rewardIdx, int rewardRegion, string iconKey)
	{
		if (ItemMainImage != null && !string.IsNullOrEmpty(iconKey))
		{
			Sprite sprite = Resources.Load<Sprite>(iconKey);
			if (sprite != null) ItemMainImage.sprite = sprite;
		}
	}

	private void SetItemRemainCountText(int count)
	{
		if (ItemRemainCountText != null)
			ItemRemainCountText.text = count.ToString();
	}

	private void SetItemCostValueText(int value)
	{
		if (ItemCostValueText != null)
			ItemCostValueText.text = value.ToString();
	}

	private void SetItemCostIconImage(int type, int idx, int region)
	{
		if (ItemCostIconImage == null) return;
	}

	private void OnItemBuyButtonClick()
	{
		if (ItemRemainCount <= 0) return;
		BuyItem(1, false);
	}

	private void OnAdsRewardButtonClick()
	{
		if (ItemRemainCount <= 0) return;
		BuyItem(1, true);
	}

	private void OnBuyLockedButtonClick()
	{
		if (!string.IsNullOrEmpty(LockedMessage))
		{
			// Display stage condition message
			if (StageConditionText != null)
				StageConditionText.text = LockedMessage;
		}
	}

	private void OnItemInfoButtonClick()
	{
		// TODO
	}

	private void BuyItem(int buyCount, bool isAdsReward)
	{
		if (ItemRemainCount <= 0) return;
		ItemRemainCount -= buyCount;
		SetItemRemainCountText(ItemRemainCount);
		UpdateBuyBoxLayout();
	}
}
