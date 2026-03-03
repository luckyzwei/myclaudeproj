using System;

namespace Newtonsoft.Json.Serialization
{
	internal struct ResolverContractKey : IEquatable<ResolverContractKey>
	{
		private readonly Type _resolverType;

		private readonly Type _contractType;

		public ResolverContractKey(Type resolverType, Type contractType)
		{
			_resolverType = null;
			_contractType = null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ResolverContractKey other)
		{
			return false;
		}
	}
}
