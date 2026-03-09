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
	}

	protected override void Finished()
	{
	}

	private void OnCrossMarked(int obj)
	{
	}

	private void OnCrossRemoved(int obj)
	{
	}
}
