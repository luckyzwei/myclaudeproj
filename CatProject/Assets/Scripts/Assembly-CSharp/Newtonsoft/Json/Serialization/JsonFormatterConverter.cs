using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonFormatterConverter : IFormatterConverter
	{
		private readonly JsonSerializer _serializer;

		public JsonFormatterConverter(JsonSerializer serializer)
		{
		}

		private T GetTokenValue<T>(object value)
		{
			return default(T);
		}

		public object Convert(object value, Type type)
		{
			return null;
		}

		public object Convert(object value, TypeCode typeCode)
		{
			return null;
		}

		public bool ToBoolean(object value)
		{
			return false;
		}

		public byte ToByte(object value)
		{
			return 0;
		}

		public char ToChar(object value)
		{
			return '\0';
		}

		public DateTime ToDateTime(object value)
		{
			return default(DateTime);
		}

		public decimal ToDecimal(object value)
		{
			return default(decimal);
		}

		public double ToDouble(object value)
		{
			return 0.0;
		}

		public short ToInt16(object value)
		{
			return 0;
		}

		public int ToInt32(object value)
		{
			return 0;
		}

		public long ToInt64(object value)
		{
			return 0L;
		}

		public sbyte ToSByte(object value)
		{
			return 0;
		}

		public float ToSingle(object value)
		{
			return 0f;
		}

		public string ToString(object value)
		{
			return null;
		}

		public ushort ToUInt16(object value)
		{
			return 0;
		}

		public uint ToUInt32(object value)
		{
			return 0u;
		}

		public ulong ToUInt64(object value)
		{
			return 0uL;
		}
	}
}
