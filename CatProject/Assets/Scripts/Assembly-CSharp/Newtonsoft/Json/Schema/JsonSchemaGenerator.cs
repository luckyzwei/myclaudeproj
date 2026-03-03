using System;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Schema
{
	public class JsonSchemaGenerator
	{
		private class TypeSchema
		{
			public Type Type { get; private set; }

			public JsonSchema Schema { get; private set; }

			public TypeSchema(Type type, JsonSchema schema)
			{
			}
		}

		private IContractResolver _contractResolver;

		private JsonSchemaResolver _resolver;

		private IList<TypeSchema> _stack;

		private JsonSchema _currentSchema;

		public UndefinedSchemaIdHandling UndefinedSchemaIdHandling { get; set; }

		public IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private JsonSchema CurrentSchema => null;

		private void Push(TypeSchema typeSchema)
		{
		}

		private TypeSchema Pop()
		{
			return null;
		}

		public JsonSchema Generate(Type type)
		{
			return null;
		}

		public JsonSchema Generate(Type type, JsonSchemaResolver resolver)
		{
			return null;
		}

		public JsonSchema Generate(Type type, bool rootSchemaNullable)
		{
			return null;
		}

		public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			return null;
		}

		private string GetTitle(Type type)
		{
			return null;
		}

		private string GetDescription(Type type)
		{
			return null;
		}

		private string GetTypeId(Type type, bool explicitOnly)
		{
			return null;
		}

		private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required)
		{
			return null;
		}

		private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired)
		{
			return default(JsonSchemaType);
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return false;
		}

		private void GenerateObjectSchema(Type type, JsonObjectContract contract)
		{
		}

		private void GenerateISerializableContract(Type type, JsonISerializableContract contract)
		{
		}

		internal static bool HasFlag(JsonSchemaType? value, JsonSchemaType flag)
		{
			return false;
		}

		private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired)
		{
			return default(JsonSchemaType);
		}
	}
}
