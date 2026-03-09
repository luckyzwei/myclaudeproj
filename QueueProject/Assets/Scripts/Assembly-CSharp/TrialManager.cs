using System;
using System.Runtime.CompilerServices;
using Balancy.Models;
using KWCore.Utils;

public class TrialManager : Singleton<TrialManager>
{
	private const string PURCHASE_EVENT_NAME = "purchase";

	public static event Action<FeatureTrial> TrialExpired
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

	public static event Action<FeatureTrial> TrialStarted
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

	private void GameCoreEventsOnLevelCompleted()
	{
	}

	public void StartTrial(string clientId)
	{
	}

	public void StartTrial(FeatureTrial trial)
	{
	}

	public FeatureTrial GetTrialDataById(string clientId)
	{
		return null;
	}

	public bool IsTrialSeen(FeatureTrial trial)
	{
		return false;
	}

	public bool IsTrialSeen(string clientId)
	{
		return false;
	}

	public bool IsTrialActive(string clientId)
	{
		return false;
	}

	public bool IsTrialActive(FeatureTrial trial)
	{
		return false;
	}

	private static void SendPurchaseAnalyticsEvent(string clientId)
	{
	}
}
