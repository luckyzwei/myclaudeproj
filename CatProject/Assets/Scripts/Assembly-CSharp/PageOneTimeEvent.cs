using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageOneTimeEvent", false, false)]
public class PageOneTimeEvent : UIBase, ILocalizeRefresh
{
	[Serializable]
	public class BuildingStruct
	{
		[Header("BuildingStruct")]
		[SerializeField]
		private int idx;

		[SerializeField]
		private List<ItemOnetimeFloor> itemOnetimeFloors;

		[SerializeField]
		private GameObject bodyR;

		[SerializeField]
		private GameObject roof;

		public int Idx { get { return 0; } }

		public List<ItemOnetimeFloor> ItemOnetimeFloors { get { return null; } }

		public GameObject BodyR { get { return null; } }

		public GameObject Roof { get { return null; } }
	}

	[CompilerGenerated]
	private sealed class _003CRandomMessage_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageOneTimeEvent _003C_003E4__this;

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
		public _003CRandomMessage_003Ed__68(int _003C_003E1__state)
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

	[Header("[PageOneTimeEvent]")]
	[Header("Top")]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text titleText;

	[SerializeField]
	private Text subTitleText;

	[SerializeField]
	private Text RemainTimeText;

	[Space(5f)]
	[Header("Building")]
	[SerializeField]
	private Transform backgroundT;

	private GameObject CurBackgroundObj;

	[SerializeField]
	private List<BuildingStruct> BuildingStructs;

	private BuildingStruct CurBuildingStruct;

	[SerializeField]
	private List<DoTweenScriptComponent> floorDoTweens;

	[SerializeField]
	private float floorDoTweenTerm;

	[SerializeField]
	private Transform exitT;

	[Header("Message")]
	[SerializeField]
	private Transform MessageT;

	[SerializeField]
	private Text MessageText;

	[SerializeField]
	private float MessageTerm;

	[Header("Characters")]
	[SerializeField]
	private Animator charactersAnimator;

	[SerializeField]
	private float characterTerm;

	[Space(10f)]
	[Header("Progress")]
	[SerializeField]
	private ItemOnetimeReward[] RewardItems;

	[SerializeField]
	private GameObject ProgressRoot;

	[SerializeField]
	private Text CurStep;

	[SerializeField]
	private Text ProgressBarText;

	[SerializeField]
	private Slider ProgressSlider;

	[Space(5f)]
	[Header("Currency")]
	[SerializeField]
	private ButtonPressed UseCurrencyBtn;

	[SerializeField]
	private Image CurrencyIcon;

	[SerializeField]
	private Text CurrencyText;

	[SerializeField]
	private GameObject CurrencyReddot;

	[SerializeField]
	private GameObject UpgradeFxObj;

	[Space(5f)]
	[SerializeField]
	private Transform CurrencyParticleSmallT;

	[SerializeField]
	private Transform CurrencyParticleBigT;

	private ParticleSystem CurrencyParticleSmall;

	private ParticleSystem CurrencyParticleBig;

	[SerializeField]
	private float CurrencyParticleDuration;

	[Space(5f)]
	[SerializeField]
	private GameObject CompleteObject;

	[Header("ETC")]
	[SerializeField]
	private Button screenTouch;

	[SerializeField]
	private Button AprilFoolBannerBtn;

	[SerializeField]
	private GameObject AprilFoolGuideArrow;

	private int CurOneTimeIdx;

	private int CurOneTimeThemeIdx;

	private int CurNeedCount;

	private WaitUntil waitMessageTerm;

	private CompositeDisposable disposables;

	private Coroutine CurMessageCoroutine;

	private Coroutine CurAnimationCoroutine;

	private float RemainMessageDuration;

	private float RemainCurrencyParticleDuration;

	private float RemainFloorDoTweenDuration;

	private bool IsOnSimpleMode;

	public Animator CharactersAnimator { get { return null; } }

	public Button ScreenTouch { get { return null; } }

	public bool OnRewarding { get; set; }

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void UpdateOneTimeInfo(bool isUpdateTheme = true)
	{
	}

	private void UpdateLevel()
	{
	}

	private void UpdateLevelText()
	{
	}

	private void UpdateLevelBuilding(int nextLevel = -1)
	{
	}

	public void UpdateBtns()
	{
	}

	private void UpdateExp()
	{
	}

	public void UpdateCurrency()
	{
	}

	private void HideInfoBubbles()
	{
	}

	private void ShowCurrencyParticle()
	{
	}

	private void ShowMessage(int targetLevel)
	{
	}

	[IteratorStateMachine(typeof(_003CRandomMessage_003Ed__68))]
	private IEnumerator RandomMessage()
	{
		yield break;
	}

	private void ShowGuideArrow()
	{
	}

	private void OnClickUseCurrency()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickAprilFoolBanner()
	{
	}

	public void RefreshText()
	{
	}

	private void KillCoroutine()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
