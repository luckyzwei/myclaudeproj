using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class GameScreenInfoButton : MonoBehaviour
{
	[SerializeField]
	private GameObject m_notif;

	private bool m_isShowingNotif;

	private void Awake()
	{
		var btn = GetComponent<Button>();
		if (btn != null)
			btn.onClick.AddListener(OnClick);
	}

	private void OnDestroy()
	{
		var btn = GetComponent<Button>();
		if (btn != null)
			btn.onClick.RemoveListener(OnClick);
	}

	private void OnSwipeHappened()
	{
	}

	public void OnClick()
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
