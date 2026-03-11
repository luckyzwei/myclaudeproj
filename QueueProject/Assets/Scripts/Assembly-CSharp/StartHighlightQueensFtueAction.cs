using UnityEngine;

public class StartHighlightQueensFtueAction : BaseFtueAction
{
	[SerializeField]
	private Vector2Int[] m_cells;

	public override void Play()
	{
		if (m_grid != null && m_cells != null)
		{
			for (int i = 0; i < m_cells.Length; i++)
				m_grid.AddFtueTarget(m_cells[i].x, m_cells[i].y);
		}
		Finished();
	}
}
