using System;
using Balancy.Models;
using KWAudio;
using UnityEngine;

public class LimitedOfferPopup : PopupSpecialOffer
{
	private const string ANIM_INTRO = "Intro";

	private const string ANIM_IDLEOUT = "IdleOut";

	private const float SHOW_POPUP_DELAY = 2.5f;

	[PrefabReferenceRequiredComponent(typeof(TrialPopup))]
	[SerializeField]
	private PrefabReference m_trialPopupPrefab;

	[SerializeField]
	private LimitedOfferTimer m_timer;

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private AudioClipReference m_clip;

	private LimitedOffer m_limitedOffer;

	public PrefabReference TrialPopupAssociated => null;

	public override void Config(KwaleeOffer kwaleeOffer, Action callback = null, bool userRequested = false, string source = "")
	{
	}

	protected override void PurchaseButtonPressed(bool purchased)
	{
	}

	public void OnCloseLimitedOfferPressed()
	{
	}

	protected override void OnDestroy()
	{
	}
}
