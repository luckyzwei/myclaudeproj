using UnityEngine;

public class StopDirectorFtueAction : BaseFtueAction
{
	[SerializeField]
	private PlayableDirectorHelper m_directorHelper;

	public override void Play()
	{
		if (m_directorHelper != null)
			m_directorHelper.Stop();
		Finished();
	}

	private void Reset()
	{
	}
}
