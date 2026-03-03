using System.Collections.Generic;

public class TpResponseQueue
{
	private readonly Queue<SendResponse> responseQueue;

	private readonly object queueLock;

	public void Cycle()
	{
	}

	public int GetCount()
	{
		return 0;
	}

	public void ScheduleResponse(SendResponse newResponse)
	{
	}

	public void Clear()
	{
	}
}
