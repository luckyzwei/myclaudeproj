using UnityEngine;

public class TutorialEntityFocus : TutorialEntity
{
	[SerializeField]
	private RectTransform maskTrans;

	[SerializeField]
	private GameObject clickobj;

	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	private float paddingValue;

	[SerializeField]
	private Vector2 Padding;

	[SerializeField]
	private bool IsPadding;

	public override void StartEntity()
	{
	}

	private void Update()
	{
	}
}
