using UnityEngine;

public class TimedFtueAction : BaseFtueAction
{
	[SerializeField]
	private float m_time;

	public override void Play()
	{
		Invoke(nameof(TimerFinished), m_time);
	}

	private void TimerFinished()
	{
		Finished();
	}
}
