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
		return default(T);
	}

	public static T GetRandomExcluding<T>(this IList<T> list, List<T> exclude)
	{
		return default(T);
	}

	public static T GetRandomExcluding<T>(this IList<T> list, params T[] exclude)
	{
		return default(T);
	}

	public static T GetRandomExcluding<T>(this IList<T> list, ICollection exclude)
	{
		return default(T);
	}

	public static T GetRandomWithWeights<T>(this IList<T> list, float[] weights)
	{
		return default(T);
	}

	public static T GetRandomExcluding<T>(this IList<T> list, int excludeIndex)
	{
		return default(T);
	}

	private static bool CheckList<T>(IList<T> list)
	{
		return false;
	}

	public static T GetRandomExcluding<T>(this IList<T> list, Predicate<T> match)
	{
		return default(T);
	}

	public static T KWFindFirstOrDefault<T>(this IList<T> list, Predicate<T> match)
	{
		return default(T);
	}

	public static IList<T> KWWhere<T>(this IList<T> list, Predicate<T> match)
	{
		return null;
	}

	public static T LastItem<T>(this IList<T> list)
	{
		return default(T);
	}

	public static void Shuffle<T>(this IList<T> list)
	{
	}

	public static IList<T> Concatenate<T>(this IList<T> list, IList<T> listToAdd)
	{
		return null;
	}

	public static void ConcatAndClear<T>(this IList<T> list, IList<T> listToAdd)
	{
	}

	public static void Fill<T>(this List<T> list, T itemToFill)
	{
	}

	public static void Fill<T>(this IList<T> list, T itemToFill, int start, int end)
	{
	}

	public static void RemoveDuplicates<T>(this IList<T> list)
	{
	}

	[Conditional("CANDIDATE_DEBUG")]
	[Conditional("NOT_SERVER_ENVIROMENT_CANDIDATE")]
	public static void DebugLog<T>(this IList<T> list, int system = -1, KWCore.Debugging.Debugger.Colour colour = KWCore.Debugging.Debugger.Colour.WHITE)
	{
	}

	public static int Push<T>(this IList<T> list, T itemToPush)
	{
		return 0;
	}

	public static T Pop<T>(this List<T> list)
	{
		return default(T);
	}

	public static List<T> Split<T>(this IList<T> list, int start, int end)
	{
		return null;
	}

	public static int Unshift<T>(this IList<T> list, T itemToUnshift)
	{
		return 0;
	}

	public static int WrapIndex<T>(this IList<T> list, int index)
	{
		return 0;
	}

	public static int ClampIndex<T>(this IList<T> list, int index)
	{
		return 0;
	}

	public static bool IsValidIndex<T>(this IList<T> list, int index)
	{
		return false;
	}

	public static bool AddIfUnique<T>(this List<T> list, T element)
	{
		return false;
	}

	public static bool Contains(this IList<string> list, string element)
	{
		return false;
	}

	public static bool Contains<T>(this IList<T> list, T element) where T : class
	{
		return false;
	}

	public static bool AreAllItemsValid<T>(this IList<GameObject> list)
	{
		return false;
	}

	public static void DestroyAllAndClear(this IList<GameObject> list)
	{
	}
}
