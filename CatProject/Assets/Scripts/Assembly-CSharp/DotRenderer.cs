using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
public class DotRenderer : MaskableGraphic
{
	public List<Vector2> points;

	public float dotSize;

	public Sprite dotSprite;

	public override Texture mainTexture { get { return null; } }

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}
}
