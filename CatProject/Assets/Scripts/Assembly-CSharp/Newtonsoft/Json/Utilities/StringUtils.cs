using System;
using System.Collections.Generic;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	internal static class StringUtils
	{
		private delegate void ActionLine(TextWriter textWriter, string line);

		public const string CarriageReturnLineFeed = "\r\n";

		public const string Empty = "";

		public const char CarriageReturn = '\r';

		public const char LineFeed = '\n';

		public const char Tab = '\t';

		public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			return null;
		}

		public static bool ContainsWhiteSpace(string s)
		{
			return false;
		}

		public static bool IsWhiteSpace(string s)
		{
			return false;
		}

		public static string EnsureEndsWith(string target, string value)
		{
			return null;
		}

		public static bool IsNullOrEmptyOrWhiteSpace(string s)
		{
			return false;
		}

		public static void IfNotNullOrEmpty(string value, Action<string> action)
		{
		}

		private static void IfNotNullOrEmpty(string value, Action<string> trueAction, Action<string> falseAction)
		{
		}

		public static string Indent(string s, int indentation)
		{
			return null;
		}

		public static string Indent(string s, int indentation, char indentChar)
		{
			return null;
		}

		private static void ActionTextReaderLine(TextReader textReader, TextWriter textWriter, ActionLine lineAction)
		{
		}

		public static string NumberLines(string s)
		{
			return null;
		}

		public static string NullEmptyString(string s)
		{
			return null;
		}

		public static string ReplaceNewLines(string s, string replacement)
		{
			return null;
		}

		public static string Truncate(string s, int maximumLength)
		{
			return null;
		}

		public static string Truncate(string s, int maximumLength, string suffix)
		{
			return null;
		}

		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		public static int? GetLength(string value)
		{
			return null;
		}

		public static string ToCharAsUnicode(char c)
		{
			return null;
		}

		public static void WriteCharAsUnicode(TextWriter writer, char c)
		{
		}

		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return default(TSource);
		}

		public static string ToCamelCase(string s)
		{
			return null;
		}
	}
}
