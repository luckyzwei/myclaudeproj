using System.Collections.Generic;
using Balancy.Models;
using UnityEngine;

public class QueensControlSchemeB : QueensControlSchemeBase
{
	private QueensGridCell m_startingCell;

	private QueensGridCell m_currentCell;

	private bool m_isBrushX;

	private float m_lastClickTime;

	private bool m_isDragging;

	private Vector2 m_colliderDefaultSize;

	private Vector2 m_colliderBigSize;

	private float m_offset;

	private bool m_swipeEventSent;

	private List<QueensGridCell> m_predictedCells;

	private void Awake()
	{
		m_predictedCells = new List<QueensGridCell>();
		m_colliderDefaultSize = Vector2.one * 0.5f;
		m_colliderBigSize = Vector2.one * 0.8f;
		m_offset = 0.1f;
	}

	public override ControlSchemes GetScheme()
	{
		return ControlSchemes.Scheme_B;
	}

	private void Update()
	{
		if (!IsActive()) return;
		if (m_grid == null) return;

		if (Input.GetMouseButtonDown(0))
		{
			var cell = GetCell();
			if (cell != null)
			{
				m_startingCell = cell;
				m_currentCell = cell;
				m_isDragging = false;
				m_swipeEventSent = false;
				m_isBrushX = m_markingXEnabled || m_grid.GetPlayerSolution(cell.CellIndex) == QueensGrid.NONE;
			}
		}
		else if (Input.GetMouseButton(0) && m_startingCell != null)
		{
			var cell = GetCell();
			if (cell != null && cell != m_currentCell)
			{
				m_isDragging = true;
				m_currentCell = cell;
				// Brush X while dragging
				if (m_isBrushX && m_grid.GetPlayerSolution(cell.CellIndex) == QueensGrid.NONE)
				{
					m_grid.MarkXCell(cell.CellIndex);
				}
			}
		}
		else if (Input.GetMouseButtonUp(0) && m_startingCell != null)
		{
			if (!m_isDragging)
			{
				CellClicked(m_startingCell, true);
			}
			SetCellColliderBackToDefault();
			m_startingCell = null;
			m_currentCell = null;
			m_isDragging = false;
		}
	}

	private QueensGridCell GetCell(Vector2Int coords)
	{
		if (m_grid == null) return null;
		return m_grid.GetCell(coords);
	}

	private void CellClicked(QueensGridCell cell, bool isClick)
	{
		if (m_grid == null || cell == null) return;
		int idx = cell.CellIndex;
		int currentValue = m_grid.GetPlayerSolution(idx);

		if (IsDoubleClick(cell) && currentValue == QueensGrid.NONE)
		{
			// Double click places queen
			m_grid.MarkQueenCell(idx);
			return;
		}

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
		}
	}

	private bool IsDoubleClick(QueensGridCell target)
	{
		float now = Time.time;
		bool isDouble = (now - m_lastClickTime < 0.3f) && target == m_startingCell;
		m_lastClickTime = now;
		return isDouble;
	}

	public override void KillInput()
	{
		m_startingCell = null;
		m_currentCell = null;
		m_isDragging = false;
		SetCellColliderBackToDefault();
	}

	private void SetCollidersBiggerInOpositeSides(QueensGridCell cell, Vector2Int direction)
	{
		// Enlarge colliders in drag direction for easier swiping
	}

	private void SetCellColliderBackToDefault()
	{
		// Reset collider sizes
	}
}
