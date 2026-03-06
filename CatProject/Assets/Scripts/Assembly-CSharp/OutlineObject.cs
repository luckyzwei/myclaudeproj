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
		if (sRenderer == null) sRenderer = GetComponent<SpriteRenderer>();
	}

	private void Start()
	{
		if (sRenderer != null)
		{
			defaultMaterial = sRenderer.material;
			create = true;
		}
	}

	private void OnDestroy()
	{
		if (create && sRenderer != null && defaultMaterial != null)
			sRenderer.material = defaultMaterial;
	}

	public void SwitchOn(bool value)
	{
		if (!enable) return;
		if (target != null) target.SetActive(value);
	}

	public void Enable(bool value)
	{
		enable = value;
		if (!value) SwitchOn(false);
	}
}
