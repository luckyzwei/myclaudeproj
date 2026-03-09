using UnityEngine;

public class StreakLosePushMessage : BasePushMessage
{
	private const string ID = "0008";

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

	[ContextMenu("Test")]
	public void Test()
	{
	}

	private void OnWinStreakIncreased(int days, bool isNewRecord)
	{
	}

	public override void ReCheck()
	{
	}
}
