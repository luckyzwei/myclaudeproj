using UnityEngine;

public class TutorialEntityFadeInOut : TutorialEntity
{
	private enum FadeType
	{
		In = 0,
		Out = 1
	}

	[SerializeField]
	private GameObject FadeObj;

	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private FadeType type;

	[SerializeField]
	private float FadeTime;

	public override void StartEntity()
	{
	}
}
