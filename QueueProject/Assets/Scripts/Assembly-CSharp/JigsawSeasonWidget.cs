using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using Balancy.Models.JigsawPuzzleEvent;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class JigsawSeasonWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public JigsawSeasonWidget _003C_003E4__this;

		public Action callback;

		internal void _003CClaimRewardCoroutine_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CClaimRewardCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JigsawSeasonWidget _003C_003E4__this;

		public Action callback;

		private _003C_003Ec__DisplayClass58_0 _003C_003E8__1;

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
		public _003CClaimRewardCoroutine_003Ed__58(int _003C_003E1__state)
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

	private const string ANIM_ANIM_GRANDPRIZE_REWARDED = "Anim-GrandPrize-Rewarded";

	private const string ANIM_ANIM_GRANDPRIZE_CLAIMED = "Anim-GrandPrize-Claimed";

	private const float BANNER_OFFSET = 4f;

	[SerializeField]
	private JigsawPuzzleCell m_cellPrefab;

	[SerializeField]
	private Transform m_cellsParent;

	[SerializeField]
	private JigsawPuzzleCell[] m_presetCells;

	[SerializeField]
	private Text m_titleTMP;

	[SerializeField]
	private JigsawEventTimerWidget m_jigsawEventTimerWidget;

	[SerializeField]
	private GrandPrizeContainer m_grandPrizeContainer;

	[SerializeField]
	private Transform m_rewardLayout;

	[SerializeField]
	private Transform m_bannerRewardLayout;

	[SerializeField]
	private AnimatorHelper m_rewardAnimator;

	[SerializeField]
	private Vector3 m_finalScale;

	[SerializeField]
	private float m_timeToMove;

	[SerializeField]
	private float m_delayToGiveReward;

	private Transform m_targetRewardPosition;

	private int m_index;

	private List<string> m_clientIDsList;

	private List<JigsawPuzzleCell> m_cells;

	private bool m_checkedForReward;

	private JigsawPuzzles[] m_jigsawPuzzlesArray;

	private JigsawEvent m_jigsawEvent;

	private Action<RectTransform, bool> m_scrollToCallback;

	private int m_rowsCount;

	private List<string> m_cellClientIds;

	private PopUpHighlighter m_popUpHighlighter;

	private bool m_isInitialized;

	private ScrollRect m_scrollRect;

	private bool m_giveAllRewards;

	private Reward m_reward;

	private bool m_showingJigsawViewer;

	private bool m_triedToClaimGrandPrize;

	private const int ROW_CAPACITY = 2;

	public event DecoramaEvents.BasicDelegate OnLoadedCells
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void CoreEvents_PopupShown(PopUpBase popUpBase)
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}

	private void ConfigureFromCurrentEvent(Action<RectTransform, bool> scrollToCallback, Transform rewardPosition, ScrollRect scrollRect, string titleText, bool configureTimer, JigsawPuzzleGameEvent timerSource)
	{
	}

	public void Configure(JigsawPuzzleGameEvent jigsawEvent, Action<RectTransform, bool> scrollToCallback, Transform rewardPosition, ScrollRect scrollRect)
	{
	}

	public void Configure(string jigsawEventId, Action<RectTransform, bool> scrollToCallback, Transform rewardPosition, ScrollRect scrollRect, bool giveAllRewards = false)
	{
	}

	public string GetCellClientId(int index)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void CheckClaimGrandPrize()
	{
	}

	public void ReloadEvent()
	{
	}

	private void LoadingAtlasDone()
	{
	}

	private void StartSpawningCells()
	{
	}

	private void CellSpawned()
	{
	}

	private void SpawnCell(string clientId)
	{
	}

	private void CellAnimationDone()
	{
	}

	public void ScrollToRow(int row, bool immediately)
	{
	}

	private void RewardFlowFinished()
	{
	}

	private string GetClientID(int index)
	{
		return null;
	}

	private int GetPuzzlesCount()
	{
		return 0;
	}

	public List<JigsawPuzzleCell> GetCells()
	{
		return null;
	}

	public void ClaimReward(Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CClaimRewardCoroutine_003Ed__58))]
	private IEnumerator ClaimRewardCoroutine(Action callback)
	{
		return null;
	}

	private void RewardFlow(string clientId, Action callback)
	{
	}

	private void DisableRewards()
	{
	}

	private void ReturnRewardsToPosition()
	{
	}

	public void GotPoint()
	{
	}

	public bool IsGrandRewardComplete()
	{
		return false;
	}

	public void ShowInfoPopup()
	{
	}

	public int GetCellsCount()
	{
		return 0;
	}
}
