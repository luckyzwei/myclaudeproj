using UnityEngine;

public class DailyChallenge : ScriptableObject
{
	[SerializeField]
	protected string m_dailyChallengeID;

	[SerializeField]
	protected DailyChallengePopup m_dailyChallengePopupPrefab;

	private DailyChallengePopup m_dailyChallengePopup;

	public string DailyChallengeID => m_dailyChallengeID;

	public DailyChallengePopup DailyChallengePopup => m_dailyChallengePopup;

	public virtual void ShowDailyChallengePopup(bool firstShow = true)
	{
		if (m_dailyChallengePopupPrefab != null)
		{
			m_dailyChallengePopup = Instantiate(m_dailyChallengePopupPrefab);
		}
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
