using UniRx;
using UnityEngine;

public class ShopContentsPackage : IShopContents
{
	public enum E_TimeLimitShowType
	{
		TimeLimited = 0,
		NotTimeLimited = 1,
		All = 2
	}

	[Header("ShopPackage 테이븛의 show_type 같은 경우 노출")]
	[SerializeField]
	private int ShowType;

	[Header("ShopPackage 테이븛의 package_type 같은 경우 노출")]
	[SerializeField]
	private int Type;

	[SerializeField]
	private E_TimeLimitShowType TimeLimitShowType;

	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GameObject PackageItem;

	private CompositeDisposable Disposables;

	private void Awake()
	{
		Disposables = new CompositeDisposable();
	}

	public override void Init()
	{
		base.Init();
		RefreshActive();
	}

	public override void Reset()
	{
		if (Disposables != null)
			Disposables.Clear();
	}

	private void RefreshActive()
	{
		// Update display
	}

	private void RefreshActive(int buyPackageIdx)
	{
		RefreshActive();
	}

	private void ClickPackage(int idx)
	{
		// TODO
	}

	private bool CheckTimeLimitShowType(E_TimeLimitShowType timeLimitShowType, int remainTime)
	{
		switch (timeLimitShowType)
		{
			case E_TimeLimitShowType.TimeLimited:
				return remainTime > 0;
			case E_TimeLimitShowType.NotTimeLimited:
				return remainTime <= 0;
			case E_TimeLimitShowType.All:
				return true;
			default:
				return false;
		}
	}
}
