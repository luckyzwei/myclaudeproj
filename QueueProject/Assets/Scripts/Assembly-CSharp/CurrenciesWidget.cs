using KWUserInterface;
using UnityEngine;

public class CurrenciesWidget : MonoBehaviour
{
	[SerializeField]
	private CoinWidget m_currencyWidget;

	[SerializeField]
	private string[] m_currencies;

	[SerializeField]
	private Transform m_transform;

	private void Awake()
	{
	}
}
