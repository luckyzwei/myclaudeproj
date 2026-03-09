using KWCore.UI;
using UnityEngine;

public class PopUpLevelDifficulty : PopUpBase
{
	private const string ANIM_INTRO_1 = "Intro-1";

	private const string ANIM_WITHDIFFICULTYPOPUP = "WithDifficultyPopup";

	private const string ANIM_WITHOUTDIFFICULTYPOPUP = "WithoutDifficultyPopup";

	private const string ANIM_ANIM_POPUP_SAGAMAP_INTRO_HOLD = "Anim-PopUp-SagaMap-Intro-Hold";

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private float m_delayBeforeClose;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private LevelIntroWidget m_levelIntroWidget;

	private void Start()
	{
	}

	public void OnClose()
	{
	}

	public void FadeAway()
	{
	}

	public void AnimEvent_FadeTimeWidget()
	{
	}
}
