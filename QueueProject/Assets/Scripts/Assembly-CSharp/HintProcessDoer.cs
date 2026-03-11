using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;

public class HintProcessDoer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoAutoActionCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public HintProcessDoer _003C_003E4__this;
		public bool setQueen;
		public List<QueensGridCell> cellsList;
		public Action finishCallback;
		private float _003Cdelay_003E5__2;
		private float _003Cmultiplier_003E5__3;
		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CDoAutoActionCoroutine_003Ed__10(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003Cdelay_003E5__2 = 0.15f;
					_003Cmultiplier_003E5__3 = 1f;
					_003Ci_003E5__4 = 0;
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					if (cellsList != null && _003Ci_003E5__4 < cellsList.Count)
					{
						var cell = cellsList[_003Ci_003E5__4];
						var grid = QueensGameController.Instance?.Grid;
						if (cell != null && grid != null)
						{
							if (setQueen)
								grid.MarkQueenCell(cell.CellIndex, false, true);
							else
								grid.MarkXCell(cell.CellIndex, true, true);
						}
						_003Ci_003E5__4++;
						_003C_003E2__current = new WaitForSeconds(_003Cdelay_003E5__2 * _003Cmultiplier_003E5__3);
						_003C_003E1__state = 1;
						return true;
					}
					finishCallback?.Invoke();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext() { return this.MoveNext(); }

		[DebuggerHidden]
		void IEnumerator.Reset() { }
	}

	private HintsManager.HintResult m_hintResult;

	private PopupHint m_popupHint;

	private Action m_callback;

	private List<QueensGridCell> m_interactableCells;

	private List<QueensGridCell> m_highlightedCells;

	private bool m_subscribedToEvents;

	public void DoHint(HintsManager.HintResult hintResult, Action callback)
	{
		// Clean up previous hint if any
		CleanupPreviousHint();

		m_hintResult = hintResult;
		m_callback = callback;

		if (hintResult == null) return;

		m_interactableCells = new List<QueensGridCell>();
		m_highlightedCells = new List<QueensGridCell>();

		GetCells(hintResult.interactibleCells, m_interactableCells);
		GetCells(hintResult.highlightedCells, m_highlightedCells);

		// Highlight cells with white background
		for (int i = 0; i < m_highlightedCells.Count; i++)
		{
			if (m_highlightedCells[i] != null)
				m_highlightedCells[i].Highlight(true);
		}

		// Show hint highlight animation on interactible cells
		for (int i = 0; i < m_interactableCells.Count; i++)
		{
			if (m_interactableCells[i] != null)
				m_interactableCells[i].ShowHintHighlight(true);
		}

		// Subscribe to grid events so we know when player acts on the hint
		SubscribeToGridEvents();

		// Show hint popup with explanation text
		if (!string.IsNullOrEmpty(hintResult.explanation))
		{
			m_popupHint = KWCore.UI.PopUpBase.ShowPopup<PopupHint>(PopupHint.PREFAB_NAME);
			if (m_popupHint != null)
				m_popupHint.Config(hintResult.explanation, m_interactableCells, m_highlightedCells);
		}
	}

	private void SubscribeToGridEvents()
	{
		UnsubscribeFromGridEvents();
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null) return;
		grid.CrossMarked += OnCrossMarked;
		grid.QueenMarked += OnQueenMarked;
		m_subscribedToEvents = true;
	}

	private void UnsubscribeFromGridEvents()
	{
		if (!m_subscribedToEvents) return;
		var grid = QueensGameController.Instance?.Grid;
		if (grid != null)
		{
			grid.CrossMarked -= OnCrossMarked;
			grid.QueenMarked -= OnQueenMarked;
		}
		m_subscribedToEvents = false;
	}

	private void OnCrossMarked(int cellIndex)
	{
		if (m_hintResult == null || m_interactableCells == null) return;

		for (int i = m_interactableCells.Count - 1; i >= 0; i--)
		{
			if (m_interactableCells[i] != null && m_interactableCells[i].CellIndex == cellIndex)
			{
				m_interactableCells[i].ShowHintHighlight(false);
				m_interactableCells.RemoveAt(i);
				break;
			}
		}

		if (m_interactableCells.Count == 0)
			HintCompleted();
	}

	private void OnQueenMarked(int cellIndex)
	{
		if (m_hintResult == null || m_interactableCells == null) return;

		for (int i = m_interactableCells.Count - 1; i >= 0; i--)
		{
			if (m_interactableCells[i] != null && m_interactableCells[i].CellIndex == cellIndex)
			{
				m_interactableCells[i].ShowHintHighlight(false);
				m_interactableCells.RemoveAt(i);
				break;
			}
		}

		if (m_interactableCells.Count == 0)
			HintCompleted();
	}

	private void CleanupPreviousHint()
	{
		UnsubscribeFromGridEvents();
		// Clear old highlights
		if (m_highlightedCells != null)
		{
			for (int i = 0; i < m_highlightedCells.Count; i++)
			{
				if (m_highlightedCells[i] != null)
					m_highlightedCells[i].Highlight(false);
			}
		}
		if (m_interactableCells != null)
		{
			for (int i = 0; i < m_interactableCells.Count; i++)
			{
				if (m_interactableCells[i] != null)
					m_interactableCells[i].ShowHintHighlight(false);
			}
		}
		// Close old popup if still alive
		if (m_popupHint != null)
		{
			Destroy(m_popupHint.gameObject);
			m_popupHint = null;
		}
	}

	private void HintCompleted()
	{
		UnsubscribeFromGridEvents();
		// Clear highlights
		if (m_highlightedCells != null)
		{
			for (int i = 0; i < m_highlightedCells.Count; i++)
			{
				if (m_highlightedCells[i] != null)
					m_highlightedCells[i].Highlight(false);
			}
		}
		// Clear hint highlight animations
		if (m_interactableCells != null)
		{
			for (int i = 0; i < m_interactableCells.Count; i++)
			{
				if (m_interactableCells[i] != null)
					m_interactableCells[i].ShowHintHighlight(false);
			}
		}
		// Close popup
		if (m_popupHint != null)
		{
			m_popupHint.gameObject.SetActive(false);
			Destroy(m_popupHint.gameObject);
			m_popupHint = null;
		}
		m_hintResult = null;
		m_callback?.Invoke();
	}

	private void OnDestroy()
	{
		UnsubscribeFromGridEvents();
	}

	private static void GetCells(List<int> cellIndexList, List<QueensGridCell> cellsList)
	{
		if (cellIndexList == null || cellsList == null) return;
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null) return;

		for (int i = 0; i < cellIndexList.Count; i++)
		{
			var cell = grid.GetCell(cellIndexList[i]);
			if (cell != null)
				cellsList.Add(cell);
		}
	}

	public void AutoDo(Action finishCallback)
	{
		// Unsubscribe so auto-do actions don't trigger OnCrossMarked/OnQueenMarked
		UnsubscribeFromGridEvents();

		if (m_hintResult == null || m_interactableCells == null)
		{
			finishCallback?.Invoke();
			return;
		}
		StartCoroutine(DoAutoActionCoroutine(m_interactableCells, m_hintResult.isQueen, () =>
		{
			HintCompleted();
			finishCallback?.Invoke();
		}));
	}

	[IteratorStateMachine(typeof(_003CDoAutoActionCoroutine_003Ed__10))]
	private IEnumerator DoAutoActionCoroutine(List<QueensGridCell> cellsList, bool setQueen, Action finishCallback)
	{
		var d = new _003CDoAutoActionCoroutine_003Ed__10(0);
		d._003C_003E4__this = this;
		d.cellsList = cellsList;
		d.setQueen = setQueen;
		d.finishCallback = finishCallback;
		return d;
	}
}
