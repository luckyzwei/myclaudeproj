using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerProxy : JsonSerializer
	{
		private readonly JsonSerializerInternalReader _serializerReader;

		private readonly JsonSerializerInternalWriter _serializerWriter;

		private readonly JsonSerializer _serializer;

		public override IReferenceResolver ReferenceResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JsonConverterCollection Converters => null;

		public override DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return default(DefaultValueHandling);
			}
			set
			{
			}
		}

		public override IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return default(MissingMemberHandling);
			}
			set
			{
			}
		}

		public override NullValueHandling NullValueHandling
		{
			get
			{
				return default(NullValueHandling);
			}
			set
			{
			}
		}

		public override ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return default(ObjectCreationHandling);
			}
			set
			{
			}
		}

		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return default(ReferenceLoopHandling);
			}
			set
			{
			}
		}

		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return default(PreserveReferencesHandling);
			}
			set
			{
			}
		}

		public override TypeNameHandling TypeNameHandling
		{
			get
			{
				return default(TypeNameHandling);
			}
			set
			{
			}
		}

		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return default(FormatterAssemblyStyle);
			}
			set
			{
			}
		}

		public override ConstructorHandling ConstructorHandling
		{
			get
			{
				return default(ConstructorHandling);
			}
			set
			{
			}
		}

		public override SerializationBinder Binder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
			set
			{
			}
		}

		public override event EventHandler<ErrorEventArgs> Error
		{
			add
			{
			}
			remove
			{
			}
		}

		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		internal override void SerializeInternal(JsonWriter jsonWriter, object value)
		{
		}
	}
}
