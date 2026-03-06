using UnityEngine;
using UnityEngine.UI;

public class ItemMiniGame_DigTreasureHint : MonoBehaviour
{
	[SerializeField]
	private Image ItemImg;

	private int ItemIdx;

	public string IconPath { get; private set; }

	public void SetItem(int itemIdx, bool isFind)
	{
		ItemIdx = itemIdx;
		SetIsFind(isFind);
	}

	public void SetIsFind(bool isFind)
	{
		if (ItemImg != null)
		{
			var color = ItemImg.color;
			color.a = isFind ? 1f : 0.3f;
			ItemImg.color = color;
		}
	}

	public void SetIcon(string iconPath)
	{
		IconPath = iconPath;
	}
}
