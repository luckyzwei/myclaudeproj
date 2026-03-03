using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Bson;

namespace Newtonsoft.Json.Converters
{
	public class RegexConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return false;
		}

		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		private void WriteJson(JsonWriter writer, Regex regex)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private object ReadBson(BsonReader reader)
		{
			return null;
		}

		private Regex ReadJson(JsonReader reader)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
