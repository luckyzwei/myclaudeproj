using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class Item1stEventShop : MonoBehaviour
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
	private Button ItemBuyButton;

	[SerializeField]
	private Button ItemInfoButton;

	[SerializeField]
	private GameObject ItemBuyObj;

	[SerializeField]
	private GameObject ItemSoldOutObj;

	[SerializeField]
	private GameObject HotLabelObj;

	[SerializeField]
	private GameObject HotLabelSoldOutObj;

	private int ShopItemIdx;

	private int ItemExchangeCount;

	private bool bShowHotLabel;

	private bool bShowBuyObj;

	public int ItemRemainCount { get; private set; }

	public RewardItemData ItemRewardData { get; private set; }

	public RewardItemData ItemCostData { get; private set; }

	private void Awake()
	{
	}

	public void SetItem(SpecialDayShopData shopItemData, bool isShowBuyObj)
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

	private void OnItemInfoButtonClick()
	{
	}

	private void BuyItem(int buyCount)
	{
	}
}
