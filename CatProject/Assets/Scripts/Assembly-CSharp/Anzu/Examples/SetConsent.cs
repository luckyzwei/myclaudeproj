using UnityEngine;
using UnityEngine.UI;

namespace Anzu.Examples
{
	public class SetConsent : MonoBehaviour
	{
		public string _consentString;

		[Space]
		public Toggle _toggle;

		public Text _stateText;

		public Button _toggleButton;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValueChanged(bool hasConsent)
		{
		}

		private void OnToggleConsentButton()
		{
		}
	}
}
