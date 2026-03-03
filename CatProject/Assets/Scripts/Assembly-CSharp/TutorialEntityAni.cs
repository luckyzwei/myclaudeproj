using UnityEngine;

public class TutorialEntityAni : TutorialEntity
{
	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private string aniName;

	private GameObject target;

	public override void StartEntity()
	{
	}
}
