using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal static class EnumUtils
	{
		public static T Parse<T>(string enumMemberName) where T : struct
		{
			return default(T);
		}

		public static T Parse<T>(string enumMemberName, bool ignoreCase) where T : struct
		{
			return default(T);
		}

		public static bool TryParse<T>(string enumMemberName, bool ignoreCase, out T value) where T : struct
		{
			value = default(T);
			return false;
		}

		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			return null;
		}

		public static EnumValues<ulong> GetNamesAndValues<T>() where T : struct
		{
			return null;
		}

		public static EnumValues<TUnderlyingType> GetNamesAndValues<TEnum, TUnderlyingType>() where TEnum : struct where TUnderlyingType : struct
		{
			return null;
		}

		public static EnumValues<TUnderlyingType> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			return null;
		}

		public static IList<T> GetValues<T>()
		{
			return null;
		}

		public static IList<object> GetValues(Type enumType)
		{
			return null;
		}

		public static IList<string> GetNames<T>()
		{
			return null;
		}

		public static IList<string> GetNames(Type enumType)
		{
			return null;
		}

		public static TEnumType GetMaximumValue<TEnumType>(Type enumType) where TEnumType : IConvertible, IComparable<TEnumType>
		{
			return default(TEnumType);
		}
	}
}
