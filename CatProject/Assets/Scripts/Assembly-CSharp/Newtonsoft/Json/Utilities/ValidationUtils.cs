using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal static class ValidationUtils
	{
		public const string EmailAddressRegex = "^([a-zA-Z0-9_'+*$%\\^&!\\.\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9:]{2,4})+$";

		public const string CurrencyRegex = "(^\\$?(?!0,?\\d)\\d{1,3}(,?\\d{3})*(\\.\\d\\d)?)$";

		public const string DateRegex = "^(((0?[1-9]|[12]\\d|3[01])[\\.\\-\\/](0?[13578]|1[02])[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|((0?[1-9]|[12]\\d|30)[\\.\\-\\/](0?[13456789]|1[012])[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|((0?[1-9]|1\\d|2[0-8])[\\.\\-\\/]0?2[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|(29[\\.\\-\\/]0?2[\\.\\-\\/]((1[6-9]|[2-9]\\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$";

		public const string NumericRegex = "\\d*";

		public static void ArgumentNotNullOrEmpty(string value, string parameterName)
		{
		}

		public static void ArgumentNotNullOrEmptyOrWhitespace(string value, string parameterName)
		{
		}

		public static void ArgumentTypeIsEnum(Type enumType, string parameterName)
		{
		}

		public static void ArgumentNotNullOrEmpty<T>(ICollection<T> collection, string parameterName)
		{
		}

		public static void ArgumentNotNullOrEmpty<T>(ICollection<T> collection, string parameterName, string message)
		{
		}

		public static void ArgumentNotNullOrEmpty(ICollection collection, string parameterName)
		{
		}

		public static void ArgumentNotNullOrEmpty(ICollection collection, string parameterName, string message)
		{
		}

		public static void ArgumentNotNull(object value, string parameterName)
		{
		}

		public static void ArgumentNotNegative(int value, string parameterName)
		{
		}

		public static void ArgumentNotNegative(int value, string parameterName, string message)
		{
		}

		public static void ArgumentNotZero(int value, string parameterName)
		{
		}

		public static void ArgumentNotZero(int value, string parameterName, string message)
		{
		}

		public static void ArgumentIsPositive<T>(T value, string parameterName) where T : struct, IComparable<T>
		{
		}

		public static void ArgumentIsPositive(int value, string parameterName, string message)
		{
		}

		public static void ObjectNotDisposed(bool disposed, Type objectType)
		{
		}

		public static void ArgumentConditionTrue(bool condition, string parameterName, string message)
		{
		}
	}
}
