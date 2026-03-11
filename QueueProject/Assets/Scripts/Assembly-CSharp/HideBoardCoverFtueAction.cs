using UnityEngine;

public class HideBoardCoverFtueAction : BaseFtueAction
{
	[SerializeField]
	private GameObject[] m_cellMasks;

	[SerializeField]
	private GameObject m_background;

	public override void Play()
	{
		if (m_cellMasks != null)
		{
			for (int i = 0; i < m_cellMasks.Length; i++)
			{
				if (m_cellMasks[i] != null)
					m_cellMasks[i].SetActive(false);
			}
		}
		if (m_background != null)
			m_background.SetActive(false);
		Finished();
	}
}
