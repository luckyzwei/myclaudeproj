using UnityEngine;
using UnityEngine.UI;

public class ItemSeasonalSlotRank : MonoBehaviour
{
	[SerializeField]
	private Image imgRank;

	[SerializeField]
	private Image imgProfile;

	[SerializeField]
	private Text textRank;

	[SerializeField]
	private Text textName;

	[SerializeField]
	private Text textScore;

	[SerializeField]
	private GameObject myRankObj;

	public void Set(SeasonalCoinRankUserData userData)
	{
		// Update display
	}
}
