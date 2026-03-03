using System;
using System.IO;
using System.Xml;

namespace Newtonsoft.Json
{
	public static class JsonConvert
	{
		public static readonly string True;

		public static readonly string False;

		public static readonly string Null;

		public static readonly string Undefined;

		public static readonly string PositiveInfinity;

		public static readonly string NegativeInfinity;

		public static readonly string NaN;

		internal static readonly long InitialJavaScriptDateTicks;

		public static string ToString(DateTime value)
		{
			return null;
		}

		public static string ToString(DateTimeOffset value)
		{
			return null;
		}

		private static TimeSpan GetUtcOffset(DateTime dateTime)
		{
			return default(TimeSpan);
		}

		internal static void WriteDateTimeString(TextWriter writer, DateTime value)
		{
		}

		internal static void WriteDateTimeString(TextWriter writer, DateTime value, TimeSpan offset, DateTimeKind kind)
		{
		}

		private static long ToUniversalTicks(DateTime dateTime)
		{
			return 0L;
		}

		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return 0L;
		}

		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return 0L;
		}

		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			return 0L;
		}

		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		public static string ToString(bool value)
		{
			return null;
		}

		public static string ToString(char value)
		{
			return null;
		}

		public static string ToString(Enum value)
		{
			return null;
		}

		public static string ToString(int value)
		{
			return null;
		}

		public static string ToString(short value)
		{
			return null;
		}

		public static string ToString(ushort value)
		{
			return null;
		}

		public static string ToString(uint value)
		{
			return null;
		}

		public static string ToString(long value)
		{
			return null;
		}

		public static string ToString(ulong value)
		{
			return null;
		}

		public static string ToString(float value)
		{
			return null;
		}

		public static string ToString(double value)
		{
			return null;
		}

		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		public static string ToString(byte value)
		{
			return null;
		}

		public static string ToString(sbyte value)
		{
			return null;
		}

		public static string ToString(decimal value)
		{
			return null;
		}

		public static string ToString(Guid value)
		{
			return null;
		}

		public static string ToString(TimeSpan value)
		{
			return null;
		}

		public static string ToString(Uri value)
		{
			return null;
		}

		public static string ToString(string value)
		{
			return null;
		}

		public static string ToString(string value, char delimter)
		{
			return null;
		}

		public static string ToString(object value)
		{
			return null;
		}

		private static bool IsJsonPrimitiveTypeCode(TypeCode typeCode)
		{
			return false;
		}

		internal static bool IsJsonPrimitiveType(Type type)
		{
			return false;
		}

		internal static bool IsJsonPrimitive(object value)
		{
			return false;
		}

		public static string SerializeObject(object value)
		{
			return null;
		}

		public static string SerializeObject(object value, Formatting formatting)
		{
			return null;
		}

		public static string SerializeObject(object value, params JsonConverter[] converters)
		{
			return null;
		}

		public static string SerializeObject(object value, Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		public static object DeserializeObject(string value)
		{
			return null;
		}

		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			return null;
		}

		public static object DeserializeObject(string value, Type type)
		{
			return null;
		}

		public static T DeserializeObject<T>(string value)
		{
			return default(T);
		}

		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			return default(T);
		}

		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return default(T);
		}

		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			return default(T);
		}

		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			return null;
		}

		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		public static void PopulateObject(string value, object target)
		{
		}

		public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
		{
		}

		public static string SerializeXmlNode(XmlNode node)
		{
			return null;
		}

		public static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			return null;
		}

		public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			return null;
		}

		public static XmlDocument DeserializeXmlNode(string value)
		{
			return null;
		}

		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			return null;
		}

		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return null;
		}
	}
}
