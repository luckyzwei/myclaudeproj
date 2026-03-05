using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAcquisitionReward", false, false)]
public class PopupAcquisitionReward : UIBase
{
	public enum ButtonType
	{
		Confirm = 0,
		NextStage = 1
	}

	[CompilerGenerated]
	private sealed class _003CCheckAndShowAutoPlayPopup_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupAcquisitionReward _003C_003E4__this;

		private float _003CwaitTime_003E5__2;

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
		public _003CCheckAndShowAutoPlayPopup_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CSetRewardItemsCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupAcquisitionReward _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CSetRewardItemsCoroutine_003Ed__29(int _003C_003E1__state)
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
	private Text ClearStageText;

	[SerializeField]
	private List<Image> RevenueIconList;

	[SerializeField]
	private List<Text> BeforeRevenueTextList;

	[SerializeField]
	private List<Text> AfterRevenueTextList;

	[SerializeField]
	private List<ItemArticle> RewardItemArticleList;

	[Header("보상연출 최초 시작 시간 팝업 애니메이션 때문에 딜레이 걸어 둠")]
	[SerializeField]
	private float RewardGetStartTime;

	[Header("보상연출 하나당 재생 딜레이 두번째부터 적용")]
	[SerializeField]
	private float RewardGetDelayTime;

	[SerializeField]
	protected string RewardGetSoundName;

	[SerializeField]
	private Button ConfirmButton;

	[SerializeField]
	private Button MultipleRewardButton;

	[SerializeField]
	private Text MultipleRewardCostText;

	[SerializeField]
	private Button NextStageButton;

	[SerializeField]
	private GameObject NextStageCountDownObj;

	[SerializeField]
	private Text NextStageCountDownText;

	[SerializeField]
	private GameObject AutoPlayObj;

	[SerializeField]
	private Button AutoPlayToggleBtn;

	[SerializeField]
	private GameObject AutoPlayToggleObj;

	[SerializeField]
	private GameObject AutoPlayGuideObj;

	public Action<ButtonType> OnClickedButton;

	private int ClearStageIdx;

	private List<RewardItemData> RewardItemDataList;

	private int MultipleNeedCash;

	private Coroutine CountDownCoroutine;

	protected override void Awake()
	{
		base.Awake();
		RewardItemDataList = new List<RewardItemData>();
		MultipleNeedCash = 0;

		if (ConfirmButton != null) ConfirmButton.onClick.AddListener(OnConfirmButtonClick);
		if (NextStageButton != null) NextStageButton.onClick.AddListener(OnNextStageButtonClick);
		if (MultipleRewardButton != null) MultipleRewardButton.onClick.AddListener(() => GetReward(2));
		if (AutoPlayToggleBtn != null) AutoPlayToggleBtn.onClick.AddListener(OnClickAutoPlayBtn);
	}

	public void Init(int clearStageIdx)
	{
		ClearStageIdx = clearStageIdx;
		if (ClearStageText != null) ClearStageText.text = clearStageIdx.ToString();

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;

		// Set reward info from battle system
		SetAutoPlay();

		// Start reward items display coroutine
		StartCoroutine(SetRewardItemsCoroutine());
	}

	private void SetAutoPlay()
	{
		if (AutoPlayObj != null) AutoPlayObj.SetActive(false);
		if (AutoPlayGuideObj != null) AutoPlayGuideObj.SetActive(false);
		// Check if auto play is available
		StartCoroutine(CheckAndShowAutoPlayPopup());
	}

	private void SetRewardText(Config.CurrencyID currencyId, BigInteger beforeReward, BigInteger afterReward)
	{
		int idx = (int)currencyId;
		if (RevenueIconList != null && idx >= 0 && idx < RevenueIconList.Count && RevenueIconList[idx] != null)
			RevenueIconList[idx].gameObject.SetActive(true);
		if (BeforeRevenueTextList != null && idx >= 0 && idx < BeforeRevenueTextList.Count && BeforeRevenueTextList[idx] != null)
			BeforeRevenueTextList[idx].text = ProjectUtility.GetThousandCommaText(beforeReward);
		if (AfterRevenueTextList != null && idx >= 0 && idx < AfterRevenueTextList.Count && AfterRevenueTextList[idx] != null)
			AfterRevenueTextList[idx].text = ProjectUtility.GetThousandCommaText(afterReward);
	}

	private void SetRewardItems(AcquisitionInfoData acqInfoTable)
	{
		if (RewardItemArticleList == null) return;
		// Hide all reward items first
		for (int i = 0; i < RewardItemArticleList.Count; i++)
		{
			if (RewardItemArticleList[i] != null)
				RewardItemArticleList[i].gameObject.SetActive(false);
		}
	}

	[IteratorStateMachine(typeof(_003CSetRewardItemsCoroutine_003Ed__29))]
	private IEnumerator SetRewardItemsCoroutine()
	{
		yield return new WaitForSeconds(RewardGetStartTime);
		if (RewardItemArticleList == null) yield break;
		for (int i = 0; i < RewardItemArticleList.Count; i++)
		{
			if (RewardItemArticleList[i] == null) continue;
			RewardItemArticleList[i].gameObject.SetActive(true);
			// Play reward get sound/animation
			if (i > 0) yield return new WaitForSeconds(RewardGetDelayTime);
		}
	}

	private void OnConfirmButtonClick()
	{
		GetReward(1);
		OnClickedButton?.Invoke(ButtonType.Confirm);
	}

	private void OnNextStageButtonClick()
	{
		PlayNextStage();
	}

	private void PlayNextStage()
	{
		GetReward(1);
		OnClickedButton?.Invoke(ButtonType.NextStage);
	}

	private void GetReward(int multiple)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		// Apply reward with multiplier
	}

	[IteratorStateMachine(typeof(_003CCheckAndShowAutoPlayPopup_003Ed__34))]
	private IEnumerator CheckAndShowAutoPlayPopup()
	{
		float waitTime = 3f;
		yield return new WaitForSeconds(waitTime);
		// Check if auto play toggle should show
		if (NextStageCountDownObj != null) NextStageCountDownObj.SetActive(false);
	}

	private void OnClickAutoPlayBtn()
	{
		if (AutoPlayToggleObj != null)
			AutoPlayToggleObj.SetActive(!AutoPlayToggleObj.activeSelf);
	}

	public override void OnHideBefore()
	{
		if (CountDownCoroutine != null) { StopCoroutine(CountDownCoroutine); CountDownCoroutine = null; }
	}
}
