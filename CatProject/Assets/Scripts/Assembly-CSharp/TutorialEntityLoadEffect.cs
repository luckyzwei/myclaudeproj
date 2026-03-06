using UnityEngine;

public class TutorialEntityLoadEffect : TutorialEntity
{
	public enum effectType
	{
		ClickHandsEffect = 0
	}

	[SerializeField]
	private effectType eType;

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
