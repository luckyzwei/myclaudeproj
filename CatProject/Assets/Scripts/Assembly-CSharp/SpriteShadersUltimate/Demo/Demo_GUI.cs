using UnityEngine;
using UnityEngine.UI;

namespace SpriteShadersUltimate.Demo
{
	public class Demo_GUI : MonoBehaviour
	{
		public static Demo_GUI instance;

		private GameObject displayTitlePrefab;

		private RectTransform propertyRect;

		private CanvasGroup hudCG;

		private Slider slider;

		private float scrollArea;

		private float targetHeight;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void CreateTitle(string title, Transform target)
		{
		}

		public void UpdateHud()
		{
		}

		public static bool IsKeyword(string propName)
		{
			return false;
		}

		public void BackButton()
		{
		}

		public void ResetMaterialButton()
		{
		}

		public void AlternativeButton()
		{
		}

		public void UpdateScroll()
		{
		}
	}
}
