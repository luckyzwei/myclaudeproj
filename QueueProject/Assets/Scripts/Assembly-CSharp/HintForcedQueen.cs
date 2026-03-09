using UnityEngine;

public class HintForcedQueen : BaseHint
{
	[SerializeField]
	private string m_textKey;

	private bool m_isColumn;

	private GridState m_gridState;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		return false;
	}

	private bool HasRowOneEmptyCell(int row, out Vector2Int coords)
	{
		coords = default(Vector2Int);
		return false;
	}

	private bool HasColumnOneEmptyCell(int column, out Vector2Int coords)
	{
		coords = default(Vector2Int);
		return false;
	}

	private void DoActionInternal(GridState gridState, int index, bool isColumn, Vector2Int cellCoords, HintsManager.HintResult result)
	{
	}
}
