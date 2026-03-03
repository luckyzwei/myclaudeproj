using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpriteShadersUltimate
{
	public class ShaderFaderSSU : MonoBehaviour
	{
		public bool automaticFading;

		public bool isFaded;

		[Range(0f, 1f)]
		public float fadeValue;

		[Min(0.01f)]
		public float duration;

		public bool unscaledTime;

		public AnimationCurve fadeCurve;

		public bool getChildObjects;

		public bool poolMaterials;

		public List<Renderer> renderers;

		public List<Graphic> graphics;

		public List<FloatFaderSSU> floatProperties;

		public List<VectorFaderSSU> vectorProperties;

		public List<ColorFaderSSU> colorProperties;

		private HashSet<Material> materials;

		private Dictionary<Material, Material> materialPool;

		private float lastFadeValue;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateMaterials()
		{
		}

		public void UpdateSingleMaterial(Material mat, float fadeFactor)
		{
		}

		private float ApplyTimeRange(float fadeFactor, float fromTime, float toTime)
		{
			return 0f;
		}

		public void ReloadMaterials()
		{
		}

		private void GetMaterialFromRenderer(Renderer renderer)
		{
		}

		private void GetMaterialFromGraphic(Graphic graphic)
		{
		}

		private Material InstantiateMaterial(Material sharedMaterial)
		{
			return null;
		}
	}
}
