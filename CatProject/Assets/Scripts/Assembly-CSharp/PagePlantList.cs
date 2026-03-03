using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PagePlantList", false, false)]
public class PagePlantList : UIBase
{
	[SerializeField]
	private GameObject NothingObj;

	[SerializeField]
	private Button ShopBtn;

	[SerializeField]
	private Button RouletteBtn;

	[SerializeField]
	private Button DailyQuestBtn;

	[SerializeField]
	private Button BeforeBtn;

	[SerializeField]
	private Button AfterBtn;

	[SerializeField]
	private GameObject BeforeGemPlantNotiObj;

	[SerializeField]
	private GameObject AfterGemPlantNotiObj;

	[SerializeField]
	private List<ItemPlant> Plants;

	[SerializeField]
	private Text Tonic1Count;

	[SerializeField]
	private Text Tonic2Count;

	[SerializeField]
	private Text Tonic3Count;

	[SerializeField]
	private Text CashCount;

	[SerializeField]
	private Transform CashRoot;

	[SerializeField]
	private Button BuyTonicBtn;

	[SerializeField]
	private Button infoBtn;

	private CompositeDisposable disposables;

	private int MaxPage;

	private int CurPage;

	private int GemPlantPage;

	private bool IsActiveGem;

	private const int ITEMCOUNT_PER_ONEPAGE = 4;

	private List<int> PlantSortList;

	public Transform CashRootTransform => null;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void UpdatePage()
	{
	}

	private void UpdateItems()
	{
	}

	private void UpdateGemPlantData()
	{
	}

	private void UpdateGemPlantNoti()
	{
	}

	private (int, int) GetGemPlantInfo()
	{
		return default((int, int));
	}

	private void OnClickPlantManage(int plant_idx)
	{
	}

	private void OnClickBefore()
	{
	}

	private void OnClickAfter()
	{
	}

	private void OnClickBuyTonic()
	{
	}

	private void OnClickGotoShop()
	{
	}

	private void OnClickRoulette()
	{
	}

	private void OnClickDailyQuest()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
