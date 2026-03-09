using System;
using UnityEngine;

[Serializable]
public sealed class PrefabReference : ISerializationCallbackReceiver
{
	[SerializeField]
	private string m_localPath;

	public string GetResourcesPath()
	{
		return null;
	}

	public bool Exists()
	{
		return false;
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
