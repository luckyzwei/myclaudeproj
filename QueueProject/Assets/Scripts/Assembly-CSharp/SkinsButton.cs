using KWCore.UI;
using UnityEngine;

public class SkinsButton : MonoBehaviour
{
	private const string TITLE_KEY = "PopupSkinsUnlock.Title";

	private const string DESCRIPTION_KEY = "PopupSkinsUnlock.Description";

	[SerializeField]
	private GameObject m_notification;

	[SerializeField]
	private Sprite m_skinIcon;

	[SerializeField]
	private Transform m_body;

	[Space]
	[SerializeField]
	private CanvasGroup m_textCanvasGroup;

	[SerializeField]
	private float m_textDelay;

	[SerializeField]
	private float m_textAppearDuration;

	private void Awake()
	{
	}

	private void FlyOver()
	{
	}

	private void CheckNotification()
	{
	}

	public void OnSkinsButtonPressed()
	{
		// Show skins popup
		PopUpBase.ShowPopup<PopUpSkins>("prefabs/popups/PopUp-Skins", null);
	}
}
