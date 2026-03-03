using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal static class CollectionUtils
	{
		public static IEnumerable<T> CastValid<T>(this IEnumerable enumerable)
		{
			return null;
		}

		public static List<T> CreateList<T>(params T[] values)
		{
			return null;
		}

		public static bool IsNullOrEmpty(ICollection collection)
		{
			return false;
		}

		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return false;
		}

		public static bool IsNullOrEmptyOrDefault<T>(IList<T> list)
		{
			return false;
		}

		public static IList<T> Slice<T>(IList<T> list, int? start, int? end)
		{
			return null;
		}

		public static IList<T> Slice<T>(IList<T> list, int? start, int? end, int? step)
		{
			return null;
		}

		public static Dictionary<K, List<V>> GroupBy<K, V>(ICollection<V> source, Func<V, K> keySelector)
		{
			return null;
		}

		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		public static void AddRange(this IList initial, IEnumerable collection)
		{
		}

		public static List<T> Distinct<T>(List<T> collection)
		{
			return null;
		}

		public static List<List<T>> Flatten<T>(params IList<T>[] lists)
		{
			return null;
		}

		private static void Recurse<T>(IList<IList<T>> global, int current, Dictionary<int, T> currentSet, List<List<T>> flattenedResult)
		{
		}

		public static List<T> CreateList<T>(ICollection collection)
		{
			return null;
		}

		public static bool ListEquals<T>(IList<T> a, IList<T> b)
		{
			return false;
		}

		public static bool TryGetSingleItem<T>(IList<T> list, out T value)
		{
			value = default(T);
			return false;
		}

		public static bool TryGetSingleItem<T>(IList<T> list, bool returnDefaultIfEmpty, out T value)
		{
			value = default(T);
			return false;
		}

		public static T GetSingleItem<T>(IList<T> list)
		{
			return default(T);
		}

		public static T GetSingleItem<T>(IList<T> list, bool returnDefaultIfEmpty)
		{
			return default(T);
		}

		public static IList<T> Minus<T>(IList<T> list, IList<T> minus)
		{
			return null;
		}

		public static IList CreateGenericList(Type listType)
		{
			return null;
		}

		public static IDictionary CreateGenericDictionary(Type keyType, Type valueType)
		{
			return null;
		}

		public static bool IsListType(Type type)
		{
			return false;
		}

		public static bool IsCollectionType(Type type)
		{
			return false;
		}

		public static bool IsDictionaryType(Type type)
		{
			return false;
		}

		public static IWrappedCollection CreateCollectionWrapper(object list)
		{
			return null;
		}

		public static IWrappedList CreateListWrapper(object list)
		{
			return null;
		}

		public static IWrappedDictionary CreateDictionaryWrapper(object dictionary)
		{
			return null;
		}

		public static object CreateAndPopulateList(Type listType, Action<IList, bool> populateList)
		{
			return null;
		}

		public static Array ToArray(Array initial, Type type)
		{
			return null;
		}

		private static IList<int> GetDimensions(IList values)
		{
			return null;
		}

		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}

		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			return false;
		}

		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			return false;
		}

		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return false;
		}

		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values)
		{
			return false;
		}

		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			return false;
		}

		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return 0;
		}

		public static int IndexOf<TSource>(this IEnumerable<TSource> list, TSource value) where TSource : IEquatable<TSource>
		{
			return 0;
		}

		public static int IndexOf<TSource>(this IEnumerable<TSource> list, TSource value, IEqualityComparer<TSource> comparer)
		{
			return 0;
		}
	}
}
