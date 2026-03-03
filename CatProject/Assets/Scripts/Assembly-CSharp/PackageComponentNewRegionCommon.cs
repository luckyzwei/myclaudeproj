using UniRx;
using UnityEngine;

public class PackageComponentNewRegionCommon : PackageComponent
{
	[Header("PackageComponentNewRegionCommon")]
	private CompositeDisposable disposables;

	public override void Set(int packageIdx)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
