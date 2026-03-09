using System;

namespace KWCore
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class SubkeyDictionary : Attribute
	{
		public SubkeyDictionary(Type keyType, Type valueType)
		{
		}
	}
}
