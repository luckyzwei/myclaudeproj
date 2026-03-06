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

	public Transform CashRootTransform { get { return CashRoot; } }

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		PlantSortList = new List<int>();

		if (BeforeBtn != null) BeforeBtn.onClick.AddListener(OnClickBefore);
		if (AfterBtn != null) AfterBtn.onClick.AddListener(OnClickAfter);
		if (ShopBtn != null) ShopBtn.onClick.AddListener(OnClickGotoShop);
		if (RouletteBtn != null) RouletteBtn.onClick.AddListener(OnClickRoulette);
		if (DailyQuestBtn != null) DailyQuestBtn.onClick.AddListener(OnClickDailyQuest);
		if (BuyTonicBtn != null) BuyTonicBtn.onClick.AddListener(OnClickBuyTonic);
		if (infoBtn != null) infoBtn.onClick.AddListener(OnClickInfo);
	}

	public override void OnShowBefore()
	{
		CurPage = 0;
		UpdatePage();
	}

	public override void OnHideBefore()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void UpdatePage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateItems();
		UpdateGemPlantData();
		UpdateGemPlantNoti();

		if (BeforeBtn != null) BeforeBtn.gameObject.SetActive(CurPage > 0);
		if (AfterBtn != null) AfterBtn.gameObject.SetActive(CurPage < MaxPage - 1);
	}

	private void UpdateItems()
	{
		if (Plants == null) return;
		bool hasAny = PlantSortList != null && PlantSortList.Count > 0;
		if (NothingObj != null) NothingObj.SetActive(!hasAny);

		int startIdx = CurPage * ITEMCOUNT_PER_ONEPAGE;
		for (int i = 0; i < Plants.Count; i++)
		{
			if (Plants[i] == null) continue;
			int plantIdx = startIdx + i;
			bool isValid = PlantSortList != null && plantIdx < PlantSortList.Count;
			Plants[i].gameObject.SetActive(isValid);
		}
	}

	private void UpdateGemPlantData()
	{
		var info = GetGemPlantInfo();
		IsActiveGem = info.Item1 > 0;
		GemPlantPage = info.Item2;
	}

	private void UpdateGemPlantNoti()
	{
		if (BeforeGemPlantNotiObj != null) BeforeGemPlantNotiObj.SetActive(false);
		if (AfterGemPlantNotiObj != null) AfterGemPlantNotiObj.SetActive(false);
	}

	private (int, int) GetGemPlantInfo()
	{
		return (0, 0);
	}

	private void OnClickPlantManage(int plant_idx)
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PagePlantManage>();
	}

	private void OnClickBefore()
	{
		if (CurPage > 0)
		{
			CurPage--;
			UpdatePage();
		}
	}

	private void OnClickAfter()
	{
		if (CurPage < MaxPage - 1)
		{
			CurPage++;
			UpdatePage();
		}
	}

	private void OnClickBuyTonic()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickGotoShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickRoulette()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageRoulette>();
	}

	private void OnClickDailyQuest()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMission>();
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PagePlantInfo>();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
