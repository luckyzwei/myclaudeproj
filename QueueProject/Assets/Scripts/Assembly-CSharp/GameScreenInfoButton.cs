using KWCore.UI;
using UnityEngine;

public class GameScreenInfoButton : MonoBehaviour
{
	[SerializeField]
	private GameObject m_notif;

	private bool m_isShowingNotif;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSwipeHappened()
	{
	}

	private void OnClick()
	{
		// Show FTUE tutorial popup (rules/how to play)
		PopUpBase.ShowPopup<PopupQueensInGameAdaptiveFTUE>(
			"prefabs/popups/Popup-FTUE-SchemeA", null);
		// Hide notification dot
		if (m_notif != null)
			m_notif.SetActive(false);
		m_isShowingNotif = false;
	}

	private void SwipeReminderDisplayed()
	{
	}
}
