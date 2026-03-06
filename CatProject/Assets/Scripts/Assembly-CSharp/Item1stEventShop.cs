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
		if (ItemBuyButton != null) ItemBuyButton.onClick.AddListener(OnItemBuyButtonClick);
		if (ItemInfoButton != null) ItemInfoButton.onClick.AddListener(OnItemInfoButtonClick);
	}

	public void SetItem(SpecialDayShopData shopItemData, bool isShowBuyObj)
	{
		if (shopItemData == null) return;
		bShowBuyObj = isShowBuyObj;
		UpdateBuyBoxLayout();
	}

	private void UpdateBuyBoxLayout()
	{
		bool isSoldOut = ItemRemainCount <= 0;
		if (ItemBuyObj != null) ItemBuyObj.SetActive(bShowBuyObj && !isSoldOut);
		if (ItemSoldOutObj != null) ItemSoldOutObj.SetActive(isSoldOut);
		if (HotLabelObj != null) HotLabelObj.SetActive(bShowHotLabel && !isSoldOut);
		if (HotLabelSoldOutObj != null) HotLabelSoldOutObj.SetActive(bShowHotLabel && isSoldOut);
	}

	private void SetItemMainImage(int rewardType, int rewardIdx, int rewardRegion, string iconKey)
	{
		if (ItemMainImage == null) return;
		// Set item main image sprite from iconKey or reward type/idx
	}

	private void SetItemRemainCountText(int count)
	{
		ItemRemainCount = count;
		if (ItemRemainCountText != null)
			ItemRemainCountText.text = count.ToString();
	}

	private void SetItemCostValueText(int value)
	{
		if (ItemCostValueText != null)
			ItemCostValueText.text = ProjectUtility.GetThousandCommaText(value);
	}

	private void SetItemCostIconImage(int type, int idx, int region)
	{
		if (ItemCostIconImage == null) return;
		// Set cost icon sprite based on currency type/idx/region
	}

	private void OnItemBuyButtonClick()
	{
		if (ItemRemainCount <= 0) return;
		BuyItem(1);
	}

	private void OnItemInfoButtonClick()
	{
		// Show item detail info popup
	}

	private void BuyItem(int buyCount)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Process buy and update remain count
		ItemRemainCount -= buyCount;
		if (ItemRemainCount < 0) ItemRemainCount = 0;
		UpdateBuyBoxLayout();
	}
}
