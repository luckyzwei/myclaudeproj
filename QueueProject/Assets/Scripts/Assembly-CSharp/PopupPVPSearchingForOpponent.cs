using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupPVPSearchingForOpponent : PopUpBase
{
	[CompilerGenerated]
	private sealed class _003CChangeTexts_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupPVPSearchingForOpponent _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CChangeTexts_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const string PREFAB_NAME = "Prefabs/PopUps/Popup-PVP-SearchingForOpponent";

	private const string ANIM_ANIM_COMEIN = "Anim-ComeIn";

	private const string ANIM_ANIM_FOUND = "Anim-Found";

	private const string ANIM_ANIM_SEARCHING = "Anim-Searching";

	private const string ANIM_ANIM_STOPSEARCH = "Anim-StopSearch";

	private const float START_DELAY = 1.5f;

	private const string AUTOX_BOOSTER = "autox_booster";

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private GameObject m_searchingText;

	[SerializeField]
	private GameObject m_foundOpponentText;

	[SerializeField]
	private GameObject m_connectingText;

	[SerializeField]
	private GameObject m_seachingAnimationOverlay;

	[SerializeField]
	private GameObject[] m_opponentFoundGameObjects;

	[Header("Buttons")]
	[SerializeField]
	private Button m_continueButton;

	[SerializeField]
	private Button m_continueWithAutoXButton;

	[SerializeField]
	private Button m_cancelButton;

	[Space]
	[Header("Rewards")]
	[SerializeField]
	private RewardWidget m_winnerReward;

	[SerializeField]
	private RewardWidget m_loserReward;

	private bool m_canInteract;

	private bool m_isRematch;

	private void Awake()
	{
	}

	protected void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeTexts_003Ed__22))]
	protected IEnumerator ChangeTexts()
	{
		return null;
	}

	private void DoOpponentFoundAnimation()
	{
	}

	private void FinishOpponentSearch()
	{
	}

	private void OnContinueClick()
	{
	}

	private void ContinueToChallenge()
	{
	}

	private void OnContinueWithAutoXClick()
	{
	}

	private void ContinueToChallengeWithAutoX()
	{
	}

	private void OnCancelClick()
	{
	}

	private void LoadChallenge(bool purchasedAutoX)
	{
	}

	public static PopupPVPSearchingForOpponent Show(bool isRematch, Action closeCallback = null)
	{
		return null;
	}
}
