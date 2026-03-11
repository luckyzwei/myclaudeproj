using System.Collections.Generic;

public class QueenBoosterButton : BoosterButton
{
	private const string ANIM_ANIM_BOOSTERBUTTON_ALERT = "Anim-BoosterButton-Alert";

	public const string QUEEN_BOOSTER_CLIENT_ID = "queen_booster";

	public const int QUEEN_BOOSTER_UNNY_ID = 3074;

	protected override bool TryPerformAction()
	{
		if (QueensGameController.Instance == null) return false;
		var grid = QueensGameController.Instance.Grid;
		if (grid == null || grid.LevelData == null) return false;

		// Find a correct queen cell that hasn't been placed yet
		var levelData = grid.LevelData;
		for (int i = 0; i < levelData.queensGrid.Length; i++)
		{
			if (levelData.queensGrid[i] >= 1 && grid.GetPlayerSolution(i) != QueensGrid.QUEEN)
			{
				// Show hint popup instead of placing queen directly
				ShowQueenHint(i);
				return true;
			}
		}
		return false;
	}

	private void ShowQueenHint(int cellIndex)
	{
		var hintsManager = HintsManager.Instance;
		if (hintsManager == null) return;

		// Build a HintResult for this single queen cell
		var result = new HintsManager.HintResult();
		result.isQueen = true;
		result.hintTechniqueName = "QueenBooster";
		result.highlightedCells = new List<int> { cellIndex };
		result.interactibleCells = new List<int> { cellIndex };
		string text = Kwalee.GetLocalisedText("Hints.QueenBooster");
		result.explanation = !string.IsNullOrEmpty(text) ? text : "在这里放置皇后！";

		// Use HintProcessDoer to show the popup with highlight
		hintsManager.DoHintExternal(result);
	}

	public override void OnButtonPressed()
	{
		TryPerformAction();
	}

	public override void PlayAlertAnimation()
	{
	}
}
