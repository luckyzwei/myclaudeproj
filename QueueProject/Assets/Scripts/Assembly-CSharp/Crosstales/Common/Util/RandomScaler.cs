using UnityEngine;

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent]
	public class RandomScaler : MonoBehaviour
	{
		[Tooltip("Use intervals to change the scale (default: true).")]
		public bool UseInterval;

		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 10, y = 20).")]
		public Vector2 ChangeInterval;

		[Tooltip("Minimum rotation speed per axis (default: 5 for all axis).")]
		public Vector3 ScaleMin;

		[Tooltip("Maximum scale per axis (default: 0.1 for all axis).")]
		public Vector3 ScaleMax;

		[Tooltip("Uniform scaling for all axis (x-axis values will be used, default: true).")]
		public bool Uniform;

		[Tooltip("Set the object to a random scale at Start (default: false).")]
		public bool RandomScaleAtStart;

		private Transform _tf;

		private Vector3 _startScale;

		private Vector3 _endScale;

		private float _elapsedTime;

		private float _changeTime;

		private float _lerpTime;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
