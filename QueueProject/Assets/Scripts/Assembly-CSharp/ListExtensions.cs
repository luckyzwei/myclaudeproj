using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using KWCore.Debugging;
using UnityEngine;

public static class ListExtensions
{
	private const int MAX_ITERATION_MULT = 100;

	public static int[] s_randExcludingIndexCache;

	public static T GetRandom<T>(this IList<T> list)
	{
		if (!CheckList(list)) return default(T);
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	public static T GetRandomExcluding<T>(this IList<T> list, List<T> exclude)
	{
		if (!CheckList(list)) return default(T);
		if (exclude == null || exclude.Count == 0) return list.GetRandom();

		int maxIter = list.Count * MAX_ITERATION_MULT;
		for (int i = 0; i < maxIter; i++)
		{
			T item = list[UnityEngine.Random.Range(0, list.Count)];
			if (!exclude.Contains(item))
				return item;
		}
		return list[0];
	}

	public static T GetRandomExcluding<T>(this IList<T> list, params T[] exclude)
	{
		if (!CheckList(list)) return default(T);
		if (exclude == null || exclude.Length == 0) return list.GetRandom();

		int maxIter = list.Count * MAX_ITERATION_MULT;
		for (int i = 0; i < maxIter; i++)
		{
			T item = list[UnityEngine.Random.Range(0, list.Count)];
			bool found = false;
			for (int j = 0; j < exclude.Length; j++)
			{
				if (EqualityComparer<T>.Default.Equals(item, exclude[j]))
				{
					found = true;
					break;
				}
			}
			if (!found) return item;
		}
		return list[0];
	}

	public static T GetRandomExcluding<T>(this IList<T> list, ICollection exclude)
	{
		if (!CheckList(list)) return default(T);
		if (exclude == null || exclude.Count == 0) return list.GetRandom();

		int maxIter = list.Count * MAX_ITERATION_MULT;
		for (int i = 0; i < maxIter; i++)
		{
			int idx = UnityEngine.Random.Range(0, list.Count);
			T item = list[idx];
			bool found = false;
			foreach (object obj in exclude)
			{
				if (EqualityComparer<T>.Default.Equals(item, (T)obj))
				{
					found = true;
					break;
				}
			}
			if (!found) return item;
		}
		return list[0];
	}

	public static T GetRandomWithWeights<T>(this IList<T> list, float[] weights)
	{
		if (!CheckList(list)) return default(T);
		if (weights == null || weights.Length != list.Count) return list.GetRandom();

		float totalWeight = 0f;
		for (int i = 0; i < weights.Length; i++)
			totalWeight += weights[i];

		float random = UnityEngine.Random.Range(0f, totalWeight);
		float cumulative = 0f;
		for (int i = 0; i < list.Count; i++)
		{
			cumulative += weights[i];
			if (random <= cumulative)
				return list[i];
		}
		return list[list.Count - 1];
	}

	public static T GetRandomExcluding<T>(this IList<T> list, int excludeIndex)
	{
		if (!CheckList(list)) return default(T);
		if (list.Count == 1) return list[0];

		int idx = UnityEngine.Random.Range(0, list.Count - 1);
		if (idx >= excludeIndex) idx++;
		return list[idx];
	}

	private static bool CheckList<T>(IList<T> list)
	{
		return list != null && list.Count > 0;
	}

	public static T GetRandomExcluding<T>(this IList<T> list, Predicate<T> match)
	{
		if (!CheckList(list)) return default(T);

		int maxIter = list.Count * MAX_ITERATION_MULT;
		for (int i = 0; i < maxIter; i++)
		{
			T item = list[UnityEngine.Random.Range(0, list.Count)];
			if (!match(item))
				return item;
		}
		return list[0];
	}

	public static T KWFindFirstOrDefault<T>(this IList<T> list, Predicate<T> match)
	{
		if (list == null || match == null) return default(T);
		for (int i = 0; i < list.Count; i++)
		{
			if (match(list[i]))
				return list[i];
		}
		return default(T);
	}

	public static IList<T> KWWhere<T>(this IList<T> list, Predicate<T> match)
	{
		if (list == null || match == null) return new List<T>();
		var result = new List<T>();
		for (int i = 0; i < list.Count; i++)
		{
			if (match(list[i]))
				result.Add(list[i]);
		}
		return result;
	}

	public static T LastItem<T>(this IList<T> list)
	{
		if (!CheckList(list)) return default(T);
		return list[list.Count - 1];
	}

	public static void Shuffle<T>(this IList<T> list)
	{
		if (list == null) return;
		int n = list.Count;
		while (n > 1)
		{
			n--;
			int k = UnityEngine.Random.Range(0, n + 1);
			T temp = list[k];
			list[k] = list[n];
			list[n] = temp;
		}
	}

	public static IList<T> Concatenate<T>(this IList<T> list, IList<T> listToAdd)
	{
		if (list == null) return listToAdd;
		if (listToAdd == null) return list;
		var result = new List<T>(list.Count + listToAdd.Count);
		for (int i = 0; i < list.Count; i++)
			result.Add(list[i]);
		for (int i = 0; i < listToAdd.Count; i++)
			result.Add(listToAdd[i]);
		return result;
	}

	public static void ConcatAndClear<T>(this IList<T> list, IList<T> listToAdd)
	{
		if (list == null || listToAdd == null) return;
		for (int i = 0; i < listToAdd.Count; i++)
			list.Add(listToAdd[i]);
		listToAdd.Clear();
	}

	public static void Fill<T>(this List<T> list, T itemToFill)
	{
		if (list == null) return;
		for (int i = 0; i < list.Count; i++)
			list[i] = itemToFill;
	}

	public static void Fill<T>(this IList<T> list, T itemToFill, int start, int end)
	{
		if (list == null) return;
		for (int i = start; i < end && i < list.Count; i++)
			list[i] = itemToFill;
	}

	public static void RemoveDuplicates<T>(this IList<T> list)
	{
		if (list == null) return;
		var seen = new HashSet<T>();
		for (int i = list.Count - 1; i >= 0; i--)
		{
			if (!seen.Add(list[i]))
				list.RemoveAt(i);
		}
	}

	[Conditional("CANDIDATE_DEBUG")]
	[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
	public static void DebugLog<T>(this IList<T> list, int system = -1, KWCore.Debugging.Debugger.Colour colour = KWCore.Debugging.Debugger.Colour.WHITE)
	{
	}

	public static int Push<T>(this IList<T> list, T itemToPush)
	{
		if (list == null) return 0;
		list.Add(itemToPush);
		return list.Count;
	}

	public static T Pop<T>(this List<T> list)
	{
		if (list == null || list.Count == 0) return default(T);
		int lastIndex = list.Count - 1;
		T item = list[lastIndex];
		list.RemoveAt(lastIndex);
		return item;
	}

	public static List<T> Split<T>(this IList<T> list, int start, int end)
	{
		if (list == null) return new List<T>();
		var result = new List<T>();
		for (int i = start; i < end && i < list.Count; i++)
			result.Add(list[i]);
		return result;
	}

	public static int Unshift<T>(this IList<T> list, T itemToUnshift)
	{
		if (list == null) return 0;
		list.Insert(0, itemToUnshift);
		return list.Count;
	}

	public static int WrapIndex<T>(this IList<T> list, int index)
	{
		if (list == null || list.Count == 0) return 0;
		return ((index % list.Count) + list.Count) % list.Count;
	}

	public static int ClampIndex<T>(this IList<T> list, int index)
	{
		if (list == null || list.Count == 0) return 0;
		return Mathf.Clamp(index, 0, list.Count - 1);
	}

	public static bool IsValidIndex<T>(this IList<T> list, int index)
	{
		return list != null && index >= 0 && index < list.Count;
	}

	public static bool AddIfUnique<T>(this List<T> list, T element)
	{
		if (list == null) return false;
		if (list.Contains(element)) return false;
		list.Add(element);
		return true;
	}

	public static bool Contains(this IList<string> list, string element)
	{
		if (list == null) return false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] == element)
				return true;
		}
		return false;
	}

	public static bool Contains<T>(this IList<T> list, T element) where T : class
	{
		if (list == null) return false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] == element)
				return true;
		}
		return false;
	}

	public static bool AreAllItemsValid<T>(this IList<GameObject> list)
	{
		if (list == null) return false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] == null)
				return false;
		}
		return true;
	}

	public static void DestroyAllAndClear(this IList<GameObject> list)
	{
		if (list == null) return;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
				UnityEngine.Object.Destroy(list[i]);
		}
		list.Clear();
	}
}
