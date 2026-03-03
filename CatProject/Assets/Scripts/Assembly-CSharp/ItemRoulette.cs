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
	}

	public void SetRouletteSpecialDayItem(int idx)
	{
	}

	public void ShowParticle()
	{
	}

	public void SetLuckyDraw(int idx)
	{
	}

	public void ShowInfoBtn()
	{
	}

	public void HideInfoBtn()
	{
	}
}
