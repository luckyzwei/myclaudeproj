using System.Runtime.CompilerServices;
using Balancy.Models.Gameplay.Missions;

public abstract class BaseMission
{
	public delegate void ProgressDelegate(bool isCompleted);

	protected MissionData m_missionData;

	protected int m_targetValue;

	protected int m_progress;

	public int TargetValue => 0;

	public int Progress => 0;

	public event ProgressDelegate ProgressEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public virtual void Config(MissionData missionData, int value, int progress = 0)
	{
	}

	public abstract void StartTracking();

	public abstract void StopTracking();

	public abstract bool IsEligible();

	public virtual string GetDescription()
	{
		return null;
	}

	public virtual int GetProgress()
	{
		return 0;
	}

	public virtual float GetProgressNormalized()
	{
		return 0f;
	}

	public virtual void SetProgress(int progress)
	{
	}

	public virtual void AddProgress(int addingAmount = 1)
	{
	}

	public virtual bool IsCompleted()
	{
		return false;
	}

	public MissionData GetMissionData()
	{
		return null;
	}
}
