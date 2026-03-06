using UnityEngine;

public class TutorialEntityHUDAniController : TutorialEntity
{
	private enum Status
	{
		HideAll = 0,
		ShowAll = 1
	}

	[SerializeField]
	private Status hudstatus;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
