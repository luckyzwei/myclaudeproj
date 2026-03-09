using System;
using DG.Tweening;
using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FeatureUnlockPopUp : PopUpBase
{
	private const string ANIM_BOOSTERUNLOCK_INTRO = "BoosterUnlock-Intro";

	private const string ANIM_BOOSTERUNLOCK_OUTRO = "BoosterUnlock-Outro";

	private const float VFX_DELAY = 1f;

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-Unlock";

	public const string PREFAB_SPIN_WHEEL = "Prefabs/Popups/Popup-SpinWheelUnlock";

	public const string PREFAB_SKINS = "Prefabs/Popups/Popup-SkinsFeatureUnlock";

	[SerializeField]
	private TextMeshProUGUI m_featureName;

	[SerializeField]
	private TextMeshProUGUI m_featureDescription;

	[SerializeField]
	private Image m_featureIcon;

	[SerializeField]
	private Transform m_iconTransform;

	[SerializeField]
	private float m_moveDuration;

	[SerializeField]
	private Ease m_moveEase;

	[SerializeField]
	private float m_finalScale;

	[SerializeField]
	private Ease m_scaleEase;

	[SerializeField]
	private float m_singlePunchDuration;

	[SerializeField]
	private float m_punchEveryX;

	private Transform m_receiverTransform;

	private Transform m_receiverParent;

	private new AnimatorHelper m_animatorHelper;

	private bool m_hasClaimed;

	private Action m_onFeatureUnlockComplete;

	public void Config(Sprite featureIcon, string featureName, string featureDescription, Transform receiverTransform, Transform receiverParent, Action onFeatureUnlockComplete)
	{
	}

	private void OnEnable()
	{
	}

	public void Claim()
	{
	}

	private void MoveTowardsReceiver()
	{
	}

	private void DestroyIcon()
	{
	}
}
