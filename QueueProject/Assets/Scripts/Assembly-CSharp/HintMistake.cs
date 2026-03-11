using UnityEngine;

public class HintMistake : BaseHint
{
	[SerializeField]
	private string m_textKey;

	public override bool CheckIfPossible(GridState gridState, HintsManager.HintResult result)
	{
		if (gridState == null || result == null) return false;

		// Find cells where the player placed an X but the solution says it should be a queen
		for (int x = 0; x < gridState.Size.x; x++)
		{
			for (int y = 0; y < gridState.Size.y; y++)
			{
				if (gridState.GetSolution(x, y) == QueensGrid.X && gridState.IsQueen(x, y))
				{
					int idx = gridState.Index(x, y);
					result.isQueen = true;
					result.hintTechniqueName = "Mistake";
					result.interactibleCells.Add(idx);
					result.highlightedCells.Add(idx);
					string text = GetLocalisedText(m_textKey);
					result.explanation = !string.IsNullOrEmpty(text) ? text : "This square should not contain an X. It must be a Queen";
					return true;
				}
			}
		}
		return false;
	}
}
