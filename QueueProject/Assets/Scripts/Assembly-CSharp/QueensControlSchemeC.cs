using Balancy.Models;
using UnityEngine;

public class QueensControlSchemeC : QueensControlSchemeBase
{
	[SerializeField]
	private float m_moveAmountAllowed;

	private QueensGridCell m_startingCell;

	private QueensGridCell m_currentCell;

	private bool m_isBrushX;

	private float m_lastClickTime;

	private bool m_isDragging;

	private float m_holdTime;

	private bool m_stillOnStartingCell;

	private bool m_isShowingTimer;

	private Vector3 m_firstTouchPos;

	private float m_distanceAllowedSqr;

	private bool m_movedTooMuch;

	private bool m_swipeEventSent;

	protected override void Start()
	{
		base.Start();
		m_distanceAllowedSqr = m_moveAmountAllowed * m_moveAmountAllowed;
	}

	public override ControlSchemes GetScheme()
	{
		return ControlSchemes.Scheme_C;
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
				m_holdTime = 0f;
				m_isDragging = false;
				m_stillOnStartingCell = true;
				m_movedTooMuch = false;
				m_swipeEventSent = false;
				m_firstTouchPos = Input.mousePosition;
			}
		}
		else if (Input.GetMouseButton(0) && m_startingCell != null)
		{
			m_holdTime += Time.deltaTime;
			float dist = (Input.mousePosition - m_firstTouchPos).sqrMagnitude;
			if (dist > m_distanceAllowedSqr)
				m_movedTooMuch = true;

			var cell = GetCell();
			if (cell != null && cell != m_currentCell)
			{
				m_currentCell = cell;
				m_stillOnStartingCell = false;
				m_isDragging = true;
				// Drag marks X
				if (IsFreeCell(cell))
					m_grid.MarkXCell(cell.CellIndex);
			}

			// Long press to place queen
			if (m_stillOnStartingCell && !m_movedTooMuch && m_holdTime > 0.5f && !m_isShowingTimer)
			{
				ShowTimer(m_startingCell);
			}
		}
		else if (Input.GetMouseButtonUp(0) && m_startingCell != null)
		{
			DisableTimer();
			if (!m_isDragging && !m_movedTooMuch)
			{
				CellClicked(m_startingCell, true);
			}
			m_startingCell = null;
			m_currentCell = null;
			m_isDragging = false;
		}
	}

	private bool IsFreeCell(QueensGridCell cell)
	{
		if (cell == null || m_grid == null) return false;
		return m_grid.GetPlayerSolution(cell.CellIndex) == QueensGrid.NONE;
	}

	private void ShowTimer(QueensGridCell currentCell)
	{
		m_isShowingTimer = true;
	}

	private void DisableTimer()
	{
		m_isShowingTimer = false;
	}

	private void CellClicked(QueensGridCell cell, bool isClick)
	{
		if (m_grid == null || cell == null) return;
		SelectedCell(cell.CellIndex);
	}

	private void SelectedCell(int cellIndex)
	{
		if (m_grid == null) return;
		int currentValue = m_grid.GetPlayerSolution(cellIndex);

		if (currentValue == QueensGrid.NONE)
		{
			if (m_markingXEnabled)
				m_grid.MarkXCell(cellIndex);
			else
				m_grid.MarkQueenCell(cellIndex);
		}
		else if (currentValue == QueensGrid.X)
		{
			m_grid.ClearCell(cellIndex);
		}
	}

	public bool IsHolding()
	{
		return m_startingCell != null && m_holdTime > 0.3f && m_stillOnStartingCell;
	}

	public override void KillInput()
	{
		m_startingCell = null;
		m_currentCell = null;
		m_isDragging = false;
		DisableTimer();
	}
}
