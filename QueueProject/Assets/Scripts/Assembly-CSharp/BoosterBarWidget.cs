using Balancy.Models.Inventory;
using UnityEngine;

public class BoosterBarWidget : MonoBehaviour
{
	private const float SPEECH_BUBBLE_DELAY = 1f;

	private const string QUEEN_BOOSTER_KEY = "FeatureUnlockPopup.QueenBooster";

	private const string QUEEN_BOOSTER_DESC_KEY = "FeatureUnlockPopup.QueenBoosterDesc";

	[SerializeField]
	private BoosterButton m_queensButton;

	[SerializeField]
	private BoosterButton m_hintButton;

	[SerializeField]
	private BoosterButton m_clearButton;

	[SerializeField]
	private Transform m_queensButtonContent;

	[SerializeField]
	private BoosterButtonsAlertAnimation m_alertAnimationController;

	[SerializeField]
	private Sprite m_queensIcon;

	[SerializeField]
	private Transform m_queensIconScreen;

	private PopupInputBlocker m_inputBlocker;

	private PopUpHighlighter m_popUpHighlighter;

	private float m_time;

	private void Start()
	{
		// Configure booster buttons
		if (m_queensButton != null)
		{
			m_queensButton.Configure(QueenBoosterButton.QUEEN_BOOSTER_CLIENT_ID, (id) => ButtonPressed(), 1, BoosterButton.BoosterButtonType.NORMAL);
			m_queensButton.SetButtonEnabled(true);
			if (m_alertAnimationController != null)
				m_alertAnimationController.AddBoosterButton(m_queensButton);
		}
		if (m_hintButton != null)
		{
			m_hintButton.Configure(HintBoosterButton.HINT_BOOSTER_CLIENT_ID, (id) => ButtonPressed(), 1, BoosterButton.BoosterButtonType.NORMAL);
			m_hintButton.SetButtonEnabled(true);
			if (m_alertAnimationController != null)
				m_alertAnimationController.AddBoosterButton(m_hintButton);
		}
		if (m_clearButton != null)
		{
			m_clearButton.Configure("clear_booster", (id) => ButtonPressed(), 1, BoosterButton.BoosterButtonType.NORMAL);
			m_clearButton.SetButtonEnabled(true);
			if (m_alertAnimationController != null)
				m_alertAnimationController.AddBoosterButton(m_clearButton);
		}
	}

	private bool FindBoosterByUnnyId(BoosterItem item)
	{
		return item != null;
	}

	private void ForceClickBooster()
	{
		if (m_queensButton != null)
			m_queensButton.OnButtonPressed();
	}

	private void ButtonPressed()
	{
		// Booster was used - refresh all buttons
		if (m_queensButton != null) m_queensButton.Refresh();
		if (m_hintButton != null) m_hintButton.Refresh();
		if (m_clearButton != null) m_clearButton.Refresh();
	}

	private void EnableSpeechBubble()
	{
		if (m_queensButton != null)
			m_queensButton.EnableSpeechBubble();
	}

	public void OnButtonPressed()
	{
		ButtonPressed();
	}
}
