public class DailyChallengesLeftToTrohyPushMessage : BasePushMessage
{
	private const string ID = "0011";

	private const float DELAY = 3f;

	public override string GetPushMessageID()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnDCCompleted()
	{
	}

	public override void ReCheck()
	{
	}

	private void CheckCurrentMonth()
	{
	}

	private void CheckForAllMonths()
	{
	}

	private bool CheckForMonth(DCDate date)
	{
		return false;
	}

	private void TriggerForMonth(DCDate date)
	{
	}
}
