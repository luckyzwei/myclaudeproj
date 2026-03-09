using System;

namespace KWCore
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class KeyDictionary : Attribute
	{
		public KeyDictionary(Type keyType, Type valueType)
		{
		}
	}
}
