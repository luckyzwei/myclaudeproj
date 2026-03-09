using System.Collections;
using UnityEngine;

public abstract class BaseData : ScriptableObject
{
	public string csv;

	[Tooltip("Only fill if there's gonna be more than one of this type")]
	public string clientId;

	public virtual void ParseData(Hashtable data)
	{
	}

	public virtual void ProcessData()
	{
	}
}
