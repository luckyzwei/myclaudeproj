using System;
using System.Collections.Generic;
using Hiro;

public static class NakamaEnergyExtensions
{
	public static bool IsAtMaxEnergy(this IEnergy energy)
	{
		return false;
	}

	public static bool IsAtZeroEnergy(this IEnergy energy)
	{
		return false;
	}

	public static TimeSpan GetTimeUntilNextRefill(this IEnergy energy)
	{
		return default(TimeSpan);
	}

	public static TimeSpan GetTimeUntilMaxEnergy(this IEnergy energy)
	{
		return default(TimeSpan);
	}

	public static double GetRefillProgress(this IEnergy energy)
	{
		return 0.0;
	}

	public static bool CanSpendEnergy(this IEnergy energy, int amount)
	{
		return false;
	}

	public static DateTimeOffset GetNextRefillTime(this IEnergy energy)
	{
		return default(DateTimeOffset);
	}

	public static DateTimeOffset GetMaxRefillTime(this IEnergy energy)
	{
		return default(DateTimeOffset);
	}

	public static IEnergyModifier GetModifier(this IEnergy energy, string operatorId)
	{
		return null;
	}

	public static IEnumerable<IEnergyModifier> GetActiveModifiers(this IEnergy energy)
	{
		return null;
	}

	public static bool HasActiveModifiers(this IEnergy energy)
	{
		return false;
	}

	public static Dictionary<string, string> GetMetadata(this IEnergy energy, params string[] keys)
	{
		return null;
	}

	public static int GetEnergyNeededForMax(this IEnergy energy)
	{
		return 0;
	}

	public static float GetEnergyPercentage(this IEnergy energy)
	{
		return 0f;
	}

	public static string ToString(this IEnergy energy)
	{
		return null;
	}
}
