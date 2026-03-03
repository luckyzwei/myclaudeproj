using System.Collections.Generic;
using UnityEngine;
using anzu;

namespace Anzu.Examples
{
	public class Obstruction : MonoBehaviour
	{
		public bool _updateElement;

		private int _prevScreenWidth;

		private int _prevScreenHeight;

		private Obstructor _obstructor;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateObstruction()
		{
		}

		private Vector2[] TryGetShape()
		{
			return null;
		}

		private Vector2[] GetRectTransformScreenShape(RectTransform rectTransform)
		{
			return null;
		}

		private bool HasScreenSizeChanged()
		{
			return false;
		}

		private Vector2[] GetMeshScreenShape(MeshFilter meshFilter, Camera cam)
		{
			return null;
		}

		private Vector2[] GetSpriteScreenShape(SpriteRenderer spriteRenderer, Camera cam)
		{
			return null;
		}

		private static Vector2[] ConvexHull2D(List<Vector2> points)
		{
			return null;
		}

		private static float Cross(Vector2 o, Vector2 a, Vector2 b)
		{
			return 0f;
		}
	}
}
