using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaguePodiumStepWidget : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CConfigure_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LeaguePodiumStepWidget _003C_003E4__this;

		public bool isPlayer;

		public int rank;

		public int score;

		public string name;

		public int avatarIndex;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const string PLAYER_NAME_DEFAULT_LOC = "Leaderboard.DefaultPlayerName";

	private const string ANIM_PLAYERMOVETOPODIUM = "PlayerMoveToPodium";

	private const string ANIM_DEFAULT = "Default";

	private const string ANIM_PLAYER = "Player";

	private const string ANIM_PLAYERMOVETOGOLD = "PlayerMoveToGold";

	private const string ANIM_PLAYERGOLD = "PlayerGold";

	[SerializeField]
	private TMP_Text m_nameTMP;

	[SerializeField]
	private TMP_Text m_cellScoreTMP;

	[SerializeField]
	private LeagueRewardWidget m_leagueReward;

	[SerializeField]
	private Image m_profileImage;

	[SerializeField]
	private GameObject m_profileContainer;

	private AnimatorHelper m_animatorHelper;

	private bool m_isPlayer;

	private int m_rank;

	private bool m_playerProfileEventSubscribed;

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CConfigure_003Ed__16))]
	public void Configure(int score, int rank, int avatarIndex = -1, string name = null, bool isPlayer = false)
	{
	}

	public void PlayPlayerAnimation(bool dynamic)
	{
	}

	private void UpdatePlayerUIWithProfileData(PublicProfile profile)
	{
	}

	public void HilightAnimation()
	{
	}
}
