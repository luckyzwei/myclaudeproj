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

	public override Texture mainTexture { get { return s_WhiteTexture; } }

	protected override void OnPopulateMesh(VertexHelper vh)
	{
		vh.Clear();
		if (Points == null || Points.Count < 2) return;

		List<Vector2> drawPoints = AutoDensity ? AddIntermediatePoints(Points) : Points;
		if (drawPoints == null || drawPoints.Count < 2) return;

		for (int i = 0; i < drawPoints.Count - 1; i++)
		{
			Vector2 next = (i + 1 < drawPoints.Count - 1) ? drawPoints[i + 2] : drawPoints[i + 1];
			DrawLineSegment(vh, drawPoints[i], drawPoints[i + 1], next);
		}
	}

	private float GetAdaptiveOverlap(Vector2 start, Vector2 end, Vector2 next)
	{
		Vector2 dir1 = (end - start).normalized;
		Vector2 dir2 = (next - end).normalized;
		float angle = Vector2.Angle(dir1, dir2);
		float ratio = Mathf.Clamp01(angle / CriticalAngle);
		return BaseOverlapRatio + ratio * AdaptiveOverlapMultiplier * BaseOverlapRatio;
	}

	private void DrawLineSegment(VertexHelper vh, Vector2 start, Vector2 end, Vector2 next)
	{
		float halfThickness = LineThickness * 0.5f;
		Vector2 dir = (end - start).normalized;
		Vector2 perp = new Vector2(-dir.y, dir.x) * halfThickness;

		float overlap = GetAdaptiveOverlap(start, end, next);
		Vector2 extendedEnd = end + dir * (LineThickness * overlap);

		int idx = vh.currentVertCount;
		vh.AddVert(start - perp, color, Vector2.zero);
		vh.AddVert(start + perp, color, new Vector2(0, 1));
		vh.AddVert(extendedEnd + perp, color, new Vector2(1, 1));
		vh.AddVert(extendedEnd - perp, color, new Vector2(1, 0));
		vh.AddTriangle(idx, idx + 1, idx + 2);
		vh.AddTriangle(idx + 2, idx + 3, idx);
	}

	private List<Vector2> AddIntermediatePoints(List<Vector2> originalPoints)
	{
		if (originalPoints == null || originalPoints.Count < 2) return originalPoints;
		var result = new List<Vector2>();
		result.Add(originalPoints[0]);
		for (int i = 1; i < originalPoints.Count; i++)
		{
			float dist = Vector2.Distance(originalPoints[i - 1], originalPoints[i]);
			float segLen = LineThickness * DensityMultiplier;
			if (segLen <= 0f) segLen = 1f;
			int segments = Mathf.Max(1, Mathf.CeilToInt(dist / segLen));
			for (int j = 1; j <= segments; j++)
			{
				float t = (float)j / segments;
				result.Add(Vector2.Lerp(originalPoints[i - 1], originalPoints[i], t));
			}
		}
		return result;
	}

	public void SetPoints(List<Vector2> newPoints)
	{
		Points = newPoints;
		SetVerticesDirty();
	}

	public void SetLineStyle(Color color, float thickness)
	{
		this.color = color;
		LineThickness = thickness;
		SetVerticesDirty();
	}

	public void SetOverlapSettings(float baseRatio, float adaptiveMultiplier)
	{
		BaseOverlapRatio = baseRatio;
		AdaptiveOverlapMultiplier = adaptiveMultiplier;
		SetVerticesDirty();
	}

	public void SetDensitySettings(bool autoDensity, float multiplier, float criticalAngle)
	{
		AutoDensity = autoDensity;
		DensityMultiplier = multiplier;
		CriticalAngle = criticalAngle;
		SetVerticesDirty();
	}
}
