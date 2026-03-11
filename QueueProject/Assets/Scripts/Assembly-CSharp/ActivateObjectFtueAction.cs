using UnityEngine;

public class ActivateObjectFtueAction : BaseFtueAction
{
	[SerializeField]
	private GameObject m_target;

	[SerializeField]
	private bool m_active;

	public override void Play()
	{
		if (m_target != null)
			m_target.SetActive(m_active);
		Finished();
	}
}
