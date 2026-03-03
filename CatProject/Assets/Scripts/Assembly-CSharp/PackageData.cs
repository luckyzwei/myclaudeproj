using System;
using UniRx;

public class PackageData : IReadOnlyData, ICloneable
{
	public DateTime EndTime;

	public IReactiveProperty<int> RemainTimeProperty;

	public Subject<int> OnBuyPackage;

	public int PackageIdx { get; set; }

	public int BuyCount { get; set; }

	public void BuyPackage()
	{
	}

	public PackageData(int idx, long datetime, int count)
	{
	}

	public virtual void Create()
	{
	}

	public virtual object Clone()
	{
		return null;
	}
}
