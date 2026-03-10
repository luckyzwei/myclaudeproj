using Balancy.Models;
using UnityEngine;

public class QueensControlSchemeA : QueensControlSchemeBase
{
	private const float DOUBLE_CLICK_TIME = 0.4f;

	private float m_lastClickTime;
	private int m_lastClickCellIndex = -1;

	// Drag state
	private QueensGridCell m_startingCell;
	private QueensGridCell m_currentCell;
	private bool m_isDragging;
	private bool m_dragIsMarking; // true = mark X, false = clear X

	public override ControlSchemes GetScheme()
	{
		return ControlSchemes.Scheme_A;
	}

	protected override void Start()
	{
		base.Start();
		m_markingXEnabled = true;
	}

	private void Update()
	{
		if (m_grid == null)
		{
			m_grid = FindObjectOfType<QueensGrid>();
			if (m_grid == null) return;
		}

		if (!IsActive()) return;

		if (Input.GetMouseButtonDown(0))
		{
			var cell = GetCell();
			if (cell != null)
			{
				m_startingCell = cell;
				m_currentCell = cell;
				m_isDragging = false;

				int idx = cell.CellIndex;
				int val = m_grid.GetPlayerSolution(idx);
				float now = Time.time;

				// Double-click detection: place queen
				bool isDoubleClick = (idx == m_lastClickCellIndex) &&
					(now - m_lastClickTime < DOUBLE_CLICK_TIME);
				m_lastClickTime = now;
				m_lastClickCellIndex = idx;

				if (isDoubleClick)
				{
					// Undo the X we just placed on first click, then place queen
					if (val == QueensGrid.X)
						m_grid.ClearCell(idx);
					m_grid.MarkQueenCell(idx);
					m_lastClickCellIndex = -1;
					m_startingCell = null;
					return;
				}

				// Single press: immediately mark/clear X
				m_dragIsMarking = (val == QueensGrid.NONE);
				ApplyDragToCell(cell);
			}
		}
		else if (Input.GetMouseButton(0) && m_startingCell != null)
		{
			var cell = GetCell();
			if (cell != null && cell != m_currentCell)
			{
				m_isDragging = true;
				m_currentCell = cell;
				ApplyDragToCell(cell);
			}
		}
		else if (Input.GetMouseButtonUp(0) && m_startingCell != null)
		{
			m_startingCell = null;
			m_currentCell = null;
			m_isDragging = false;
		}
	}

	private void ApplyDragToCell(QueensGridCell cell)
	{
		if (m_grid == null || cell == null) return;
		int idx = cell.CellIndex;
		int val = m_grid.GetPlayerSolution(idx);

		if (m_dragIsMarking)
		{
			if (val == QueensGrid.NONE)
				m_grid.MarkXCell(idx);
		}
		else
		{
			if (val == QueensGrid.X)
				m_grid.ClearCell(idx);
		}
	}

	public override void KillInput()
	{
		m_lastClickCellIndex = -1;
		m_startingCell = null;
		m_currentCell = null;
		m_isDragging = false;
	}
}
