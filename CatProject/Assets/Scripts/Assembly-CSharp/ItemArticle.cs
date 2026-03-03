using System;
using System.Collections.Generic;
using System.Numerics;
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
	}

	public void Set(int type, int idx, int region, BigInteger value, string iconPath = "", bool showInfoBtn = false, bool isCountChar = false, bool isTimeRevenue = false, bool showValueDirectly = false)
	{
	}

	public void Set(IRewardItemData itemData, bool showInfoBtn = false, bool isCountChar = false, bool showValueDirectly = false)
	{
	}

	public void Set(SeasonalRewardData rewardData, bool isPremium)
	{
	}

	public void SetShopSale(int type, int idx, int region, int value)
	{
	}

	private void SetItem(RewardItemData itemData, bool showInfoBtn, bool isCountChar, bool showValueDirectly)
	{
	}

	private void SetSeasonalItem(RewardItemData_Seasonal itemData, bool showInfoBtn, bool showValueDirectly)
	{
	}

	public void SetIcon(int type, int idx, int region, Config.AtlasType atlasType, string iconPath)
	{
	}

	public void SetCountText(int type, int idx, BigInteger count, bool isCountChar, int region, bool isTimeRevenue, bool showValueDirectly)
	{
	}

	public void SetOverrideInfoBtn(bool bActive, Action action)
	{
	}

	public void ShowInfoBtn(bool isShow)
	{
	}

	protected void SetActivateInfoButton(int type, int idx, bool bActivate)
	{
	}

	private void SetNameText(int type, int idx, int region = -1)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickBubbleCloseBtn()
	{
	}

	public void SetActiveDirectingObject(bool isActive, int index)
	{
	}

	public void SetActiveDirectingObjects(bool isActive)
	{
	}

	public void SetIconScale(float scale)
	{
	}

	public void Reset()
	{
	}
}
