using System;
using KWAudio;
using UnityEngine;

[Serializable]
public struct CurrencyExplosionAudio
{
	[SerializeField]
	private string clientID;

	[SerializeField]
	private AudioClipReference audioClipRef;

	public CurrencyExplosionAudio(string id, AudioClipReference clip)
	{
		clientID = null;
		audioClipRef = null;
	}

	public string GetClientID()
	{
		return null;
	}

	public AudioClipReference GetAudioClip()
	{
		return null;
	}
}
