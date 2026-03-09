using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoosterPurchaseButton : MonoBehaviour
{
	public delegate void BoosterClickDelegate(PriceType priceType, int price, int count);

	private const string ADS_KEY = "Store.CoinsGet";

	[SerializeField]
	private TMP_Text m_coinsText;

	[SerializeField]
	private GameObject[] m_boosters;

	[SerializeField]
	private Button m_button;

	private PriceType m_priceType;

	private int m_price;

	private int m_count;

	public event BoosterClickDelegate ClickEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void Config(int boosterCount, PriceType priceType, int price)
	{
	}

	public void ButtonClicked()
	{
	}
}
