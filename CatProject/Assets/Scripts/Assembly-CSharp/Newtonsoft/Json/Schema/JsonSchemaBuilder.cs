using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	internal class JsonSchemaBuilder
	{
		private JsonReader _reader;

		private readonly IList<JsonSchema> _stack;

		private readonly JsonSchemaResolver _resolver;

		private JsonSchema _currentSchema;

		private JsonSchema CurrentSchema => null;

		private void Push(JsonSchema value)
		{
		}

		private JsonSchema Pop()
		{
			return null;
		}

		public JsonSchemaBuilder(JsonSchemaResolver resolver)
		{
		}

		internal JsonSchema Parse(JsonReader reader)
		{
			return null;
		}

		private JsonSchema BuildSchema()
		{
			return null;
		}

		private void ProcessSchemaProperty(string propertyName)
		{
		}

		private void ProcessExtends()
		{
		}

		private void ProcessEnum()
		{
		}

		private void ProcessOptions()
		{
		}

		private void ProcessDefault()
		{
		}

		private void ProcessIdentity()
		{
		}

		private void ProcessAdditionalProperties()
		{
		}

		private void ProcessPatternProperties()
		{
		}

		private void ProcessItems()
		{
		}

		private void ProcessProperties()
		{
		}

		private JsonSchemaType? ProcessType()
		{
			return null;
		}

		internal static JsonSchemaType MapType(string type)
		{
			return default(JsonSchemaType);
		}

		internal static string MapType(JsonSchemaType type)
		{
			return null;
		}
	}
}
