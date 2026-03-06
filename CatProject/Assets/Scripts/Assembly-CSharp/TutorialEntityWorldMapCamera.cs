using UnityEngine;

public class TutorialEntityWorldMapCamera : TutorialEntity
{
	[SerializeField]
	private bool basicZoom;

	[SerializeField]
	private bool noZoom;

	[SerializeField]
	private bool zoomOut;

	[SerializeField]
	private bool Immediately;

	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
