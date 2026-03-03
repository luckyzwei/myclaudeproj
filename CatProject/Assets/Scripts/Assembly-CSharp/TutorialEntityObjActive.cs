using UnityEngine;

public class TutorialEntityObjActive : TutorialEntity
{
	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private bool active;

	private GameObject target;

	public TutorialIdent Id => default(TutorialIdent);

	public bool Active => false;

	public override void StartEntity()
	{
	}
}
