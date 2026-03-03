using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HUDFactory", true, false)]
public class HUDFactory : HUDBase, IScreenAction
{
	[CompilerGenerated]
	private sealed class _003CWaitComebackCo_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDFactory _003C_003E4__this;

		public bool value;

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
		public _003CWaitComebackCo_003Ed__77(int _003C_003E1__state)
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

	private HUDType[] aniType;

	[Header("[HUDFactory]")]
	private bool appear;

	private bool screenAction;

	[SerializeField]
	private GameObject FactoryRoot;

	[SerializeField]
	private List<GameObject> LeftRoot;

	[SerializeField]
	private List<GameObject> RightRoot;

	private List<float> originLeftPos;

	private List<float> originRightPos;

	[Header("Storage")]
	[SerializeField]
	private Button StorageBtn;

	[Header("Order")]
	[SerializeField]
	private Button OrderBtn;

	[Header("Process")]
	[SerializeField]
	private Button ProcessBtn;

	[Header("Shop")]
	[SerializeField]
	private Button ShopBtn;

	[Header("Roulette")]
	[SerializeField]
	private Button RouletteBtn;

	[Header("NoAds")]
	[SerializeField]
	private Button NoAdsBtn;

	[SerializeField]
	private Image NoAdsIcon;

	[SerializeField]
	private Image NoAdsIcon2;

	[SerializeField]
	private Text NoAdsSaleRemainTime;

	[SerializeField]
	private GameObject NoAdsSaleObj;

	[SerializeField]
	private Text NoAdsSale;

	[Header("GemPass")]
	[SerializeField]
	private Button GemPassBtn;

	[SerializeField]
	private Image GemPassIcon;

	[SerializeField]
	private Image GemPassIcon2;

	[Header("Worldmap")]
	[SerializeField]
	private Button WorldMapShortCutBtn;

	[SerializeField]
	private Button OfficeShortCutBtn;

	[Header("Option")]
	[SerializeField]
	private Button OptionBtn;

	[Header("DailyQuest")]
	[SerializeField]
	private Button DailyQuestBtn;

	[Header("MultiRevenue")]
	[SerializeField]
	private Button MultiRevenueBtn;

	[SerializeField]
	private GameObject MultiRevenueSaleObj;

	[SerializeField]
	private Text MultiRevenueRemainText;

	[SerializeField]
	private Text MultiRevenueSaleText;

	[Header("PiggyBank")]
	[SerializeField]
	private Button PiggyBtn;

	[SerializeField]
	private Text PiggyCount;

	[SerializeField]
	private Image PiggyIcon;

	[SerializeField]
	private GameObject PiggyReddot;

	[SerializeField]
	private DoTweenScriptComponent PiggyTween;

	[Header("Package")]
	[SerializeField]
	private HudPackageComponent PackageComp;

	[SerializeField]
	private HudShopSaleComponent ShopSaleComp;

	[Header("Etc")]
	[SerializeField]
	private GameObject TopRightBGObj;

	private CompositeDisposable noadssale_disposables;

	private CompositeDisposable mrsale_disposables;

	private Coroutine ScreenActionCo;

	private List<Tween> ScreenActionTweens;

	public HUDType[] HudType => null;

	public bool IsScreenAction => false;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Refresh(E_RefreshType refreshType)
	{
	}

	public void SetMRSale()
	{
	}

	public void SetMultiRevenue()
	{
	}

	private void OnClickMultiRevenue()
	{
	}

	private void OnClickWorldMapShortCutBtn()
	{
	}

	private void OnClickOfficeShortCutBtn()
	{
	}

	private void OnClickStorage()
	{
	}

	private void OnClickProcess()
	{
	}

	private void OnClickOrder()
	{
	}

	private void SetShop()
	{
	}

	private void OnClickShop()
	{
	}

	public void UpdatePackage()
	{
	}

	private void SetDailyQuest()
	{
	}

	private void OnClickDailyQuest()
	{
	}

	private void SetPiggyBank()
	{
	}

	public void UpdatePiggyValue()
	{
	}

	private void OnClickPiggyBank()
	{
	}

	public void SetNoAds()
	{
	}

	private void UpdateNoAdsIcon()
	{
	}

	private void OnClickNoAds()
	{
	}

	public void SetGemPass()
	{
	}

	private void OnClickGemPass()
	{
	}

	private void OnClickOption()
	{
	}

	private void SetRoulette()
	{
	}

	private void OnClickRoulette()
	{
	}

	public Vector3 GetPiggyPos()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CWaitComebackCo_003Ed__77))]
	private IEnumerator WaitComebackCo(bool value)
	{
		return null;
	}

	public void ScreenAction(bool value)
	{
	}

	private void InitScreenTweens()
	{
	}

	public void ScreenTopOn(bool value)
	{
	}

	public bool IsScreenTopOn()
	{
		return false;
	}

	public void SetActiveRoot(bool isActive)
	{
	}
}
