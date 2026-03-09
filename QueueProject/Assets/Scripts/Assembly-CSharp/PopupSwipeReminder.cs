using KWCore.UI;
using UnityEngine;

public class PopupSwipeReminder : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-SwipeReminderTutorial";

	[SerializeField]
	private GameObject m_closeButton;

	private void Awake()
	{
	}

	private void AnimEventLooped()
	{
	}
}
