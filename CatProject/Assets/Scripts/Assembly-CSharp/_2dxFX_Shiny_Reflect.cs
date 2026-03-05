using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/Shiny Reflect")]
public class _2dxFX_Shiny_Reflect : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	[HideInInspector]
	public Texture2D __MainTex2;

	private string shader = "2DxFX/Standard/Shiny_Reflect";

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha = 1f;

	[HideInInspector]
	[Range(-0.5f, 1.5f)]
	public float Light;

	[HideInInspector]
	[Range(0.05f, 1f)]
	public float LightSize = 0.1f;

	[HideInInspector]
	public bool UseShinyCurve;

	[HideInInspector]
	public AnimationCurve ShinyLightCurve;

	[HideInInspector]
	[Range(0f, 32f)]
	public float AnimationSpeedReduction = 8f;

	[HideInInspector]
	[Range(0f, 2f)]
	public float Intensity = 1f;

	[HideInInspector]
	[Range(0f, 1f)]
	public float OnlyLight;

	[HideInInspector]
	[Range(-1f, 1f)]
	public float LightBump;

	private float ShinyLightCurveTime;

	[SerializeField]
	private bool InScrollRect;

	[HideInInspector]
	public int ShaderChange;

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
		if (ShinyLightCurve == null)
			ShinyLightCurve = new AnimationCurve();
		XUpdate();
	}

	public void CallUpdate()
	{
		XUpdate();
	}

	private void Update()
	{
		if (ActiveUpdate || UseShinyCurve)
		{
			if (UseShinyCurve && ShinyLightCurve != null)
			{
				ShinyLightCurveTime += Time.deltaTime;
				if (AnimationSpeedReduction > 0f)
					Light = ShinyLightCurve.Evaluate(ShinyLightCurveTime / AnimationSpeedReduction);
			}
			XUpdate();
		}
	}

	private void XUpdate()
	{
		if (CanvasImage == null && CanvasSpriteRenderer == null) return;
		var mat = GetMaterial();
		if (mat == null) return;
		mat.SetFloat("_Alpha", 1f - _Alpha);
		mat.SetFloat("_Light", Light);
		mat.SetFloat("_LightSize", LightSize);
		mat.SetFloat("_Intensity", Intensity);
		mat.SetFloat("_OnlyLight", OnlyLight);
		mat.SetFloat("_LightBump", LightBump);
		if (__MainTex2 != null)
			mat.SetTexture("_MainTex2", __MainTex2);
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
