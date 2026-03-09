using System;
using KWCore.UI;
using KWLocalisation.Localisation;
using UnityEngine;

public class PopUpLifeLost : PopUpBase
{
	private const float BREAK_DELAY = 0.2f;

	private const string ANIM_ANIM_HEARTBREAK = "Anim-Heartbreak";

	private const string ANIM_ANIM_LOSELIFEIDLE = "Anim-LoseLifeIdle";

	private const string ANIM_ANIM_LOSELIFEIDLE_BROKEN = "Anim-LoseLifeIdle-Broken";

	private const string LEVEL_X_FAILED_LOC_KEY = "LevelFailed.LevelXFailed";

	public const string PREFAB_NAME = "Prefabs/KWLifeSystem/PopUp-LifeLost";

	[SerializeField]
	private TextWrapper m_levelFailedText;

	[SerializeField]
	private AnimatorHelper m_warningAnimator;

	[SerializeField]
	private bool m_autoClose;

	private Action m_onTryAgainPressed;

	private Action m_onHomePressed;

	private bool m_buttonPressed;

	public void Config(Action onTryAgainPressed, Action onHomePressed)
	{
	}

	private void Start()
	{
	}

	public void OnHomeButtonPressed()
	{
	}

	private void GoHome()
	{
	}

	public void OnTryAgainPressed()
	{
	}

	private void PlayAgain()
	{
	}

	private void OnPopUpClosed()
	{
	}
}
