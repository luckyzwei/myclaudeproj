using System;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Serialization
{
	public class DefaultContractResolver : IContractResolver
	{
		private static readonly IContractResolver _instance;

		private static readonly IList<JsonConverter> BuiltInConverters;

		private static Dictionary<ResolverContractKey, JsonContract> _sharedContractCache;

		private static readonly object _typeContractCacheLock;

		private Dictionary<ResolverContractKey, JsonContract> _instanceContractCache;

		private readonly bool _sharedCache;

		internal static IContractResolver Instance => null;

		public bool DynamicCodeGeneration => false;

		public BindingFlags DefaultMembersSearchFlags { get; set; }

		public bool SerializeCompilerGeneratedMembers { get; set; }

		public DefaultContractResolver()
		{
		}

		public DefaultContractResolver(bool shareCache)
		{
		}

		private Dictionary<ResolverContractKey, JsonContract> GetCache()
		{
			return null;
		}

		private void UpdateCache(Dictionary<ResolverContractKey, JsonContract> cache)
		{
		}

		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return false;
		}

		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		private ConstructorInfo GetParametrizedConstructor(Type objectType)
		{
			return null;
		}

		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		private void InitializeContract(JsonContract contract)
		{
		}

		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		private void GetCallbackMethodsForType(Type type, out MethodInfo onSerializing, out MethodInfo onSerialized, out MethodInfo onDeserializing, out MethodInfo onDeserialized, out MethodInfo onError)
		{
			onSerializing = null;
			onSerialized = null;
			onDeserializing = null;
			onDeserialized = null;
			onError = null;
		}

		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		internal static bool CanConvertToString(Type type)
		{
			return false;
		}

		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			return false;
		}

		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		private void SetPropertySettingsFromAttributes(JsonProperty property, ICustomAttributeProvider attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess, out bool hasExplicitAttribute)
		{
			allowNonPublicAccess = default(bool);
			hasExplicitAttribute = default(bool);
		}

		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		protected internal virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}
	}
}
