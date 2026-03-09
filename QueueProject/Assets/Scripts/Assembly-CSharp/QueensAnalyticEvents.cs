using System.Text;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class QueensAnalyticEvents : MonoBehaviour
{
	public static class Helper
	{
		private static StringBuilder m_stringBuilder;

		private const string HINT = "hint_booster";

		private const string QUEEN = "queen_booster";

		private const string AUTO_X = "autox_booster";

		private const string NONE = "none";

		public static string GetBoostersBalance(bool includeAutoX = false)
		{
			return null;
		}

		public static int GetTotalQueensCount()
		{
			return 0;
		}

		public static int GetQueensFoundCount()
		{
			return 0;
		}

		public static string GetScreenName()
		{
			return null;
		}

		public static int GetLevelTypeNumber()
		{
			return 0;
		}
	}

	public static class QueenPlacedEvent
	{
		public static void SendEvent(bool placedCorrectly, string coordinates, bool boosterUsed)
		{
		}
	}

	public static class CurrencyItemEarnedEvent
	{
		public static void SendEvent(string source, string name, int amount)
		{
		}
	}

	public static class CurrencyItemSpendEvent
	{
		public static void SendEvent(string target, string name, int amount)
		{
		}
	}

	public static class CleanUsedEvent
	{
		public static void SendEvent()
		{
		}
	}

	public static class DailyChallengeEvent
	{
		public static void SendEvent(bool rv, string period, int day, int progression, int attempts, string state)
		{
		}
	}

	public static class WrongClientId
	{
		public static void SendEvent(string id, int index)
		{
		}
	}

	public static class SkinSelectedEvent
	{
		public static void SendEvent()
		{
		}
	}

	public static class QueensTreasureStatus
	{
		public static void TrySendEvents(Reward gameReward)
		{
		}

		public static void SendEvent(int milestone, string state)
		{
		}
	}

	public static class HomeVisit
	{
		public static void SendEvent()
		{
		}
	}

	public static class SkinsOpenedEvent
	{
		public static void SendEvent()
		{
		}
	}

	public static class JigsawPuzzleOpenEvent
	{
		public static void SendEvent(string name, int pieces, bool complete)
		{
		}
	}

	public static class IapSurfaced
	{
		public static void SendEvent(bool tap, string name, string source)
		{
		}
	}

	public static class StoreStart
	{
		public static string s_source;

		public static string s_reason;
	}

	public static class SwipeToXEvent
	{
		public static void SendEvent()
		{
		}

		private static void SendEventInternal()
		{
		}
	}

	public static class DailyChallengeOpenedEvent
	{
		public static void SendEvent(string period, int progression)
		{
		}
	}

	public static class QueenTreasureVisitEvent
	{
		public static void SendEvent(string source, int activeMilestone)
		{
		}
	}

	public static class InfoVisitEvent
	{
		public static void SendEvent(string source)
		{
		}
	}

	public static class JigsawVisitEvent
	{
		public static void SendEvent(string eventId)
		{
		}
	}

	public static class FeedbackGivenEvent
	{
		public static void SendEvent(bool reward)
		{
		}
	}

	public static class DailyChallengeTrophiesVisit
	{
		public static void SendEvent(string currentPeriod, int daysCompletedBeforeThisOne)
		{
		}
	}

	public static class BoosterPurchasePopup
	{
		public static void SendEvent()
		{
		}
	}

	public static class SpinWheelOpened
	{
		public static void SendEvent()
		{
		}
	}

	public static class Purchase
	{
		private const string PURCHASE_EVENT_NAME = "purchase";

		public static void SendEvent(string clientId, Price price, bool fromStore)
		{
		}
	}

	public static class JigsawIAP
	{
		public static void SendEvent(string puzzleSetName, int totalPiecesEarned, float percentagePiecesEarned)
		{
		}
	}

	public static class WeeklyLeaderboardEnded
	{
		public static void SendEvent(int rank, string trophy)
		{
		}
	}

	public static class PVP1v1Status
	{
		public static void SendEvent(string initiationType, string flowType, string lossStatus, float timeTaken)
		{
		}
	}

	public static void SendLeagueLeaderboardShown(string location, string leaderboardType)
	{
	}
}
