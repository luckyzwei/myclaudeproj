using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		internal enum PropertyPresence
		{
			None = 0,
			Null = 1,
			Value = 2
		}

		private JsonSerializerProxy _internalSerializer;

		private JsonFormatterConverter _formatterConverter;

		public JsonSerializerInternalReader(JsonSerializer serializer)
			: base(null)
		{
		}

		public void Populate(JsonReader reader, object target)
		{
		}

		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		private JsonContract GetContractSafe(Type type, object value)
		{
			return null;
		}

		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		private JsonFormatterConverter GetFormatterConverter()
		{
			return null;
		}

		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			return null;
		}

		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		private object CreateValueProperty(JsonReader reader, JsonProperty property, object target, bool gottenCurrentValue, object currentValue)
		{
			return null;
		}

		private object CreateValueNonProperty(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue)
		{
			return null;
		}

		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter)
		{
			return null;
		}

		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue)
		{
			return null;
		}

		private JsonArrayContract EnsureArrayContract(Type objectType, JsonContract contract)
		{
			return null;
		}

		private void CheckedRead(JsonReader reader)
		{
		}

		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string reference)
		{
			return null;
		}

		private bool HasDefinedType(Type type)
		{
			return false;
		}

		private object EnsureType(object value, CultureInfo culture, Type targetType)
		{
			return null;
		}

		private string FormatValueForPrint(object value)
		{
			return null;
		}

		private void SetPropertyValue(JsonProperty property, JsonReader reader, object target)
		{
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return false;
		}

		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			return false;
		}

		private object CreateAndPopulateDictionary(JsonReader reader, JsonDictionaryContract contract, string id)
		{
			return null;
		}

		private object PopulateDictionary(IWrappedDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, string id)
		{
			return null;
		}

		private object CreateAndPopulateList(JsonReader reader, string reference, JsonArrayContract contract)
		{
			return null;
		}

		private bool ReadForTypeArrayHack(JsonReader reader, Type t)
		{
			return false;
		}

		private object PopulateList(IWrappedCollection wrappedList, JsonReader reader, string reference, JsonArrayContract contract)
		{
			return null;
		}

		private object PopulateMultidimensionalArray(IList list, JsonReader reader, string reference, JsonArrayContract contract)
		{
			return null;
		}

		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, string id)
		{
			return null;
		}

		private object CreateAndPopulateObject(JsonReader reader, JsonObjectContract contract, string id)
		{
			return null;
		}

		private object CreateObjectFromNonDefaultConstructor(JsonReader reader, JsonObjectContract contract, ConstructorInfo constructorInfo, string id)
		{
			return null;
		}

		private IDictionary<JsonProperty, object> ResolvePropertyAndConstructorValues(JsonObjectContract contract, JsonReader reader, Type objectType)
		{
			return null;
		}

		private bool ReadForType(JsonReader reader, Type t, JsonConverter propertyConverter)
		{
			return false;
		}

		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, string id)
		{
			return null;
		}

		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties)
		{
		}

		private void HandleError(JsonReader reader, int initialDepth)
		{
		}
	}
}
