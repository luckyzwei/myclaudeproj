using System;
using System.Runtime.CompilerServices;
using KWCore.Utils;

public class PVPManager : Singleton<PVPManager>
{
	public enum ChallengeInitiationType
	{
		RECEIVE = 0,
		SENT = 1,
		REMATCH = 2
	}

	private const string TEST_LEVEL = "";

	private const string COUNTDOWN_TEXT_KEY = "FakePVP.CompleteLevelFastToWin";

	private bool m_isThereChallenge;

	private PVPDataAdapter m_dataAdapter;

	private UserInputRecorder m_playerRecorder;

	private LevelPlayRecording m_opponentRecording;

	private bool m_playerWon;

	private LeaderboardData.User m_opponentUser;

	private bool m_opponentLoseByHearts;

	private bool m_playerLoseByHearts;

	private int m_deductedPoints;

	public bool IsThereChallenge => false;

	public PVPDataAdapter DataAdapter => null;

	public bool PlayerWon => false;

	public LeaderboardData.User OponnentUser => null;

	public bool OpponentLoseByHearts => false;

	public bool PlayerLoseByHearts => false;

	public int DeductedPoints => 0;

	private ChallengeInitiationType CurrentChallengeInitiationType => default(ChallengeInitiationType);

	public static event GameplayEvents.BasicDelegate ChallengeStartedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event GameplayEvents.BasicDelegate ChallengeFinishedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Init()
	{
	}

	private void OnLevelStarted()
	{
	}

	private void DecideIfShouldHaveChallengeOnNextLevel()
	{
	}

	public bool IsDataLoaded()
	{
		return false;
	}

	private void SetChallenge()
	{
	}

	private static LeaderboardData.User GetRandomPlayer()
	{
		return null;
	}

	public void ChallengeRequested(bool isRematch)
	{
	}

	public void CancelChallengeRequest()
	{
	}

	public void ChallengeAccepted()
	{
	}

	public void ChallengeRefused()
	{
	}

	public LeaderboardData.User GetOpponentPlayer()
	{
		return null;
	}

	public void LoadChallenge()
	{
	}

	private void StartChallenge()
	{
	}

	public void PurchasedAutoX()
	{
	}

	public bool HasAutoX()
	{
		return false;
	}

	public void ChallengeFinished()
	{
	}

	private int GetOpponentMistakesCount()
	{
		return 0;
	}

	public void MatchDisconnected(Action callback = null, bool showPopup = true)
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void SetPlayerLostByHearts(bool value = true)
	{
	}

	private static LeaderboardData.User CreateFakeUser()
	{
		return null;
	}
}
