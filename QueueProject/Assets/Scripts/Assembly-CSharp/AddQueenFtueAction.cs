using UnityEngine;

public class AddQueenFtueAction : BaseFtueAction
{
	[SerializeField]
	private int m_queensNeeded;

	[SerializeField]
	protected Vector2Int[] m_ftueCells;

	[SerializeField]
	private bool m_clearFtueCellsAtEnd;

	[SerializeField]
	protected PlayableDirectorHelper m_wrongPLayable;

	[SerializeField]
	protected FtueHandController m_hand;

	[SerializeField]
	protected bool m_showHandAtStart;

	[SerializeField]
	protected bool m_removeHilightOnCross;

	private int m_queensCount;

	public override void Play()
	{
	}

	private void ConfigureFTUEHand()
	{
	}

	private void CrossMarked(int cellIndex)
	{
	}

	private void OnLifeLost(int cellIndex)
	{
	}

	protected override void Finished()
	{
	}

	private void QueenMarked(int cellIndex)
	{
	}
}
