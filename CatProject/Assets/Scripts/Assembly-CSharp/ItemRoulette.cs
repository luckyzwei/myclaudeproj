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
	}

	public void SetRouletteSpecialDayItem(int idx)
	{
		Order = idx;
	}

	public void ShowParticle()
	{
		if (FocusParticle != null)
			FocusParticle.SetActive(true);
	}

	public void SetLuckyDraw(int idx)
	{
		Order = idx;
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
