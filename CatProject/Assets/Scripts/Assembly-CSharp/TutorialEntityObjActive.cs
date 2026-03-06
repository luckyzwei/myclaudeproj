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

	public TutorialIdent Id { get { return default(TutorialIdent); } }

	public bool Active { get { return false; } }

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
