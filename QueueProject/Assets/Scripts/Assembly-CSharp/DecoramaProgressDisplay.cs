using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DecoramaProgressDisplay : MonoBehaviour
{
	[SerializeField]
	private Image m_currencyImage;

	[SerializeField]
	private TextMeshProUGUI m_remainingCurrencyText;

	private Transform m_parent;

	public void UpdateProgressDisplay(DecoramaPaintable paintable)
	{
	}

	private void Update()
	{
	}
}
