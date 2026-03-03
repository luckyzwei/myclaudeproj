using UnityEngine;

[RequireComponent(typeof(ButtonPressed))]
public class PlaySoundButtonPressed : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keySound;

	private void Awake()
	{
	}
}
