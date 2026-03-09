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
	}

	public override ControlSchemes GetScheme()
	{
		return default(ControlSchemes);
	}

	private void Update()
	{
	}

	private QueensGridCell GetCell(Vector2Int coords)
	{
		return null;
	}

	private void CellClicked(QueensGridCell cell, bool isClick)
	{
	}

	private bool IsDoubleClick(QueensGridCell target)
	{
		return false;
	}

	public override void KillInput()
	{
	}

	private void SetCollidersBiggerInOpositeSides(QueensGridCell cell, Vector2Int direction)
	{
	}

	private void SetCellColliderBackToDefault()
	{
	}
}
