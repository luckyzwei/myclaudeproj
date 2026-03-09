using System;

public class DummyQueueableEntity : IQueueableEntity
{
	private int m_priority;

	private int m_locactionMask;

	private Action<Action> m_process;

	public DummyQueueableEntity(int priority, int locactionMask, Action<Action> process)
	{
	}

	public void StartProcess(Action finishCallback)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}
}
