using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	public static class SchemaExtensions
	{
		public static bool IsValid(this JToken source, JsonSchema schema)
		{
			return false;
		}

		public static void Validate(this JToken source, JsonSchema schema)
		{
		}

		public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
		}
	}
}
