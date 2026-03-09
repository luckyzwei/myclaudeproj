using UnityEngine;

public class DailyChallenge : ScriptableObject
{
	[SerializeField]
	protected string m_dailyChallengeID;

	[SerializeField]
	protected DailyChallengePopup m_dailyChallengePopupPrefab;

	private DailyChallengePopup m_dailyChallengePopup;

	public string DailyChallengeID => null;

	public DailyChallengePopup DailyChallengePopup => null;

	public virtual void ShowDailyChallengePopup(bool firstShow = true)
	{
	}

	public virtual void OnDailyChallengeWidgetUpdated(DCDate date)
	{
	}

	public virtual void OnChallengeStarted()
	{
	}

	public virtual void OnChallengeComplete()
	{
	}

	public virtual void OnChallengeFailed()
	{
	}
}
