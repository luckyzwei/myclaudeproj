using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupJigsawCompleteIap : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-JigsawCompleteIAP";

	private const string ANIM_ANIM_JIGSAWIAPTRANSITION_01 = "Anim-JigsawIAPTransition-01";

	private const string ANIM_NEW_STATE = "New State";

	private const string ANIM_ANIM_JIGSAWIAPFINISH = "Anim-JigsawIAPFinish";

	[SerializeField]
	private TextMeshProUGUI m_percentCompleteTMP;

	[SerializeField]
	private Image m_eventImage;

	[SerializeField]
	private Button m_continueButton;

	[SerializeField]
	private Button m_closeButton;

	[SerializeField]
	private GameObject m_percentContent;

	[SerializeField]
	private JigsawStrikeOutWidget m_strikeOutContent;

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private TextMeshProUGUI m_eventTMP;

	private string m_eventId;

	private float m_percentComplete;

	private void Awake()
	{
	}

	public void Configure(string eventId, float percentComplete)
	{
	}

	private void ContinueFlow()
	{
	}

	private void ShowCloseButton()
	{
	}

	private void SuccessCallback()
	{
	}

	private void RejectOffer()
	{
	}
}
