using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class JigsawPiecesRewardController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public JigsawPiecesRewardController _003C_003E4__this;

		public JigsawPuzzleCell cell;

		internal void _003CHighlightCellRoutine_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public JigsawPiecesRewardController _003C_003E4__this;

		public float animTime;
	}

	[CompilerGenerated]
	private sealed class _003CHighlightCellRoutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JigsawPiecesRewardController _003C_003E4__this;

		private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

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
		public _003CHighlightCellRoutine_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CMoveJigsawPiecesIntoPuzzles_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JigsawPiecesRewardController _003C_003E4__this;

		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

		private float _003Cdelay_003E5__2;

		private float _003Cacceleration_003E5__3;

		private float _003CfragmentMoveTime_003E5__4;

		private int _003CrowStart_003E5__5;

		private Vector3 _003CfragmentStartScale_003E5__6;

		private Vector3 _003CfragmentFinalScale_003E5__7;

		private Vector3 _003CstartPosition_003E5__8;

		private int _003Ci_003E5__9;

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
		public _003CMoveJigsawPiecesIntoPuzzles_003Ed__36(int _003C_003E1__state)
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

	private const int ROW_CAPACITY = 2;

	[SerializeField]
	private JigsawFragment m_fragmentPrefab;

	[SerializeField]
	private Transform m_fragmentsParent;

	[SerializeField]
	private GameObject m_inputLockOverlay;

	private List<JigsawFragment> m_fragments;

	private JigsawSeasonWidget m_seasonWidget;

	private List<JigsawPuzzleCell> m_cells;

	private List<int> m_indexes;

	private List<int> m_pieceCountInCells;

	private Action m_finishCallback;

	private int m_row;

	private bool m_hasFinishedEvent;

	private LockInputPopup m_lockInputPopup;

	private float m_pitch;

	private bool m_gaveAnyRewardYet;

	private bool m_stopScrollingForFinishRV;

	private int m_finishRVTargetRow;

	private bool m_hasScrolledToFinishRVTargetRow;

	private JigsawPuzzleCell m_cellToHighlight;

	private bool m_highlightingCell;

	private bool m_allowRv;

	private PopUpHighlighter m_popupHighlighter;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private int GetFirstPuzzleWidgetIndex()
	{
		return 0;
	}

	public void MovePiecesIntoPuzzles(JigsawSeasonWidget seasonWidgets, Action callback, bool allowRv = true)
	{
	}

	public void UnlockInput()
	{
	}

	private void FinishFlow()
	{
	}

	private void HandleWidget()
	{
	}

	private void CalculateStartingRow()
	{
	}

	private void MoveToNextRow()
	{
	}

	private bool ShouldStopScrollingForFinishRV()
	{
		return false;
	}

	private void HighlightCell()
	{
	}

	[IteratorStateMachine(typeof(_003CHighlightCellRoutine_003Ed__33))]
	private IEnumerator HighlightCellRoutine()
	{
		return null;
	}

	private bool CheckRowForPieces(int row)
	{
		return false;
	}

	private void HandleRow()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveJigsawPiecesIntoPuzzles_003Ed__36))]
	private IEnumerator MoveJigsawPiecesIntoPuzzles()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
