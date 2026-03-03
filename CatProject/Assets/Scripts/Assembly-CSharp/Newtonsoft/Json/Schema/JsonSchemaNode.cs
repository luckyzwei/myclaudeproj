using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
	internal class JsonSchemaNode
	{
		public string Id { get; private set; }

		public ReadOnlyCollection<JsonSchema> Schemas { get; private set; }

		public Dictionary<string, JsonSchemaNode> Properties { get; private set; }

		public Dictionary<string, JsonSchemaNode> PatternProperties { get; private set; }

		public List<JsonSchemaNode> Items { get; private set; }

		public JsonSchemaNode AdditionalProperties { get; set; }

		public JsonSchemaNode(JsonSchema schema)
		{
		}

		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
		}

		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return null;
		}

		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return null;
		}
	}
}
