using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class PlaySoundTmpToggleClick : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keySound;

	private void Awake()
	{
		// Initialize
	}
}
