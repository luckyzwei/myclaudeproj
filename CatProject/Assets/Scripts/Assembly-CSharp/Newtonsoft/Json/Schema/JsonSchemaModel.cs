using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	internal class JsonSchemaModel
	{
		public bool Required { get; set; }

		public JsonSchemaType Type { get; set; }

		public int? MinimumLength { get; set; }

		public int? MaximumLength { get; set; }

		public double? DivisibleBy { get; set; }

		public double? Minimum { get; set; }

		public double? Maximum { get; set; }

		public bool ExclusiveMinimum { get; set; }

		public bool ExclusiveMaximum { get; set; }

		public int? MinimumItems { get; set; }

		public int? MaximumItems { get; set; }

		public IList<string> Patterns { get; set; }

		public IList<JsonSchemaModel> Items { get; set; }

		public IDictionary<string, JsonSchemaModel> Properties { get; set; }

		public IDictionary<string, JsonSchemaModel> PatternProperties { get; set; }

		public JsonSchemaModel AdditionalProperties { get; set; }

		public bool AllowAdditionalProperties { get; set; }

		public IList<JToken> Enum { get; set; }

		public JsonSchemaType Disallow { get; set; }

		public static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			return null;
		}

		private static void Combine(JsonSchemaModel model, JsonSchema schema)
		{
		}
	}
}
