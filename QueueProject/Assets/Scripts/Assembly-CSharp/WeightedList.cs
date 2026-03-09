using System;
using System.Collections.Generic;

public class WeightedList<T>
{
	private List<WeightedListItem<T>> items;

	private float totalWeight;

	private Random random;

	public WeightedList()
	{
	}

	public WeightedList(Random randomGenerator)
	{
	}

	public void Add(T item, float weight, float weightUnit)
	{
	}

	public void Clear()
	{
	}

	public T GetRandom()
	{
		return default(T);
	}

	public void DecreaseOneWeightUnit(T item)
	{
	}
}
