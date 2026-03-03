using System;

namespace Newtonsoft.Json.Linq
{
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>
	{
		private JTokenType _valueType;

		private object _value;

		public override bool HasValues => false;

		public override JTokenType Type => default(JTokenType);

		public new object Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal JValue(object value, JTokenType type)
		{
		}

		public JValue(JValue other)
		{
		}

		public JValue(long value)
		{
		}

		public JValue(ulong value)
		{
		}

		public JValue(double value)
		{
		}

		public JValue(DateTime value)
		{
		}

		public JValue(bool value)
		{
		}

		public JValue(string value)
		{
		}

		public JValue(Guid value)
		{
		}

		public JValue(Uri value)
		{
		}

		public JValue(TimeSpan value)
		{
		}

		public JValue(object value)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		private static int Compare(JTokenType valueType, object objA, object objB)
		{
			return 0;
		}

		private static int CompareFloat(object objA, object objB)
		{
			return 0;
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public static JValue CreateComment(string value)
		{
			return null;
		}

		public static JValue CreateString(string value)
		{
			return null;
		}

		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return default(JTokenType);
		}

		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default(JTokenType);
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return false;
		}

		public bool Equals(JValue other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(JValue obj)
		{
			return 0;
		}
	}
}
