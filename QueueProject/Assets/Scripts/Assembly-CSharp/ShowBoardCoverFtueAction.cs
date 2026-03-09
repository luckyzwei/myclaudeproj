using UnityEngine;
using UnityEngine.UI;

public class ShowBoardCoverFtueAction : BaseFtueAction
{
	[SerializeField]
	private Vector2Int[] m_cellsToShow;

	[SerializeField]
	private Image[] m_cellMasks;

	[SerializeField]
	private GameObject m_background;

	public override void Play()
	{
	}
}
