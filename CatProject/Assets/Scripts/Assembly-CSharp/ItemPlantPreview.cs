using UnityEngine;
using UnityEngine.UI;

public class ItemPlantPreview : MonoBehaviour
{
	[SerializeField]
	private Image PlantImg;

	[SerializeField]
	private Text PlantLevel;

	[SerializeField]
	private GameObject CheckObj;

	public void Set(int plantIdx, int plantLevel, bool isSatisfied)
	{
		// Update display
	}
}
