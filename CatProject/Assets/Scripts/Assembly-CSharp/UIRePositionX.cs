using UnityEngine;

[ExecuteInEditMode]
public class UIRePositionX : UIRePositionBase
{
	private enum E_POS_DIR
	{
		LEFT = 0,
		RIGHT = 1
	}

	[SerializeField]
	private E_POS_DIR dir;

	public override void UpdatePosition()
	{
	}
}
