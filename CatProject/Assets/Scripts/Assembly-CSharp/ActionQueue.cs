using System;
using System.Collections.Generic;

public class ActionQueue
{
	private Queue<Action> Queue;

	public bool IsPlaying { get; private set; }

	public void Enqueue(Action action)
	{
	}

	public bool Any()
	{
		return false;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public void Clear()
	{
	}

	public void StartAction()
	{
	}

	public void Invoke()
	{
	}
}
