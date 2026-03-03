using System;
using Newtonsoft.Json;

[Serializable]
public class ConversionValuesParams
{
	private int _value;

	private int _coarse;

	private bool _lock;

	[JsonProperty(PropertyName = "value")]
	public int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[JsonProperty(PropertyName = "coarse")]
	public int Coarse
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[JsonProperty(PropertyName = "lock")]
	public bool Lock
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
