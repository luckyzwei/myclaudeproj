using UnityEngine;

public class SetLoseLifeEnabledFtueAction : BaseFtueAction
{
	[SerializeField]
	private bool m_loseLifeEnabled;

	public override void Play()
	{
		if (m_grid != null)
			m_grid.EnableLosingLife(m_loseLifeEnabled);
		Finished();
	}
}
