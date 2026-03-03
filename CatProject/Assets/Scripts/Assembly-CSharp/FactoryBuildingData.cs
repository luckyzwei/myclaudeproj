using System;
using UniRx;

public class FactoryBuildingData : IReadOnlyData, ICloneable
{
	public DateTime OpenEndTime;

	public DateTime EndBatteryTime;

	public int UseBatteryIdx;

	public IReactiveProperty<int> LevelProperty;

	public IReactiveProperty<int> OpenRemainTime;

	public IReactiveProperty<int> RemainBatteryTime;

	public IReactiveProperty<int> MakeProduct;

	public IReactiveProperty<bool> IsLack;

	public IReactiveProperty<bool> IsFull;

	public float d_time;

	public float production_time;

	public int[] need_product;

	public int[] need_product_count;

	public int Idx { get; private set; }

	public int Level { get; private set; }

	public FactoryBuildingData(int idx, int level, int product, DateTime opentime, DateTime batterytime)
	{
	}

	public void Create()
	{
	}

	public void UpdateProductionTime()
	{
	}

	public void SelectMakeProduct(int product)
	{
	}

	public void DeSelectMakeProduct()
	{
	}

	public void UseMix()
	{
	}

	public void CreateProduct()
	{
	}

	public void FindTargetNeedProduct()
	{
	}

	public void UpdateIsLack()
	{
	}

	public virtual object Clone()
	{
		return null;
	}
}
