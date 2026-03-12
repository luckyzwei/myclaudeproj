using UnityEngine;

public class ShowHandOnCellFtueAction : BaseFtueAction
{
	[SerializeField]
	protected Vector2Int m_ftueCell;

	[SerializeField]
	private FtueHandController m_hand;

	private int m_cellIndex;

	public override void Play()
	{
		if (m_grid != null)
		{
			var cell = m_grid.GetCell(m_ftueCell.x, m_ftueCell.y);
			if (cell != null)
			{
				m_cellIndex = cell.CellIndex;
				if (m_hand != null)
					m_hand.Config(cell);
				m_grid.QueenMarked += OnCellChanged;
				m_grid.CrossMarked += OnCellChanged;
			}
		}
	}

	private void OnCellChanged(int index)
	{
		if (index == m_cellIndex)
		{
			Finished();
		}
	}

	protected override void Finished()
	{
		UnityEngine.Debug.Log($"[ShowHandOnCellFtueAction] Finished() on '{gameObject.name}' - m_hand={(m_hand != null ? m_hand.gameObject.name : "NULL")}");

		if (m_grid != null)
		{
			m_grid.QueenMarked -= OnCellChanged;
			m_grid.CrossMarked -= OnCellChanged;
		}
		if (m_hand != null)
			m_hand.Hide();
		base.Finished();
	}
}
