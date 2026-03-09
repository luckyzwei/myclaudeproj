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
	}

	private void OnLifeLost(int obj)
	{
	}

	protected override void Finished()
	{
	}

	private void QueenMarked(int obj)
	{
	}
}
