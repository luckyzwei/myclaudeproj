using UnityEngine;
using UnityEngine.UI;
using anzu;

namespace Anzu.Examples
{
	public class EmptyMedia : MonoBehaviour
	{
		public bool _hasNoMedia;

		[Space]
		public AnzuAd _anzuAd;

		public Text _buttonText;

		public Image _buttonIcon;

		public Button _startButton;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPlaybackEmpty()
		{
		}

		private void OnStartButtonPress()
		{
		}
	}
}
