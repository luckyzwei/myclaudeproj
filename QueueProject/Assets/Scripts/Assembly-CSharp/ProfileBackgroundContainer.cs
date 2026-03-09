using System;
using Balancy.Models;
using Balancy.Models.KWPlayerProfile;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileBackgroundContainer : MonoBehaviour
{
	public enum State
	{
		UNLOCKED = 0,
		SELECTED = 1,
		LOCKED_COINS = 2,
		LOCKED_PROGRESS = 3,
		LOCKED_RV = 4
	}

	private const string PROGRESS_FORMAT_KEY = "ProfileBackground.LevelProgressText";

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private GameObject m_notificationBadge;

	[Space]
	[SerializeField]
	private GameObject m_unlockedOverlay;

	[SerializeField]
	private GameObject m_selectOverlay;

	[SerializeField]
	private GameObject m_lockedCoinsOverlay;

	[SerializeField]
	private GameObject m_lockedProgressOverlay;

	[SerializeField]
	private GameObject m_lockedRvOverlay;

	[Space]
	[SerializeField]
	private TMP_Text m_coinAmountText;

	[SerializeField]
	private TMP_Text m_progressText;

	[SerializeField]
	private RectTransform m_progressLockTransform;

	private ProfileBackgrounds m_bannerData;

	private Action<string> m_pressedCallback;

	private State m_state;

	public void Config(ProfileBackgrounds data, Action<string> pressedCallback)
	{
	}

	private bool IsFree(KwaleePrice dataPrice)
	{
		return false;
	}

	private void SetState(State state)
	{
	}

	private void DisableAllOverlays()
	{
	}

	public void ButtonClicked()
	{
	}

	public void SetCoins(int coins)
	{
	}

	public void SetProgress(int level)
	{
	}

	protected virtual void SendUnlockedAnalytics()
	{
	}
}
