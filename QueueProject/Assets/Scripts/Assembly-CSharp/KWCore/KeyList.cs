using System;

namespace KWCore
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class KeyList : Attribute
	{
		public KeyList(Type valueType)
		{
		}
	}
}
