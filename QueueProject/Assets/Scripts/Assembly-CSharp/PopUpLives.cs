using Balancy.Models.SmartObjects;
using KWCore.UI;
using KWLocalisation.Localisation;
using UnityEngine;

public class PopUpLives : PopUpBase
{
	private const string INFINITE_LIVES_STRING = "Runs out in:";

	private const string NEXT_LIFE_STRING = "Next life in:";

	public const string PREFAB_NAME = "Prefabs/KWLifeSystem/PopUp-Lives";

	[SerializeField]
	private TextWrapper m_titleText;

	[SerializeField]
	private LifePurchaseButton m_rvLifePurchaseButton;

	[SerializeField]
	private LifePurchaseButton m_softLifePurchaseButton;

	[SerializeField]
	private NextLifeTimerWidget m_timerWidget;

	[SerializeField]
	private TextWrapper m_nextLifeText;

	[SerializeField]
	private GameObject m_fullLivesPanel;

	[SerializeField]
	private GameObject m_notFullLivesPanel;

	private void Start()
	{
	}

	private void OnTimerHitZero()
	{
	}

	private void UpdateVisuals()
	{
	}

	private void SetupPurchaseButtons()
	{
	}

	private void SetNextLifeNext()
	{
	}

	private ItemWithAmount GetMultipliedPrice(ItemWithAmount toMultiply)
	{
		return null;
	}

	private void OnLivesPurchased(bool success)
	{
	}
}
