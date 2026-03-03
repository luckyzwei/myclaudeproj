using System;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		private static readonly ThreadSafeStore<ICustomAttributeProvider, T> TypeAttributeCache;

		public static T GetAttribute(ICustomAttributeProvider type)
		{
			return null;
		}
	}
}
