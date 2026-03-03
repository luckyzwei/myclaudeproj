using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		private JsonSerializerProxy _internalSerializer;

		private List<object> _serializeStack;

		private List<object> SerializeStack => null;

		public JsonSerializerInternalWriter(JsonSerializer serializer)
			: base(null)
		{
		}

		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract contract)
		{
			return false;
		}

		private void WriteMemberInfoProperty(JsonWriter writer, object memberValue, JsonProperty property, JsonContract contract)
		{
		}

		private bool CheckForCircularReference(object value, ReferenceLoopHandling? referenceLoopHandling, JsonContract contract)
		{
			return false;
		}

		private void WriteReference(JsonWriter writer, object value)
		{
		}

		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			s = null;
			return false;
		}

		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return false;
		}

		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return false;
		}

		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return false;
		}

		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract)
		{
		}

		private void SerializeList(JsonWriter writer, IWrappedCollection values, JsonArrayContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContract collectionContract)
		{
		}

		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
		}

		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContract containerContract)
		{
			return false;
		}

		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract)
		{
		}

		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
			return false;
		}

		private void SerializeDictionary(JsonWriter writer, IWrappedDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContract collectionValueContract)
		{
		}

		private string GetPropertyName(DictionaryEntry entry)
		{
			return null;
		}

		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		private bool ShouldSerialize(JsonProperty property, object target)
		{
			return false;
		}

		private bool IsSpecified(JsonProperty property, object target)
		{
			return false;
		}
	}
}
