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
	}

	private void OnCellChanged(int index)
	{
	}

	protected override void Finished()
	{
	}
}
