using System;
using System.Reflection;

namespace KWGameplay
{
	public static class FieldInfoExt
	{
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
