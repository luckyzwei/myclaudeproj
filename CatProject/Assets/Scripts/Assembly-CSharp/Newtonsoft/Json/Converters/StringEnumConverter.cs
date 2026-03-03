using System;
using System.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	public class StringEnumConverter : JsonConverter
	{
		private readonly Dictionary<Type, BidirectionalDictionary<string, string>> _enumMemberNamesPerType;

		public bool CamelCaseText { get; set; }

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private BidirectionalDictionary<string, string> GetEnumNameMap(Type t)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
