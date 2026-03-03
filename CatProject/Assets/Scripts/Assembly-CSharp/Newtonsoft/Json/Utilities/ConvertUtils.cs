using System;
using System.ComponentModel;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	internal static class ConvertUtils
	{
		internal struct TypeConvertKey : IEquatable<TypeConvertKey>
		{
			private readonly Type _initialType;

			private readonly Type _targetType;

			public Type InitialType => null;

			public Type TargetType => null;

			public TypeConvertKey(Type initialType, Type targetType)
			{
				_initialType = null;
				_targetType = null;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public bool Equals(TypeConvertKey other)
			{
				return false;
			}
		}

		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters;

		private static Func<object, object> CreateCastConverter(TypeConvertKey t)
		{
			return null;
		}

		public static bool CanConvertType(Type initialType, Type targetType, bool allowTypeNameToString)
		{
			return false;
		}

		private static bool IsComponentConverter(TypeConverter converter)
		{
			return false;
		}

		public static T Convert<T>(object initialValue)
		{
			return default(T);
		}

		public static T Convert<T>(object initialValue, CultureInfo culture)
		{
			return default(T);
		}

		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		public static bool TryConvert<T>(object initialValue, out T convertedValue)
		{
			convertedValue = default(T);
			return false;
		}

		public static bool TryConvert<T>(object initialValue, CultureInfo culture, out T convertedValue)
		{
			convertedValue = default(T);
			return false;
		}

		public static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object convertedValue)
		{
			convertedValue = null;
			return false;
		}

		public static T ConvertOrCast<T>(object initialValue)
		{
			return default(T);
		}

		public static T ConvertOrCast<T>(object initialValue, CultureInfo culture)
		{
			return default(T);
		}

		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		public static bool TryConvertOrCast<T>(object initialValue, out T convertedValue)
		{
			convertedValue = default(T);
			return false;
		}

		public static bool TryConvertOrCast<T>(object initialValue, CultureInfo culture, out T convertedValue)
		{
			convertedValue = default(T);
			return false;
		}

		public static bool TryConvertOrCast(object initialValue, CultureInfo culture, Type targetType, out object convertedValue)
		{
			convertedValue = null;
			return false;
		}

		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		internal static TypeConverter GetConverter(Type t)
		{
			return null;
		}

		public static bool IsInteger(object value)
		{
			return false;
		}
	}
}
