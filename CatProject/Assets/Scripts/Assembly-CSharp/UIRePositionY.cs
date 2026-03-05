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
		if (myRectTr == null) return;
		float posY = startPadding;
		for (int i = 0; i < myRectTr.childCount; i++)
		{
			var child = myRectTr.GetChild(i) as RectTransform;
			if (child == null || !child.gameObject.activeSelf) continue;
			float y = (dir == E_POS_DIR.UP) ? posY : -posY;
			if (isReverse) y = -y;
			child.anchoredPosition = new Vector2(child.anchoredPosition.x, y);
			posY += child.rect.height + spacing;
		}
		if (isSetSize)
			myRectTr.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, posY - spacing + startPadding);
	}
}
