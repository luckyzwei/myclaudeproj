public class ClearAllBoosterButton : BoosterButton
{
	protected override bool TryPerformAction()
	{
		if (QueensGameController.Instance == null) return false;
		var grid = QueensGameController.Instance.Grid;
		if (grid == null) return false;

		// Clear all X marks from the board
		bool cleared = false;
		for (int i = 0; i < grid.LevelData.sizeX * grid.LevelData.sizeY; i++)
		{
			if (grid.GetPlayerSolution(i) == QueensGrid.X)
			{
				grid.ClearCellSilently(i);
				cleared = true;
			}
		}
		return cleared;
	}

	public override void OnButtonPressed()
	{
		TryPerformAction();
	}

	protected override void ConfigureVisuals()
	{
	}

	public override void PlayAlertAnimation()
	{
	}
}
