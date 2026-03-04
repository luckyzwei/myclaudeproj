using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
public class LineRenderer : MaskableGraphic
{
	[Header("Line Settings")]
	public List<Vector2> Points;

	public float LineThickness;

	[Header("Overlap Settings")]
	[Range(0.05f, 0.3f)]
	public float BaseOverlapRatio;

	[Range(0.5f, 3f)]
	public float AdaptiveOverlapMultiplier;

	[Header("Point Density")]
	public bool AutoDensity;

	[Range(0.5f, 2f)]
	public float DensityMultiplier;

	[Range(30f, 180f)]
	public float CriticalAngle;

	public override Texture mainTexture { get { return null; } }

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	private float GetAdaptiveOverlap(Vector2 start, Vector2 end, Vector2 next)
	{
		return 0f;
	}

	private void DrawLineSegment(VertexHelper vh, Vector2 start, Vector2 end, Vector2 next)
	{
	}

	private List<Vector2> AddIntermediatePoints(List<Vector2> originalPoints)
	{
		return null;
	}

	public void SetPoints(List<Vector2> newPoints)
	{
	}

	public void SetLineStyle(Color color, float thickness)
	{
	}

	public void SetOverlapSettings(float baseRatio, float adaptiveMultiplier)
	{
	}

	public void SetDensitySettings(bool autoDensity, float multiplier, float criticalAngle)
	{
	}
}
