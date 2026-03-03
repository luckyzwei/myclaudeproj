using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PlaySoundButtonClick : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string keySound;

	private void Awake()
	{
	}
}
