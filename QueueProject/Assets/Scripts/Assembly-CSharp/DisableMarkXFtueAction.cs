using UnityEngine;

public class DisableMarkXFtueAction : BaseFtueAction
{
	[SerializeField]
	private bool m_markingXEnabled;

	public override void Play()
	{
		if (m_grid != null)
			m_grid.DisableInput();
		if (m_markingXEnabled && m_grid != null)
			m_grid.EnableInput();
		Finished();
	}
}
