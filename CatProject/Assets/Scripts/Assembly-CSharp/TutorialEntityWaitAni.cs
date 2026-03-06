using UnityEngine;

public class TutorialEntityWaitAni : TutorialEntity
{
	[SerializeField]
	private TutorialIdent AniId;

	[SerializeField]
	private string WaitAni;

	private bool isDone;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
