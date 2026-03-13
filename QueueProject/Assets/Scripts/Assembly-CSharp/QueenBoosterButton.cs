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

		// Find a correct queen cell that hasn't been placed yet and place it directly
		var levelData = grid.LevelData;
		for (int i = 0; i < levelData.queensGrid.Length; i++)
		{
			if (levelData.queensGrid[i] >= 1 && grid.GetPlayerSolution(i) != QueensGrid.QUEEN)
			{
				grid.MarkQueenCell(i, false, true);
				return true;
			}
		}
		return false;
	}

	public override void OnButtonPressed()
	{
		TryPerformAction();
	}

	public override void PlayAlertAnimation()
	{
	}
}
