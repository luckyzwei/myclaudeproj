using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAuction", false, false)]
public class PageAuction : UIBase
{
	[CompilerGenerated]
	private sealed class _003CEndTrial2xCoroutine_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CEndTrial2xCoroutine_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CStartGame_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageAuction _003C_003E4__this;

		private int _003CtotalRound_003E5__2;

		private int _003Ci_003E5__3;

		private int _003Cmyscore_003E5__4;

		private AuctionSystem.E_AuctionResult _003CgameResult_003E5__5;

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
		public _003CStartGame_003Ed__55(int _003C_003E1__state)
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
	private Button InfoBtn;

	[Header("Auction")]
	[SerializeField]
	private Text RoundText;

	[SerializeField]
	private Animator AuctionAni;

	[SerializeField]
	private Image AuctionRewardImg;

	[Header("OrganizeCoin")]
	[SerializeField]
	private GameObject CoinOrganizeRoot;

	[SerializeField]
	private Text RemainCoinText;

	[SerializeField]
	private Button AddCoinBtn;

	[SerializeField]
	private Button DelCoinBtn;

	[SerializeField]
	private Button MaxCoinBtn;

	[SerializeField]
	private Text CoinText;

	[SerializeField]
	private Button StartRoundBtn;

	[Header("EnemyInfo")]
	[SerializeField]
	private GameObject EnemyCoinBubbleRoot;

	[SerializeField]
	private Text EnemyCoinRange;

	[SerializeField]
	private Button EnemyCoinSpyBtn;

	[SerializeField]
	private Text EnemyCoinSpyPrice;

	[SerializeField]
	private GameObject EnemyCoinRoot;

	[SerializeField]
	private Text EnemyCoinText;

	[Header("Me")]
	[SerializeField]
	private Transform MyCharRoot;

	[SerializeField]
	private List<Transform> MyWinLose;

	[SerializeField]
	private Transform MySignUI;

	[SerializeField]
	private Text MyCoinText;

	[SerializeField]
	private Text MyWinText;

	[Header("Npc")]
	[SerializeField]
	private Transform NpcCharRoot;

	[SerializeField]
	private List<Transform> NpcWinLose;

	[SerializeField]
	private Transform NpcSignUI;

	[SerializeField]
	private Text NpcCoinText;

	[SerializeField]
	private Text NpcWinText;

	[SerializeField]
	private Text MyName;

	[SerializeField]
	private Text NpcName;

	[Header("ManagerInfo")]
	[SerializeField]
	private GameObject ManagerRoot;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private Text MaxCoinText;

	[SerializeField]
	private Button ManagerInfoBtn;

	[Header("HUD")]
	[SerializeField]
	private Text StaminaText;

	[SerializeField]
	private Text StaminaRemainTime;

	[SerializeField]
	private GameObject StaminaTimeRoot;

	[SerializeField]
	private Button StanimaShopBtn;

	[SerializeField]
	private Text GemText;

	[SerializeField]
	private Button GemShopBtn;

	private CompositeDisposable disposables;

	private int CurRound;

	private Animator MyAni;

	private Animator NpcAni;

	private Transform MySignTrans;

	private Transform NpcSignTrans;

	private Coroutine AuctionCoroutin;

	private string AuctionRewardResName;

	private int MaxCoin;

	private int UseSpy;

	private bool AuctionStart;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickManagerInfo()
	{
	}

	private void CheckResult()
	{
	}

	[IteratorStateMachine(typeof(_003CStartGame_003Ed__55))]
	private IEnumerator StartGame()
	{
		yield break;
	}

	private void SetManager()
	{
	}

	private void UpdateOrganizeCoin()
	{
	}

	private void EndGame(PopupAuctionResultWin.E_GameEndType endType)
	{
	}

	[IteratorStateMachine(typeof(_003CEndTrial2xCoroutine_003Ed__59))]
	private IEnumerator EndTrial2xCoroutine()
	{
		yield break;
	}

	private void LoadMyChar()
	{
	}

	private void LoadNpcChar()
	{
	}

	private void SetRound()
	{
	}

	private void ResetWinLoseProgress()
	{
	}

	private void OnClickAddCoin()
	{
	}

	private void OnClickDelCoin()
	{
	}

	private void OnClickMaxCoin()
	{
	}

	private void onClickStartRound()
	{
	}

	private void OnClickShowEnemyCoin()
	{
	}

	private void OnClickStaminaShop()
	{
	}

	private void OnClickGemShop()
	{
	}

	public override void Hide()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
