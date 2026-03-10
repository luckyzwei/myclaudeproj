using System;
using UnityEngine;

public class BaseFtueAction : MonoBehaviour
{
	protected QueensGrid m_grid;

	private Action m_finishCallback;

	public void Config(QueensGrid grid, Action finishCallback)
	{
		m_grid = grid;
		m_finishCallback = finishCallback;
	}

	public virtual void Play()
	{
		// Default: finish immediately
		Finished();
	}

	public virtual void Stop()
	{
	}

	protected virtual void Finished()
	{
		m_finishCallback?.Invoke();
	}

	public virtual void ContinuePressed()
	{
		Finished();
	}
}
