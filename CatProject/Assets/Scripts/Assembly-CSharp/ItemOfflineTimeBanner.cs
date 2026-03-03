using UnityEngine;
using UnityEngine.UI;

public class ItemOfflineTimeBanner : ItemShopSpecialBanner
{
	[SerializeField]
	private Text BeforeMaxOffline;

	[SerializeField]
	private Text AfterMaxOffline;

	public override void Init(int idx)
	{
	}
}
