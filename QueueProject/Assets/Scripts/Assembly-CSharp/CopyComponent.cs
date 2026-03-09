using UnityEngine;

public class CopyComponent : MonoBehaviour
{
	[Tooltip("Component to copy values FROM")]
	public Component source;

	[Tooltip("Component to copy values TO")]
	public Component target;
}
