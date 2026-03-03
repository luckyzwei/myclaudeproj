using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public class JsonSerializer
	{
		private TypeNameHandling _typeNameHandling;

		private FormatterAssemblyStyle _typeNameAssemblyFormat;

		private PreserveReferencesHandling _preserveReferencesHandling;

		private ReferenceLoopHandling _referenceLoopHandling;

		private MissingMemberHandling _missingMemberHandling;

		private ObjectCreationHandling _objectCreationHandling;

		private NullValueHandling _nullValueHandling;

		private DefaultValueHandling _defaultValueHandling;

		private ConstructorHandling _constructorHandling;

		private JsonConverterCollection _converters;

		private IContractResolver _contractResolver;

		private IReferenceResolver _referenceResolver;

		private SerializationBinder _binder;

		private StreamingContext _context;

		public virtual IReferenceResolver ReferenceResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual SerializationBinder Binder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual TypeNameHandling TypeNameHandling
		{
			get
			{
				return default(TypeNameHandling);
			}
			set
			{
			}
		}

		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return default(FormatterAssemblyStyle);
			}
			set
			{
			}
		}

		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return default(PreserveReferencesHandling);
			}
			set
			{
			}
		}

		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return default(ReferenceLoopHandling);
			}
			set
			{
			}
		}

		public virtual MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return default(MissingMemberHandling);
			}
			set
			{
			}
		}

		public virtual NullValueHandling NullValueHandling
		{
			get
			{
				return default(NullValueHandling);
			}
			set
			{
			}
		}

		public virtual DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return default(DefaultValueHandling);
			}
			set
			{
			}
		}

		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return default(ObjectCreationHandling);
			}
			set
			{
			}
		}

		public virtual ConstructorHandling ConstructorHandling
		{
			get
			{
				return default(ConstructorHandling);
			}
			set
			{
			}
		}

		public virtual JsonConverterCollection Converters => null;

		public virtual IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
			set
			{
			}
		}

		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			return null;
		}

		public void Populate(TextReader reader, object target)
		{
		}

		public void Populate(JsonReader reader, object target)
		{
		}

		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		public object Deserialize(JsonReader reader)
		{
			return null;
		}

		public object Deserialize(TextReader reader, Type objectType)
		{
			return null;
		}

		public T Deserialize<T>(JsonReader reader)
		{
			return default(T);
		}

		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		public void Serialize(TextWriter textWriter, object value)
		{
		}

		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value)
		{
		}

		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		internal void OnError(ErrorEventArgs e)
		{
		}
	}
}
