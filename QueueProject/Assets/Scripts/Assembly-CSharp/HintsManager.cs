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
			isQueen = false;
			hintTechniqueName = null;
			explanation = null;
			highlightedCells?.Clear();
			interactibleCells?.Clear();
			cellConnectionList = null;
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

	public GridState CurrentGridState => m_currentGridState;

	public BaseHint ActiveHintTechnique => m_activeHintTechnique;

	protected override void Init()
	{
		m_hintResult = new HintResult();
		m_hintResult.highlightedCells = new List<int>();
		m_hintResult.interactibleCells = new List<int>();
	}

	private void Start()
	{
		GameplayEvents.GridIntroDone += OnGridBuilt;
	}

	private void OnGridBuilt()
	{
		LoadLevel();
	}

	public bool TryShowHint(bool doubleQueen = false)
	{
		if (m_currentGridState == null) LoadLevel();
		if (m_currentGridState == null) return false;

		m_hintResult.Clear();
		if (GetHintData(m_currentGridState, doubleQueen, out var result))
		{
			DoHint(result);
			return true;
		}
		return false;
	}

	public bool GetHintData(GridState gridState, bool doubleQueen, out HintResult hintResult)
	{
		hintResult = null;
		if (gridState == null) return false;

		var hints = GetAllHints(doubleQueen);
		if (hints == null) return false;

		var result = new HintResult();
		result.highlightedCells = new List<int>();
		result.interactibleCells = new List<int>();

		for (int i = 0; i < hints.Count; i++)
		{
			if (hints[i] == null || !hints[i].IsEnabled) continue;
			result.Clear();
			result.highlightedCells = new List<int>();
			result.interactibleCells = new List<int>();
			if (hints[i].CheckIfPossible(gridState, result))
			{
				m_activeHintTechnique = hints[i];
				hintResult = result;
				return true;
			}
		}
		return false;
	}

	private void DoHint(HintResult hintResult)
	{
		if (hintResult == null) return;
		if (m_hintProcessDoer != null)
			m_hintProcessDoer.DoHint(hintResult, null);
	}

	public void AutoDoHint(Action finishCallback = null)
	{
		if (m_activeHintTechnique != null)
			m_activeHintTechnique.AutoDoAction(finishCallback);
		else
			finishCallback?.Invoke();
	}

	public void DisableCell(QueensGridCell cell)
	{
		if (cell != null)
			cell.SetColliderEnabled(false);
	}

	public void DisableAllCells()
	{
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null) return;
		var cells = grid.GetAllCells();
		if (cells == null) return;
		for (int i = 0; i < cells.Count; i++)
			cells[i].SetColliderEnabled(false);
	}

	public void DisableAllCellsExcept(List<QueensGridCell> excludeCells)
	{
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null) return;
		var cells = grid.GetAllCells();
		if (cells == null) return;
		for (int i = 0; i < cells.Count; i++)
		{
			bool exclude = excludeCells != null && excludeCells.Contains(cells[i]);
			cells[i].SetColliderEnabled(exclude);
		}
	}

	public void EnableCells(List<QueensGridCell> cells)
	{
		if (cells == null) return;
		for (int i = 0; i < cells.Count; i++)
		{
			if (cells[i] != null)
				cells[i].SetColliderEnabled(true);
		}
	}

	public void EnableAllCells()
	{
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null) return;
		var cells = grid.GetAllCells();
		if (cells == null) return;
		for (int i = 0; i < cells.Count; i++)
			cells[i].SetColliderEnabled(true);
	}

	public void EnableAllCellsExcept(List<QueensGridCell> excludeCells)
	{
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null) return;
		var cells = grid.GetAllCells();
		if (cells == null) return;
		for (int i = 0; i < cells.Count; i++)
		{
			bool exclude = excludeCells != null && excludeCells.Contains(cells[i]);
			cells[i].SetColliderEnabled(!exclude);
		}
	}

	public bool IsDefaultColorSelected()
	{
		// Check if current board colors are default
		string colors = CosmeticsManager.BoardColorsClientID;
		return string.IsNullOrEmpty(colors) || colors == "BoardColors_A";
	}

	private void LoadLevel()
	{
		var grid = QueensGameController.Instance?.Grid;
		if (grid == null || grid.LevelData == null) return;
		m_currentGridState = new GridState();
		m_currentGridState.LoadLevel(grid);
	}

	private GridState GetGridState()
	{
		if (m_currentGridState == null) LoadLevel();
		return m_currentGridState;
	}

	public List<BaseHint> GetAllHints(bool doubleQueen = false)
	{
		bool isExpert = GameManager.Instance != null &&
			GameManager.Instance.CurrentGameMode == GameManager.GameMode.EXPERT_MODE;

		if (isExpert && m_expertHints != null && m_expertHints.Count > 0)
			return m_expertHints;
		return m_hints;
	}
}
