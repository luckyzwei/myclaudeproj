using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using UnityEngine;
using UnityEngine.UI;

public class WidgetChallengePVP : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CComeInFlow_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WidgetChallengePVP _003C_003E4__this;

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
		public _003CComeInFlow_003Ed__11(int _003C_003E1__state)
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

	[Header("Opponent")]
	[SerializeField]
	private PVPPlayerProfileWidget m_opponentProfileWidget;

	[Header("Buttons")]
	[SerializeField]
	private Button m_acceptButton;

	[SerializeField]
	private Button m_acceptWithRvButton;

	[SerializeField]
	private Button m_refuseButton;

	[Space]
	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private float m_comeInDelay;

	[SerializeField]
	private float m_comeInAnimDuration;

	[SerializeField]
	private GameObject[] m_gameObjectsToDisable;

	[SerializeField]
	private CanvasGroup[] m_canvasGroupsToHide;

	[SerializeField]
	private float m_canvasFadeDuration;

	private void Awake()
	{
		// Hide challenge widget unless there is an active PVP challenge
		bool hasChallenge = PVPManager.Instance != null && PVPManager.Instance.IsThereChallenge;
		gameObject.SetActive(hasChallenge);
	}

	[IteratorStateMachine(typeof(_003CComeInFlow_003Ed__11))]
	private IEnumerator ComeInFlow()
	{
		return null;
	}

	private void SetOtherGameObjects(bool active, bool animate = false)
	{
	}

	private void Config(LeaderboardData.User opponentPlayerId)
	{
	}

	private void LogReward(KwaleeReward reward, string additionalText)
	{
	}

	private void OnAcceptWithRvClicked()
	{
	}

	private void OnRefuseClicked()
	{
	}

	private void CloseWidget(Action callback = null)
	{
	}

	private void OnAcceptClicked()
	{
	}

	private void LoadConnectingScreen(bool purchasedAutoX)
	{
	}
}
