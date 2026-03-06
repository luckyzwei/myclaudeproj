using UnityEngine;
using UnityEngine.UI;

public class TutorialEnityForceFrontUI : TutorialEntity
{
	[SerializeField]
	private Image dim;

	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	private GameObject target;

	private Transform originParent;

	private TutorialFinishChecker checker;

	public override void StartEntity()
	{
		if (dim != null) dim.enabled = true;
	}

	private void Update()
	{
		// Check if tutorial finished
	}
}
