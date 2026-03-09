using System.Collections;
using System.Globalization;
using System.Text;

namespace KWCore.Utils
{
	public class JsonSerializer
	{
		public const int TOKEN_NONE = 0;
		public const int TOKEN_CURLY_OPEN = 1;
		public const int TOKEN_CURLY_CLOSE = 2;
		public const int TOKEN_SQUARED_OPEN = 3;
		public const int TOKEN_SQUARED_CLOSE = 4;
		public const int TOKEN_COLON = 5;
		public const int TOKEN_COMMA = 6;
		public const int TOKEN_STRING = 7;
		public const int TOKEN_NUMBER = 8;
		public const int TOKEN_TRUE = 9;
		public const int TOKEN_FALSE = 10;
		public const int TOKEN_NULL = 11;

		private const int BUILDER_CAPACITY = 2000;

		public static object JsonDecode(byte[] json)
		{
			if (json == null) return null;
			return JsonDecode(System.Text.Encoding.UTF8.GetString(json));
		}

		public static object JsonDecode(string json)
		{
			bool success = true;
			return JsonDecode(json, ref success);
		}

		public static object JsonDecode(string json, ref bool success)
		{
			success = true;
			if (string.IsNullOrEmpty(json)) { success = false; return null; }
			char[] charArray = json.ToCharArray();
			int index = 0;
			object value = ParseValue(charArray, ref index, ref success);
			return value;
		}

		public static string BeautifyJsonSubstring(string str)
		{
			return str;
		}

		public static string JsonEncode(object json, bool isPretty = false)
		{
			StringBuilder builder = new StringBuilder(BUILDER_CAPACITY);
			if (SerializeValue(json, builder, isPretty))
				return builder.ToString();
			return null;
		}

		protected static Hashtable ParseObject(char[] json, ref int index, ref bool success)
		{
			Hashtable table = new Hashtable();
			// Skip '{'
			NextToken(json, ref index);

			while (true)
			{
				int token = LookAhead(json, index);
				if (token == TOKEN_NONE) { success = false; return null; }
				if (token == TOKEN_CURLY_CLOSE) { NextToken(json, ref index); return table; }
				if (token == TOKEN_COMMA) { NextToken(json, ref index); continue; }

				string name = ParseString(json, ref index, ref success);
				if (!success) return null;

				token = NextToken(json, ref index);
				if (token != TOKEN_COLON) { success = false; return null; }

				object value = ParseValue(json, ref index, ref success);
				if (!success) return null;

				table[name] = value;
			}
		}

		protected static ArrayList ParseArray(char[] json, ref int index, ref bool success)
		{
			ArrayList array = new ArrayList();
			// Skip '['
			NextToken(json, ref index);

			while (true)
			{
				int token = LookAhead(json, index);
				if (token == TOKEN_NONE) { success = false; return null; }
				if (token == TOKEN_SQUARED_CLOSE) { NextToken(json, ref index); return array; }
				if (token == TOKEN_COMMA) { NextToken(json, ref index); continue; }

				object value = ParseValue(json, ref index, ref success);
				if (!success) return null;
				array.Add(value);
			}
		}

		protected static object ParseValue(char[] json, ref int index, ref bool success)
		{
			int token = LookAhead(json, index);
			switch (token)
			{
				case TOKEN_STRING: return ParseString(json, ref index, ref success);
				case TOKEN_NUMBER: return ParseNumber(json, ref index, ref success);
				case TOKEN_CURLY_OPEN: return ParseObject(json, ref index, ref success);
				case TOKEN_SQUARED_OPEN: return ParseArray(json, ref index, ref success);
				case TOKEN_TRUE: NextToken(json, ref index); return true;
				case TOKEN_FALSE: NextToken(json, ref index); return false;
				case TOKEN_NULL: NextToken(json, ref index); return null;
				default: success = false; return null;
			}
		}

		protected static string ParseString(char[] json, ref int index, ref bool success)
		{
			StringBuilder s = new StringBuilder(128);
			EatWhitespace(json, ref index);
			// Skip opening quote
			if (index >= json.Length || json[index] != '"') { success = false; return null; }
			index++;

			while (index < json.Length)
			{
				char c = json[index++];
				if (c == '"') return s.ToString();
				if (c == '\\')
				{
					if (index >= json.Length) break;
					c = json[index++];
					switch (c)
					{
						case '"': s.Append('"'); break;
						case '\\': s.Append('\\'); break;
						case '/': s.Append('/'); break;
						case 'b': s.Append('\b'); break;
						case 'f': s.Append('\f'); break;
						case 'n': s.Append('\n'); break;
						case 'r': s.Append('\r'); break;
						case 't': s.Append('\t'); break;
						case 'u':
							if (index + 4 <= json.Length)
							{
								string hex = new string(json, index, 4);
								index += 4;
								if (int.TryParse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int codePoint))
									s.Append((char)codePoint);
							}
							break;
					}
				}
				else
				{
					s.Append(c);
				}
			}
			success = false;
			return null;
		}

		protected static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			EatWhitespace(json, ref index);
			int lastIndex = GetLastIndexOfNumber(json, index);
			int charLength = lastIndex - index + 1;
			string numberStr = new string(json, index, charLength);
			index = lastIndex + 1;

			if (numberStr.Contains(".") || numberStr.Contains("e") || numberStr.Contains("E"))
			{
				if (double.TryParse(numberStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double d))
					return d;
			}
			else
			{
				if (long.TryParse(numberStr, out long l))
					return l;
			}
			success = false;
			return 0;
		}

		protected static int GetLastIndexOfNumber(char[] json, int index)
		{
			int lastIndex = index;
			while (lastIndex < json.Length)
			{
				char c = json[lastIndex];
				if ("0123456789+-.eE".IndexOf(c) == -1) break;
				lastIndex++;
			}
			return lastIndex - 1;
		}

		protected static void EatWhitespace(char[] json, ref int index)
		{
			while (index < json.Length && " \t\n\r".IndexOf(json[index]) != -1)
				index++;
		}

		protected static int LookAhead(char[] json, int index)
		{
			int saveIndex = index;
			return NextToken(json, ref saveIndex);
		}

		protected static int NextToken(char[] json, ref int index)
		{
			EatWhitespace(json, ref index);
			if (index >= json.Length) return TOKEN_NONE;

			char c = json[index];
			index++;
			switch (c)
			{
				case '{': return TOKEN_CURLY_OPEN;
				case '}': return TOKEN_CURLY_CLOSE;
				case '[': return TOKEN_SQUARED_OPEN;
				case ']': return TOKEN_SQUARED_CLOSE;
				case ',': return TOKEN_COMMA;
				case '"': index--; return TOKEN_STRING;
				case ':': return TOKEN_COLON;
			}

			index--;

			int remainingLength = json.Length - index;
			// true
			if (remainingLength >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
			{ index += 4; return TOKEN_TRUE; }
			// false
			if (remainingLength >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
			{ index += 5; return TOKEN_FALSE; }
			// null
			if (remainingLength >= 4 && json[index] == 'n' && json[index + 1] == 'u' && json[index + 2] == 'l' && json[index + 3] == 'l')
			{ index += 4; return TOKEN_NULL; }

			// Number
			if (c == '-' || (c >= '0' && c <= '9'))
				return TOKEN_NUMBER;

			return TOKEN_NONE;
		}

		protected static bool SerializeValue(object value, StringBuilder builder, bool isPretty = false, int prettyLevel = 0)
		{
			if (value == null) { builder.Append("null"); return true; }
			if (value is string s) return SerializeString(s, builder);
			if (value is Hashtable ht) return SerializeObject(ht, builder, isPretty, prettyLevel);
			if (value is ArrayList al) return SerializeArray(al, builder);
			if (value is object[] arr) return SerializeArray(arr, builder);
			if (value is bool b) { builder.Append(b ? "true" : "false"); return true; }
			if (IsNumeric(value)) return SerializeNumber(System.Convert.ToDouble(value), builder);
			return SerializeString(value.ToString(), builder);
		}

		protected static bool SerializeObject(Hashtable anObject, StringBuilder builder, bool isPretty = false, int prettyLevel = 0)
		{
			builder.Append("{");
			bool first = true;
			foreach (DictionaryEntry entry in anObject)
			{
				if (!first) builder.Append(",");
				SerializeString(entry.Key.ToString(), builder);
				builder.Append(":");
				SerializeValue(entry.Value, builder, isPretty, prettyLevel + 1);
				first = false;
			}
			builder.Append("}");
			return true;
		}

		protected static bool SerializeArray(ArrayList anArray, StringBuilder builder)
		{
			builder.Append("[");
			bool first = true;
			foreach (object value in anArray)
			{
				if (!first) builder.Append(",");
				SerializeValue(value, builder);
				first = false;
			}
			builder.Append("]");
			return true;
		}

		protected static bool SerializeArray(object[] anArray, StringBuilder builder)
		{
			builder.Append("[");
			for (int i = 0; i < anArray.Length; i++)
			{
				if (i > 0) builder.Append(",");
				SerializeValue(anArray[i], builder);
			}
			builder.Append("]");
			return true;
		}

		protected static bool SerializeString(string aString, StringBuilder builder)
		{
			builder.Append("\"");
			foreach (char c in aString)
			{
				switch (c)
				{
					case '"': builder.Append("\\\""); break;
					case '\\': builder.Append("\\\\"); break;
					case '\b': builder.Append("\\b"); break;
					case '\f': builder.Append("\\f"); break;
					case '\n': builder.Append("\\n"); break;
					case '\r': builder.Append("\\r"); break;
					case '\t': builder.Append("\\t"); break;
					default: builder.Append(c); break;
				}
			}
			builder.Append("\"");
			return true;
		}

		protected static bool SerializeNumber(double number, StringBuilder builder)
		{
			builder.Append(number.ToString(CultureInfo.InvariantCulture));
			return true;
		}

		protected static bool IsNumeric(object o)
		{
			return o is int || o is long || o is float || o is double || o is decimal ||
				   o is short || o is byte || o is uint || o is ulong || o is ushort || o is sbyte;
		}
	}
}
