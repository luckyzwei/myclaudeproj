using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json.Utilities
{
	internal static class ReflectionUtils
	{
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return false;
		}

		public static Type GetObjectType(object v)
		{
			return null;
		}

		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat)
		{
			return null;
		}

		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			return null;
		}

		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		public static bool IsInstantiatableType(Type t)
		{
			return false;
		}

		public static bool HasDefaultConstructor(Type t)
		{
			return false;
		}

		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return false;
		}

		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		public static bool IsNullable(Type t)
		{
			return false;
		}

		public static bool IsNullableType(Type t)
		{
			return false;
		}

		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		public static bool IsUnitializedValue(object value)
		{
			return false;
		}

		public static object CreateUnitializedValue(Type type)
		{
			return null;
		}

		public static bool IsPropertyIndexed(PropertyInfo property)
		{
			return false;
		}

		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return false;
		}

		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			implementingType = null;
			return false;
		}

		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match)
		{
			match = null;
			return false;
		}

		public static bool AssignableToTypeName(this Type type, string fullTypeName)
		{
			return false;
		}

		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return false;
		}

		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			implementingType = null;
			return false;
		}

		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			implementingType = null;
			return false;
		}

		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			keyType = null;
			valueType = null;
		}

		public static Type GetDictionaryValueType(Type dictionaryType)
		{
			return null;
		}

		public static Type GetDictionaryKeyType(Type dictionaryType)
		{
			return null;
		}

		public static bool ItemsUnitializedValue<T>(IList<T> list)
		{
			return false;
		}

		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		public static bool IsIndexedProperty(MemberInfo member)
		{
			return false;
		}

		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return false;
		}

		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
		}

		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return false;
		}

		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return false;
		}

		public static List<MemberInfo> GetFieldsAndProperties<T>(BindingFlags bindingAttr)
		{
			return null;
		}

		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return false;
		}

		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider) where T : Attribute
		{
			return null;
		}

		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T[] GetAttributes<T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		public static string GetNameAndAssessmblyName(Type t)
		{
			return null;
		}

		public static Type MakeGenericType(Type genericTypeDefinition, params Type[] innerTypes)
		{
			return null;
		}

		public static object CreateGeneric(Type genericTypeDefinition, Type innerType, params object[] args)
		{
			return null;
		}

		public static object CreateGeneric(Type genericTypeDefinition, IList<Type> innerTypes, params object[] args)
		{
			return null;
		}

		public static object CreateGeneric(Type genericTypeDefinition, IList<Type> innerTypes, Func<Type, IList<object>, object> instanceCreator, params object[] args)
		{
			return null;
		}

		public static bool IsCompatibleValue(object value, Type type)
		{
			return false;
		}

		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			typeName = null;
			assemblyName = null;
		}

		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return default(BindingFlags);
		}

		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
		}
	}
}
