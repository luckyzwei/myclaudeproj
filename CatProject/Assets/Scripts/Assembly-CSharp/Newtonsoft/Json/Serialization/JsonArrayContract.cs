using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonArrayContract : JsonContract
	{
		private readonly bool _isCollectionItemTypeNullableType;

		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private MethodCall<object, object> _genericWrapperCreator;

		internal Type CollectionItemType { get; private set; }

		public bool IsMultidimensionalArray { get; private set; }

		public JsonArrayContract(Type underlyingType)
			: base(null)
		{
		}

		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		private void EnsureGenericWrapperCreator()
		{
		}

		private bool IsTypeGenericCollectionInterface(Type type)
		{
			return false;
		}
	}
}
