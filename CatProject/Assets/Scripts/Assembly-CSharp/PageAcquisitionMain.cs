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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void Hide()
	{
	}

	public override void OnRefresh()
	{
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return null;
	}

	public Transform FindRewardGetTransform(TopInfoData topInfoData)
	{
		return null;
	}

	public void SetStageList(int curStageIdx, bool isClearAll)
	{
	}

	public void OpenBizAcqBattleStart()
	{
	}

	public void UpdateJewelryBoxValue()
	{
	}

	public void UpdateAccumulateJewelryBoxValue(Vector3 rewardGetPos, Action onEndAction)
	{
	}

	private void UpdateAccumulateJewelryBoxValue(Action onEndAction)
	{
	}

	private void SetIdleRewardInfo()
	{
	}

	private void StartActionQueue()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayEndActionQueue_003Ed__47))]
	private IEnumerator DelayEndActionQueue(Action onEndAction)
	{
		yield break;
	}

	private void UpdateContentsOpen()
	{
	}

	private void SetSubMissionItem()
	{
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
	}

	private void CheckAndPlayReinforceTutorial(Action onEndAction)
	{
	}

	private void CheckAndOpenBattleSpeedSpecialPackage(Action onEndAction)
	{
	}

	private void ShowBattleSpeedSpecialPackage(Action onEndAction)
	{
	}

	private void SetBattleSpeedSpecialPackageIcon()
	{
	}

	private void CheckAndOpenAcqStagePassSpecialPackage(Action onEndAction)
	{
	}

	private void ShowAcqStagePassSpecialPackage(Action onEndAction)
	{
	}

	private void SetAcqStagePassSpecialPackageIcon()
	{
	}

	private void UpdatePackage(Action onEndAction)
	{
	}

	private void SetManagerPackage()
	{
	}

	private void SetWeeklyShopSaleInfo()
	{
	}

	private void SetWeeklyShopSaleTimer(DateTime startTime)
	{
	}

	private void CheckAndOpenWeeklyShop(Action onEndAction)
	{
	}

	private void SetEndlessOffer()
	{
	}

	private void CheckAndOpenEndlessOffer(int offerIdx, Action onEndAction)
	{
	}

	public void OpenBizAcquisitionReward()
	{
	}

	private void OnClickedBizAcquisitionStartBtn()
	{
	}

	private void OnClickedBizAcquisitionRewardBtn()
	{
	}

	private void OnInfoBtnClick()
	{
	}

	private void OnClickedManagerShopBtn()
	{
	}

	private void OnClickedPackageBtn_BattleSpeed()
	{
	}

	private void OnClickedPackageBtn_AcqPass()
	{
	}

	private void OnClickedWeeklyShopBtn()
	{
	}

	private void OnClickedManagerBtn()
	{
	}
}
