using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	public class JsonSchemaResolver
	{
		public IList<JsonSchema> LoadedSchemas { get; protected set; }

		public virtual JsonSchema GetSchema(string id)
		{
			return null;
		}
	}
}
