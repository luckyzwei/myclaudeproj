using System;
using System.Xml;

namespace Newtonsoft.Json.Utilities
{
	internal static class DateTimeUtils
	{
		public static string GetLocalOffset(this DateTime d)
		{
			return null;
		}

		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return default(XmlDateTimeSerializationMode);
		}
	}
}
