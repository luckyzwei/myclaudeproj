using System;
using System.Collections.Generic;

public class ActionQueue
{
	private Queue<Action> Queue;

	public bool IsPlaying { get; private set; }

	public void Enqueue(Action action)
	{
		if (action == null) return;
		if (Queue == null)
			Queue = new Queue<Action>();
		Queue.Enqueue(action);
	}

	public bool Any()
	{
		return Queue != null && Queue.Count > 0;
	}

	public bool IsEmpty()
	{
		return Queue == null || Queue.Count == 0;
	}

	public void Clear()
	{
		if (Queue != null)
			Queue.Clear();
		IsPlaying = false;
	}

	public void StartAction()
	{
		if (IsPlaying) return;
		Invoke();
	}

	public void Invoke()
	{
		if (Queue == null || Queue.Count == 0)
		{
			IsPlaying = false;
			return;
		}
		IsPlaying = true;
		var action = Queue.Dequeue();
		action?.Invoke();
	}
}
