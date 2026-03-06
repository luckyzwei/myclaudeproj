using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageGacha", false, false)]
public class PageGacha : UIBase
{
	public enum GachaState
	{
		Init = 0,
		Show = 1,
		WaitOpen = 2,
		Opening = 3,
		Result = 4,
		Hide = 5,
		NextAction = 6
	}

	[CompilerGenerated]
	private sealed class _003CPlayRewardAnimation_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageGacha _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CPlayRewardAnimation_003Ed__30(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.animReward == null || _003C_003E4__this.animReward.Count == 0)
						return false;
					_003Ci_003E5__2 = 0;
					goto case 2;
				case 1:
					_003C_003E1__state = -1;
					_003Ci_003E5__2++;
					goto case 2;
				case 2:
					if (_003Ci_003E5__2 < _003C_003E4__this.animReward.Count)
					{
						_003C_003E2__current = new WaitForSeconds(0.15f);
						_003C_003E1__state = 1;
						return true;
					}
					_003C_003E4__this.state = GachaState.Result;
					return false;
				default:
					return false;
			}
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

	[Header("PageGacha")]
	[SerializeField]
	private CardBoxComponent CardBoxObj;

	[SerializeField]
	private ItemManagerCard CurCardItem;

	[SerializeField]
	private ItemArticle CurItemArticle;

	[SerializeField]
	private Text CurItemArticleName;

	[Space(5f)]
	[SerializeField]
	private Image CurGradeFrame;

	[SerializeField]
	private Text CurGradeText;

	[SerializeField]
	private Text CurName;

	[Header("buttons")]
	[SerializeField]
	private Button SkipBtn;

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private Button OpenBtn;

	[Header("Reward")]
	[SerializeField]
	private ScrollRect GridScroll;

	[SerializeField]
	private GridLayoutGroup GridLayout;

	[SerializeField]
	private List<ItemManagerCard> GridCardList;

	[SerializeField]
	private GameObject GridCardPrefab;

	[SerializeField]
	private List<ItemArticle> GridRewardList;

	[SerializeField]
	private GameObject GridRewardPrefab;

	[Header("Animation")]
	public GachaState state;

	private List<Config.RewardItemData> reward;

	private List<Config.RewardItemData> animReward;

	private IEnumerator rewardRoutine;

	private List<int> newManagerIdx;

	private RectTransform scrollRect;

	private int scrollStartRow;

	private float gridColCount;

	private int NormalKeyRewardCount;

	private int PremiumKeyRewardCount;

	protected override void Awake()
	{
		base.Awake();
		if (GridCardList == null) GridCardList = new List<ItemManagerCard>();
		if (GridRewardList == null) GridRewardList = new List<ItemArticle>();
		newManagerIdx = new List<int>();

		if (SkipBtn != null) SkipBtn.onClick.AddListener(OnClickSkip);
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(() => Hide());
		if (OpenBtn != null) OpenBtn.onClick.AddListener(OnClickOpen);
	}

	public void Show(int costType, List<Config.RewardItemData> rewardData, int openCount = 1)
	{
		reward = rewardData;
		animReward = rewardData != null ? new List<Config.RewardItemData>(rewardData) : new List<Config.RewardItemData>();
		state = GachaState.Init;

		if (CardBoxObj != null) CardBoxObj.Set(costType);

		int cardSize = 0;
		int rewardSize = 0;
		if (rewardData != null)
		{
			for (int i = 0; i < rewardData.Count; i++)
			{
				if (rewardData[i].rewardType == (int)Config.RewardType.Manager)
					cardSize++;
				else
					rewardSize++;
			}
		}
		CheckGridSize(cardSize, rewardSize);

		base.Show();
	}

	public override void OnShowAfter()
	{
		state = GachaState.Show;
		if (SkipBtn != null) SkipBtn.gameObject.SetActive(true);
		if (ConfirmBtn != null) ConfirmBtn.gameObject.SetActive(false);
		if (OpenBtn != null) OpenBtn.gameObject.SetActive(true);
	}

	private void CheckGridSize(int cardSize, int rewardSize)
	{
		int totalCount = cardSize + rewardSize;
		if (totalCount <= 0) return;

		if (GridLayout != null)
		{
			gridColCount = totalCount <= 5 ? totalCount : 5;
			GridLayout.constraintCount = (int)gridColCount;
		}

		if (GridScroll != null)
		{
			scrollRect = GridScroll.GetComponent<RectTransform>();
		}
	}

	[IteratorStateMachine(typeof(_003CPlayRewardAnimation_003Ed__30))]
	private IEnumerator PlayRewardAnimation()
	{
		var routine = new _003CPlayRewardAnimation_003Ed__30(0);
		routine._003C_003E4__this = this;
		return routine;
	}

	private void OnClickOpen()
	{
		if (state != GachaState.Show && state != GachaState.WaitOpen) return;
		state = GachaState.Opening;

		if (OpenBtn != null) OpenBtn.gameObject.SetActive(false);

		rewardRoutine = PlayRewardAnimation();
		StartCoroutine(rewardRoutine);
	}

	private void OnClickSkip()
	{
		if (rewardRoutine != null)
		{
			StopCoroutine(rewardRoutine);
			rewardRoutine = null;
		}
		state = GachaState.Result;
		SetResult();
	}

	private void SetResult()
	{
		if (SkipBtn != null) SkipBtn.gameObject.SetActive(false);
		if (ConfirmBtn != null) ConfirmBtn.gameObject.SetActive(true);
		if (OpenBtn != null) OpenBtn.gameObject.SetActive(false);
	}
}
