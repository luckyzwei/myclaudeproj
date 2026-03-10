using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupPause : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-Pause";

	[SerializeField]
	private Button m_returnHomeButton;

	[SerializeField]
	private float m_closeDelay;

	private void Awake()
	{
		if (m_returnHomeButton != null)
			m_returnHomeButton.onClick.AddListener(OnReturnHomeClick);
	}

	private void OnReturnHomeClick()
	{
		Close();
		if (GameManager.Instance != null)
			GameManager.Instance.ReturnToHomeScreen();
	}
}
