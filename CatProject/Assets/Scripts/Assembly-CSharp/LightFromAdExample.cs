using UnityEngine;

public class LightFromAdExample : MonoBehaviour
{
	public Light[] Lights;

	public Renderer PlacementRenderer;

	private Texture2D _tempTexture;

	private RenderTexture _renderTexture;

	private Rect _samplingRegion;

	private const int _downscaleResolution = 5;

	private const float _lightIntensityScale = 10f;

	private const float _lerpSpeed = 0.3f;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void CopyPixelsFromTargetToTexture()
	{
	}

	private void UpdateLight()
	{
	}

	private Color GetAverageColor(Texture2D texture)
	{
		return default(Color);
	}

	private float GetLightIntensity(Color color)
	{
		return 0f;
	}
}
