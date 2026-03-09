using Balancy.Models;
using UnityEngine;

public class QueensControlSchemeA : QueensControlSchemeBase
{
	public override ControlSchemes GetScheme()
	{
		return ControlSchemes.Scheme_A;
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

		if (currentValue == QueensGrid.NONE)
		{
			if (m_markingXEnabled)
				m_grid.MarkXCell(idx);
			else
				m_grid.MarkQueenCell(idx);
		}
		else if (currentValue == QueensGrid.X)
		{
			m_grid.ClearCell(idx);
			if (!m_markingXEnabled)
				m_grid.MarkQueenCell(idx);
		}
		else if (currentValue == QueensGrid.QUEEN)
		{
			// Can't undo queens in scheme A
		}
	}

	public override void KillInput()
	{
		// Nothing to clean up
	}
}
