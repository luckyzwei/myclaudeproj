using System;
using System.Runtime.CompilerServices;
using KWCore.Utils;

public class MigrationManager : MonoSingleton<MigrationManager>
{
	public static event Action OnMigrationCompleted
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

	private void Start()
	{
	}

	private void LeaderboardToWeeklyMigration()
	{
	}

	private void MigrateFreeAutoX()
	{
	}

	protected override void Init()
	{
	}

	private bool CheckIfInstallVersionLowerThan(string version)
	{
		return false;
	}

	private bool CheckIfInstallVersionHigherThanOrEqual(string version)
	{
		return false;
	}

	private void ControlSchemeMigration()
	{
	}

	private void QueensTreasureWidgetMigration()
	{
	}

	private void MigrateNoAdsTimers()
	{
	}

	private static void MigrateJigsawGrandPrizeReward()
	{
	}
}
