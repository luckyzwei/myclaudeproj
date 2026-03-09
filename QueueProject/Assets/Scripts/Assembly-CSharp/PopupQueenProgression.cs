using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupQueenProgression : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CScrollToCurrentNode_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupQueenProgression _003C_003E4__this;

		public int slotIndex;

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
		public _003CScrollToCurrentNode_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CShowProgress_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupQueenProgression _003C_003E4__this;

		public int prevGems;

		public int currentGems;

		public float delay;

		public float delayEnd;

		private PrizeLadderRewardData[] _003CprizeLadderRewards_003E5__2;

		private int _003CstartingSlot_003E5__3;

		private int _003CendingSlot_003E5__4;

		private int _003CstartExtraSlot_003E5__5;

		private bool _003CstartFromZero_003E5__6;

		private float _003Cduration_003E5__7;

		private float _003Ctime_003E5__8;

		private int _003CcurrentSlot_003E5__9;

		private List<int> _003CcompletedSlots_003E5__10;

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
		public _003CShowProgress_003Ed__25(int _003C_003E1__state)
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

	private const string PREFAB_NAME_ACTIVE = "Prefabs/Popups/PopUp-QueenEventProgression-ActiveEvent";

	private const string PREFAB_NAME_NOT_ACTIVE = "Prefabs/Popups/PopUp-QueenEventProgression-NotActiveEvent";

	private const string PREFAB_NAME_EVENT_ENDED = "Prefabs/Popups/PopUp-QueenEventProgression-EventEnded";

	[SerializeField]
	private LadderCell m_ladderCellPrefab;

	[SerializeField]
	private int m_maxRewards;

	[SerializeField]
	private bool m_showProgress;

	[SerializeField]
	private GameObject m_closeButton;

	[SerializeField]
	private Button m_backgroundButton;

	[SerializeField]
	private GameObject m_timer;

	[SerializeField]
	private DailyChallengeSagaMapWidget m_sagaMapWidget;

	[SerializeField]
	private RewardWidget m_grandPrize;

	[SerializeField]
	private GameObject m_grandPrizeClaimed;

	private GameEvent m_queenEvent;

	private List<LadderCell> m_cells;

	private PrizeLadderRewardData[] m_prizeLadderRewards;

	private static string m_source;

	private bool m_autoClose;

	private bool m_showCompletedPopup;

	private bool m_grandPrizeCollected;

	public static PopupQueenProgression Show(string source, Action onClose = null, bool autoClose = false)
	{
		return null;
	}

	private void SetAutoClose(bool autoClose)
	{
	}

	private void Start()
	{
	}

	private void Init()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToCurrentNode_003Ed__23))]
	private IEnumerator ScrollToCurrentNode(int slotIndex)
	{
		return null;
	}

	private void AutoClose()
	{
	}

	[IteratorStateMachine(typeof(_003CShowProgress_003Ed__25))]
	private IEnumerator ShowProgress(int prevGems, int currentGems, float delay, float delayEnd)
	{
		return null;
	}

	private void ShowProgressOnGrandPrize(float progress)
	{
	}

	private void CollectGrandPrize()
	{
	}

	protected override void OnDestroy()
	{
	}

	private float GetProgressDuration(int slotsCount)
	{
		return 0f;
	}

	private void RewardFlowFinished()
	{
	}

	private float GetProgress(int index, float gems)
	{
		return 0f;
	}

	public void OnInfoButtonClick()
	{
	}

	public void ClosePopupWithInterstitial()
	{
	}
}
