using UnityEngine;

public class StopHighlightQueensFtueAction : BaseFtueAction
{
	[SerializeField]
	private Vector2Int[] m_cells;

	public override void Play()
	{
		if (m_grid != null)
			m_grid.ClearFtueTargets();
		Finished();
	}
}
