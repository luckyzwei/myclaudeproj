using UnityEngine;
using UnityEngine.UI;

public class ItemRoulette : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private GameObject FocusParticle;

	[SerializeField]
	private Button InfoBtn;

	private int Order;

	private bool isPlant;

	public void SetRouletteItem(int idx)
	{
		Order = idx;
		// Set icon and count from roulette reward data table
	}

	public void SetRouletteSpecialDayItem(int idx)
	{
		Order = idx;
		// Set icon and count from special day roulette data
	}

	public void ShowParticle()
	{
		if (FocusParticle != null)
			FocusParticle.SetActive(true);
	}

	public void SetLuckyDraw(int idx)
	{
		Order = idx;
		// Set icon and count for lucky draw
	}

	public void ShowInfoBtn()
	{
		if (InfoBtn != null)
			InfoBtn.gameObject.SetActive(true);
	}

	public void HideInfoBtn()
	{
		if (InfoBtn != null)
			InfoBtn.gameObject.SetActive(false);
	}
}
