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
		base.Awake();
		disposables = new CompositeDisposable();
		notiDisposables = new CompositeDisposable();

		if (InvestBtn != null) InvestBtn.onClick.AddListener(OnClickInvest);
		if (InvestRewardBtn != null) InvestRewardBtn.onClick.AddListener(OnClickInvestReward);
		if (btnLeft != null) btnLeft.onClick.AddListener(OnClickLeft);
		if (btnRight != null) btnRight.onClick.AddListener(OnClickRight);
	}

	public override void OnShowBefore()
	{
		investIdx = 0;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		investMaxCnt = 1;
		Set(investIdx);
		UpdateSuperStaff();
	}

	private void Set(int InvestIdx)
	{
		investIdx = InvestIdx;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		bool isInvested = false;
		if (BeforeInvestRoot != null) BeforeInvestRoot.SetActive(!isInvested);
		if (AfterInvestRoot != null) AfterInvestRoot.SetActive(isInvested);

		if (EnableInvestReddot != null) EnableInvestReddot.SetActive(false);
		if (EnableRewardReddot != null) EnableRewardReddot.SetActive(false);

		UpdateLRBtn();
	}

	public void UpdateSuperStaff()
	{
		if (superStaffBtn == null) return;
	}

	private void OnClickInvest()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Set(investIdx);
	}

	private void OnClickInvestReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Set(investIdx);
	}

	[IteratorStateMachine(typeof(_003CWaitEndFrameCallback_003Ed__41))]
	private IEnumerator WaitEndFrameCallback(Action callback)
	{
		yield return new WaitForEndOfFrame();
		callback?.Invoke();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
		if (notiDisposables != null) { notiDisposables.Dispose(); notiDisposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		if (notiDisposables != null) { notiDisposables.Dispose(); notiDisposables = new CompositeDisposable(); }
	}

	private void UpdateLRBtn()
	{
		if (btnLeft != null) btnLeft.gameObject.SetActive(investIdx > 0);
		if (btnRight != null) btnRight.gameObject.SetActive(investIdx < investMaxCnt - 1);
		if (leftReddot != null) leftReddot.SetActive(false);
		if (rightReddot != null) rightReddot.SetActive(false);
	}

	private void OnClickLeft()
	{
		if (investIdx > 0)
		{
			Set(investIdx - 1);
		}
	}

	private void OnClickRight()
	{
		if (investIdx < investMaxCnt - 1)
		{
			Set(investIdx + 1);
		}
	}
}
