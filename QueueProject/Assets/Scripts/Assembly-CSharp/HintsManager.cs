using System;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;

public class HintsManager : MonoSingleton<HintsManager>
{
	public class HintResult
	{
		public bool isQueen;

		public string hintTechniqueName;

		public string explanation;

		public List<int> highlightedCells;

		public List<int> interactibleCells;

		public ManyToManyCellConnection cellConnectionList;

		public void Clear()
		{
		}
	}

	[SerializeField]
	private List<BaseHint> m_hints;

	[SerializeField]
	private List<BaseHint> m_expertHints;

	[SerializeField]
	private HintProcessDoer m_hintProcessDoer;

	private BaseHint m_activeHintTechnique;

	private GridState m_currentGridState;

	private HintResult m_hintResult;

	public GridState CurrentGridState => null;

	public BaseHint ActiveHintTechnique => null;

	protected override void Init()
	{
	}

	private void Start()
	{
	}

	private void OnGridBuilt()
	{
	}

	public bool TryShowHint(bool doubleQueen = false)
	{
		return false;
	}

	public bool GetHintData(GridState gridState, bool doubleQueen, out HintResult hintResult)
	{
		hintResult = null;
		return false;
	}

	private void DoHint(HintResult hintResult)
	{
	}

	public void AutoDoHint(Action finishCallback = null)
	{
	}

	public void DisableCell(QueensGridCell cell)
	{
	}

	public void DisableAllCells()
	{
	}

	public void DisableAllCellsExcept(List<QueensGridCell> excludeCells)
	{
	}

	public void EnableCells(List<QueensGridCell> cells)
	{
	}

	public void EnableAllCells()
	{
	}

	public void EnableAllCellsExcept(List<QueensGridCell> excludeCells)
	{
	}

	public bool IsDefaultColorSelected()
	{
		return false;
	}

	private void LoadLevel()
	{
	}

	private GridState GetGridState()
	{
		return null;
	}

	public List<BaseHint> GetAllHints(bool doubleQueen = false)
	{
		return null;
	}
}
