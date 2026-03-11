using UnityEngine;

public class PlayDirectorFtueAction : BaseFtueAction
{
	[SerializeField]
	private PlayableDirectorHelper m_directorHelper;

	[SerializeField]
	private float m_startDelay;

	[SerializeField]
	private bool m_sendFinishInstantly;

	public override void Play()
	{
		UnityEngine.Debug.Log($"[PlayDirectorFtueAction] Play() on '{gameObject.name}' - helper={m_directorHelper != null}, delay={m_startDelay}, finishInstantly={m_sendFinishInstantly}");

		if (m_startDelay > 0f)
			Invoke(nameof(PlayDirector), m_startDelay);
		else
			PlayDirector();

		if (m_sendFinishInstantly)
			Finished();
	}

	private void PlayDirector()
	{
		UnityEngine.Debug.Log($"[PlayDirectorFtueAction] PlayDirector() on '{gameObject.name}' - helper={m_directorHelper != null}");
		if (m_directorHelper != null)
		{
			m_directorHelper.Play(m_sendFinishInstantly ? null : (System.Action)(() => Finished()));
		}
		else if (!m_sendFinishInstantly)
		{
			UnityEngine.Debug.LogWarning($"[PlayDirectorFtueAction] No helper on '{gameObject.name}', finishing immediately");
			Finished();
		}
	}

	private void Reset()
	{
		m_startDelay = 0f;
		m_sendFinishInstantly = false;
	}
}
