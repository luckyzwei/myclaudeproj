using UnityEngine;
using UnityEngine.UI;

public class TicketBanner : MonoBehaviour
{
	[SerializeField]
	private Button ShopBtn;

	private void Awake()
	{
		if (ShopBtn != null)
			ShopBtn.onClick.AddListener(OnClickGotoShop);
	}

	private void OnEnable()
	{
		// Enabled
	}

	private void OnClickGotoShop()
	{
		// Handle click
	}
}
