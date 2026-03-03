using UnityEngine;
using UnityEngine.UI;

public class ItemStrikeTier : MonoBehaviour
{
	[Header("ItemStrikeTier")]
	[SerializeField]
	private Image tierTag;

	[SerializeField]
	private Text tierText;

	[SerializeField]
	private Text tierCountText;

	public void SetTier(int grade, int count)
	{
	}
}
