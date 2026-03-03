using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonDictionaryContract : JsonContract
	{
		private readonly bool _isDictionaryValueTypeNullableType;

		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private MethodCall<object, object> _genericWrapperCreator;

		public Func<string, string> PropertyNameResolver { get; set; }

		internal Type DictionaryKeyType { get; private set; }

		internal Type DictionaryValueType { get; private set; }

		public JsonDictionaryContract(Type underlyingType)
			: base(null)
		{
		}

		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		private bool IsTypeGenericDictionaryInterface(Type type)
		{
			return false;
		}
	}
}
