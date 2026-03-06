using UnityEngine;

public class PlaySoundEnable : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keySound;

	[SerializeField]
	private bool BGM;

	private void OnEnable()
	{
		// Play sound via SoundSystem
	}

	private void OnDisable()
	{
		// Disabled
	}
}
