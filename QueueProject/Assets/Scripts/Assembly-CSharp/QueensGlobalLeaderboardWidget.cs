using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Data;
using UnityEngine;
using UnityEngine.UI;

public class QueensGlobalLeaderboardWidget : MonoBehaviour
{
	public enum ScrollBehavior
	{
		SHOW_PLAYER_NO_SCROLL = 0,
		START_FROM_TOP_SCROLL_TO_PLAYER = 1,
		START_FROM_PLAYER_SCROLL_UP = 2
	}

	[CompilerGenerated]
	private sealed class _003CMovePlayerUp_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensGlobalLeaderboardWidget _003C_003E4__this;

		public int oldRank;

		public int newRank;

		private RectTransform _003CplayerCellTransform_003E5__2;

		private RectTransform _003Ccontent_003E5__3;

		private RectTransform _003CscrollTransform_003E5__4;

		private float _003CvisibleAreaHeight_003E5__5;

		private Vector2 _003CanchoredPosition_003E5__6;

		private float _003CplayerY_003E5__7;

		private float _003CtargetY_003E5__8;

		private int _003CsiblingIndex_003E5__9;

		private float _003CscrollDuration_003E5__10;

		private LeaderboardCellPlayerAdditions _003Cadditions_003E5__11;

		private float _003Ctime_003E5__12;

		private float _003CcontentStartY_003E5__13;

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
		public _003CMovePlayerUp_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CScrollFromTopToPlayer_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public QueensGlobalLeaderboardWidget _003C_003E4__this;

		public float lerpTime;

		public float playerNormalizedPosition;

		private float _003CelapsedTime_003E5__2;

		private float _003CstartPosition_003E5__3;

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
		public _003CScrollFromTopToPlayer_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CShowPlayerCell_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensGlobalLeaderboardWidget _003C_003E4__this;

		public float time;

		public Action onDone;

		private RectTransform _003Ccontent_003E5__2;

		private RectTransform _003CscrollTransform_003E5__3;

		private Vector2 _003CanchoredPosition_003E5__4;

		private RectTransform _003CplayerCellTransform_003E5__5;

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
		public _003CShowPlayerCell_003Ed__26(int _003C_003E1__state)
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

	private const float MIN_DISTANCE_FOR_SCROLLING = 0.05f;

	[SerializeField]
	private LeaderboardCell m_cellPrefab;

	[SerializeField]
	private LeaderboardCell m_playerCellPrefab;

	[SerializeField]
	private GameObject m_separator;

	[SerializeField]
	private Transform m_cellContainer;

	[SerializeField]
	private ScrollRect m_scroll;

	[SerializeField]
	private ScrollBehavior m_scrollBehavior;

	[SerializeField]
	private float m_scrollDelay;

	[SerializeField]
	private bool m_putPlaceholderInPlayerPlace;

	[SerializeField]
	private bool m_doBotScoring;

	[Header("Analytics")]
	[SerializeField]
	private string m_leaderboardLocation;

	private bool m_started;

	private List<LeaderboardCell> m_cells;

	private int m_lastPlayerScoreSeen;

	private int m_firstRank;

	private int m_lastRank;

	private LeaderboardCell m_playerCell;

	private LeaderboardCell m_playerTargetCell;

	private float m_currentVerticalNormalisedPosition;

	private UserPlayerProfileData KWPlayerProfile => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void CreateCells()
	{
	}

	private void TryScrollToPLayer()
	{
	}

	[IteratorStateMachine(typeof(_003CShowPlayerCell_003Ed__26))]
	private IEnumerator ShowPlayerCell(float time, Action onDone)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMovePlayerUp_003Ed__27))]
	private IEnumerator MovePlayerUp(int oldRank, int newRank, int oldScore, int newScore)
	{
		return null;
	}

	private void PlayCellScaleUpSfx()
	{
	}

	private void PlayCellMovementSfx(int movement)
	{
	}

	private void PlayCellScaleDownSfx()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollFromTopToPlayer_003Ed__31))]
	private IEnumerator ScrollFromTopToPlayer(float playerNormalizedPosition, float lerpTime, float delay)
	{
		return null;
	}
}
