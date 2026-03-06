using UnityEngine;

public class ShopContentsPackageDesk : IShopContents
{
	[SerializeField]
	private ItemPackageGroup package;

	public void Set(int packageIdx)
	{
		if (package != null)
			package.gameObject.SetActive(true);
	}

	private void Hide()
	{
		if (package != null)
			package.gameObject.SetActive(false);
	}

	private void BuyPackage(int idx)
	{
	}
}
