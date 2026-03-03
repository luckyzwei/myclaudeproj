using DG.Tweening;
using UnityEngine;

public class TutorialEntityFocusZoom : TutorialEntity
{
	[SerializeField]
	private RectTransform maskTrans;

	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private float zoomOutSize;

	[SerializeField]
	private Ease zoomEaseType;

	[SerializeField]
	private float zoomInSize;

	[SerializeField]
	private float zoomedTime;

	[SerializeField]
	private float zoomAddPaddingY;

	public override void StartEntity()
	{
	}
}
