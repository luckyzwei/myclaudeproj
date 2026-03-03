using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class CollectionExtensions
{
	public static bool IsValidIndex<T>(this List<T> list, int index)
	{
		return false;
	}

	public static bool IsValidIndex<T>(this IReadOnlyCollection<T> collection, int index)
	{
		return false;
	}

	public static void InitDefault<T>(this List<T> collection, int count)
	{
	}

	public static void InitNew<T>(this List<T> collection, int count) where T : class, new()
	{
	}

	public static void AddUnique<T>(this List<T> collection, T value)
	{
	}

	public static T GetOrDefault<T>(this List<T> collection, int index)
	{
		return default(T);
	}

	public static void SetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
	{
	}

	public static TValue FindOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key) where TValue : class, new()
	{
		return null;
	}

	public static TValue FindOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
	{
		return default(TValue);
	}

	public static bool RemoveFirst<T>(this List<T> collection, Func<T, bool> predicated)
	{
		return false;
	}

	public static List<T> GetSafeRange<T>(this List<T> collection, int index, int count)
	{
		return null;
	}

	public static TValue Find<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
	{
		return default(TValue);
	}

	public static TValue Find<TKey, TValue>(this ReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
	{
		return default(TValue);
	}
}
