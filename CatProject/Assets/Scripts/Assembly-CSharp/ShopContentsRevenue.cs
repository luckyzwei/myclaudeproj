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
		base.Init();
		RefreshActive();
	}

	private void RefreshActive()
	{
		if (PackageItem != null) PackageItem.SetActive(true);
	}

	private void OpenPackageUI(int idx)
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}
}
