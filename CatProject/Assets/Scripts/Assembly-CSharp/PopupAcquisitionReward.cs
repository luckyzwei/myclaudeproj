using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
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
	}

	public void Init(int clearStageIdx)
	{
	}

	private void SetAutoPlay()
	{
	}

	private void SetRewardText(Config.CurrencyID currencyId, BigInteger beforeReward, BigInteger afterReward)
	{
	}

	private void SetRewardItems(AcquisitionInfoData acqInfoTable)
	{
	}

	[IteratorStateMachine(typeof(_003CSetRewardItemsCoroutine_003Ed__29))]
	private IEnumerator SetRewardItemsCoroutine()
	{
		return null;
	}

	private void OnConfirmButtonClick()
	{
	}

	private void OnNextStageButtonClick()
	{
	}

	private void PlayNextStage()
	{
	}

	private void GetReward(int multiple)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckAndShowAutoPlayPopup_003Ed__34))]
	private IEnumerator CheckAndShowAutoPlayPopup()
	{
		return null;
	}

	private void OnClickAutoPlayBtn()
	{
	}

	public override void OnHideBefore()
	{
	}
}
