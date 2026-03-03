using UnityEngine;

namespace SpriteShadersUltimate
{
	public class WindManagerSSU : MonoBehaviour
	{
		[Header("Settings:")]
		[Tooltip("Smaller values will result in more frequent changes in wind.")]
		public float windNoiseScale;

		private float lastWindNoiseScale;

		[Tooltip("Speed at which the wind pattern moves horizontally.")]
		public float windNoiseSpeed;

		[Tooltip("The wind intensity will be between this value and 'Wind Intensity To'.")]
		public float windIntensityFrom;

		private float lastWindIntensityFrom;

		[Tooltip("The wind intensity will be between this value and 'Wind Intensity From'.")]
		public float windIntensityTo;

		private float lastWindIntensityTo;

		private float currentTime;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public void ModifyIfChanged(ref float currentValue, ref float oldValue, string globalShaderName)
		{
		}
	}
}
