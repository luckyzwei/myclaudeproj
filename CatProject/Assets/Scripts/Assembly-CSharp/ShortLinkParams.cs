using System;
using Newtonsoft.Json;

[Serializable]
public class ShortLinkParams
{
	private string data;

	private string error;

	[JsonProperty(PropertyName = "data")]
	public string Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonProperty(PropertyName = "error")]
	public string Error
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
