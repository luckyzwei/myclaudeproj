using UnityEngine;
using UnityEngine.UI;

public class ItemMiniGame_DigTreasure : MonoBehaviour
{
	[SerializeField]
	private Image Img_Icon;

	public int ItemIdx { get; private set; }

	public Vector2 Size { get; private set; }

	public void SetItem(int itemIdx)
	{
		ItemIdx = itemIdx;
	}

	private void SetSize(int width, int height)
	{
		Size = new Vector2(width, height);
		var rt = GetComponent<RectTransform>();
		if (rt != null)
			rt.sizeDelta = Size;
	}

	private void SetIcon(string iconPath)
	{
		// Update display
	}
}
