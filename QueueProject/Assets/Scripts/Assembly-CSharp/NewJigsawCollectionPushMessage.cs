using UnityEngine;

public class NewJigsawCollectionPushMessage : BasePushMessage
{
	private const string ID = "0005";

	private const string EMOJI_STRING = "(emoji)";

	public override string GetPushMessageID()
	{
		return null;
	}

	[ContextMenu("Test")]
	private void Start()
	{
	}

	public override void ReCheck()
	{
	}
}
