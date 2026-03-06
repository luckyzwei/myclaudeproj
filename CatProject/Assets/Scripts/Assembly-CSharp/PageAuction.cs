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
		base.Awake();
		disposables = new CompositeDisposable();
		CurRound = 0;
		MaxCoin = 100;
		UseSpy = 0;
		AuctionStart = false;

		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (ManagerInfoBtn != null) ManagerInfoBtn.onClick.AddListener(OnClickManagerInfo);
		if (AddCoinBtn != null) AddCoinBtn.onClick.AddListener(OnClickAddCoin);
		if (DelCoinBtn != null) DelCoinBtn.onClick.AddListener(OnClickDelCoin);
		if (MaxCoinBtn != null) MaxCoinBtn.onClick.AddListener(OnClickMaxCoin);
		if (StartRoundBtn != null) StartRoundBtn.onClick.AddListener(onClickStartRound);
		if (EnemyCoinSpyBtn != null) EnemyCoinSpyBtn.onClick.AddListener(OnClickShowEnemyCoin);
		if (StanimaShopBtn != null) StanimaShopBtn.onClick.AddListener(OnClickStaminaShop);
		if (GemShopBtn != null) GemShopBtn.onClick.AddListener(OnClickGemShop);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		CurRound = 0;
		AuctionStart = false;
		UseSpy = 0;
		SetManager();
		SetRound();
		ResetWinLoseProgress();
		UpdateOrganizeCoin();
		LoadMyChar();
		LoadNpcChar();

		if (StaminaText != null) StaminaText.text = "0";
		if (GemText != null) GemText.text = "0";
		if (StaminaTimeRoot != null) StaminaTimeRoot.SetActive(false);
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickManagerInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void CheckResult()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.AuctionSystem == null) return;
	}

	[IteratorStateMachine(typeof(_003CStartGame_003Ed__55))]
	private IEnumerator StartGame()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.AuctionSystem == null) yield break;

		int totalRound = 3;
		for (int i = 0; i < totalRound; i++)
		{
			CurRound = i + 1;
			SetRound();
			// Wait for player coin input and round result
			yield return new WaitForSeconds(1f);
			// Show round result animation
			int myscore = 0;
			var gameResult = AuctionSystem.E_AuctionResult.Lose;
			// Check round result
		}
		CheckResult();
	}

	private void SetManager()
	{
		if (ManagerRoot == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (MaxCoinText != null) MaxCoinText.text = MaxCoin.ToString();
	}

	private void UpdateOrganizeCoin()
	{
		int curCoin = 0;
		if (CoinText != null)
		{
			int.TryParse(CoinText.text, out curCoin);
		}
		if (RemainCoinText != null) RemainCoinText.text = (MaxCoin - curCoin).ToString();
	}

	private void EndGame(PopupAuctionResultWin.E_GameEndType endType)
	{
		AuctionStart = false;
	}

	[IteratorStateMachine(typeof(_003CEndTrial2xCoroutine_003Ed__59))]
	private IEnumerator EndTrial2xCoroutine()
	{
		yield return new WaitForSeconds(0.5f);
	}

	private void LoadMyChar()
	{
		if (MyCharRoot == null) return;
	}

	private void LoadNpcChar()
	{
		if (NpcCharRoot == null) return;
	}

	private void SetRound()
	{
		if (RoundText != null) RoundText.text = CurRound.ToString();
		if (CoinOrganizeRoot != null) CoinOrganizeRoot.SetActive(true);
		if (EnemyCoinBubbleRoot != null) EnemyCoinBubbleRoot.SetActive(true);
		if (EnemyCoinRoot != null) EnemyCoinRoot.SetActive(false);
		if (CoinText != null) CoinText.text = "0";
		UpdateOrganizeCoin();
	}

	private void ResetWinLoseProgress()
	{
		if (MyWinLose != null)
		{
			for (int i = 0; i < MyWinLose.Count; i++)
			{
				if (MyWinLose[i] != null) MyWinLose[i].gameObject.SetActive(false);
			}
		}
		if (NpcWinLose != null)
		{
			for (int i = 0; i < NpcWinLose.Count; i++)
			{
				if (NpcWinLose[i] != null) NpcWinLose[i].gameObject.SetActive(false);
			}
		}
		if (MyWinText != null) MyWinText.text = "0";
		if (NpcWinText != null) NpcWinText.text = "0";
	}

	private void OnClickAddCoin()
	{
		if (CoinText == null) return;
		int cur = 0;
		int.TryParse(CoinText.text, out cur);
		if (cur < MaxCoin)
		{
			cur++;
			CoinText.text = cur.ToString();
			UpdateOrganizeCoin();
		}
	}

	private void OnClickDelCoin()
	{
		if (CoinText == null) return;
		int cur = 0;
		int.TryParse(CoinText.text, out cur);
		if (cur > 0)
		{
			cur--;
			CoinText.text = cur.ToString();
			UpdateOrganizeCoin();
		}
	}

	private void OnClickMaxCoin()
	{
		if (CoinText != null) CoinText.text = MaxCoin.ToString();
		UpdateOrganizeCoin();
	}

	private void onClickStartRound()
	{
		if (AuctionStart) return;
		AuctionStart = true;
		if (AuctionCoroutin != null) StopCoroutine(AuctionCoroutin);
		AuctionCoroutin = StartCoroutine(StartGame());
	}

	private void OnClickShowEnemyCoin()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UseSpy++;
		if (EnemyCoinRoot != null) EnemyCoinRoot.SetActive(true);
	}

	private void OnClickStaminaShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickGemShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public override void Hide()
	{
		if (AuctionCoroutin != null) { StopCoroutine(AuctionCoroutin); AuctionCoroutin = null; }
		base.Hide();
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		if (AuctionCoroutin != null) { StopCoroutine(AuctionCoroutin); AuctionCoroutin = null; }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
