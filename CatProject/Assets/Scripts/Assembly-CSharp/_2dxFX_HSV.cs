using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/HSV")]
public class _2dxFX_HSV : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader = "2DxFX/Standard/HSV";

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha = 1f;

	[HideInInspector]
	[Range(0f, 360f)]
	public float _HueShift;

	[HideInInspector]
	[Range(-2f, 2f)]
	public float _Saturation = 1f;

	[HideInInspector]
	[Range(-2f, 2f)]
	public float _ValueBrightness;

	[HideInInspector]
	public int ShaderChange;

	[SerializeField]
	private bool InScrollRect;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private SpriteRenderer CanvasSpriteRenderer;

	[HideInInspector]
	public bool ActiveUpdate;

	private void Awake()
	{
		CanvasImage = GetComponent<Image>();
		CanvasSpriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void Start()
	{
		ShaderChange = 0;
		XUpdate();
	}

	public void CallUpdate()
	{
		XUpdate();
	}

	private void Update()
	{
		if (ActiveUpdate)
			XUpdate();
	}

	private void XUpdate()
	{
		if (CanvasImage == null && CanvasSpriteRenderer == null) return;
		var mat = GetMaterial();
		if (mat == null) return;
		mat.SetFloat("_Alpha", 1f - _Alpha);
		mat.SetFloat("_HueShift", _HueShift);
		mat.SetFloat("_Saturation", _Saturation);
		mat.SetFloat("_ValueBrightness", _ValueBrightness);
	}

	private void OnDestroy()
	{
		if (tempMaterial != null)
		{
			DestroyImmediate(tempMaterial);
			tempMaterial = null;
		}
		SetDefaultMaterial();
	}

	private void OnDisable()
	{
		SetDefaultMaterial();
	}

	private void OnEnable()
	{
		XUpdate();
	}

	private Material GetMaterial()
	{
		if (ForceMaterial != null) return ForceMaterial;
		if (tempMaterial != null) return tempMaterial;
		var s = Shader.Find(shader);
		if (s == null) return null;
		tempMaterial = new Material(s);
		if (CanvasImage != null) CanvasImage.material = tempMaterial;
		else if (CanvasSpriteRenderer != null) CanvasSpriteRenderer.material = tempMaterial;
		return tempMaterial;
	}

	private void SetDefaultMaterial()
	{
		if (CanvasImage != null) CanvasImage.material = defaultMaterial;
		else if (CanvasSpriteRenderer != null) CanvasSpriteRenderer.material = defaultMaterial;
	}
}
