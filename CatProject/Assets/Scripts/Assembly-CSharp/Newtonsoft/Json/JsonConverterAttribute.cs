using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonConverterAttribute : Attribute
	{
		private readonly Type _converterType;

		public Type ConverterType => null;

		public JsonConverterAttribute(Type converterType)
		{
		}

		internal static JsonConverter CreateJsonConverterInstance(Type converterType)
		{
			return null;
		}
	}
}
