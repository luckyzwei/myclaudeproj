using UnityEngine;

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent]
	public class RandomRotator : MonoBehaviour
	{
		[Tooltip("Use intervals to change the rotation (default: true).")]
		public bool UseInterval;

		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 10, y = 20).")]
		public Vector2 ChangeInterval;

		[Tooltip("Minimum rotation speed per axis (default: 5 for all axis).")]
		public Vector3 SpeedMin;

		[Tooltip("Minimum rotation speed per axis (default: 15 for all axis).")]
		public Vector3 SpeedMax;

		[Tooltip("Set the object to a random rotation at Start (default: false).")]
		public bool RandomRotationAtStart;

		[Tooltip("Random change interval per axis (default: true).")]
		public bool RandomChangeIntervalPerAxis;

		[Tooltip("Random direction per axis (default: true).")]
		public bool RandomDirectionPerAxis;

		private Transform _tf;

		private Vector3 _speed;

		private float _elapsedTime;

		private float _changeTime;

		private Vector3 _elapsedTimeAxis;

		private Vector3 _changeTimeAxis;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
