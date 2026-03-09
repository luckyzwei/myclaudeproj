using System.Collections.Generic;
using UnityEngine;

public class HintRowColumnCheck : BaseHint
{
	[SerializeField]
	private string m_textKey;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool AddUnmarkedCellInRow(GridState gridState, int row, int queenCell, List<int> cellsList, ManyToManyCellConnection cellConnection)
	{
		return false;
	}

	private bool AddUnmarkedCellInColumn(GridState gridState, int column, int queenCell, List<int> cellsList, ManyToManyCellConnection cellConnection)
	{
		return false;
	}
}
