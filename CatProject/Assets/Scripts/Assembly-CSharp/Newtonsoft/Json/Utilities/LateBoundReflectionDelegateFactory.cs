using System;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		private static readonly LateBoundReflectionDelegateFactory _instance;

		internal static ReflectionDelegateFactory Instance => null;

		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			return null;
		}

		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			return null;
		}

		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}
	}
}
