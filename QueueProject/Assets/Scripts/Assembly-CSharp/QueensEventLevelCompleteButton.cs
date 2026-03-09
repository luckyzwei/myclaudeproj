using UnityEngine;

public class QueensEventLevelCompleteButton : MonoBehaviour
{
	[SerializeField]
	private GameObject m_button;

	[SerializeField]
	private float m_refreshInterval;

	[SerializeField]
	private GameObject m_timerObject;

	[SerializeField]
	private string m_location;

	private float m_timer;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClaimedAllTreasureEventRewards()
	{
	}

	protected virtual void Start()
	{
	}

	private int TimeLeft()
	{
		return 0;
	}

	private void Update()
	{
	}

	private void RefreshButtonVisibility()
	{
	}

	protected virtual bool IsQueensEventActive()
	{
		return false;
	}

	public virtual void OnPressed()
	{
	}
}
