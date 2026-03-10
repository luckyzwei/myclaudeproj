using System.Runtime.CompilerServices;
using Balancy.Models.Gameplay.Missions;

public abstract class BaseMission
{
	public delegate void ProgressDelegate(bool isCompleted);

	protected MissionData m_missionData;

	protected int m_targetValue;

	protected int m_progress;

	private ProgressDelegate _progressEvent;

	public int TargetValue => m_targetValue;

	public int Progress => m_progress;

	public event ProgressDelegate ProgressEvent
	{
		add { _progressEvent += value; }
		remove { _progressEvent -= value; }
	}

	public virtual void Config(MissionData missionData, int value, int progress = 0)
	{
		m_missionData = missionData;
		m_targetValue = value;
		m_progress = progress;
	}

	public abstract void StartTracking();

	public abstract void StopTracking();

	public abstract bool IsEligible();

	public virtual string GetDescription()
	{
		return m_missionData != null ? m_missionData.ToString() : string.Empty;
	}

	public virtual int GetProgress()
	{
		return m_progress;
	}

	public virtual float GetProgressNormalized()
	{
		if (m_targetValue <= 0) return 0f;
		return (float)m_progress / m_targetValue;
	}

	public virtual void SetProgress(int progress)
	{
		m_progress = progress;
		_progressEvent?.Invoke(IsCompleted());
	}

	public virtual void AddProgress(int addingAmount = 1)
	{
		m_progress += addingAmount;
		if (m_progress > m_targetValue)
			m_progress = m_targetValue;
		_progressEvent?.Invoke(IsCompleted());
	}

	public virtual bool IsCompleted()
	{
		return m_progress >= m_targetValue;
	}

	public MissionData GetMissionData()
	{
		return m_missionData;
	}
}
