using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SpriteShadersUltimate.Demo
{
	public class Demo_ColorPicker : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		public Material targetMaterial;

		public string propertyName;

		private RectTransform colorArea;

		private Slider brightnessSlider;

		private RectTransform dotRect;

		private Image dotImage;

		private bool isHovered;

		private bool isDragging;

		private float lastHue;

		private float lastSaturation;

		private float maxBrightness;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetTarget(Material newMaterial, string newProperty, string shaderName)
		{
		}

		public void LoadColor(Color color)
		{
		}

		public void UpdateColor(float hue, float saturation)
		{
		}

		public void SliderChanged()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
