using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAuctionPass", false, false)]
public class PageAuctionPass : UIBase
{
	public enum E_PopupType
	{
		none = 0,
		hud = 1,
		popup = 2,
		reward = 3,
		banner_assign = 4,
		banner_result = 5
	}

	[CompilerGenerated]
	private sealed class _003CFirstShowPlayCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageAuctionPass _003C_003E4__this;

		private Vector2 _003CstartPosition_003E5__2;

		private Vector2 _003CtargetPosition_003E5__3;

		private float _003CelapsedTime_003E5__4;

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
		public _003CFirstShowPlayCoroutine_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CFocusCurrentItemCoroutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageAuctionPass _003C_003E4__this;

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
		public _003CFocusCurrentItemCoroutine_003Ed__32(int _003C_003E1__state)
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

	[Header("강제 연출 활성화")]
	[SerializeField]
	private bool ForceFirstShowPlay;

	[Header("연출 시작 딜레이 시간")]
	[SerializeField]
	private float FirstShowPlayDelayTime;

	[Header("스크롤 시작 딜레이 시간")]
	[SerializeField]
	private float FirstShowPlayStartDelayTime;

	[Header("스크롤 총 시간")]
	[SerializeField]
	private float FirstShowPlayTime;

	[Header("연출 스케일 시간")]
	[SerializeField]
	private float ScaleDurationTime;

	[Header("연출 스케일 되돌아가는 시간")]
	[SerializeField]
	private float ScaleReturnDurationTime;

	[Header("연출 스케일")]
	[SerializeField]
	private float Scale;

	[Header("PageAuctionPass")]
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private GameObject PurchaseObj;

	[SerializeField]
	private GameObject PurchaseDoneObj;

	[SerializeField]
	private Text CurPointText;

	[SerializeField]
	private Text RemainTimeText;

	[Header("PremiumBonusReward")]
	[SerializeField]
	private GameObject PremiumBonusRewardObj;

	[SerializeField]
	private Text PremiumBonusExchangeRateText;

	[SerializeField]
	private Text PremiumBonusValueText;

	[SerializeField]
	private GameObject PremiumBonusLockObj;

	[SerializeField]
	private Animator PremiumBonusLockAnimator;

	[Header("HUD")]
	[SerializeField]
	private Text StaminaText;

	[SerializeField]
	private Text StaminaRemainTime;

	[SerializeField]
	private GameObject StaminaTimeRoot;

	private bool FirstShowPlay;

	private CompositeDisposable disposables;

	private E_PopupType PopupType;

	protected override void Awake()
	{
	}

	public void InitPage(E_PopupType popupType)
	{
	}

	private void OnClickPurchase_RewardPopup()
	{
	}

	private void OnClickPurchase(bool isRewardPopup)
	{
	}

	[IteratorStateMachine(typeof(_003CFirstShowPlayCoroutine_003Ed__31))]
	private IEnumerator FirstShowPlayCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFocusCurrentItemCoroutine_003Ed__32))]
	private IEnumerator FocusCurrentItemCoroutine()
	{
		return null;
	}

	public Transform GetStaminaTransform()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
