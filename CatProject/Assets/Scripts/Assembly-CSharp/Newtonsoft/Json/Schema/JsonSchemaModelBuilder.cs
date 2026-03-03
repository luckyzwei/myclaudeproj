using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	internal class JsonSchemaModelBuilder
	{
		private JsonSchemaNodeCollection _nodes;

		private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels;

		private JsonSchemaNode _node;

		public JsonSchemaModel Build(JsonSchema schema)
		{
			return null;
		}

		public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema)
		{
			return null;
		}

		public void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target)
		{
		}

		public void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema)
		{
		}

		public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema)
		{
		}

		public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema)
		{
		}

		private JsonSchemaModel BuildNodeModel(JsonSchemaNode node)
		{
			return null;
		}
	}
}
