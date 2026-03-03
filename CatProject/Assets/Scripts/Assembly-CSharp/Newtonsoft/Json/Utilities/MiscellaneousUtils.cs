using System;

namespace Newtonsoft.Json.Utilities
{
	internal static class MiscellaneousUtils
	{
		public static bool ValueEquals(object objA, object objB)
		{
			return false;
		}

		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		public static bool TryAction<T>(Creator<T> creator, out T output)
		{
			output = default(T);
			return false;
		}

		public static string ToString(object value)
		{
			return null;
		}

		public static byte[] HexToBytes(string hex)
		{
			return null;
		}

		public static string BytesToHex(byte[] bytes)
		{
			return null;
		}

		public static string BytesToHex(byte[] bytes, bool removeDashes)
		{
			return null;
		}

		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return 0;
		}

		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			prefix = null;
			localName = null;
		}
	}
}
