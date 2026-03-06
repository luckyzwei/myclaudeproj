using UnityEngine;

public class TutorialEntityLockFree : TutorialEntity
{
	[SerializeField]
	private bool on;

	[SerializeField]
	private GameObject Lock;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
