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
	}

	public void InitTab(Tab tabType)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateCatstagram()
	{
	}

	private void UpdateBank()
	{
	}

	private void UpdateCompanyBook()
	{
	}

	private void UpdateCompanyItem(int companyIdx)
	{
	}

	private void UpdateContact()
	{
	}

	public void UpdateContactList()
	{
	}

	private void SetChats()
	{
	}

	private void SetPassiveChat(int subChat)
	{
	}

	[IteratorStateMachine(typeof(_003CStartChat_003Ed__100))]
	private IEnumerator StartChat()
	{
		return null;
	}

	private void UpdateUserInfo()
	{
	}

	public void UpdateUserName()
	{
	}

	private void UpdateRank()
	{
	}

	private void UpdateTab()
	{
	}

	private void Update()
	{
	}

	private void UpdateDayTime()
	{
	}

	private void OnSendChat()
	{
	}

	private void OnClickSelect(int select)
	{
	}

	private void OnSelectChat(int group)
	{
	}

	private void OnClickGotoChat()
	{
	}

	private void OnClickGotoRank()
	{
	}

	private void OnClickGotoInfo()
	{
	}

	public void OnClickGotoCompanyBook()
	{
	}

	private void OnClickGotoOfficeBook()
	{
	}

	private void OnClickGotoCostume()
	{
	}

	private void OnClickGotoCatsta()
	{
	}

	private void OnClickGotoPlant()
	{
	}

	private void OnClickGotoMain()
	{
	}

	private void OnClickRichPointInfo()
	{
	}

	private void OnClickEditNameInfo()
	{
	}

	private void OnClickBankInfo()
	{
	}

	private void OnClickBankLevelUp()
	{
	}

	private void OnClickCompanyInfo(int company)
	{
	}

	public void FocusCompanyInfo(int companyIdx)
	{
	}

	public void ShowLevelUpGuide(int companyIdx, int guideLevel)
	{
	}

	private void OnFocusAfterScrolled(Vector2 value)
	{
	}

	private void FocusNextMaxCompany()
	{
	}

	private void ReleaseFocusCompany()
	{
	}

	private void OnClickCompanyBookFilter()
	{
	}

	private void OnClickGetRankingReward()
	{
	}
}
