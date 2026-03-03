using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupInvest", false, false)]
public class PopupInvest : UIBase
{
	[CompilerGenerated]
	private sealed class _003CWaitEndFrameCallback_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

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
		public _003CWaitEndFrameCallback_003Ed__41(int _003C_003E1__state)
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

	[Header("HUD")]
	[SerializeField]
	private Text MoneyText;

	[Header("Company")]
	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text CompnayName;

	[Header("InvestInfo")]
	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Text RemainTimeText2;

	[SerializeField]
	private Text InvestMoneyText;

	[SerializeField]
	private Text InvestMoney2Text;

	[SerializeField]
	private Text InvestRewardMoneyText;

	[SerializeField]
	private Button InvestBtn;

	[SerializeField]
	private Button InvestRewardBtn;

	[SerializeField]
	private GameObject BeforeInvestRoot;

	[SerializeField]
	private GameObject AfterInvestRoot;

	[SerializeField]
	private Text MultipleValueText;

	[SerializeField]
	private GameObject EnableInvestReddot;

	[SerializeField]
	private GameObject EnableRewardReddot;

	[SerializeField]
	private GameObject RewardTimeRoot;

	[SerializeField]
	private GameObject InRisingObj;

	[SerializeField]
	private GameObject RemainTimeRoot;

	[SerializeField]
	private SuperStaffStatBtn superStaffBtn;

	[SerializeField]
	private Button btnLeft;

	[SerializeField]
	private Button btnRight;

	[SerializeField]
	private GameObject rightReddot;

	[SerializeField]
	private GameObject leftReddot;

	[SerializeField]
	private List<Image> listInvestIcos;

	[SerializeField]
	private List<Button> GotoBtns;

	[Header("Graph")]
	[SerializeField]
	private List<Transform> GraphPoint;

	[SerializeField]
	private RectTransform CurPoint;

	[SerializeField]
	private Text CurRewardText;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[Header("IAP")]
	[SerializeField]
	private ItemPopupNoAdsBanner NoAdsBanner;

	private int investIdx;

	private int investMaxCnt;

	private CompositeDisposable disposables;

	private CompositeDisposable notiDisposables;

	private Coroutine coroutine;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void Set(int InvestIdx)
	{
	}

	public void UpdateSuperStaff()
	{
	}

	private void OnClickInvest()
	{
	}

	private void OnClickInvestReward()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitEndFrameCallback_003Ed__41))]
	private IEnumerator WaitEndFrameCallback(Action callback)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateLRBtn()
	{
	}

	private void OnClickLeft()
	{
	}

	private void OnClickRight()
	{
	}
}
