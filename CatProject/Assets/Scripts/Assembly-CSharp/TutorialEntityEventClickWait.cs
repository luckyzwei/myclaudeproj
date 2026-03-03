using UnityEngine;

public class TutorialEntityEventClickWait : TutorialEntityClickWait
{
	[Header("Toast")]
	[SerializeField]
	private RectTransform toastRect;

	[SerializeField]
	private GameObject toast;

	[SerializeField]
	private GameObject upTail;

	[SerializeField]
	private GameObject downTail;

	public override void StartEntity()
	{
	}
}
