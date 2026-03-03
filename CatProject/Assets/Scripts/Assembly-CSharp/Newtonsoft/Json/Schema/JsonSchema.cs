using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	public class JsonSchema
	{
		private readonly string _internalId;

		public string Id { get; set; }

		public string Title { get; set; }

		public bool? Required { get; set; }

		public bool? ReadOnly { get; set; }

		public bool? Hidden { get; set; }

		public bool? Transient { get; set; }

		public string Description { get; set; }

		public JsonSchemaType? Type { get; set; }

		public string Pattern { get; set; }

		public int? MinimumLength { get; set; }

		public int? MaximumLength { get; set; }

		public double? DivisibleBy { get; set; }

		public double? Minimum { get; set; }

		public double? Maximum { get; set; }

		public bool? ExclusiveMinimum { get; set; }

		public bool? ExclusiveMaximum { get; set; }

		public int? MinimumItems { get; set; }

		public int? MaximumItems { get; set; }

		public IList<JsonSchema> Items { get; set; }

		public IDictionary<string, JsonSchema> Properties { get; set; }

		public JsonSchema AdditionalProperties { get; set; }

		public IDictionary<string, JsonSchema> PatternProperties { get; set; }

		public bool AllowAdditionalProperties { get; set; }

		public string Requires { get; set; }

		public IList<string> Identity { get; set; }

		public IList<JToken> Enum { get; set; }

		public IDictionary<JToken, string> Options { get; set; }

		public JsonSchemaType? Disallow { get; set; }

		public JToken Default { get; set; }

		public JsonSchema Extends { get; set; }

		public string Format { get; set; }

		internal string InternalId => null;

		public static JsonSchema Read(JsonReader reader)
		{
			return null;
		}

		public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
		{
			return null;
		}

		public static JsonSchema Parse(string json)
		{
			return null;
		}

		public static JsonSchema Parse(string json, JsonSchemaResolver resolver)
		{
			return null;
		}

		public void WriteTo(JsonWriter writer)
		{
		}

		public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
