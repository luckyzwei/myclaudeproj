using UnityEngine;

public class TutorialEntityGiveItem : TutorialEntity
{
	[SerializeField]
	private int itemType;

	[SerializeField]
	private int itemIdx;

	[SerializeField]
	private int itemCnt;

	[SerializeField]
	private string defineKey;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
