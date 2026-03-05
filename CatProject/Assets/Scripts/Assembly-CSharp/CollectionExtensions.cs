using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class CollectionExtensions
{
	public static bool IsValidIndex<T>(this List<T> list, int index)
	{
		return list != null && index >= 0 && index < list.Count;
	}

	public static bool IsValidIndex<T>(this IReadOnlyCollection<T> collection, int index)
	{
		return collection != null && index >= 0 && index < collection.Count;
	}

	public static void InitDefault<T>(this List<T> collection, int count)
	{
		if (collection == null) return;
		collection.Clear();
		for (int i = 0; i < count; i++)
			collection.Add(default(T));
	}

	public static void InitNew<T>(this List<T> collection, int count) where T : class, new()
	{
		if (collection == null) return;
		collection.Clear();
		for (int i = 0; i < count; i++)
			collection.Add(new T());
	}

	public static void AddUnique<T>(this List<T> collection, T value)
	{
		if (collection == null) return;
		if (!collection.Contains(value))
			collection.Add(value);
	}

	public static T GetOrDefault<T>(this List<T> collection, int index)
	{
		if (collection == null || index < 0 || index >= collection.Count)
			return default(T);
		return collection[index];
	}

	public static void SetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
	{
		if (dictionary == null) return;
		dictionary[key] = value;
	}

	public static TValue FindOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key) where TValue : class, new()
	{
		if (dictionary == null) return null;
		if (dictionary.TryGetValue(key, out TValue val))
			return val;
		val = new TValue();
		dictionary[key] = val;
		return val;
	}

	public static TValue FindOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
	{
		if (dictionary == null) return default(TValue);
		if (dictionary.TryGetValue(key, out TValue val))
			return val;
		return default(TValue);
	}

	public static bool RemoveFirst<T>(this List<T> collection, Func<T, bool> predicated)
	{
		if (collection == null || predicated == null) return false;
		for (int i = 0; i < collection.Count; i++)
		{
			if (predicated(collection[i]))
			{
				collection.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public static List<T> GetSafeRange<T>(this List<T> collection, int index, int count)
	{
		if (collection == null) return new List<T>();
		int start = Math.Max(0, index);
		int safeCount = Math.Min(count, collection.Count - start);
		if (safeCount <= 0) return new List<T>();
		return collection.GetRange(start, safeCount);
	}

	public static TValue Find<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
	{
		if (dictionary == null) return default(TValue);
		if (dictionary.TryGetValue(key, out TValue val))
			return val;
		return default(TValue);
	}

	public static TValue Find<TKey, TValue>(this ReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
	{
		if (dictionary == null) return default(TValue);
		if (dictionary.TryGetValue(key, out TValue val))
			return val;
		return default(TValue);
	}
}
