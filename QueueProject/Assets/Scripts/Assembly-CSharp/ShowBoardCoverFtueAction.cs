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
		// Show background overlay
		if (m_background != null)
			m_background.SetActive(true);

		// Hide all cell masks first, then reveal only the specified cells
		if (m_cellMasks != null)
		{
			for (int i = 0; i < m_cellMasks.Length; i++)
			{
				if (m_cellMasks[i] != null)
					m_cellMasks[i].gameObject.SetActive(true);
			}
		}

		// Make specified cells visible (disable their masks)
		if (m_cellsToShow != null && m_cellMasks != null)
		{
			for (int i = 0; i < m_cellsToShow.Length; i++)
			{
				// Use index from serialized cells array - mask index maps directly
				int idx = i;
				if (idx >= 0 && idx < m_cellMasks.Length && m_cellMasks[idx] != null)
					m_cellMasks[idx].gameObject.SetActive(false);
			}
		}

		Finished();
	}
}
