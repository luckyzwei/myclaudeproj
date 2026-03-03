using System;
using Newtonsoft.Json;

namespace JsonDotNet.Extras.CustomConverters
{
	public class Matrix4x4Converter : JsonConverter
	{
		public override bool CanRead => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
