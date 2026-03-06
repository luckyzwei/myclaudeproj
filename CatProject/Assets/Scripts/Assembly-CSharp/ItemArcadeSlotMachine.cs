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
		Disposables = new CompositeDisposable();
		MultipleBettingValue = 1;
		MultipleValueList = new List<int> { 1, 2, 5, 10 };
		RouletteResultRewards = new Dictionary<int, BigInteger>();
		SlotImageObjects = new List<List<Image>>();
		SlotRewardList = new List<int>();
		bPlayingSlotMachine = false;
		bOnAutoPlay = false;
		bFreeChance = false;

		if (GuideInfoBtn != null) GuideInfoBtn.onClick.AddListener(OnClickGuideInfoBtn);
		if (BettingMultiplyBtn != null) BettingMultiplyBtn.onClick.AddListener(OnClickedChangeMultiply);
		if (RewardInfoButton != null) RewardInfoButton.onClick.AddListener(OnClickedRewardInfoBtn);
		if (MachineLevelUpBtn != null) MachineLevelUpBtn.onClick.AddListener(OnClickedLevelUpBtn);
		if (PlaySlotMachineLongPressBtn != null)
		{
			PlaySlotMachineLongPressBtn.OnPressed = OnClickedPlaySlotMachineButton;
			PlaySlotMachineLongPressBtn.OnLongPressed = OnLongPressedPlaySlotMachineButton;
		}
		if (SkillBookBtn != null) SkillBookBtn.onClick.AddListener(OnClickedSkillBookBtn);
		if (btnRank != null) btnRank.onClick.AddListener(OnClickCoinRank);
		if (btnSlotCoinBuff != null) btnSlotCoinBuff.onClick.AddListener(OnClickSlotCoinBuff);

		if (BettingToast != null)
		{
			OriginToastTrans = BettingToast.transform.localPosition;
			BettingToast.SetActive(false);
		}
	}

	private void UpdateMyRank(int rank)
	{
		if (textMyRank != null)
			textMyRank.text = rank > 0 ? rank.ToString() : "-";
	}

	public bool Hide()
	{
		if (bPlayingSlotMachine) return false;
		isClickHide = true;
		return true;
	}

	public void OnHideBefore()
	{
		bOnAutoPlay = false;
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Init(PageArcadeSlotMachine ownerPage)
	{
		OwnerPage = ownerPage;
		isClickHide = false;
		bPlayingSlotMachine = false;
		bOnAutoPlay = false;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		SubscribeEvents();
		CheckFreeChanceSkill();
		SetDiscountNeedCurrency();
	}

	private void UpdateLevelInfo(SeasonalArcadeMachineData machineData, SeasonalRouletteInfoData rouletteInfoTable)
	{
		if (machineData == null) return;
		SetArcadeMachineLevelStar(machineData.Level);
		if (slider_rouletteCount != null)
		{
			slider_rouletteCount.value = machineData.RouletteCount;
		}
		if (text_rouletteCount != null)
			text_rouletteCount.text = machineData.RouletteCount.ToString();
		RedrawMachineLevelUpBtn();
	}

	private void SubscribeEvents()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	private void OnChangeHasCurrencyValue(int currencyIdx, BigInteger currencyValue)
	{
		if (currencyIdx != MatchCurrencyIdx) return;
		if (HasCurrencyText != null)
			HasCurrencyText.text = ProjectUtility.GetThousandCommaText(currencyValue);
		RedrawMachineLevelUpBtn();
	}

	private void SetNameText(string nameKey)
	{
		if (MainNameText != null) MainNameText.text = nameKey;
	}

	private void SetPlaySlotMachineText(string strKey)
	{
		if (PlaySlotMachineText != null) PlaySlotMachineText.text = strKey;
	}

	private void SetDescriptionText(string descKey)
	{
		if (DescriptionText != null) DescriptionText.text = descKey;
	}

	private void SetNeedCurrencyIcon(string iconKey)
	{
		// Update display
	}

	private void SetHasCurrencyValue(BigInteger hasValue, int needValue)
	{
		if (HasCurrencyText != null)
			HasCurrencyText.text = ProjectUtility.GetThousandCommaText(hasValue);
		bool isEnough = hasValue >= needValue;
		if (HasCurrencyText != null)
			HasCurrencyText.color = isEnough ? Color.white : Color.red;
	}

	private void SetNeedCurrencyValue(int originValue)
	{
		int finalValue = originValue * MultipleBettingValue;
		if (NeedCurrencyText != null)
			NeedCurrencyText.text = ProjectUtility.GetThousandCommaText(finalValue);
	}

	private void SetMultipleBettingText(int bettingMultiple)
	{
		if (BettingMultiplyText != null)
			BettingMultiplyText.text = "x" + bettingMultiple;
	}

	private void SetRewardInfo(string iconKey, BigInteger rewardValue_PerMile)
	{
		if (RewardValueText != null)
			RewardValueText.text = ProjectUtility.GetThousandCommaText(rewardValue_PerMile);
	}

	private void SetArcadeMachineLevelStar(int level)
	{
		if (MachineLevelImages == null) return;
		for (int i = 0; i < MachineLevelImages.Count; i++)
		{
			if (MachineLevelImages[i] != null)
				MachineLevelImages[i].gameObject.SetActive(i < level);
		}
	}

	private void RedrawMachineLevelUpBtn()
	{
		if (MachineLevelUpBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		bool canAfford = true; // Check if user has enough currency for level up
		MachineLevelUpBtn.interactable = canAfford;
	}

	private void ShowRewardTween()
	{
		if (RewardDoTween == null) return;
		for (int i = 0; i < RewardDoTween.Count; i++)
			if (RewardDoTween[i] != null) RewardDoTween[i].Play();
	}

	private void HideRewardTween()
	{
		if (RewardDoTween == null) return;
		for (int i = 0; i < RewardDoTween.Count; i++)
			if (RewardDoTween[i] != null) RewardDoTween[i].Pause();
	}

	private void OnClickSlotCoinBuff()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickGuideInfoBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickedChangeMultiply()
	{
		if (MultipleValueList == null || MultipleValueList.Count == 0) return;
		int curIdx = MultipleValueList.IndexOf(MultipleBettingValue);
		int nextIdx = (curIdx + 1) % MultipleValueList.Count;
		MultipleBettingValue = MultipleValueList[nextIdx];
		SetMultipleBettingText(MultipleBettingValue);

		if (BettingToast != null)
		{
			if (BettingToastText != null) BettingToastText.text = "x" + MultipleBettingValue;
			BettingToast.SetActive(false);
			BettingToast.SetActive(true);
		}
	}

	private void OnClickedRewardInfoBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickedLevelUpBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickedPlaySlotMachineButton()
	{
		if (bPlayingSlotMachine) return;
		bOnAutoPlay = false;
		PlayArcadeRoulette();
	}

	private void OnLongPressedPlaySlotMachineButton()
	{
		if (bPlayingSlotMachine) return;
		bOnAutoPlay = true;
		PlayArcadeRoulette();
	}

	private bool PlayArcadeRoulette()
	{
		if (bPlayingSlotMachine) return false;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;

		bPlayingSlotMachine = true;
		SetInteractionSlotMachineBtn(false);

		if (SlotMachineAnimator != null)
			SlotMachineAnimator.SetTrigger(ROULETTE_PLAY_KEY);

		OnPlayArcadeSlotMachine?.Invoke(MultipleBettingValue);

		StartCoroutine(OnAnimationComplete());
		return true;
	}

	private void ResetPlaySlotMachineLongPressState()
	{
		bOnAutoPlay = false;
	}

	private void SetInteractionSlotMachineBtn(bool isActive)
	{
		if (PlaySlotMachineLongPressBtn != null)
			PlaySlotMachineLongPressBtn.Interactable = isActive;
		if (obj_reddot != null) obj_reddot.SetActive(false);
	}

	private void SetSlotImages(int rewardCurrencyIdx)
	{
		if (SlotParentsObjects == null) return;
		SlotImageObjects.Clear();
		for (int i = 0; i < SlotParentsObjects.Count; i++)
		{
			if (SlotParentsObjects[i] != null)
			{
				var images = new List<Image>(SlotParentsObjects[i].GetComponentsInChildren<Image>());
				SlotImageObjects.Add(images);
			}
		}
	}

	private void SetSlotImageBlur(int slotIndex, bool isBlur)
	{
		if (SlotImageObjects == null || slotIndex < 0 || slotIndex >= SlotImageObjects.Count) return;
		var images = SlotImageObjects[slotIndex];
		if (images == null) return;
		for (int i = 0; i < images.Count; i++)
		{
			if (images[i] != null)
			{
				var c = images[i].color;
				c.a = isBlur ? 0.5f : 1f;
				images[i].color = c;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CWaitForAnimation_003Ed__103))]
	private IEnumerator WaitForAnimation(Animator anim, string stateName)
	{
		if (anim == null) yield break;
		yield return null;
		while (anim.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
			   anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
		{
			yield return null;
		}
	}

	[IteratorStateMachine(typeof(_003COnAnimationComplete_003Ed__104))]
	private IEnumerator OnAnimationComplete()
	{
		if (SlotMachineAnimator != null)
		{
			yield return StartCoroutine(WaitForAnimation(SlotMachineAnimator, ROULETTE_STOP_KEY));
		}
		else
		{
			yield return new WaitForSeconds(2f);
		}

		if (RouletteResultRewards != null && RouletteResultRewards.Count > 0)
		{
			ShowRewardTween();
			ShowRewardGoodsEffect(RouletteResultRewards);
		}

		bPlayingSlotMachine = false;
		SetInteractionSlotMachineBtn(true);

		if (bOnAutoPlay && !isClickHide)
		{
			PlayArcadeRoulette();
		}
	}

	private void ShowRewardGoodsEffect(Dictionary<int, BigInteger> rewards)
	{
		if (rewards == null) return;
		ShowRewardGoodsEffect_Delay(rewards);
	}

	private void ShowRewardGoodsEffect_Delay(Dictionary<int, BigInteger> rewards)
	{
		if (rewards == null || OwnerPage == null) return;
	}

	private void SetDiscountNeedCurrency()
	{
		if (DiscountObj != null) DiscountObj.SetActive(false);
		if (DiscountNeedCurrencyText != null) DiscountNeedCurrencyText.gameObject.SetActive(false);
	}

	private void OnClickCoinRank()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageSeasonalSlotRank>();
	}

	private void AddCatstaEventMissionValue(int slotMatchCount, int rewardTableOrder)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void CheckFreeChanceSkill()
	{
		bFreeChance = false;
		if (FreeChanceSkillRoot != null) FreeChanceSkillRoot.SetActive(false);
		if (FreeChanceFxObj != null) FreeChanceFxObj.SetActive(false);
	}

	private void OnClickedSkillBookBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSkills>();
	}
}
