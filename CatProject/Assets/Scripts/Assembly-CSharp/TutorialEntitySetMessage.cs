using UnityEngine;
using UnityEngine.UI;

public class TutorialEntitySetMessage : TutorialEntity
{
	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private GameObject toast;

	[SerializeField]
	private Text toastTitle;

	[SerializeField]
	private Text toastDesc;

	[SerializeField]
	private string titleKey;

	[SerializeField]
	private string descKey;

	public override void StartEntity()
	{
		base.StartEntity();
	}
}
