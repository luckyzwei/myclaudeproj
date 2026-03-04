using System.Collections.Generic;
using Firebase.Analytics;

public sealed class TpParameter
{
	private string _key;

	private long _value;

	private double _dvalue;

	private string _strvalue;

	public string _str { get { return null; } }

	public TpParameter(string key, long value)
	{
	}

	public TpParameter(string key, string strvalue)
	{
	}

	public TpParameter(string key, double dvalue)
	{
	}

	public Parameter ConvertToFirebaseParameter()
	{
		return null;
	}

	public KeyValuePair<string, string> ConvertToKeyValuePair()
	{
		return default(KeyValuePair<string, string>);
	}
}
