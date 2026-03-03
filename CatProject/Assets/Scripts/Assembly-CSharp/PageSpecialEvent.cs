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

	public Button ScreenTouch => null;

	public bool OnRewarding { get; set; }

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnChangeBuildingScroll(Vector2 value)
	{
	}

	public override void OnShowBefore()
	{
	}

	private void InitPage()
	{
	}

	private void UpdateOneTimeInfo(Action onSuccess, Action onFail)
	{
	}

	private void UpdateInfo()
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

	private void UpdateLastReward()
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

	[IteratorStateMachine(typeof(_003CRandomMessage_003Ed__60))]
	private IEnumerator RandomMessage()
	{
		return null;
	}

	private void OnClickUseCurrency()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickRoulette()
	{
	}

	public void RefreshText()
	{
	}

	private void SetScroll(float speed)
	{
	}

	private void SetScrollExit(float speed)
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
