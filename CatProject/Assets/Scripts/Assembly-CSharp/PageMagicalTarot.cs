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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public override void Hide()
	{
	}

	private void HidePopup()
	{
	}

	private void ResetGameProcess()
	{
	}

	private void InitGameProcess()
	{
	}

	private void SetNewCardList(bool isUpdate)
	{
	}

	private void LoadCradList()
	{
	}

	private void LoadGetCardList()
	{
	}

	private void SetCardList(bool isUpdate)
	{
	}

	private void UpdateUseCurrency()
	{
	}

	private void SetChangeButtonState()
	{
	}

	private void ShowCardReward(int idx, bool isOwn, Action cb)
	{
	}

	private void SetNextGame()
	{
	}

	private void SetGameDone(bool isSpecial)
	{
	}

	private int GetRandomIdx()
	{
		return 0;
	}

	private void SetDescText()
	{
	}

	private void OnClickPlay()
	{
	}

	private void OnClickChange()
	{
	}

	private void OnClickFreeChange()
	{
	}

	private void OnClickAdd()
	{
	}

	private void UseTarotTicket(bool isSpecialTicket, Action addCb)
	{
	}

	private void AddCatstaEventTarotPlay()
	{
	}

	private void OnClickCurrencyLeft()
	{
	}

	private void OnClickCurrencyRight()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickCard(ItemTarotCard card)
	{
	}

	public void EventShuffleDone()
	{
	}

	public void EventReversCard(int idx)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCards_003Ed__74))]
	private IEnumerator PlayCards(ItemTarotCard.AniClip clip, Action cb = null)
	{
		return null;
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void UploadUserData(Action SuccessCb)
	{
	}
}
