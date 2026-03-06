using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemArticle : MonoBehaviour
{
	public enum ShowLocation
	{
		None = 0,
		Seller = 1
	}

	[Header("Currency or Item")]
	[SerializeField]
	protected GameObject Root;

	[SerializeField]
	protected Image Icon;

	[SerializeField]
	protected Text Count;

	[SerializeField]
	protected Button InfoBtn;

	[SerializeField]
	protected AutoPlayBubble InfoBubble;

	[SerializeField]
	protected Button BubbleCloseBtn;

	[SerializeField]
	private List<GameObject> DirectingObjects;

	[Header("ETC")]
	[SerializeField]
	protected Text Name;

	[HideInInspector]
	public ShowLocation showLocation;

	public Action OverrideInfoBtnAction;

	public int Type { get; protected set; }

	public int Idx { get; protected set; }

	public int Region { get; protected set; }

	public int Grade { get; protected set; }

	public int Level { get; protected set; }

	public string IconPath { get; protected set; }

	private void Awake()
	{
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (BubbleCloseBtn != null) BubbleCloseBtn.onClick.AddListener(OnClickBubbleCloseBtn);
	}

	public void Set(int type, int idx, int region, BigInteger value, string iconPath = "", bool showInfoBtn = false, bool isCountChar = false, bool isTimeRevenue = false, bool showValueDirectly = false)
	{
		Type = type;
		Idx = idx;
		Region = region;
		IconPath = iconPath;

		if (Root != null) Root.SetActive(true);
		SetIcon(type, idx, region, Config.AtlasType.None, iconPath);
		SetCountText(type, idx, value, isCountChar, region, isTimeRevenue, showValueDirectly);
		SetNameText(type, idx, region);
		SetActivateInfoButton(type, idx, showInfoBtn);
	}

	public void Set(IRewardItemData itemData, bool showInfoBtn = false, bool isCountChar = false, bool showValueDirectly = false)
	{
		if (itemData == null) return;
		if (itemData is RewardItemData rewardItem)
			SetItem(rewardItem, showInfoBtn, isCountChar, showValueDirectly);
		else if (itemData is RewardItemData_Seasonal seasonalItem)
			SetSeasonalItem(seasonalItem, showInfoBtn, showValueDirectly);
	}

	public void Set(SeasonalRewardData rewardData, bool isPremium)
	{
		if (rewardData == null) return;
		Type = (int)rewardData.CurrencyType;
		Idx = rewardData.CurrencyIdx;
		Region = -1;

		if (Root != null) Root.SetActive(true);
		SetIcon(Type, Idx, Region, Config.AtlasType.None, rewardData.RewardIcon);
		if (Count != null) Count.text = ProjectUtility.GetThousandCommaText(rewardData.RewardValue);
		SetNameText(Type, Idx);
	}

	public void SetShopSale(int type, int idx, int region, int value)
	{
		Type = type;
		Idx = idx;
		Region = region;

		if (Root != null) Root.SetActive(true);
		SetIcon(type, idx, region, Config.AtlasType.None, "");
		if (Count != null) Count.text = ProjectUtility.GetThousandCommaText(value);
		SetNameText(type, idx, region);
	}

	private void SetItem(RewardItemData itemData, bool showInfoBtn, bool isCountChar, bool showValueDirectly)
	{
		Type = itemData.rewardType;
		Idx = itemData.rewardIdx;
		Region = itemData.rewardRegion;
		IconPath = itemData.resImg;

		if (Root != null) Root.SetActive(true);
		SetIcon(itemData.rewardType, itemData.rewardIdx, itemData.rewardRegion, itemData.atlasType, itemData.resImg);
		SetCountText(itemData.rewardType, itemData.rewardIdx, itemData.rewardValue, isCountChar, itemData.rewardRegion, itemData.isTimeRevenue, showValueDirectly);
		SetNameText(itemData.rewardType, itemData.rewardIdx, itemData.rewardRegion);
		SetActivateInfoButton(itemData.rewardType, itemData.rewardIdx, showInfoBtn);
	}

	private void SetSeasonalItem(RewardItemData_Seasonal itemData, bool showInfoBtn, bool showValueDirectly)
	{
		Type = 0;
		Idx = itemData.CurrencyIdx;
		Region = -1;
		IconPath = itemData.resImg;

		if (Root != null) Root.SetActive(true);
		if (Icon != null)
		{
			var sprite = ProjectUtility.GetRewardIconImg(0, itemData.CurrencyIdx, -1);
			if (sprite != null) Icon.sprite = sprite;
		}
		if (Count != null) Count.text = ProjectUtility.GetThousandCommaText(itemData.CurrencyValue_PerMile);
		ShowInfoBtn(showInfoBtn);
	}

	public void SetIcon(int type, int idx, int region, Config.AtlasType atlasType, string iconPath)
	{
		if (Icon == null) return;
		Sprite sprite = null;
		if (!string.IsNullOrEmpty(iconPath))
		{
			sprite = Resources.Load<Sprite>(iconPath);
		}
		if (sprite == null)
			sprite = ProjectUtility.GetRewardIconImg(type, idx, region);
		if (sprite != null) Icon.sprite = sprite;
	}

	public void SetCountText(int type, int idx, BigInteger count, bool isCountChar, int region, bool isTimeRevenue, bool showValueDirectly)
	{
		if (Count == null) return;
		if (showValueDirectly)
			Count.text = count.ToString();
		else
			Count.text = ProjectUtility.GetThousandCommaText(count);
	}

	public void SetOverrideInfoBtn(bool bActive, Action action)
	{
		OverrideInfoBtnAction = action;
		ShowInfoBtn(bActive);
	}

	public void ShowInfoBtn(bool isShow)
	{
		if (InfoBtn != null) InfoBtn.gameObject.SetActive(isShow);
	}

	protected void SetActivateInfoButton(int type, int idx, bool bActivate)
	{
		if (InfoBtn == null) return;
		InfoBtn.gameObject.SetActive(bActivate);
	}

	private void SetNameText(int type, int idx, int region = -1)
	{
		if (Name == null) return;
		Name.text = "";
	}

	private void OnClickInfo()
	{
		if (OverrideInfoBtnAction != null)
		{
			OverrideInfoBtnAction.Invoke();
			return;
		}
		if (InfoBubble != null) InfoBubble.PlayShowImmediately();
	}

	private void OnClickBubbleCloseBtn()
	{
		if (InfoBubble != null) InfoBubble.PlayHide();
	}

	public void SetActiveDirectingObject(bool isActive, int index)
	{
		if (DirectingObjects == null || index < 0 || index >= DirectingObjects.Count) return;
		if (DirectingObjects[index] != null) DirectingObjects[index].SetActive(isActive);
	}

	public void SetActiveDirectingObjects(bool isActive)
	{
		if (DirectingObjects == null) return;
		for (int i = 0; i < DirectingObjects.Count; i++)
		{
			if (DirectingObjects[i] != null) DirectingObjects[i].SetActive(isActive);
		}
	}

	public void SetIconScale(float scale)
	{
		if (Icon != null) Icon.transform.localScale = Vector3.one * scale;
	}

	public void Reset()
	{
		Type = 0;
		Idx = 0;
		Region = -1;
		Grade = 0;
		Level = 0;
		IconPath = "";
		OverrideInfoBtnAction = null;
		if (Root != null) Root.SetActive(false);
		if (Count != null) Count.text = "";
		if (Name != null) Name.text = "";
		ShowInfoBtn(false);
		SetActiveDirectingObjects(false);
	}
}
