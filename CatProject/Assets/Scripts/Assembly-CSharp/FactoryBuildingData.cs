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
		Idx = idx;
		Level = level;
		MakeProduct = new ReactiveProperty<int>(product);
		OpenEndTime = opentime;
		EndBatteryTime = batterytime;
	}

	public void Create()
	{
		LevelProperty = new ReactiveProperty<int>();
		OpenRemainTime = new ReactiveProperty<int>();
		RemainBatteryTime = new ReactiveProperty<int>();
		MakeProduct = new ReactiveProperty<int>();
		IsLack = new ReactiveProperty<bool>();
		IsFull = new ReactiveProperty<bool>();
	}

	public void UpdateProductionTime()
	{
		// Recalculate production time based on level and battery
		float baseTime = 60f;
		float levelReduction = Level * 0.05f;
		production_time = baseTime * Math.Max(0.2f, 1f - levelReduction);

		// Battery speed boost
		if (EndBatteryTime > DateTime.UtcNow)
		{
			production_time *= 0.5f;
		}

		d_time = 0f;
	}

	public void SelectMakeProduct(int product)
	{
		if (MakeProduct != null)
			MakeProduct.Value = product;

		UpdateProductionTime();
		FindTargetNeedProduct();
	}

	public void DeSelectMakeProduct()
	{
		if (MakeProduct != null)
			MakeProduct.Value = 0;

		d_time = 0f;
		need_product = null;
		need_product_count = null;
	}

	public void UseMix()
	{
		// Consume needed products and start production
		d_time = 0f;
	}

	public void CreateProduct()
	{
		if (MakeProduct == null || MakeProduct.Value <= 0)
			return;

		d_time = 0f;
		UpdateIsLack();
	}

	public void FindTargetNeedProduct()
	{
		// Would look up recipe for MakeProduct and populate need_product/need_product_count
		if (MakeProduct == null || MakeProduct.Value <= 0)
		{
			need_product = null;
			need_product_count = null;
			return;
		}

		// Default: no materials needed (base products)
		need_product = null;
		need_product_count = null;
	}

	public void UpdateIsLack()
	{
		if (IsLack == null) return;

		if (need_product == null || need_product.Length == 0)
		{
			IsLack.Value = false;
			return;
		}

		// Would check if player has enough materials in factory storage
		IsLack.Value = false;
	}

	public virtual object Clone()
	{
		FactoryBuildingData clone = (FactoryBuildingData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
