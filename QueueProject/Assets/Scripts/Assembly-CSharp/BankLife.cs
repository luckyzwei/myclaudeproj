using KWLocalisation.Localisation;
using UnityEngine;
using UnityEngine.UI;

public class BankLife : MonoBehaviour
{
	private const string ANIM_HIDDEN = "Hidden";

	private const string ANIM_VISIBLE = "Visible";

	private const float PUNCH_SCALE = 0.5f;

	private const float PUNCH_TIME = 0.2f;

	private const string FULL_TEXT = "FULL";

	[SerializeField]
	private TextWrapper m_lifeCounter;

	[SerializeField]
	private Image m_heartIconImage;

	[SerializeField]
	private Image m_infiniteLivesIconImage;

	[Header("Animations")]
	[SerializeField]
	protected AnimatorHelper m_animatorHelper;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void HandleMoneyEarned(long newAmount, string currencyID, long diffAmount)
	{
	}

	private void OnInfiniteLivesStarted()
	{
	}

	private void InfiniteLivesExpired()
	{
	}

	private void OnBankVisibilityToggleEvent(string currencyID, bool visibility)
	{
	}

	private void OnTweenComplete()
	{
	}

	private void UpdateValue()
	{
	}
}
