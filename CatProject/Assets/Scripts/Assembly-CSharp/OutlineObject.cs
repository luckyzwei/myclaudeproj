using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class OutlineObject : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer sRenderer;

	[SerializeField]
	private GameObject target;

	[SerializeField]
	private float snapCamSize;

	private Material defaultMaterial;

	private bool create;

	private bool enable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SwitchOn(bool value)
	{
	}

	public void Enable(bool value)
	{
	}
}
