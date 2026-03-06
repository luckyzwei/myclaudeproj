using UnityEngine;

public class TutorialEntityShowPopup : TutorialEntity
{
	public enum WaitPopups
	{

	}

	[SerializeField]
	private WaitPopups popup;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
