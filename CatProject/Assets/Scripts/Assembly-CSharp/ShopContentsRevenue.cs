using UnityEngine;

public class ShopContentsRevenue : IShopContents
{
	[SerializeField]
	private int Type;

	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GameObject PackageItem;

	private void Awake()
	{
	}

	public override void Init()
	{
	}

	private void RefreshActive()
	{
	}

	private void OpenPackageUI(int idx)
	{
	}
}
