using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal static class JsonTypeReflector
	{
		public const string IdPropertyName = "$id";

		public const string RefPropertyName = "$ref";

		public const string TypePropertyName = "$type";

		public const string ValuePropertyName = "$value";

		public const string ArrayValuesPropertyName = "$values";

		public const string ShouldSerializePrefix = "ShouldSerialize";

		public const string SpecifiedPostfix = "Specified";

		private static readonly ThreadSafeStore<ICustomAttributeProvider, Type> JsonConverterTypeCache;

		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		private const string MetadataTypeAttributeTypeName = "System.ComponentModel.DataAnnotations.MetadataTypeAttribute, System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

		private static Type _cachedMetadataTypeAttributeType;

		private static bool? _dynamicCodeGeneration;

		public static bool DynamicCodeGeneration => false;

		public static ReflectionDelegateFactory ReflectionDelegateFactory => null;

		public static JsonContainerAttribute GetJsonContainerAttribute(Type type)
		{
			return null;
		}

		public static JsonObjectAttribute GetJsonObjectAttribute(Type type)
		{
			return null;
		}

		public static JsonArrayAttribute GetJsonArrayAttribute(Type type)
		{
			return null;
		}

		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		public static MemberSerialization GetObjectMemberSerialization(Type objectType)
		{
			return default(MemberSerialization);
		}

		private static Type GetJsonConverterType(ICustomAttributeProvider attributeProvider)
		{
			return null;
		}

		private static Type GetJsonConverterTypeFromAttribute(ICustomAttributeProvider attributeProvider)
		{
			return null;
		}

		public static JsonConverter GetJsonConverter(ICustomAttributeProvider attributeProvider, Type targetConvertedType)
		{
			return null;
		}

		public static TypeConverter GetTypeConverter(Type type)
		{
			return null;
		}

		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		private static Type GetMetadataTypeAttributeType()
		{
			return null;
		}

		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			return null;
		}

		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider) where T : Attribute
		{
			return null;
		}
	}
}
