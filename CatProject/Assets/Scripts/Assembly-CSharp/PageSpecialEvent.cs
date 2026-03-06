using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageSpecialEvent", false, false)]
public class PageSpecialEvent : UIBase, ILocalizeRefresh
{
	[CompilerGenerated]
	private sealed class _003CRandomMessage_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageSpecialEvent _003C_003E4__this;

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
		public _003CRandomMessage_003Ed__60(int _003C_003E1__state)
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

	[Header("[PageSpecialEvent]")]
	[Header("Top")]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text SubTitleText;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button RouletteBtn;

	[Space(5f)]
	[Header("Building")]
	[SerializeField]
	private Transform buildingRoot;

	private ItemSpecialDayStruct CurSpecialDayStruct;

	[SerializeField]
	private float floorDoTweenTerm;

	[Header("Message")]
	[SerializeField]
	private Transform MessageT;

	[SerializeField]
	private Text MessageText;

	[SerializeField]
	private float MessageTerm;

	[Space(10f)]
	[Header("Progress")]
	[SerializeField]
	private Slider ProgressSlider;

	[SerializeField]
	private Text CurStep;

	[SerializeField]
	private Text ProgressBarText;

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
	private ParticleSystem CurrencyParticle;

	[SerializeField]
	private float CurrencyParticleDuration;

	[Space(5f)]
	[SerializeField]
	private GameObject CompleteObject;

	[Space(5f)]
	[Header("Last Reward")]
	[SerializeField]
	private GameObject LastRewardObj;

	[SerializeField]
	private List<ItemArticle> LastRewardItems;

	[Header("ETC")]
	[SerializeField]
	private Button screenTouch;

	[SerializeField]
	private ScrollRect BuildingScroll;

	private int CurOneTimeIdx;

	private int CurOneTimeThemeIdx;

	private int curNeedCount;

	private WaitUntil waitMessageTerm;

	private CompositeDisposable disposables;

	private Coroutine CurMessageCoroutine;

	private Coroutine CurAnimationCoroutine;

	private float RemainMessageDuration;

	private float RemainCurrencyParticleDuration;

	private float RemainFloorDoTweenDuration;

	private bool IsOnSimpleMode;

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
		if (RouletteBtn != null) RouletteBtn.onClick.AddListener(OnClickRoulette);
		if (BuildingScroll != null) BuildingScroll.onValueChanged.AddListener(OnChangeBuildingScroll);
	}

	private void Update()
	{
		if (RemainMessageDuration > 0f) RemainMessageDuration -= Time.deltaTime;
		if (RemainCurrencyParticleDuration > 0f) RemainCurrencyParticleDuration -= Time.deltaTime;
		if (RemainFloorDoTweenDuration > 0f) RemainFloorDoTweenDuration -= Time.deltaTime;
	}

	private void OnChangeBuildingScroll(Vector2 value)
	{
	}

	public override void OnShowBefore()
	{
		InitPage();
	}

	private void InitPage()
	{
		UpdateOneTimeInfo(null, null);
	}

	private void UpdateOneTimeInfo(Action onSuccess, Action onFail)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) { onFail?.Invoke(); return; }

		UpdateInfo();
		onSuccess?.Invoke();
	}

	private void UpdateInfo()
	{
		UpdateLevel();
		UpdateBtns();
		UpdateCurrency();
		UpdateExp();
		UpdateLastReward();
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
		if (buildingRoot == null) return;
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
		ProgressSlider.value = 0f;
	}

	public void UpdateCurrency()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (CurrencyText != null) CurrencyText.text = "0";
	}

	private void UpdateLastReward()
	{
		if (LastRewardObj == null) return;
		LastRewardObj.SetActive(false);
	}

	private void HideInfoBubbles()
	{
	}

	private void ShowCurrencyParticle()
	{
		RemainCurrencyParticleDuration = CurrencyParticleDuration;
		if (CurrencyParticle != null) CurrencyParticle.Play();
	}

	private void ShowMessage(int targetLevel)
	{
		if (CurMessageCoroutine != null) StopCoroutine(CurMessageCoroutine);
		CurMessageCoroutine = StartCoroutine(RandomMessage());
	}

	[IteratorStateMachine(typeof(_003CRandomMessage_003Ed__60))]
	private IEnumerator RandomMessage()
	{
		if (MessageText == null || MessageT == null) yield break;
		RemainMessageDuration = MessageTerm;
		MessageText.text = "";
		yield return waitMessageTerm;
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

	private void OnClickRoulette()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageRoulette>();
	}

	public void RefreshText()
	{
		UpdateLevelText();
		UpdateCurrency();
	}

	private void SetScroll(float speed)
	{
		if (BuildingScroll != null)
			BuildingScroll.horizontalNormalizedPosition = Mathf.Clamp01(BuildingScroll.horizontalNormalizedPosition + speed * Time.deltaTime);
	}

	private void SetScrollExit(float speed)
	{
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
