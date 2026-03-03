using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

[UIPath("UI/Page/PageCrossPromotion", false, false)]
public class PageCrossPromotion : UIBase
{
	public enum APP_IDX
	{
		CatMagicSchool = 1001,
		CatOffice = 1002,
		CatMall = 1003,
		CatSnackBar = 1004,
		CatLumber = 1005,
		CatTownValley = 1006,
		CatCity = 1007,
		CatThemePark = 1008,
		CatSchool = 1009,
		DDDDDiger = 2001,
		LuckyGuy = 2002,
		BlockClash = 2003,
		GearTruck = 2004,
		SuperGrinder = 2005,
		DieTomato = 2006,
		BlockMiner = 2007,
		CatBlockJam = 3001,
		CatsLife = 3002,
		Match = 3003
	}

	public enum APP_TYPE
	{
		Tycoon = 0,
		Casual = 1,
		CatGames = 2
	}

	public enum CPTab
	{
		Tycoon = 0,
		Casual = 1,
		CatGames = 2,
		Max = 3
	}

	[SerializeField]
	private GameObject instItme;

	[SerializeField]
	private SpriteAtlas spriteAtlas;

	[Header("Tap")]
	[SerializeField]
	private GameObject originTabItem;

	[SerializeField]
	private GameObject originScrollView;

	private bool bCreateSlot;

	private List<CrossPromotionComponent> listItem;

	private List<Toggle> list_toggle;

	private Dictionary<CPTab, GameObject> list_tap_object;

	private APP_IDX appMyIdx;

	public CPTab CurTab { get; set; }

	public bool IsCreateSlot => false;

	public List<CrossPromotionComponent> GetListItems => null;

	public void Set(APP_IDX _appMyIdx, Action _onReward, Sprite rewardIcon = null)
	{
	}

	private void ChangeTab(CPTab tab, bool on)
	{
	}

	public void PlaySound(string soundKey)
	{
	}

	private void InstantiateView()
	{
	}

	private void InstantiateToggle()
	{
	}
}
