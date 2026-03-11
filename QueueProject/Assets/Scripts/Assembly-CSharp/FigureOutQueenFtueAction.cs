using UnityEngine;

public class FigureOutQueenFtueAction : BaseFtueAction
{
	[SerializeField]
	private int m_queensNeeded;

	[SerializeField]
	private Vector2Int[] m_ftueCells;

	[SerializeField]
	private bool m_clearFtueCellsAtEnd;

	[SerializeField]
	private PlayableDirectorHelper m_wrongPLayable;

	private int m_queensCount;

	public override void Play()
	{
		m_queensCount = 0;

		if (m_grid != null)
		{
			m_grid.SetFtueMode();
			m_grid.ClearFtueTargets();

			if (m_ftueCells != null)
			{
				for (int i = 0; i < m_ftueCells.Length; i++)
					m_grid.AddFtueTarget(m_ftueCells[i].x, m_ftueCells[i].y);
			}

			m_grid.QueenMarked += QueenMarked;
			m_grid.LifeLost += OnLifeLost;
		}
	}

	private void OnLifeLost(int obj)
	{
		if (m_wrongPLayable != null)
			m_wrongPLayable.Play();
	}

	protected override void Finished()
	{
		if (m_grid != null)
		{
			m_grid.QueenMarked -= QueenMarked;
			m_grid.LifeLost -= OnLifeLost;

			if (m_clearFtueCellsAtEnd)
				m_grid.ClearFtueTargets();
		}
		base.Finished();
	}

	private void QueenMarked(int obj)
	{
		m_queensCount++;
		if (m_queensCount >= m_queensNeeded)
		{
			Finished();
		}
	}
}
