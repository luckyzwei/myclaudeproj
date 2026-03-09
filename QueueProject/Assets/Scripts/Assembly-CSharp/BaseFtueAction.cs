using System;
using UnityEngine;

public class BaseFtueAction : MonoBehaviour
{
	protected QueensGrid m_grid;

	private Action m_finishCallback;

	public void Config(QueensGrid grid, Action finishCallback)
	{
	}

	public virtual void Play()
	{
	}

	public virtual void Stop()
	{
	}

	protected virtual void Finished()
	{
	}

	public virtual void ContinuePressed()
	{
	}
}
