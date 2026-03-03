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
		public _003CPlayRewardAnimation_003Ed__30(int _003C_003E1__state)
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
	}

	public void Show(int costType, List<Config.RewardItemData> rewardData, int openCount = 1)
	{
	}

	public override void OnShowAfter()
	{
	}

	private void CheckGridSize(int cardSize, int rewardSize)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayRewardAnimation_003Ed__30))]
	private IEnumerator PlayRewardAnimation()
	{
		return null;
	}

	private void OnClickOpen()
	{
	}

	private void OnClickSkip()
	{
	}

	private void SetResult()
	{
	}
}
