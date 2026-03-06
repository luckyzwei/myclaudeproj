using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupPhone", false, false)]
public class PopupPhone : UIBase
{
	public enum Tab
	{
		Main = 0,
		Chat = 1,
		Rank = 2,
		CompanyBook = 3,
		MyInfo = 4,
		Catstagram = 5
	}

	private enum CompanySortType
	{
		Basic = 0,
		UnLock = 1
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public ChatData chatData;

		internal bool _003CStartChat_003Eb__0(MessengerChatData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartChat_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupPhone _003C_003E4__this;

		private _003C_003Ec__DisplayClass100_0 _003C_003E8__1;

		private int _003CcurChat_003E5__2;

		private List<MessengerChatData> _003Cchatlist_003E5__3;

		private int _003Ci_003E5__4;

		private MessengerChatData _003Ccurchat_003E5__5;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartChat_003Ed__100(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private Tab CurTab;

	[Header("Common")]
	[SerializeField]
	private Text HudTimeText;

	[SerializeField]
	private Button HomeBtn;

	[Header("Main")]
	[SerializeField]
	private GameObject MainRoot;

	[SerializeField]
	private Text TimeText;

	[SerializeField]
	private Button ChatBtn;

	[SerializeField]
	private Button RankBtn;

	[SerializeField]
	private Button CompanyBookBtn;

	[SerializeField]
	private Button CatstaBtn;

	[SerializeField]
	private Button ItemBookBtn;

	[SerializeField]
	private Button CostumeBtn;

	[SerializeField]
	private Image SelfieImg;

	[Header("Bank")]
	[SerializeField]
	private Text MoneyCount;

	[SerializeField]
	private Text LimitMoneyCount;

	[SerializeField]
	private Text NextLimitMoney;

	[SerializeField]
	private Text BankUpNeedLevel;

	[SerializeField]
	private Button BankUpBtn;

	[SerializeField]
	private GameObject BankMaxObj;

	[SerializeField]
	private Button BankInfoBtn;

	[SerializeField]
	private GameObject MoneyLimitMaxObj;

	private CompositeDisposable money_disposables;

	[Header("Chat")]
	[SerializeField]
	private GameObject ChatRoot;

	[Header("Chat_Contact")]
	[SerializeField]
	private GameObject Chat_ContactRoot;

	[SerializeField]
	private ScrollRect Chat_ContactScroll;

	[SerializeField]
	private GameObject Chat_ContactItem;

	[SerializeField]
	private Button ContractBackBtn;

	[Header("Chat_Chat")]
	[SerializeField]
	private GameObject Chat_ChatRoot;

	[SerializeField]
	private Text Chat_AudienceName;

	[SerializeField]
	private Text Chat_NextMyChat;

	[SerializeField]
	private ScrollRect Chat_ChatScroll;

	[SerializeField]
	private GameObject Chat_MsgItem;

	[SerializeField]
	private GameObject Chat_DescItem;

	[SerializeField]
	private GameObject Chat_InsesrtObj;

	[SerializeField]
	private GameObject Chat_SelectObj;

	[SerializeField]
	private Button Chat_SelectBtn1;

	[SerializeField]
	private Button Chat_SelectBtn2;

	[SerializeField]
	private Text Chat_SelectBtnText1;

	[SerializeField]
	private Text Chat_SelectBtnText2;

	[SerializeField]
	private Button Chat_SendBtn;

	[SerializeField]
	private GameObject Chat_SendArrow;

	[SerializeField]
	private Button ChatBackBtn;

	private int SelectChat;

	private bool SendChat;

	private Dictionary<int, GameObject> ChatObjs;

	private Coroutine ChatCoroutine;

	private WaitUntil WaitSendChat;

	[Header("Rank")]
	[SerializeField]
	private GameObject RankRoot;

	[SerializeField]
	private GameObject RankTabRoot;

	[SerializeField]
	private Button RankBackBtn;

	[SerializeField]
	private Button InfoTabBtn;

	[SerializeField]
	private ScrollRect RankList;

	[SerializeField]
	private GameObject RankObj;

	[SerializeField]
	private Button RankRewardBtn;

	[SerializeField]
	private Text RankRewardCount;

	[SerializeField]
	private ItemRank MyRankInfo;

	[SerializeField]
	private DoTweenScriptComponent RankUpTween;

	[Header("UserInfo")]
	[SerializeField]
	private GameObject UserTabRoot;

	[SerializeField]
	private Button RankTabBtn;

	[SerializeField]
	private Button InfoBackBtn;

	[SerializeField]
	private Button InfoRichPointBtn;

	[SerializeField]
	private Button EditNameBtn;

	[SerializeField]
	private Image UserImg;

	[SerializeField]
	private Text UserName;

	[SerializeField]
	private Text RankText;

	[SerializeField]
	private Text PointText;

	[SerializeField]
	private Text TotalHousePoint;

	[SerializeField]
	private Text TotalCarPoint;

	[SerializeField]
	private ItemRichPoint HouseItem;

	[SerializeField]
	private ScrollRect CarList;

	[SerializeField]
	private GameObject PointItemObj;

	[SerializeField]
	private GameObject NoHaveHouseObj;

	[SerializeField]
	private GameObject NoHaveCarObj;

	[Header("CompanyBook")]
	[SerializeField]
	private GameObject CompanyBookRoot;

	[SerializeField]
	private Text CompanyBookTitle;

	[SerializeField]
	private Button CompanyBookBackBtn;

	[SerializeField]
	private Button CompanyFilterBtn;

	[SerializeField]
	private Text CompanyCount;

	[SerializeField]
	private Slider CompanyCountProgress;

	[SerializeField]
	private RecycleScrollRect CompanyBookScroll;

	[SerializeField]
	private GameObject CompanyBookItem;

	[SerializeField]
	private CompanyBookDetailPopup CompanyDetailPopup;

	[Header("Catstagram")]
	[SerializeField]
	private Catstagram CatstagramRoot;

	[Header("Plant")]
	[SerializeField]
	private Button PlantBtn;

	private ItemCompanyBook FocusCompany;

	private CompositeDisposable Disposables;

	private CompanySortType CurCompanySort;

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		money_disposables = new CompositeDisposable();
		ChatObjs = new Dictionary<int, GameObject>();
		CurTab = Tab.Main;
		SendChat = false;
		WaitSendChat = new WaitUntil(() => SendChat);
		CurCompanySort = CompanySortType.Basic;

		if (HomeBtn != null) HomeBtn.onClick.AddListener(OnClickGotoMain);
		if (ChatBtn != null) ChatBtn.onClick.AddListener(OnClickGotoChat);
		if (RankBtn != null) RankBtn.onClick.AddListener(OnClickGotoRank);
		if (CompanyBookBtn != null) CompanyBookBtn.onClick.AddListener(OnClickGotoCompanyBook);
		if (CatstaBtn != null) CatstaBtn.onClick.AddListener(OnClickGotoCatsta);
		if (ItemBookBtn != null) ItemBookBtn.onClick.AddListener(OnClickGotoOfficeBook);
		if (CostumeBtn != null) CostumeBtn.onClick.AddListener(OnClickGotoCostume);
		if (PlantBtn != null) PlantBtn.onClick.AddListener(OnClickGotoPlant);
		if (BankUpBtn != null) BankUpBtn.onClick.AddListener(OnClickBankLevelUp);
		if (BankInfoBtn != null) BankInfoBtn.onClick.AddListener(OnClickBankInfo);
		if (Chat_SendBtn != null) Chat_SendBtn.onClick.AddListener(OnSendChat);
		if (Chat_SelectBtn1 != null) Chat_SelectBtn1.onClick.AddListener(() => OnClickSelect(1));
		if (Chat_SelectBtn2 != null) Chat_SelectBtn2.onClick.AddListener(() => OnClickSelect(2));
		if (ContractBackBtn != null) ContractBackBtn.onClick.AddListener(OnClickGotoChat);
		if (ChatBackBtn != null) ChatBackBtn.onClick.AddListener(OnClickGotoChat);
		if (RankBackBtn != null) RankBackBtn.onClick.AddListener(OnClickGotoMain);
		if (InfoBackBtn != null) InfoBackBtn.onClick.AddListener(OnClickGotoMain);
		if (CompanyBookBackBtn != null) CompanyBookBackBtn.onClick.AddListener(OnClickGotoMain);
		if (RankTabBtn != null) RankTabBtn.onClick.AddListener(OnClickGotoRank);
		if (InfoTabBtn != null) InfoTabBtn.onClick.AddListener(OnClickGotoInfo);
		if (InfoRichPointBtn != null) InfoRichPointBtn.onClick.AddListener(OnClickRichPointInfo);
		if (EditNameBtn != null) EditNameBtn.onClick.AddListener(OnClickEditNameInfo);
		if (RankRewardBtn != null) RankRewardBtn.onClick.AddListener(OnClickGetRankingReward);
		if (CompanyFilterBtn != null) CompanyFilterBtn.onClick.AddListener(OnClickCompanyBookFilter);
	}

	public void InitTab(Tab tabType)
	{
		CurTab = tabType;
		UpdateTab();

		switch (tabType)
		{
			case Tab.Main:
				UpdateBank();
				break;
			case Tab.Chat:
				UpdateContact();
				break;
			case Tab.Rank:
				UpdateRank();
				break;
			case Tab.CompanyBook:
				UpdateCompanyBook();
				break;
			case Tab.MyInfo:
				UpdateUserInfo();
				break;
			case Tab.Catstagram:
				UpdateCatstagram();
				break;
		}
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
		if (money_disposables != null) { money_disposables.Dispose(); money_disposables = null; }
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
		if (money_disposables != null) { money_disposables.Dispose(); money_disposables = new CompositeDisposable(); }
		if (ChatCoroutine != null) { StopCoroutine(ChatCoroutine); ChatCoroutine = null; }
	}

	private void UpdateCatstagram()
	{
		if (CatstagramRoot != null) CatstagramRoot.gameObject.SetActive(true);
	}

	private void UpdateBank()
	{
		if (money_disposables != null)
		{
			money_disposables.Dispose();
			money_disposables = new CompositeDisposable();
		}
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (MoneyCount != null) MoneyCount.text = "0";
		if (LimitMoneyCount != null) LimitMoneyCount.text = "0";
		if (BankMaxObj != null) BankMaxObj.SetActive(false);
		if (MoneyLimitMaxObj != null) MoneyLimitMaxObj.SetActive(false);
	}

	private void UpdateCompanyBook()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (CompanyCount != null) CompanyCount.text = "0/0";
		if (CompanyCountProgress != null) CompanyCountProgress.value = 0f;
	}

	private void UpdateCompanyItem(int companyIdx)
	{
	}

	private void UpdateContact()
	{
		UpdateContactList();
	}

	public void UpdateContactList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void SetChats()
	{
		if (ChatObjs != null) ChatObjs.Clear();
	}

	private void SetPassiveChat(int subChat)
	{
	}

	[IteratorStateMachine(typeof(_003CStartChat_003Ed__100))]
	private IEnumerator StartChat()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) yield break;

		if (Chat_InsesrtObj != null) Chat_InsesrtObj.SetActive(false);
		if (Chat_SelectObj != null) Chat_SelectObj.SetActive(false);

		SendChat = false;
		if (Chat_SendArrow != null) Chat_SendArrow.SetActive(true);
		yield return WaitSendChat;
		if (Chat_SendArrow != null) Chat_SendArrow.SetActive(false);
	}

	private void UpdateUserInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateUserName();

		if (RankText != null) RankText.text = "";
		if (PointText != null) PointText.text = "0";
		if (TotalHousePoint != null) TotalHousePoint.text = "0";
		if (TotalCarPoint != null) TotalCarPoint.text = "0";
		if (NoHaveHouseObj != null) NoHaveHouseObj.SetActive(true);
		if (NoHaveCarObj != null) NoHaveCarObj.SetActive(true);
	}

	public void UpdateUserName()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (UserName != null) UserName.text = "";
	}

	private void UpdateRank()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (RankRewardCount != null) RankRewardCount.text = "0";
	}

	private void UpdateTab()
	{
		if (MainRoot != null) MainRoot.SetActive(CurTab == Tab.Main);
		if (ChatRoot != null) ChatRoot.SetActive(CurTab == Tab.Chat);
		if (RankRoot != null) RankRoot.SetActive(CurTab == Tab.Rank);
		if (CompanyBookRoot != null) CompanyBookRoot.SetActive(CurTab == Tab.CompanyBook);

		if (RankTabRoot != null) RankTabRoot.SetActive(CurTab == Tab.Rank);
		if (UserTabRoot != null) UserTabRoot.SetActive(CurTab == Tab.MyInfo);

		if (Chat_ContactRoot != null) Chat_ContactRoot.SetActive(CurTab == Tab.Chat);
		if (Chat_ChatRoot != null) Chat_ChatRoot.SetActive(false);

		if (CatstagramRoot != null) CatstagramRoot.gameObject.SetActive(CurTab == Tab.Catstagram);
	}

	private void Update()
	{
		UpdateDayTime();
	}

	private void UpdateDayTime()
	{
		var now = DateTime.Now;
		string timeStr = now.ToString("HH:mm");
		if (HudTimeText != null) HudTimeText.text = timeStr;
		if (TimeText != null && CurTab == Tab.Main) TimeText.text = timeStr;
	}

	private void OnSendChat()
	{
		SendChat = true;
	}

	private void OnClickSelect(int select)
	{
		SelectChat = select;
		SendChat = true;
		if (Chat_SelectObj != null) Chat_SelectObj.SetActive(false);
	}

	private void OnSelectChat(int group)
	{
		if (Chat_ContactRoot != null) Chat_ContactRoot.SetActive(false);
		if (Chat_ChatRoot != null) Chat_ChatRoot.SetActive(true);

		SetChats();
		if (ChatCoroutine != null) StopCoroutine(ChatCoroutine);
		ChatCoroutine = StartCoroutine(StartChat());
	}

	private void OnClickGotoChat()
	{
		CurTab = Tab.Chat;
		UpdateTab();
		UpdateContact();
	}

	private void OnClickGotoRank()
	{
		CurTab = Tab.Rank;
		UpdateTab();
		UpdateRank();
	}

	private void OnClickGotoInfo()
	{
		CurTab = Tab.MyInfo;
		UpdateTab();
		UpdateUserInfo();
	}

	public void OnClickGotoCompanyBook()
	{
		CurTab = Tab.CompanyBook;
		UpdateTab();
		UpdateCompanyBook();
	}

	private void OnClickGotoOfficeBook()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickGotoCostume()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupCostume>();
	}

	private void OnClickGotoCatsta()
	{
		CurTab = Tab.Catstagram;
		UpdateTab();
		UpdateCatstagram();
	}

	private void OnClickGotoPlant()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PagePlantList>();
	}

	private void OnClickGotoMain()
	{
		CurTab = Tab.Main;
		UpdateTab();
		UpdateBank();
	}

	private void OnClickRichPointInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickEditNameInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupEditName>();
	}

	private void OnClickBankInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupBankingInfo>();
	}

	private void OnClickBankLevelUp()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateBank();
	}

	private void OnClickCompanyInfo(int company)
	{
		FocusCompanyInfo(company);
	}

	public void FocusCompanyInfo(int companyIdx)
	{
		if (CompanyDetailPopup == null) return;
		CompanyDetailPopup.gameObject.SetActive(true);
	}

	public void ShowLevelUpGuide(int companyIdx, int guideLevel)
	{
		FocusCompanyInfo(companyIdx);
	}

	private void OnFocusAfterScrolled(Vector2 value)
	{
	}

	private void FocusNextMaxCompany()
	{
	}

	private void ReleaseFocusCompany()
	{
		FocusCompany = null;
		if (CompanyDetailPopup != null) CompanyDetailPopup.gameObject.SetActive(false);
	}

	private void OnClickCompanyBookFilter()
	{
		CurCompanySort = CurCompanySort == CompanySortType.Basic ? CompanySortType.UnLock : CompanySortType.Basic;
		UpdateCompanyBook();
	}

	private void OnClickGetRankingReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
