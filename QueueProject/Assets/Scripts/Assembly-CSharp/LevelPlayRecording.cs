using System.Collections.Generic;

public class LevelPlayRecording
{
	public List<UserSingleAction> m_actions;

	private int m_mistakesCount;

	private bool m_isFailed;

	public void Record(UserSingleAction action)
	{
	}

	public void Record(UserActionType action, float time, int cellIndex)
	{
	}

	public void Clear()
	{
	}

	public float GetTime()
	{
		return 0f;
	}

	public void ScaleTime(float timeLimit)
	{
	}

	public void OverrideTime(float newTotalTime)
	{
	}

	public int GetMistakesCount()
	{
		return 0;
	}

	public bool IsFailed()
	{
		return false;
	}

	public void SetWin()
	{
	}

	public void SetFailed()
	{
	}

	public void IncrementMistakes()
	{
	}
}
