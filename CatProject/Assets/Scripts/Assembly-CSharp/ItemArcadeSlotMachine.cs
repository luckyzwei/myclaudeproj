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

public class ItemArcadeSlotMachine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnAnimationComplete_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemArcadeSlotMachine _003C_003E4__this;

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
		public _003COnAnimationComplete_003Ed__104(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitForAnimation_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animator anim;

		public string stateName;

		public ItemArcadeSlotMachine _003C_003E4__this;

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
		public _003CWaitForAnimation_003Ed__103(int _003C_003E1__state)
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

	private readonly int MATCH_SLOT_INDEX;

	private readonly string SHOW;

	private readonly string NO_MATCH;

	private readonly string TWO_MATCH;

	private readonly string THREE_MATCH;

	private readonly string REWARD;

	private readonly string ROULETTE_PLAY_KEY;

	private readonly string ROULETTE_STOP_KEY;

	[Header("Default")]
	[SerializeField]
	private Text MainNameText;

	[SerializeField]
	private Text DescriptionText;

	[SerializeField]
	private Button GuideInfoBtn;

	[Header("Currency")]
	[SerializeField]
	private Image CurrencyIconImage;

	[SerializeField]
	private Text HasCurrencyText;

	[SerializeField]
	private Text NeedCurrencyText;

	[SerializeField]
	private Text DiscountNeedCurrencyText;

	[SerializeField]
	private GameObject DiscountObj;

	[Header("Betting")]
	[SerializeField]
	private Text BettingMultiplyText;

	[SerializeField]
	private Button BettingMultiplyBtn;

	[SerializeField]
	private GameObject BettingToast;

	[SerializeField]
	private Text BettingToastText;

	private Vector3 OriginToastTrans;

	[Header("Reward")]
	[SerializeField]
	private Button RewardInfoButton;

	[SerializeField]
	private Image RewardIconImage;

	[SerializeField]
	private Text RewardValueText;

	[SerializeField]
	private List<DoTweenScriptComponent> RewardDoTween;

	[Header("Level")]
	[SerializeField]
	private Button MachineLevelUpBtn;

	[SerializeField]
	private List<Image> MachineLevelImages;

	[SerializeField]
	private Slider slider_rouletteCount;

	[SerializeField]
	private Text text_rouletteCount;

	[SerializeField]
	private Transform area_levelStartIcon;

	[Header("SlotMachine")]
	[SerializeField]
	private Animator SlotMachineAnimator;

	[SerializeField]
	private ButtonLongPress PlaySlotMachineLongPressBtn;

	[SerializeField]
	private Text PlaySlotMachineText;

	[SerializeField]
	private Transform PlaySlotMachineTextTr;

	[SerializeField]
	private GameObject obj_reddot;

	[SerializeField]
	private List<GameObject> SlotParentsObjects;

	[Header("FreeChance")]
	[SerializeField]
	private GameObject FreeChanceSkillRoot;

	[SerializeField]
	private Text FreeChanceRateText;

	[SerializeField]
	private Button SkillBookBtn;

	[SerializeField]
	private GameObject FreeChanceFxObj;

	[Header("Rank")]
	[SerializeField]
	private GameObject rankRoot;

	[SerializeField]
	private Button btnRank;

	[SerializeField]
	private Text textRankEndTime;

	[SerializeField]
	private Text textRankEndTimeInHudTop;

	[SerializeField]
	private Text textMyRank;

	[SerializeField]
	private Image imgRank;

	[Header("CoinBuff")]
	[SerializeField]
	private Button btnSlotCoinBuff;

	[SerializeField]
	private Text textSlotCoinBuffEndTime;

	private PageArcadeSlotMachine OwnerPage;

	private int MultipleBettingValue;

	private List<int> MultipleValueList;

	private BigInteger LevelUpNeedCost_PerMile;

	private List<int> RouletteRewardItemList;

	private bool bOnAutoPlay;

	private bool bFreeChance;

	private bool isClickHide;

	private int RouletteResultRewardIdx;

	private Dictionary<int, BigInteger> RouletteResultRewards;

	private int DelayedRewardMapIndex;

	private int MatchCurrencyIdx;

	private List<List<Image>> SlotImageObjects;

	private List<int> SlotRewardList;

	private CompositeDisposable Disposables;

	public Action<int> OnPlayArcadeSlotMachine;

	public bool bPlayingSlotMachine { get; private set; }

	public Transform GetPlaySlotMachineTextTr { get { return null; } }

	private void Awake()
	{
	}

	private void UpdateMyRank(int rank)
	{
	}

	public bool Hide()
	{
		return false;
	}

	public void OnHideBefore()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(PageArcadeSlotMachine ownerPage)
	{
	}

	private void UpdateLevelInfo(SeasonalArcadeMachineData machineData, SeasonalRouletteInfoData rouletteInfoTable)
	{
	}

	private void SubscribeEvents()
	{
	}

	private void OnChangeHasCurrencyValue(int currencyIdx, BigInteger currencyValue)
	{
	}

	private void SetNameText(string nameKey)
	{
	}

	private void SetPlaySlotMachineText(string strKey)
	{
	}

	private void SetDescriptionText(string descKey)
	{
	}

	private void SetNeedCurrencyIcon(string iconKey)
	{
	}

	private void SetHasCurrencyValue(BigInteger hasValue, int needValue)
	{
	}

	private void SetNeedCurrencyValue(int originValue)
	{
	}

	private void SetMultipleBettingText(int bettingMultiple)
	{
	}

	private void SetRewardInfo(string iconKey, BigInteger rewardValue_PerMile)
	{
	}

	private void SetArcadeMachineLevelStar(int level)
	{
	}

	private void RedrawMachineLevelUpBtn()
	{
	}

	private void ShowRewardTween()
	{
	}

	private void HideRewardTween()
	{
	}

	private void OnClickSlotCoinBuff()
	{
	}

	private void OnClickGuideInfoBtn()
	{
	}

	private void OnClickedChangeMultiply()
	{
	}

	private void OnClickedRewardInfoBtn()
	{
	}

	private void OnClickedLevelUpBtn()
	{
	}

	private void OnClickedPlaySlotMachineButton()
	{
	}

	private void OnLongPressedPlaySlotMachineButton()
	{
	}

	private bool PlayArcadeRoulette()
	{
		return false;
	}

	private void ResetPlaySlotMachineLongPressState()
	{
	}

	private void SetInteractionSlotMachineBtn(bool isActive)
	{
	}

	private void SetSlotImages(int rewardCurrencyIdx)
	{
	}

	private void SetSlotImageBlur(int slotIndex, bool isBlur)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForAnimation_003Ed__103))]
	private IEnumerator WaitForAnimation(Animator anim, string stateName)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003COnAnimationComplete_003Ed__104))]
	private IEnumerator OnAnimationComplete()
	{
		yield break;
	}

	private void ShowRewardGoodsEffect(Dictionary<int, BigInteger> rewards)
	{
	}

	private void ShowRewardGoodsEffect_Delay(Dictionary<int, BigInteger> rewards)
	{
	}

	private void SetDiscountNeedCurrency()
	{
	}

	private void OnClickCoinRank()
	{
	}

	private void AddCatstaEventMissionValue(int slotMatchCount, int rewardTableOrder)
	{
	}

	private void CheckFreeChanceSkill()
	{
	}

	private void OnClickedSkillBookBtn()
	{
	}
}
