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
	}

	private bool FindBoosterByUnnyId(BoosterItem item)
	{
		return false;
	}

	private void ForceClickBooster()
	{
	}

	private void ButtonPressed()
	{
	}

	private void EnableSpeechBubble()
	{
	}

	public void OnButtonPressed()
	{
		// Base booster bar button - delegates to individual booster buttons
	}
}
