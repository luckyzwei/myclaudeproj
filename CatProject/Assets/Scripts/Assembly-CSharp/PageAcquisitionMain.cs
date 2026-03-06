using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionMain", false, false)]
public class PageAcquisitionMain : FullScreenUI, IHUDTopInfo
{
	[CompilerGenerated]
	private sealed class _003CDelayEndActionQueue_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action onEndAction;

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
		public _003CDelayEndActionQueue_003Ed__47(int _003C_003E1__state)
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

	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private Button BizAcquisitionStartBtn;

	[SerializeField]
	private Button BizAcquisitionRewardBtn;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text CurCityNameText;

	[SerializeField]
	private TimeComponent RewardTimeComponent;

	[SerializeField]
	private GameObject RewardFullObj;

	[SerializeField]
	private Transform ItemGetEndTr;

	[SerializeField]
	private List<ItemAcquisitionMainStage> StageItems;

	[Header("Manager")]
	[SerializeField]
	private Button ManagerBtn;

	[Header("[Area_LeftTop]")]
	[SerializeField]
	private Button WeeklyShopBtn;

	[SerializeField]
	private Image WeeklyShopIconImage;

	[SerializeField]
	private TimeComponent WeeklyShopTimeComponent;

	[SerializeField]
	private Button ManagerShopBtn;

	[Header("BattleSpeed")]
	[SerializeField]
	private GameObject PackageObj_BattleSpeed;

	[SerializeField]
	private Button PackageBtn_BattleSpeed;

	[Header("AcqPass")]
	[SerializeField]
	private GameObject PackageObj_AcqPass;

	[SerializeField]
	private Button PackageBtn_AcqPass;

	[SerializeField]
	private GameObject AcqPassBubbleObj;

	[SerializeField]
	private Image AcqPassBubbleImage;

	[Header("Package")]
	[SerializeField]
	private HudPackageItem ManagerPackageGroup;

	[SerializeField]
	private HudPackageComponent PackageComp;

	[SerializeField]
	private ItemMission SubMissionItem;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent OneTimeComponent;

	[Header("JewelryBox")]
	[SerializeField]
	private HUDJewelryBoxComponent JewelryBoxComp;

	[Header("EndlessOffer")]
	[SerializeField]
	private HudEndlessOfferItem EndlessOfferItem_1;

	[SerializeField]
	private HudEndlessOfferItem EndlessOfferItem_2;

	[SerializeField]
	private Transform OneTimeCurrencyEndTr;

	private bool IsOpenWeeklyShop;

	private DateTime WeeklyShopResetTime;

	private Queue<Action> ActionQueue;

	private List<int> EndlessOfferIdxList;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		ActionQueue = new Queue<Action>();
		EndlessOfferIdxList = new List<int>();
		IsOpenWeeklyShop = false;

		if (BizAcquisitionStartBtn != null) BizAcquisitionStartBtn.onClick.AddListener(OnClickedBizAcquisitionStartBtn);
		if (BizAcquisitionRewardBtn != null) BizAcquisitionRewardBtn.onClick.AddListener(OnClickedBizAcquisitionRewardBtn);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnInfoBtnClick);
		if (ManagerShopBtn != null) ManagerShopBtn.onClick.AddListener(OnClickedManagerShopBtn);
		if (ManagerBtn != null) ManagerBtn.onClick.AddListener(OnClickedManagerBtn);
		if (WeeklyShopBtn != null) WeeklyShopBtn.onClick.AddListener(OnClickedWeeklyShopBtn);
		if (PackageBtn_BattleSpeed != null) PackageBtn_BattleSpeed.onClick.AddListener(OnClickedPackageBtn_BattleSpeed);
		if (PackageBtn_AcqPass != null) PackageBtn_AcqPass.onClick.AddListener(OnClickedPackageBtn_AcqPass);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;

		SetIdleRewardInfo();
		SetSubMissionItem();
		SetWeeklyShopSaleInfo();
		SetEndlessOffer();
		SetManagerPackage();
		SetBattleSpeedSpecialPackageIcon();
		SetAcqStagePassSpecialPackageIcon();
		UpdateContentsOpen();
		UpdateJewelryBoxValue();
		StartActionQueue();
	}

	public override void OnHideBefore()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	public override void Hide()
	{
		base.Hide();
	}

	public override void OnRefresh()
	{
		SetIdleRewardInfo();
		UpdateJewelryBoxValue();
		UpdateContentsOpen();
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return HUDTopInfo;
	}

	public Transform FindRewardGetTransform(TopInfoData topInfoData)
	{
		if (ItemGetEndTr != null) return ItemGetEndTr;
		return null;
	}

	public void SetStageList(int curStageIdx, bool isClearAll)
	{
		if (StageItems == null) return;
		for (int i = 0; i < StageItems.Count; i++)
		{
			if (StageItems[i] == null) continue;
			StageItems[i].gameObject.SetActive(true);
			// Set stage item state based on current stage index
		}
		if (CurCityNameText != null) CurCityNameText.text = "";
	}

	public void OpenBizAcqBattleStart()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
	}

	public void UpdateJewelryBoxValue()
	{
		if (JewelryBoxComp == null) return;
	}

	public void UpdateAccumulateJewelryBoxValue(Vector3 rewardGetPos, Action onEndAction)
	{
		UpdateAccumulateJewelryBoxValue(onEndAction);
	}

	private void UpdateAccumulateJewelryBoxValue(Action onEndAction)
	{
		UpdateJewelryBoxValue();
		onEndAction?.Invoke();
	}

	private void SetIdleRewardInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;

		bool isFull = false;
		if (RewardFullObj != null) RewardFullObj.SetActive(isFull);
	}

	private void StartActionQueue()
	{
		if (ActionQueue == null || ActionQueue.Count == 0) return;
		var action = ActionQueue.Dequeue();
		action?.Invoke();
	}

	[IteratorStateMachine(typeof(_003CDelayEndActionQueue_003Ed__47))]
	private IEnumerator DelayEndActionQueue(Action onEndAction)
	{
		yield return new WaitForSeconds(0.5f);
		onEndAction?.Invoke();
	}

	private void UpdateContentsOpen()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ContentsOpenSystem == null) return;
		if (PackageObj_BattleSpeed != null) PackageObj_BattleSpeed.SetActive(false);
		if (PackageObj_AcqPass != null) PackageObj_AcqPass.SetActive(false);
	}

	private void SetSubMissionItem()
	{
		if (SubMissionItem == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void CheckAndPlayReinforceTutorial(Action onEndAction)
	{
		onEndAction?.Invoke();
	}

	private void CheckAndOpenBattleSpeedSpecialPackage(Action onEndAction)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) { onEndAction?.Invoke(); return; }
		onEndAction?.Invoke();
	}

	private void ShowBattleSpeedSpecialPackage(Action onEndAction)
	{
		if (PackageObj_BattleSpeed != null) PackageObj_BattleSpeed.SetActive(true);
		onEndAction?.Invoke();
	}

	private void SetBattleSpeedSpecialPackageIcon()
	{
		if (PackageObj_BattleSpeed == null) return;
	}

	private void CheckAndOpenAcqStagePassSpecialPackage(Action onEndAction)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) { onEndAction?.Invoke(); return; }
		onEndAction?.Invoke();
	}

	private void ShowAcqStagePassSpecialPackage(Action onEndAction)
	{
		if (PackageObj_AcqPass != null) PackageObj_AcqPass.SetActive(true);
		if (AcqPassBubbleObj != null) AcqPassBubbleObj.SetActive(true);
		onEndAction?.Invoke();
	}

	private void SetAcqStagePassSpecialPackageIcon()
	{
		if (PackageObj_AcqPass == null) return;
	}

	private void UpdatePackage(Action onEndAction)
	{
		if (PackageComp != null)
		{
			// Update package component
		}
		onEndAction?.Invoke();
	}

	private void SetManagerPackage()
	{
		if (ManagerPackageGroup == null) return;
	}

	private void SetWeeklyShopSaleInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (WeeklyShopBtn != null) WeeklyShopBtn.gameObject.SetActive(false);
	}

	private void SetWeeklyShopSaleTimer(DateTime startTime)
	{
		WeeklyShopResetTime = startTime;
		if (WeeklyShopTimeComponent != null)
		{
			// Set timer countdown display
		}
	}

	private void CheckAndOpenWeeklyShop(Action onEndAction)
	{
		if (IsOpenWeeklyShop) { onEndAction?.Invoke(); return; }
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) { onEndAction?.Invoke(); return; }
		onEndAction?.Invoke();
	}

	private void SetEndlessOffer()
	{
		if (EndlessOfferIdxList == null) EndlessOfferIdxList = new List<int>();
		EndlessOfferIdxList.Clear();
		if (EndlessOfferItem_1 != null) EndlessOfferItem_1.gameObject.SetActive(false);
		if (EndlessOfferItem_2 != null) EndlessOfferItem_2.gameObject.SetActive(false);
	}

	private void CheckAndOpenEndlessOffer(int offerIdx, Action onEndAction)
	{
		onEndAction?.Invoke();
	}

	public void OpenBizAcquisitionReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
	}

	private void OnClickedBizAcquisitionStartBtn()
	{
		OpenBizAcqBattleStart();
	}

	private void OnClickedBizAcquisitionRewardBtn()
	{
		OpenBizAcquisitionReward();
	}

	private void OnInfoBtnClick()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickedManagerShopBtn()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickedPackageBtn_BattleSpeed()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickedPackageBtn_AcqPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickedWeeklyShopBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickedManagerBtn()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}
}
