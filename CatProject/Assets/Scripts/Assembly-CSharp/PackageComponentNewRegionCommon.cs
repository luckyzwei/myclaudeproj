using UniRx;
using UnityEngine;

public class PackageComponentNewRegionCommon : PackageComponent
{
	[Header("PackageComponentNewRegionCommon")]
	private CompositeDisposable disposables;

	public override void Set(int packageIdx)
	{
		base.Set(packageIdx);
		disposables = new CompositeDisposable();
	}

	private void OnDisable()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}
}
