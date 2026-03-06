using UnityEngine;
using UnityEngine.UI;

public class ItemStageOpenContents : MonoBehaviour
{
	[SerializeField]
	private Image ContentsIcon;

	[SerializeField]
	private Text ContentsNameText;

	public void Set(int buildingIdx)
	{
		if (ContentsNameText != null) ContentsNameText.text = buildingIdx.ToString();
	}

	public void Set(string nameKey, string iconPath, Config.AtlasType atlasType)
	{
		if (ContentsNameText != null) ContentsNameText.text = nameKey;
		if (ContentsIcon != null)
		{
			Sprite sprite = Resources.Load<Sprite>(iconPath);
			if (sprite != null) ContentsIcon.sprite = sprite;
		}
	}
}
