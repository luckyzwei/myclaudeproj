using UnityEngine;

public class AddXFtueAction : BaseFtueAction
{
	[SerializeField]
	private int m_crossesNeeded;

	[SerializeField]
	private Vector2Int[] m_cells;

	[SerializeField]
	private bool m_clearFtueCellsAtEnd;

	[SerializeField]
	private FtueHandController m_hand;

	private int m_crossCount;

	private int m_cellIndex;

	public override void Play()
	{
		m_crossCount = 0;

		if (m_grid != null)
		{
			m_grid.SetFtueMode();
			m_grid.ClearFtueTargets();

			if (m_cells != null)
			{
				for (int i = 0; i < m_cells.Length; i++)
					m_grid.AddFtueTarget(m_cells[i].x, m_cells[i].y);
			}

			m_grid.CrossMarked += OnCrossMarked;
			m_grid.CrossRemoved += OnCrossRemoved;
		}

		if (m_hand != null && m_cells != null && m_cells.Length > 0)
		{
			var cell = m_grid != null ? m_grid.GetCell(m_cells[0].x, m_cells[0].y) : null;
			if (cell != null)
				m_hand.Config(cell);
		}
	}

	protected override void Finished()
	{
		if (m_grid != null)
		{
			m_grid.CrossMarked -= OnCrossMarked;
			m_grid.CrossRemoved -= OnCrossRemoved;

			if (m_clearFtueCellsAtEnd)
				m_grid.ClearFtueTargets();
		}
		if (m_hand != null)
			m_hand.Hide();
		base.Finished();
	}

	private void OnCrossMarked(int obj)
	{
		m_crossCount++;
		if (m_crossCount >= m_crossesNeeded)
		{
			Finished();
		}
	}

	private void OnCrossRemoved(int obj)
	{
		m_crossCount--;
		if (m_crossCount < 0) m_crossCount = 0;
	}
}
