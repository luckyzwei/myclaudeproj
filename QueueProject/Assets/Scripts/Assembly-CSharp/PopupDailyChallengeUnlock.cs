using KWCore.UI;
using UnityEngine;

public class PopupDailyChallengeUnlock : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-DailyChallenge-Unlock";

	private const string ANIM_ANIM_CHALLENGEUNLOCK_FLOW = "Anim-ChallengeUnlock-Flow";

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private RectTransform m_buttonParentTransform;

	[SerializeField]
	private RectTransform m_buttonTransform;

	private HomeScreen m_homeScreen;

	private bool m_foundHomeScreen;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AnimationDone()
	{
	}
}
