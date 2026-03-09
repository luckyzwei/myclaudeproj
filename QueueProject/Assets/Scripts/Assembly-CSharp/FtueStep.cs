using System;
using UnityEngine;

public class FtueStep : MonoBehaviour
{
	[SerializeField]
	private BaseFtueAction[] m_actions;

	private Action m_finishCallback;

	private int m_index;

	public void Play(QueensGrid grid, Action finishCallback)
	{
	}

	private void PlayNextAction()
	{
	}

	private void ActionDone()
	{
	}

	public void ContinuePressed()
	{
	}

	private string GetTypeName()
	{
		return null;
	}
}
