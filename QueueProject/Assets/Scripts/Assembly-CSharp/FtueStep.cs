using System;
using UnityEngine;

public class FtueStep : MonoBehaviour
{
	[SerializeField]
	private BaseFtueAction[] m_actions;

	private Action m_finishCallback;

	private int m_index;

	private QueensGrid m_grid;

	public void Play(QueensGrid grid, Action finishCallback)
	{
		m_grid = grid;
		m_finishCallback = finishCallback;
		m_index = 0;
		gameObject.SetActive(true);
		PlayNextAction();
	}

	private void PlayNextAction()
	{
		if (m_actions == null || m_index >= m_actions.Length)
		{
			ActionDone();
			return;
		}

		var action = m_actions[m_index];
		if (action != null)
		{
			action.Config(m_grid, () => { m_index++; PlayNextAction(); });
			action.Play();
		}
		else
		{
			m_index++;
			PlayNextAction();
		}
	}

	private void ActionDone()
	{
		gameObject.SetActive(false);
		m_finishCallback?.Invoke();
	}

	public void ContinuePressed()
	{
		m_index++;
		PlayNextAction();
	}

	private string GetTypeName()
	{
		return GetType().Name;
	}
}
