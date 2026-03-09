using System;
using UnityEngine;

[Serializable]
public sealed class SceneReference : ISerializationCallbackReceiver
{
	[SerializeField]
	private string m_name;

	public string GetName()
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
