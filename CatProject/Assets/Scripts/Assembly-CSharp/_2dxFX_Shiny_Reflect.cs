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

	private string shader;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha;

	[HideInInspector]
	[Range(-0.5f, 1.5f)]
	public float Light;

	[HideInInspector]
	[Range(0.05f, 1f)]
	public float LightSize;

	[HideInInspector]
	public bool UseShinyCurve;

	[HideInInspector]
	public AnimationCurve ShinyLightCurve;

	[HideInInspector]
	[Range(0f, 32f)]
	public float AnimationSpeedReduction;

	[HideInInspector]
	[Range(0f, 2f)]
	public float Intensity;

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
	}

	private void Start()
	{
	}

	public void CallUpdate()
	{
	}

	private void Update()
	{
	}

	private void XUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
