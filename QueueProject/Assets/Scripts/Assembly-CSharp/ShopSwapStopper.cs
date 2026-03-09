using UnityEngine;
using UnityEngine.UI;

public class ShopSwapStopper : MonoBehaviour
{
	[SerializeField]
	private Button[] m_buttonsToStop;

	[SerializeField]
	private float m_delay;

	private void Awake()
	{
	}

	private void OnShopPressed()
	{
	}
}
