using System;
using Newtonsoft.Json;

public class Vector2Converter : JsonConverter
{
	public override bool CanRead { get { return false; } }

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		base.WriteJson(writer, value, serializer);
	}

	public override bool CanConvert(Type objectType)
	{
		return false;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return null;
	}
}
