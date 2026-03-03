using UnityEngine;

[ExecuteInEditMode]
public class UIRePositionY : UIRePositionBase
{
	private enum E_POS_DIR
	{
		DOWN = 0,
		UP = 1
	}

	[SerializeField]
	private E_POS_DIR dir;

	public override void UpdatePosition()
	{
	}
}
