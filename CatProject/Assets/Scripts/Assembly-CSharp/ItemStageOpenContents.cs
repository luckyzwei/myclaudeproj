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
	}

	public void Set(string nameKey, string iconPath, Config.AtlasType atlasType)
	{
	}
}
