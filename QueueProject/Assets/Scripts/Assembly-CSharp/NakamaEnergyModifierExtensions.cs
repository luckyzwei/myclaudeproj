using System;
using Hiro;

public static class NakamaEnergyModifierExtensions
{
	public static bool IsEnabled(this IEnergyModifier energyModifier)
	{
		return false;
	}

	public static TimeSpan GetDuration(this IEnergyModifier energyModifier)
	{
		return default(TimeSpan);
	}

	public static TimeSpan GetRemainingTime(this IEnergyModifier energyModifier)
	{
		return default(TimeSpan);
	}

	public static bool IsExpired(this IEnergyModifier energyModifier)
	{
		return false;
	}

	public static bool HasStarted(this IEnergyModifier energyModifier)
	{
		return false;
	}

	public static double GetProgressPercentage(this IEnergyModifier energyModifier)
	{
		return 0.0;
	}

	public static DateTimeOffset GetStartTime(this IEnergyModifier energyModifier)
	{
		return default(DateTimeOffset);
	}

	public static DateTimeOffset GetEndTime(this IEnergyModifier energyModifier)
	{
		return default(DateTimeOffset);
	}

	public static string ToString(this IEnergyModifier modifier)
	{
		return null;
	}
}
