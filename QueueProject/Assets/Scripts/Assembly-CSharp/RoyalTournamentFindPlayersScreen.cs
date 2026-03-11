using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWUserInterface;
using UnityEngine.UI;
using UnityEngine;

public class RoyalTournamentFindPlayersScreen : KWUserInterface.Screen
{
	[CompilerGenerated]
	private sealed class _003CCheckOnline_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCheckOnline_003Ed__16(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CShowOtherPlayersCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoyalTournamentFindPlayersScreen _003C_003E4__this;

		private float _003CtimeA_003E5__2;

		private float _003CtimeB_003E5__3;

		private int _003ChalfPlayers_003E5__4;

		private int _003CtheRest_003E5__5;

		private int _003Ci_003E5__6;

		private float _003Ctime_003E5__7;

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
		public _003CShowOtherPlayersCoroutine_003Ed__15(int _003C_003E1__state)
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

	private const float TIME_BEFORE_BOTS_APPEAR = 1.2f;

	private const float TIME_BETWEEN_LAST_BOT_AND_TEXT = 0.2f;

	private const float TIME_BEFORE_PROGRESS = 2.2f;

	[SerializeField]
	private RoyalTournamentAvatarWidget m_avatarWidgetPrefab;

	[SerializeField]
	private RectTransform m_playerIconsArea;

	[SerializeField]
	private Text m_playersText;

	[SerializeField]
	private Text m_descriptionText;

	[SerializeField]
	private RoyalTournamentAvatarWidget m_playerAvatar;

	private int m_playersPopulated;

	private List<RoyalTournamentAvatarWidget> m_avatars;

	public static void Show()
	{
	}

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void LeaderboardsServiceOnOnLeaderboardUpdated(LeaderboardData leaderboardData)
	{
	}

	[IteratorStateMachine(typeof(_003CShowOtherPlayersCoroutine_003Ed__15))]
	private IEnumerator ShowOtherPlayersCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckOnline_003Ed__16))]
	private IEnumerator CheckOnline()
	{
		return null;
	}

	private void ShowPlayer()
	{
	}

	private void PopulateText()
	{
	}

	private void PopulatePlayer(LeaderboardData.User user)
	{
	}

	private void Update()
	{
	}
}
