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
	}

	public override void Init()
	{
	}

	public override void Reset()
	{
	}

	private void RefreshActive()
	{
	}

	private void RefreshActive(int buyPackageIdx)
	{
	}

	private void ClickPackage(int idx)
	{
	}

	private bool CheckTimeLimitShowType(E_TimeLimitShowType timeLimitShowType, int remainTime)
	{
		return false;
	}
}
