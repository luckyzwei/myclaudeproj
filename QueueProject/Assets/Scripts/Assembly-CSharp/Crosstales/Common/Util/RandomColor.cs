using UnityEngine;

namespace Crosstales.Common.Util
{
	public class RandomColor : MonoBehaviour
	{
		[Tooltip("Use intervals to change the color (default: true).")]
		public bool UseInterval;

		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 5, y = 10).")]
		public Vector2 ChangeInterval;

		[Tooltip("Random hue range between min (= x) and max (= y) (default: x = 0, y = 1).")]
		public Vector2 HueRange;

		[Tooltip("Random saturation range between min (= x) and max (= y) (default: x = 1, y = 1).")]
		public Vector2 SaturationRange;

		[Tooltip("Random value range between min (= x) and max (= y) (default: x = 1, y = 1).")]
		public Vector2 ValueRange;

		[Tooltip("Random alpha range between min (= x) and max (= y) (default: x = 1, y = 1).")]
		public Vector2 AlphaRange;

		[Tooltip("Use gray scale colors (default: false).")]
		public bool GrayScale;

		[Tooltip("Modify the color of a material instead of the Renderer (default: not set, optional).")]
		public Material Material;

		[Tooltip("Set the object to a random color at Start (default: false).")]
		public bool RandomColorAtStart;

		private float _elapsedTime;

		private float _changeTime;

		private Renderer _currentRenderer;

		private Color32 _startColor;

		private Color32 _endColor;

		private float _lerpProgress;

		private bool _existsMaterial;

		private static readonly int COLOR_ID;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
