using UnityEngine;

public class BringInGameUIFtueAction : BaseFtueAction
{
	[SerializeField]
	private float m_delay;

	public override void Play()
	{
		Invoke(nameof(BringInUIWithDelay), m_delay);
	}

	private void BringInUIWithDelay()
	{
		Finished();
	}
}
