using UnityEngine;

namespace SpriteShadersUltimate
{
	public class ImageSSU : InstancerSSU
	{
		[Tooltip("Enable this if the size of the RectTransform will change.")]
		public bool updateChanges;

		private RectTransform rectTransform;

		private int rectWidthID;

		private int rectHeightID;

		private Vector2 lastSizeDelta;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateMaterial()
		{
		}
	}
}
