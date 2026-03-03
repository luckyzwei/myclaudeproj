using System.Collections.Generic;
using UnityEngine;

namespace SpriteShadersUltimate.Demo
{
	public class Demo_Shaders : MonoBehaviour
	{
		public static Demo_Shaders instance;

		public static float zoomFactor;

		private GameObject environmentGO;

		private List<SpriteRenderer> environmentSprites;

		private Vector3 currentPosition;

		private float lastZoomFactor;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public bool AllowMovement()
		{
			return false;
		}

		public bool FadeInGUI()
		{
			return false;
		}
	}
}
