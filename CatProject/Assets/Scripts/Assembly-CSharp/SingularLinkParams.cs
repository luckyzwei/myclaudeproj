using System;
using Newtonsoft.Json;

[Serializable]
public class SingularLinkParams
{
	private string _deeplink;

	private string _passthrough;

	private bool _isDeferred;

	[JsonProperty(PropertyName = "deeplink")]
	public string Deeplink
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonProperty(PropertyName = "passthrough")]
	public string Passthrough
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonProperty(PropertyName = "is_deferred")]
	public bool IsDeferred
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
