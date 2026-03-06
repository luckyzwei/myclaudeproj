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

		public int Idx { get { return idx; } }

		public List<ItemOnetimeFloor> ItemOnetimeFloors { get { return itemOnetimeFloors; } }

		public GameObject BodyR { get { return bodyR; } }

		public GameObject Roof { get { return roof; } }
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

	public Animator CharactersAnimator { get { return charactersAnimator; } }

	public Button ScreenTouch { get { return screenTouch; } }

	public bool OnRewarding { get; set; }

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		OnRewarding = false;
		IsOnSimpleMode = false;
		waitMessageTerm = new WaitUntil(() => RemainMessageDuration <= 0f);

		if (UseCurrencyBtn != null) UseCurrencyBtn.OnPressed = OnClickUseCurrency;
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (AprilFoolBannerBtn != null) AprilFoolBannerBtn.onClick.AddListener(OnClickAprilFoolBanner);
	}

	private void Update()
	{
		if (RemainMessageDuration > 0f) RemainMessageDuration -= Time.deltaTime;
		if (RemainCurrencyParticleDuration > 0f) RemainCurrencyParticleDuration -= Time.deltaTime;
		if (RemainFloorDoTweenDuration > 0f) RemainFloorDoTweenDuration -= Time.deltaTime;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public override void OnShowBefore()
	{
		UpdateOneTimeInfo();
	}

	private void UpdateOneTimeInfo(bool isUpdateTheme = true)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (isUpdateTheme)
		{
			// Set theme background and building struct
		}
		UpdateLevel();
		UpdateBtns();
		UpdateCurrency();
		UpdateExp();
	}

	private void UpdateLevel()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateLevelText();
		UpdateLevelBuilding();
	}

	private void UpdateLevelText()
	{
		if (CurStep != null) CurStep.text = "";
		if (ProgressBarText != null) ProgressBarText.text = "";
	}

	private void UpdateLevelBuilding(int nextLevel = -1)
	{
		if (BuildingStructs == null || CurBuildingStruct == null) return;
		if (CurBuildingStruct.ItemOnetimeFloors != null)
		{
			for (int i = 0; i < CurBuildingStruct.ItemOnetimeFloors.Count; i++)
			{
				if (CurBuildingStruct.ItemOnetimeFloors[i] != null)
					CurBuildingStruct.ItemOnetimeFloors[i].gameObject.SetActive(true);
			}
		}
	}

	public void UpdateBtns()
	{
		bool isComplete = false;
		if (CompleteObject != null) CompleteObject.SetActive(isComplete);
		if (UseCurrencyBtn != null) UseCurrencyBtn.gameObject.SetActive(!isComplete);
		if (CurrencyReddot != null) CurrencyReddot.SetActive(false);
	}

	private void UpdateExp()
	{
		if (ProgressSlider == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		ProgressSlider.value = 0f;
	}

	public void UpdateCurrency()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (CurrencyText != null) CurrencyText.text = "0";
	}

	private void HideInfoBubbles()
	{
	}

	private void ShowCurrencyParticle()
	{
		RemainCurrencyParticleDuration = CurrencyParticleDuration;
		if (CurrencyParticleSmall != null) CurrencyParticleSmall.Play();
	}

	private void ShowMessage(int targetLevel)
	{
		if (CurMessageCoroutine != null) StopCoroutine(CurMessageCoroutine);
		CurMessageCoroutine = StartCoroutine(RandomMessage());
	}

	[IteratorStateMachine(typeof(_003CRandomMessage_003Ed__68))]
	private IEnumerator RandomMessage()
	{
		if (MessageText == null || MessageT == null) yield break;
		RemainMessageDuration = MessageTerm;
		MessageText.text = "";
		yield return waitMessageTerm;
	}

	private void ShowGuideArrow()
	{
		if (AprilFoolGuideArrow != null) AprilFoolGuideArrow.SetActive(true);
	}

	private void OnClickUseCurrency()
	{
		if (OnRewarding) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		OnRewarding = true;
		if (UpgradeFxObj != null) UpgradeFxObj.SetActive(true);
		ShowCurrencyParticle();
		UpdateLevel();
		UpdateCurrency();
		UpdateBtns();
		OnRewarding = false;
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickAprilFoolBanner()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void RefreshText()
	{
		UpdateLevelText();
		UpdateCurrency();
	}

	private void KillCoroutine()
	{
		if (CurMessageCoroutine != null) { StopCoroutine(CurMessageCoroutine); CurMessageCoroutine = null; }
		if (CurAnimationCoroutine != null) { StopCoroutine(CurAnimationCoroutine); CurAnimationCoroutine = null; }
	}

	public override void OnHideBefore()
	{
		KillCoroutine();
	}

	public override void OnHideAfter()
	{
		if (UpgradeFxObj != null) UpgradeFxObj.SetActive(false);
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		KillCoroutine();
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
