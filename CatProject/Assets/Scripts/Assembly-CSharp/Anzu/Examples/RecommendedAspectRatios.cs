using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using anzu;

namespace Anzu.Examples
{
	public class RecommendedAspectRatios : MonoBehaviour
	{
		public AnzuAd placement;

		public Button leftButton;

		public Button rightButton;

		public Text hintText;

		public Text aspectRatioText;

		private int selectedRatioIndex;

		private readonly Dictionary<float, string> aspectRatios;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void LeftButton()
		{
		}

		private void RightButton()
		{
		}

		private void SetNewAspectRatio()
		{
		}
	}
}
