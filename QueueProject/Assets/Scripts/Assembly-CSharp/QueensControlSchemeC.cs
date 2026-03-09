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
	}

	public override ControlSchemes GetScheme()
	{
		return default(ControlSchemes);
	}

	private void Update()
	{
	}

	private bool IsFreeCell(QueensGridCell cell)
	{
		return false;
	}

	private void ShowTimer(QueensGridCell currentCell)
	{
	}

	private void DisableTimer()
	{
	}

	private void CellClicked(QueensGridCell cell, bool isClick)
	{
	}

	private void SelectedCell(int cellIndex)
	{
	}

	public bool IsHolding()
	{
		return false;
	}

	public override void KillInput()
	{
	}
}
