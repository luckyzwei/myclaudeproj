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
		if (myRectTr == null) return;
		float posX = startPadding;
		int activeCount = 0;
		for (int i = 0; i < myRectTr.childCount; i++)
		{
			var child = myRectTr.GetChild(i) as RectTransform;
			if (child == null || !child.gameObject.activeSelf) continue;
			float x = (dir == E_POS_DIR.RIGHT) ? posX : -posX;
			if (isReverse) x = -x;
			child.anchoredPosition = new Vector2(x, child.anchoredPosition.y);
			posX += child.rect.width + spacing;
			activeCount++;
		}
		if (isSetSize)
			myRectTr.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, posX - spacing + startPadding);
	}
}
