using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GlobalLeaderboardWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScrollToPlayer_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GlobalLeaderboardWidget _003C_003E4__this;

		public float delay;

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
		public _003CScrollToPlayer_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CShowPlayerCell_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GlobalLeaderboardWidget _003C_003E4__this;

		private RectTransform _003Ccontent_003E5__2;

		private float _003CvisibleAreaHeight_003E5__3;

		private Vector2 _003CanchoredPosition_003E5__4;

		private RectTransform _003CplayerCellTransform_003E5__5;

		private int _003Ci_003E5__6;

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
		public _003CShowPlayerCell_003Ed__19(int _003C_003E1__state)
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
	private Transform m_cellContainer;

	[SerializeField]
	private ScrollRect m_scroll;

	[SerializeField]
	private bool m_doAutoScroll;

	[SerializeField]
	private float m_autoScrollDelay;

	[SerializeField]
	private bool m_showAroundPlayer;

	private bool m_started;

	private bool m_alwaysShowPlayer;

	private List<LeaderboardCell> m_cells;

	private int m_lastPlayerScoreSeen;

	private int m_firstRank;

	private int m_lastRank;

	private LeaderboardCell m_playerCell;

	private float m_currentVerticalNormalisedPosition;

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

	[IteratorStateMachine(typeof(_003CShowPlayerCell_003Ed__19))]
	private IEnumerator ShowPlayerCell()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScrollToPlayer_003Ed__20))]
	private IEnumerator ScrollToPlayer(float playerNormalizedPosition, float lerpTime, float delay)
	{
		return null;
	}
}
