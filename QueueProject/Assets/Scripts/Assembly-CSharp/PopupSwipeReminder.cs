using KWCore.SaveData;
using KWCore.UI;
using UnityEngine;

public class PopupSwipeReminder : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-SwipeReminderTutorial";

	[SerializeField]
	private GameObject m_closeButton;

	private void Awake()
	{
		BucketGameplay.SetSwipeTutorialDisplayed(true);
	}

	private void AnimEventLooped()
	{
		// Animation has looped - can close if needed
		if (m_closeButton != null)
			m_closeButton.SetActive(true);
	}
}
