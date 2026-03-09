using Balancy.Models;
using UnityEngine;

public class QueensControlSchemeA : QueensControlSchemeBase
{
	private const float DOUBLE_CLICK_TIME = 0.4f;

	private float m_lastClickTime;
	private int m_lastClickCellIndex = -1;

	public override ControlSchemes GetScheme()
	{
		return ControlSchemes.Scheme_A;
	}

	protected override void Start()
	{
		base.Start();
		// Single click = X mark by default
		m_markingXEnabled = true;
	}

	private void Update()
	{
		if (!IsActive()) return;
		if (m_grid == null) return;

		if (Input.GetMouseButtonDown(0))
		{
			var cell = GetCell();
			if (cell != null)
				CellClicked(cell);
		}
	}

	private void CellClicked(QueensGridCell cell)
	{
		if (m_grid == null) return;
		int idx = cell.CellIndex;
		int currentValue = m_grid.GetPlayerSolution(idx);
		float now = Time.time;

		// Double-click detection: place queen
		bool isDoubleClick = (idx == m_lastClickCellIndex) && (now - m_lastClickTime < DOUBLE_CLICK_TIME);
		m_lastClickTime = now;
		m_lastClickCellIndex = idx;

		if (isDoubleClick)
		{
			// Double click on empty or X cell -> place queen
			if (currentValue == QueensGrid.X)
				m_grid.ClearCell(idx);
			if (currentValue != QueensGrid.QUEEN)
				m_grid.MarkQueenCell(idx);
			// Reset to prevent triple-click
			m_lastClickCellIndex = -1;
			return;
		}

		// Single click logic
		if (currentValue == QueensGrid.NONE)
		{
			m_grid.MarkXCell(idx);
		}
		else if (currentValue == QueensGrid.X)
		{
			m_grid.ClearCell(idx);
		}
		else if (currentValue == QueensGrid.QUEEN)
		{
			// Can't undo queens in scheme A
		}
	}

	public override void KillInput()
	{
		m_lastClickCellIndex = -1;
	}
}
