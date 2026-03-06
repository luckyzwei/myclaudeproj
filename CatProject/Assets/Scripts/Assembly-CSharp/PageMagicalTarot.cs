using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageMagicalTarot", false, false)]
public class PageMagicalTarot : UIBase
{
	private enum Status
	{
		None = -1,
		Idle = 0,
		Wait = 1,
		WaitAdd = 2,
		Play = 3,
		Done = 4
	}

	private enum UseCurrency
	{
		None = 0,
		Gem = 1,
		BasicTicket = 2,
		SpecialTicket = 3
	}

	private enum AniClip
	{
		None = -1,
		Idle = 0,
		Shuffle = 1,
		Done = 2,
		Reward = 3,
		DirectShuffle = 4
	}

	[CompilerGenerated]
	private sealed class _003CPlayCards_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageMagicalTarot _003C_003E4__this;

		public ItemTarotCard.AniClip clip;

		public Action cb;

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
		public _003CPlayCards_003Ed__74(int _003C_003E1__state)
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

	[Header("PageMagicalTarot")]
	[SerializeField]
	private Text SpecialTicketCountText;

	[SerializeField]
	private Text BasicTicketCountText;

	[SerializeField]
	private Text GemCountText;

	[Space(10f)]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Text ResultText;

	[Header("Card")]
	[SerializeField]
	private Animator TarotAnimator;

	[SerializeField]
	private ItemTarotCard[] TarotCardList;

	private int normalCardCount;

	[Header("Buttons")]
	[SerializeField]
	private Image CurrencyIcon;

	[SerializeField]
	private Button CurrencyLeftArrowBtn;

	[SerializeField]
	private Button CurrencyRightArrowBtn;

	[SerializeField]
	private Button PlayBtn;

	[SerializeField]
	private Image PlayBtnIcon;

	[SerializeField]
	private Text PlayBtnCountText;

	[Space(5f)]
	[SerializeField]
	private Button ChangeBtn;

	[SerializeField]
	private Text ChangeBtnCountText;

	[SerializeField]
	private TimeComponent FreeChangeRemainTimeText;

	[SerializeField]
	private Button FreeChangeBtn;

	[Space(10f)]
	[SerializeField]
	private Image AddCurrencyIcon;

	[SerializeField]
	private Button AddLeftArrowBtn;

	[SerializeField]
	private Button AddRightArrowBtn;

	[SerializeField]
	private Button AddPlayBtn;

	[SerializeField]
	private Image AddBtnIcon;

	[SerializeField]
	private Text AddBtnCountText;

	[Space(5f)]
	[SerializeField]
	private GameObject SpecialParticleObj;

	private TarotRegionData curTarotRegionData;

	private List<int> curNormalIdxList;

	private int curSpecialIdx;

	private bool isOwnSpecial;

	private List<int> curGetCardList;

	private Status curStatus;

	private UseCurrency curUseCurrency;

	private int useGemCount;

	private int useBasicTicketCount;

	private int useSpecialTicketCount;

	[SerializeField]
	private int waitCardFrame;

	private WaitForSeconds waitCardTerm;

	private WaitForSeconds waitOneSec;

	private bool hasCompanyExp;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		curNormalIdxList = new List<int>();
		curGetCardList = new List<int>();
		curStatus = Status.None;
		curUseCurrency = UseCurrency.Gem;
		waitCardTerm = new WaitForSeconds(waitCardFrame / 60f);
		waitOneSec = new WaitForSeconds(1f);

		if (PlayBtn != null) PlayBtn.onClick.AddListener(OnClickPlay);
		if (ChangeBtn != null) ChangeBtn.onClick.AddListener(OnClickChange);
		if (FreeChangeBtn != null) FreeChangeBtn.onClick.AddListener(OnClickFreeChange);
		if (AddPlayBtn != null) AddPlayBtn.onClick.AddListener(OnClickAdd);
		if (CurrencyLeftArrowBtn != null) CurrencyLeftArrowBtn.onClick.AddListener(OnClickCurrencyLeft);
		if (CurrencyRightArrowBtn != null) CurrencyRightArrowBtn.onClick.AddListener(OnClickCurrencyRight);
		if (AddLeftArrowBtn != null) AddLeftArrowBtn.onClick.AddListener(OnClickCurrencyLeft);
		if (AddRightArrowBtn != null) AddRightArrowBtn.onClick.AddListener(OnClickCurrencyRight);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public override void OnShowBefore()
	{
		ResetGameProcess();
		InitGameProcess();
	}

	public override void OnHideAfter()
	{
		if (SpecialParticleObj != null) SpecialParticleObj.SetActive(false);
	}

	public override void Hide()
	{
		HidePopup();
	}

	private void HidePopup()
	{
		UploadUserData(() => { base.Hide(); });
	}

	private void ResetGameProcess()
	{
		curStatus = Status.Idle;
		isOwnSpecial = false;
		curSpecialIdx = -1;
		if (curNormalIdxList != null) curNormalIdxList.Clear();
		if (curGetCardList != null) curGetCardList.Clear();
		if (SpecialParticleObj != null) SpecialParticleObj.SetActive(false);
	}

	private void InitGameProcess()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		LoadCradList();
		LoadGetCardList();
		SetCardList(false);
		UpdateUseCurrency();
		SetChangeButtonState();
		SetDescText();
	}

	private void SetNewCardList(bool isUpdate)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (isUpdate)
			SetCardList(true);
	}

	private void LoadCradList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (curTarotRegionData != null && curTarotRegionData.TarotCardList != null)
		{
			curNormalIdxList = new List<int>(curTarotRegionData.TarotCardList);
		}
	}

	private void LoadGetCardList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (curTarotRegionData != null && curTarotRegionData.TarotCardGetList != null)
		{
			curGetCardList = new List<int>(curTarotRegionData.TarotCardGetList);
		}
	}

	private void SetCardList(bool isUpdate)
	{
		if (TarotCardList == null) return;
		normalCardCount = 0;

		for (int i = 0; i < TarotCardList.Length; i++)
		{
			if (TarotCardList[i] == null) continue;
			bool isGot = curGetCardList != null && curGetCardList.Contains(i);
			TarotCardList[i].gameObject.SetActive(true);
			// Set card visual state
			normalCardCount++;
		}
	}

	private void UpdateUseCurrency()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		switch (curUseCurrency)
		{
			case UseCurrency.Gem:
				if (GemCountText != null) GemCountText.text = "0";
				break;
			case UseCurrency.BasicTicket:
				if (BasicTicketCountText != null) BasicTicketCountText.text = "0";
				break;
			case UseCurrency.SpecialTicket:
				if (SpecialTicketCountText != null) SpecialTicketCountText.text = "0";
				break;
		}
	}

	private void SetChangeButtonState()
	{
		bool canChange = curStatus == Status.Idle;
		if (ChangeBtn != null) ChangeBtn.gameObject.SetActive(canChange);
		if (FreeChangeBtn != null) FreeChangeBtn.gameObject.SetActive(false);
	}

	private void ShowCardReward(int idx, bool isOwn, Action cb)
	{
		cb?.Invoke();
	}

	private void SetNextGame()
	{
		curStatus = Status.Idle;
		SetCardList(false);
		UpdateUseCurrency();
		SetChangeButtonState();
		SetDescText();
	}

	private void SetGameDone(bool isSpecial)
	{
		curStatus = Status.Done;
		if (isSpecial && SpecialParticleObj != null)
			SpecialParticleObj.SetActive(true);
		SetDescText();
	}

	private int GetRandomIdx()
	{
		if (curNormalIdxList == null || curNormalIdxList.Count == 0) return 0;
		return curNormalIdxList[UnityEngine.Random.Range(0, curNormalIdxList.Count)];
	}

	private void SetDescText()
	{
		if (DescText == null) return;
		switch (curStatus)
		{
			case Status.Idle:
				DescText.text = "";
				break;
			case Status.Done:
				DescText.text = "";
				break;
			default:
				DescText.text = "";
				break;
		}
	}

	private void OnClickPlay()
	{
		if (curStatus != Status.Idle) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		curStatus = Status.Play;
		if (TarotAnimator != null) TarotAnimator.Play("Shuffle");
	}

	private void OnClickChange()
	{
		if (curStatus != Status.Idle) return;
		SetNewCardList(true);
	}

	private void OnClickFreeChange()
	{
		if (curStatus != Status.Idle) return;
		SetNewCardList(true);
	}

	private void OnClickAdd()
	{
		if (curStatus != Status.WaitAdd) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void UseTarotTicket(bool isSpecialTicket, Action addCb)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		addCb?.Invoke();
	}

	private void AddCatstaEventTarotPlay()
	{
	}

	private void OnClickCurrencyLeft()
	{
		int cur = (int)curUseCurrency;
		cur--;
		if (cur < (int)UseCurrency.Gem) cur = (int)UseCurrency.SpecialTicket;
		curUseCurrency = (UseCurrency)cur;
		UpdateUseCurrency();
	}

	private void OnClickCurrencyRight()
	{
		int cur = (int)curUseCurrency;
		cur++;
		if (cur > (int)UseCurrency.SpecialTicket) cur = (int)UseCurrency.Gem;
		curUseCurrency = (UseCurrency)cur;
		UpdateUseCurrency();
	}

	private void OnClickInfo()
	{
	}

	private void OnClickCard(ItemTarotCard card)
	{
		if (curStatus != Status.Wait && curStatus != Status.WaitAdd) return;
		if (card == null) return;
		int idx = GetRandomIdx();
		ShowCardReward(idx, false, () =>
		{
			if (curGetCardList != null) curGetCardList.Add(idx);
			SetCardList(false);
			// Check if all cards collected
			if (curGetCardList != null && curGetCardList.Count >= normalCardCount)
				SetGameDone(false);
			else
				curStatus = Status.WaitAdd;
		});
	}

	public void EventShuffleDone()
	{
		curStatus = Status.Wait;
		SetDescText();
	}

	public void EventReversCard(int idx)
	{
		if (TarotCardList != null && idx >= 0 && idx < TarotCardList.Length && TarotCardList[idx] != null)
		{
			// Show card front face
		}
	}

	[IteratorStateMachine(typeof(_003CPlayCards_003Ed__74))]
	private IEnumerator PlayCards(ItemTarotCard.AniClip clip, Action cb = null)
	{
		if (TarotCardList == null) { cb?.Invoke(); yield break; }
		for (int i = 0; i < TarotCardList.Length; i++)
		{
			if (TarotCardList[i] == null) continue;
			// Play animation on each card with delay
			yield return waitCardTerm;
		}
		cb?.Invoke();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void UploadUserData(Action SuccessCb)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) { SuccessCb?.Invoke(); return; }
		SuccessCb?.Invoke();
	}
}
