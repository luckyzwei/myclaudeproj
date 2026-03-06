using UnityEngine;
using UnityEngine.UI;

public class ItemRank : MonoBehaviour
{
	[SerializeField]
	private Image TrophyImg;

	[SerializeField]
	private Text Rank;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Point;

	[SerializeField]
	private GameObject MyRankObj;

	public void Set(int rank, int idx)
	{
		// Update display
	}
}
