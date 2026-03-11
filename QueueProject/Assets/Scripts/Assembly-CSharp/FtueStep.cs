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
		Debug.Log($"[FtueStep] Play '{name}' - actions={(m_actions != null ? m_actions.Length.ToString() : "NULL")}, grid={grid != null}");
		if (m_actions != null)
		{
			for (int i = 0; i < m_actions.Length; i++)
				Debug.Log($"[FtueStep]   action[{i}]: {(m_actions[i] != null ? m_actions[i].GetType().Name + " (" + m_actions[i].gameObject.name + ")" : "NULL")}");
		}
		PlayNextAction();
	}

	private void PlayNextAction()
	{
		if (m_actions == null || m_index >= m_actions.Length)
		{
			Debug.Log($"[FtueStep] '{name}' all actions done (index={m_index})");
			ActionDone();
			return;
		}

		var action = m_actions[m_index];
		Debug.Log($"[FtueStep] '{name}' playing action[{m_index}]: {(action != null ? action.GetType().Name : "NULL")}");
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
