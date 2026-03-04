using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class TpContractResolver : DefaultContractResolver
{
	private readonly Func<bool> _includeProperty;

	public TpContractResolver(Func<bool> includeProperty)
	{
		_includeProperty = includeProperty;
	}

	protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
	{
		return null;
	}
}
